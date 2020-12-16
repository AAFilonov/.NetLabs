namespace lab12
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            System.Windows.Forms.Label producerLabel;
            System.Windows.Forms.Label coverLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label titleLabel;
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPagefilm = new System.Windows.Forms.TabPage();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.filmBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_dotNetDataSet = new lab12.DB_dotNetDataSet();
            this.producerComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBdotNetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageProducer = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producerTableAdapter = new lab12.DB_dotNetDataSetTableAdapters.ProducerTableAdapter();
            this.filmTableAdapter = new lab12.DB_dotNetDataSetTableAdapters.FilmTableAdapter();
            this.tableAdapterManager = new lab12.DB_dotNetDataSetTableAdapters.TableAdapterManager();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.loadFilmsTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProducersTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coverDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            producerLabel = new System.Windows.Forms.Label();
            coverLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPagefilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_dotNetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBdotNetDataSetBindingSource)).BeginInit();
            this.tabPageProducer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // producerLabel
            // 
            producerLabel.AutoSize = true;
            producerLabel.Location = new System.Drawing.Point(9, 32);
            producerLabel.Name = "producerLabel";
            producerLabel.Size = new System.Drawing.Size(52, 13);
            producerLabel.TabIndex = 2;
            producerLabel.Text = "producer:";
            // 
            // coverLabel
            // 
            coverLabel.AutoSize = true;
            coverLabel.Location = new System.Drawing.Point(9, 82);
            coverLabel.Name = "coverLabel";
            coverLabel.Size = new System.Drawing.Size(37, 13);
            coverLabel.TabIndex = 4;
            coverLabel.Text = "cover:";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPagefilm);
            this.tabControlMain.Controls.Add(this.tabPageProducer);
            this.tabControlMain.Location = new System.Drawing.Point(13, 27);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(777, 350);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPagefilm
            // 
            this.tabPagefilm.AutoScroll = true;
            this.tabPagefilm.Controls.Add(this.panel1);
            this.tabPagefilm.Controls.Add(this.dataGridView2);
            this.tabPagefilm.Location = new System.Drawing.Point(4, 22);
            this.tabPagefilm.Name = "tabPagefilm";
            this.tabPagefilm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagefilm.Size = new System.Drawing.Size(769, 324);
            this.tabPagefilm.TabIndex = 0;
            this.tabPagefilm.Text = "films";
            this.tabPagefilm.UseVisualStyleBackColor = true;
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coverPictureBox.ContextMenuStrip = this.contextMenuStrip1;
            this.coverPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.filmBindingSource1, "cover", true));
            this.coverPictureBox.Location = new System.Drawing.Point(52, 82);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(139, 142);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coverPictureBox.TabIndex = 5;
            this.coverPictureBox.TabStop = false;
            // 
            // filmBindingSource1
            // 
            this.filmBindingSource1.DataMember = "Film";
            this.filmBindingSource1.DataSource = this.dB_dotNetDataSet;
            // 
            // dB_dotNetDataSet
            // 
            this.dB_dotNetDataSet.DataSetName = "DB_dotNetDataSet";
            this.dB_dotNetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // producerComboBox
            // 
            this.producerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource1, "producer", true));
            this.producerComboBox.FormattingEnabled = true;
            this.producerComboBox.Location = new System.Drawing.Point(70, 29);
            this.producerComboBox.Name = "producerComboBox";
            this.producerComboBox.Size = new System.Drawing.Size(121, 21);
            this.producerComboBox.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn,
            this.producerDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.coverDataGridViewImageColumn});
            this.dataGridView2.DataSource = this.filmBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(519, 276);
            this.dataGridView2.TabIndex = 0;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.dBdotNetDataSetBindingSource;
            // 
            // dBdotNetDataSetBindingSource
            // 
            this.dBdotNetDataSetBindingSource.DataSource = this.dB_dotNetDataSet;
            this.dBdotNetDataSetBindingSource.Position = 0;
            // 
            // tabPageProducer
            // 
            this.tabPageProducer.Controls.Add(this.dataGridView1);
            this.tabPageProducer.Location = new System.Drawing.Point(4, 22);
            this.tabPageProducer.Name = "tabPageProducer";
            this.tabPageProducer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducer.Size = new System.Drawing.Size(745, 324);
            this.tabPageProducer.TabIndex = 1;
            this.tabPageProducer.Text = "producers";
            this.tabPageProducer.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.producerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataMember = "Producer";
            this.producerBindingSource.DataSource = this.dBdotNetDataSetBindingSource;
            // 
            // producerTableAdapter
            // 
            this.producerTableAdapter.ClearBeforeFill = true;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmTableAdapter = this.filmTableAdapter;
            this.tableAdapterManager.ProducerTableAdapter = this.producerTableAdapter;
            this.tableAdapterManager.UpdateOrder = lab12.DB_dotNetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(9, 58);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(30, 13);
            yearLabel.TabIndex = 5;
            yearLabel.Text = "year:";
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.filmBindingSource1, "year", true));
            this.yearNumericUpDown.Location = new System.Drawing.Point(48, 56);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.yearNumericUpDown.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(143, 20);
            this.yearNumericUpDown.TabIndex = 6;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(9, 6);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmBindingSource1, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(48, 3);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(143, 20);
            this.titleTextBox.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filmToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFilmsTableToolStripMenuItem,
            this.loadProducersTableToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.fileToolStripMenuItem.Text = "DB";
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.filmToolStripMenuItem.Text = "film";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLoad,
            this.toolStripMenuItemSave});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 48);
            // 
            // toolStripMenuItemLoad
            // 
            this.toolStripMenuItemLoad.Name = "toolStripMenuItemLoad";
            this.toolStripMenuItemLoad.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItemLoad.Text = "load from file";
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItemSave.Text = "save to file";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(titleLabel);
            this.panel1.Controls.Add(this.producerComboBox);
            this.panel1.Controls.Add(producerLabel);
            this.panel1.Controls.Add(yearLabel);
            this.panel1.Controls.Add(this.coverPictureBox);
            this.panel1.Controls.Add(this.yearNumericUpDown);
            this.panel1.Controls.Add(coverLabel);
            this.panel1.Location = new System.Drawing.Point(531, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 261);
            this.panel1.TabIndex = 9;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(116, 230);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // loadFilmsTableToolStripMenuItem
            // 
            this.loadFilmsTableToolStripMenuItem.Name = "loadFilmsTableToolStripMenuItem";
            this.loadFilmsTableToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.loadFilmsTableToolStripMenuItem.Text = "load films table";
            this.loadFilmsTableToolStripMenuItem.Click += new System.EventHandler(this.loadFilmsTableToolStripMenuItem_Click);
            // 
            // loadProducersTableToolStripMenuItem
            // 
            this.loadProducersTableToolStripMenuItem.Name = "loadProducersTableToolStripMenuItem";
            this.loadProducersTableToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.loadProducersTableToolStripMenuItem.Text = "load producers table";
            this.loadProducersTableToolStripMenuItem.Click += new System.EventHandler(this.loadProducersTableToolStripMenuItem_Click);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 40;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // producerDataGridViewTextBoxColumn
            // 
            this.producerDataGridViewTextBoxColumn.DataPropertyName = "producer";
            this.producerDataGridViewTextBoxColumn.HeaderText = "producer";
            this.producerDataGridViewTextBoxColumn.Name = "producerDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // coverDataGridViewImageColumn
            // 
            this.coverDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coverDataGridViewImageColumn.DataPropertyName = "cover";
            this.coverDataGridViewImageColumn.HeaderText = "cover";
            this.coverDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.coverDataGridViewImageColumn.Name = "coverDataGridViewImageColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 340);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPagefilm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_dotNetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBdotNetDataSetBindingSource)).EndInit();
            this.tabPageProducer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPagefilm;
        private System.Windows.Forms.TabPage tabPageProducer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dBdotNetDataSetBindingSource;
        private DB_dotNetDataSet dB_dotNetDataSet;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private DB_dotNetDataSetTableAdapters.ProducerTableAdapter producerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private DB_dotNetDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.BindingSource filmBindingSource1;
        private System.Windows.Forms.ComboBox producerComboBox;
        private DB_dotNetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoad;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ToolStripMenuItem loadFilmsTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProducersTableToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn coverDataGridViewImageColumn;
    }
}

