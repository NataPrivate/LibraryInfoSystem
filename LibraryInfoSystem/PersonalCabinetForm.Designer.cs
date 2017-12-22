namespace LibraryInfoSystemClient
{
    partial class PersonalCabinetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalCabinetForm));
            this.personalCabinetTabControl = new System.Windows.Forms.TabControl();
            this.personalDataPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.booksPage = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.personalCabinetTabControl.SuspendLayout();
            this.personalDataPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.booksPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // personalCabinetTabControl
            // 
            this.personalCabinetTabControl.Controls.Add(this.personalDataPage);
            this.personalCabinetTabControl.Controls.Add(this.booksPage);
            this.personalCabinetTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalCabinetTabControl.Location = new System.Drawing.Point(10, 12);
            this.personalCabinetTabControl.Name = "personalCabinetTabControl";
            this.personalCabinetTabControl.SelectedIndex = 0;
            this.personalCabinetTabControl.Size = new System.Drawing.Size(629, 427);
            this.personalCabinetTabControl.TabIndex = 0;
            this.personalCabinetTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.personalCabinetTabControl_Selected);
            // 
            // personalDataPage
            // 
            this.personalDataPage.BackColor = System.Drawing.Color.DarkGray;
            this.personalDataPage.Controls.Add(this.pictureBox1);
            this.personalDataPage.Controls.Add(this.buttonEdit);
            this.personalDataPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalDataPage.Location = new System.Drawing.Point(4, 25);
            this.personalDataPage.Name = "personalDataPage";
            this.personalDataPage.Padding = new System.Windows.Forms.Padding(3);
            this.personalDataPage.Size = new System.Drawing.Size(621, 398);
            this.personalDataPage.TabIndex = 0;
            this.personalDataPage.Text = "Особиста інформація";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(402, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 283);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(267, 348);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(86, 31);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // booksPage
            // 
            this.booksPage.Controls.Add(this.dataGridView);
            this.booksPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.booksPage.Location = new System.Drawing.Point(4, 25);
            this.booksPage.Name = "booksPage";
            this.booksPage.Padding = new System.Windows.Forms.Padding(3);
            this.booksPage.Size = new System.Drawing.Size(621, 398);
            this.booksPage.TabIndex = 1;
            this.booksPage.Text = "Мої книжки";
            this.booksPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(612, 386);
            this.dataGridView.TabIndex = 0;
            // 
            // PersonalCabinetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 451);
            this.Controls.Add(this.personalCabinetTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PersonalCabinetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Особистий кабінет";
            this.personalCabinetTabControl.ResumeLayout(false);
            this.personalDataPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.booksPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl personalCabinetTabControl;
        private System.Windows.Forms.TabPage personalDataPage;
        private System.Windows.Forms.TabPage booksPage;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}