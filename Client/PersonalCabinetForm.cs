using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Client
{
    public partial class PersonalCabinetForm : Form
    {
        private string UserType;
        private int Id;
        private DataTable Table;
        private InterfaceGenerator Generator;

        public PersonalCabinetForm(ViewForm owner, string userType, int id)
        {
            InitializeComponent();

            Owner = owner;
            UserType = userType;
            Id = id;

            SetFormElementsProperties();
            CreateInterface();
        }

        private void SetFormElementsProperties()
        {
            dataGridView.AllowUserToAddRows = false;
        }

        private void personalCabinetTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Text == "Особиста інформація")
                CreateInterface();
            else if (e.TabPage.Text == "Мої книжки")
            {
                if (UserType == "reader")
                    dataGridView.DataSource = GetOrdersHistoryByReader(Id);
                else if (UserType == "publisher")
                    dataGridView.DataSource = GetBooksByPublisher(Id);

                if (dataGridView.DataSource == null)
                    MessageBox.Show("На жаль, дані не знайдено.", "Шановний користувач!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }
        private void CreateInterface()
        {
            if (Owner == null)
                return;

            Table = ((ViewForm)Owner).GetSampleFromTable(UserType, Id.ToString(), "id", true);
            int y_top = 50, y_bottom = 140;
            int delta = (Size.Height - (y_top + y_bottom)) / (Table.Columns.Count - 1);
            Generator = new InterfaceGenerator(Table);
            Control[] dataElements = Generator.CreateInterface(y_top, delta, 140, new Size(230, 22), true);
            personalDataPage.Controls.AddRange(dataElements);
        }

        private DataTable GetOrdersHistoryByReader(int id)
        {
            KeyValuePair<string, IList<string>> requestData =
                new KeyValuePair<string, IList<string>>("getHistory", new List<string> { id.ToString() });
            var binFormatter = new BinaryFormatter();
            var mStream = new MemoryStream();
            binFormatter.Serialize(mStream, requestData);
            byte[] byteRequest = mStream.ToArray();

            KeyValuePair<int, byte[]> response = ((ViewForm)Owner).SendRequestToServer(byteRequest);

            if (response.Key == 0)
                return null;

            mStream = new MemoryStream();
            mStream.Write(response.Value, 0, response.Key);
            mStream.Position = 0;
            DataTable table = (DataTable)binFormatter.Deserialize(mStream);

            return table;
        }

        private DataTable GetBooksByPublisher(int id)
        {
            KeyValuePair<string, int> requestData = new KeyValuePair<string, int>("getBooks", id);
            var binFormatter = new BinaryFormatter();
            var mStream = new MemoryStream();
            binFormatter.Serialize(mStream, requestData);
            byte[] byteRequest = mStream.ToArray();

            KeyValuePair<int, byte[]> response = ((ViewForm)Owner).SendRequestToServer(byteRequest);

            mStream = new MemoryStream();
            mStream.Write(response.Value, 0, response.Key);
            mStream.Position = 0;
            DataTable table = (DataTable)binFormatter.Deserialize(mStream);

            return table;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            IList<string> columns = Generator.GetColumnNames();
            IList<string> values = GetValues();
            if (values == null)
                return;

            try
            {
                UpdateOneWithId(UserType, columns, values, Id);
            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format("На жаль, при виконанні сталася помилка.{0} Повідомлення: {1}", Environment.NewLine, exception.Message),
                    "Шановний користувач!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Зміни були успішно застосовані", "Шановний користувач!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CreateInterface();
        }
        private IList<string> GetValues()
        {
            FieldsValidator validator = new FieldsValidator();
            IList<string> values = new List<string>();

            string newValue;
            DataColumn column;
            TextBox[] textBoxes = personalDataPage.Controls.OfType<TextBox>().ToArray();
            Label[] labels = personalDataPage.Controls.OfType<Label>().ToArray();
            for (int i = 0; i < textBoxes.Length; i++)
            {
                newValue = textBoxes[i].Text.Trim();
                column = Table.Columns[Table.Columns.IndexOf(labels[i].Text)];
                if (!validator.CheckField(column, newValue))
                {
                    MessageBox.Show(string.Format("Поле '{0}' заповнене невірно.", Table.Columns[labels[i].Text].ColumnName),
                                    "Уважаемый пользователь!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }

                if (string.IsNullOrEmpty(newValue))
                    values.Add("DEFAULT");
                else
                    values.Add(" '" + newValue + "'");
            }

            return values;
        }
        private void UpdateOneWithId(string tableName, IList<string> columns, IList<string> values, int id)
        {
            IList<string>[] parameters =
            {
                new List<string> {tableName},
                columns, values,
                new List<string> {id.ToString()}
            };
            KeyValuePair<string, IList<string>[]> requestData =
                new KeyValuePair<string, IList<string>[]>("updateOneWithId", parameters);
            var binFormatter = new BinaryFormatter();
            var mStream = new MemoryStream();
            binFormatter.Serialize(mStream, requestData);
            byte[] byteRequest = mStream.ToArray();

            ((ViewForm)Owner).SendRequestToServer(byteRequest);
        }
    }
}
