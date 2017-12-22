namespace LibraryInfoSystem
{
    partial class ViewFormPublisher
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действительныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.будущиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прошедшиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свободныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.занятыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analystToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventownerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventvisitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportGenerateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxOk = new System.Windows.Forms.PictureBox();
            this.pictureBoxUp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxDown = new System.Windows.Forms.PictureBox();
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxSeparate = new System.Windows.Forms.CheckBox();
            this.labelHelp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.btnRegistVisitor = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.tablesToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(777, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountChangeToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(120, 21);
            this.accountToolStripMenuItem.Text = "Обліковий запис";
            // 
            // accountChangeToolStripMenuItem
            // 
            this.accountChangeToolStripMenuItem.Name = "accountChangeToolStripMenuItem";
            this.accountChangeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.accountChangeToolStripMenuItem.Text = "Змінити";
            this.accountChangeToolStripMenuItem.Click += new System.EventHandler(this.accountChangeToolStripMenuItem_Click);
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicesToolStripMenuItem,
            this.objectToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.analystToolStripMenuItem,
            this.visitorToolStripMenuItem,
            this.eventownerToolStripMenuItem,
            this.eventvisitorToolStripMenuItem});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.tablesToolStripMenuItem.Text = "База даних";
            this.tablesToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tablesToolStripMenuItem_DropDownItemClicked);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действительныеToolStripMenuItem,
            this.будущиеToolStripMenuItem,
            this.прошедшиеToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.servicesToolStripMenuItem.Text = "Event";
            // 
            // действительныеToolStripMenuItem
            // 
            this.действительныеToolStripMenuItem.Name = "действительныеToolStripMenuItem";
            this.действительныеToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.действительныеToolStripMenuItem.Text = "действительные";
            // 
            // будущиеToolStripMenuItem
            // 
            this.будущиеToolStripMenuItem.Name = "будущиеToolStripMenuItem";
            this.будущиеToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.будущиеToolStripMenuItem.Text = "будущие";
            // 
            // прошедшиеToolStripMenuItem
            // 
            this.прошедшиеToolStripMenuItem.Name = "прошедшиеToolStripMenuItem";
            this.прошедшиеToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.прошедшиеToolStripMenuItem.Text = "прошедшие";
            // 
            // objectToolStripMenuItem
            // 
            this.objectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.свободныеToolStripMenuItem,
            this.занятыеToolStripMenuItem});
            this.objectToolStripMenuItem.Name = "objectToolStripMenuItem";
            this.objectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.objectToolStripMenuItem.Text = "Object";
            // 
            // свободныеToolStripMenuItem
            // 
            this.свободныеToolStripMenuItem.Name = "свободныеToolStripMenuItem";
            this.свободныеToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.свободныеToolStripMenuItem.Text = "свободные";
            // 
            // занятыеToolStripMenuItem
            // 
            this.занятыеToolStripMenuItem.Name = "занятыеToolStripMenuItem";
            this.занятыеToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.занятыеToolStripMenuItem.Text = "занятые";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientsToolStripMenuItem.Text = "Result";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.employeesToolStripMenuItem.Text = "Organizer";
            // 
            // analystToolStripMenuItem
            // 
            this.analystToolStripMenuItem.Name = "analystToolStripMenuItem";
            this.analystToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.analystToolStripMenuItem.Text = "Analyst";
            // 
            // visitorToolStripMenuItem
            // 
            this.visitorToolStripMenuItem.Name = "visitorToolStripMenuItem";
            this.visitorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.visitorToolStripMenuItem.Text = "Visitor";
            // 
            // eventownerToolStripMenuItem
            // 
            this.eventownerToolStripMenuItem.Name = "eventownerToolStripMenuItem";
            this.eventownerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eventownerToolStripMenuItem.Text = "event_owner";
            // 
            // eventvisitorToolStripMenuItem
            // 
            this.eventvisitorToolStripMenuItem.Name = "eventvisitorToolStripMenuItem";
            this.eventvisitorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eventvisitorToolStripMenuItem.Text = "event_visitor";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.operationsToolStripMenuItem.Text = "Операція";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.insertToolStripMenuItem.Text = "Додати";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem.Text = "Змінити";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateTableToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Видалити";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportGenerateToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.reportToolStripMenuItem.Text = "Звіт";
            // 
            // reportGenerateToolStripMenuItem
            // 
            this.reportGenerateToolStripMenuItem.Name = "reportGenerateToolStripMenuItem";
            this.reportGenerateToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.reportGenerateToolStripMenuItem.Text = "Зберегти";
            this.reportGenerateToolStripMenuItem.Click += new System.EventHandler(this.reportGenerateToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Transparent;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.BackgroundImage = global::LibraryInfoSystem.Properties.Resources.search;
            this.pictureBoxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSearch.Location = new System.Drawing.Point(448, 39);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(29, 27);
            this.pictureBoxSearch.TabIndex = 11;
            this.pictureBoxSearch.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxSearch, "Введите ключевое слово для поиска");
            this.pictureBoxSearch.Click += new System.EventHandler(this.pictureBoxSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(71, 41);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(214, 22);
            this.textBoxSearch.TabIndex = 10;
            // 
            // pictureBoxOk
            // 
            this.pictureBoxOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxOk.BackgroundImage = global::LibraryInfoSystem.Properties.Resources.button_ok;
            this.pictureBoxOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxOk.Location = new System.Drawing.Point(744, 477);
            this.pictureBoxOk.Name = "pictureBoxOk";
            this.pictureBoxOk.Size = new System.Drawing.Size(21, 25);
            this.pictureBoxOk.TabIndex = 15;
            this.pictureBoxOk.TabStop = false;
            this.pictureBoxOk.Visible = false;
            this.pictureBoxOk.Click += new System.EventHandler(this.pictureBoxOk_Click);
            // 
            // pictureBoxUp
            // 
            this.pictureBoxUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxUp.BackgroundImage = global::LibraryInfoSystem.Properties.Resources.uparrow;
            this.pictureBoxUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUp.Location = new System.Drawing.Point(744, 194);
            this.pictureBoxUp.Name = "pictureBoxUp";
            this.pictureBoxUp.Size = new System.Drawing.Size(21, 25);
            this.pictureBoxUp.TabIndex = 13;
            this.pictureBoxUp.TabStop = false;
            this.pictureBoxUp.Visible = false;
            this.pictureBoxUp.Click += new System.EventHandler(this.pictureBoxUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Знайти";
            // 
            // pictureBoxDown
            // 
            this.pictureBoxDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDown.BackgroundImage = global::LibraryInfoSystem.Properties.Resources.downarrow;
            this.pictureBoxDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDown.Location = new System.Drawing.Point(744, 378);
            this.pictureBoxDown.Name = "pictureBoxDown";
            this.pictureBoxDown.Size = new System.Drawing.Size(21, 25);
            this.pictureBoxDown.TabIndex = 14;
            this.pictureBoxDown.TabStop = false;
            this.pictureBoxDown.Visible = false;
            this.pictureBoxDown.Click += new System.EventHandler(this.pictureBoxDown_Click);
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Location = new System.Drawing.Point(313, 41);
            this.comboBoxSelect.Name = "comboBoxSelect";
            this.comboBoxSelect.Size = new System.Drawing.Size(120, 24);
            this.comboBoxSelect.TabIndex = 17;
            this.comboBoxSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelect_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.Location = new System.Drawing.Point(12, 95);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(726, 407);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dataGridView_CellParsing);
            this.dataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(291, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "у";
            // 
            // checkBoxSeparate
            // 
            this.checkBoxSeparate.AutoSize = true;
            this.checkBoxSeparate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSeparate.Location = new System.Drawing.Point(12, 69);
            this.checkBoxSeparate.Name = "checkBoxSeparate";
            this.checkBoxSeparate.Size = new System.Drawing.Size(150, 20);
            this.checkBoxSeparate.TabIndex = 9;
            this.checkBoxSeparate.Text = "шукати цілу фразу";
            this.checkBoxSeparate.UseVisualStyleBackColor = true;
            this.checkBoxSeparate.CheckedChanged += new System.EventHandler(this.checkBoxSeparate_CheckedChanged);
            // 
            // labelHelp
            // 
            this.labelHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHelp.AutoSize = true;
            this.labelHelp.Location = new System.Drawing.Point(12, 510);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(0, 18);
            this.labelHelp.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(533, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Сортувати";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(618, 41);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(120, 24);
            this.comboBoxSort.TabIndex = 21;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // btnRegistVisitor
            // 
            this.btnRegistVisitor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistVisitor.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistVisitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistVisitor.Enabled = false;
            this.btnRegistVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegistVisitor.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnRegistVisitor.Location = new System.Drawing.Point(351, 500);
            this.btnRegistVisitor.Name = "btnRegistVisitor";
            this.btnRegistVisitor.Size = new System.Drawing.Size(75, 38);
            this.btnRegistVisitor.TabIndex = 23;
            this.btnRegistVisitor.Text = "Піти";
            this.btnRegistVisitor.UseVisualStyleBackColor = false;
            this.btnRegistVisitor.Visible = false;
            this.btnRegistVisitor.Click += new System.EventHandler(this.btnRegistVisit_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 537);
            this.Controls.Add(this.btnRegistVisitor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.checkBoxSeparate);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.pictureBoxOk);
            this.Controls.Add(this.pictureBoxUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxDown);
            this.Controls.Add(this.comboBoxSelect);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(793, 530);
            this.Name = "ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База обліку навчальної літератури бібліотеки ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormView_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportGenerateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxOk;
        private System.Windows.Forms.PictureBox pictureBoxUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxDown;
        private System.Windows.Forms.ComboBox comboBoxSelect;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxSeparate;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.ToolStripMenuItem analystToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventownerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventvisitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectToolStripMenuItem;
        private System.Windows.Forms.Button btnRegistVisitor;
        private System.Windows.Forms.ToolStripMenuItem действительныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem будущиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прошедшиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свободныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem занятыеToolStripMenuItem;
    }
}