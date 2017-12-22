using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryInfoSystem
{
    public partial class ViewFormReaders : Form
    {
        private PostrgeSQLHandler handler;

        public ViewFormReaders()
        {
            InitializeComponent();

            handler = new PostrgeSQLHandler("postgres", "postgres", "library");
            dataGridView.DataSource = handler.GetTable("user");
        }

        private void FormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistVisit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void checkBoxSeparate_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void accountChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tablesToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void updateTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void reportGenerateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBoxUp_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBoxOk_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBoxDown_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
