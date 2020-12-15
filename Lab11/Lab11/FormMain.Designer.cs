namespace Lab11
{
    partial class FormMain
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageFilms = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBdotNetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_dotNetDataSet = new Lab11.DB_dotNetDataSet();
            this.tabPageProducers = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new Lab11.DB_dotNetDataSetTableAdapters.FilmTableAdapter();
            this.producerTableAdapter = new Lab11.DB_dotNetDataSetTableAdapters.ProducerTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coverDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelCover = new System.Windows.Forms.Label();
            this.contextMenuStripPircturebox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain.SuspendLayout();
            this.tabPageFilms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBdotNetDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_dotNetDataSet)).BeginInit();
            this.tabPageProducers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.contextMenuStripPircturebox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageFilms);
            this.tabControlMain.Controls.Add(this.tabPageProducers);
            this.tabControlMain.Location = new System.Drawing.Point(12, 27);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(739, 442);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageFilms
            // 
            this.tabPageFilms.Controls.Add(this.labelCover);
            this.tabPageFilms.Controls.Add(this.dataGridView2);
            this.tabPageFilms.Controls.Add(this.pictureBoxCover);
            this.tabPageFilms.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilms.Name = "tabPageFilms";
            this.tabPageFilms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFilms.Size = new System.Drawing.Size(731, 416);
            this.tabPageFilms.TabIndex = 0;
            this.tabPageFilms.Text = "Фильмы";
            this.tabPageFilms.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.producerDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.coverDataGridViewImageColumn});
            this.dataGridView2.DataSource = this.filmBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(564, 404);
            this.dataGridView2.TabIndex = 3;
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
            // dB_dotNetDataSet
            // 
            this.dB_dotNetDataSet.DataSetName = "DB_dotNetDataSet";
            this.dB_dotNetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPageProducers
            // 
            this.tabPageProducers.Controls.Add(this.dataGridView1);
            this.tabPageProducers.Location = new System.Drawing.Point(4, 22);
            this.tabPageProducers.Name = "tabPageProducers";
            this.tabPageProducers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducers.Size = new System.Drawing.Size(685, 416);
            this.tabPageProducers.TabIndex = 1;
            this.tabPageProducers.Text = "Режисеры";
            this.tabPageProducers.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.producerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 410);
            this.dataGridView1.TabIndex = 3;
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataMember = "Producer";
            this.producerBindingSource.DataSource = this.dBdotNetDataSetBindingSource;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // producerTableAdapter
            // 
            this.producerTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // pictureBoxCover
            // 
            this.pictureBoxCover.ContextMenuStrip = this.contextMenuStripPircturebox;
            this.pictureBoxCover.Location = new System.Drawing.Point(576, 29);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(149, 153);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCover.TabIndex = 2;
            this.pictureBoxCover.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.coverDataGridViewImageColumn.DataPropertyName = "cover";
            this.coverDataGridViewImageColumn.HeaderText = "cover";
            this.coverDataGridViewImageColumn.Name = "coverDataGridViewImageColumn";
            // 
            // labelCover
            // 
            this.labelCover.AutoSize = true;
            this.labelCover.Location = new System.Drawing.Point(622, 185);
            this.labelCover.Name = "labelCover";
            this.labelCover.Size = new System.Drawing.Size(53, 13);
            this.labelCover.TabIndex = 4;
            this.labelCover.Text = "Обложка";
            // 
            // contextMenuStripPircturebox
            // 
            this.contextMenuStripPircturebox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLoad,
            this.toolStripMenuItemSave,
            this.toolStripMenuItemOptions});
            this.contextMenuStripPircturebox.Name = "contextMenuStripPircturebox";
            this.contextMenuStripPircturebox.Size = new System.Drawing.Size(182, 70);
            // 
            // toolStripMenuItemLoad
            // 
            this.toolStripMenuItemLoad.Name = "toolStripMenuItemLoad";
            this.toolStripMenuItemLoad.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItemLoad.Text = "Загрузить из файла";
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItemSave.Text = "Сохранить в файл";
            // 
            // toolStripMenuItemOptions
            // 
            this.toolStripMenuItemOptions.Name = "toolStripMenuItemOptions";
            this.toolStripMenuItemOptions.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItemOptions.Text = "Свойства";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 500);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "Фильмотека";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageFilms.ResumeLayout(false);
            this.tabPageFilms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBdotNetDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_dotNetDataSet)).EndInit();
            this.tabPageProducers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.contextMenuStripPircturebox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageFilms;
        private System.Windows.Forms.TabPage tabPageProducers;
        internal System.Windows.Forms.TabControl tabControlMain;
        private DB_dotNetDataSet dB_dotNetDataSet;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource dBdotNetDataSetBindingSource;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private DB_dotNetDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private DB_dotNetDataSetTableAdapters.ProducerTableAdapter producerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelCover;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn coverDataGridViewImageColumn;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPircturebox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoad;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOptions;
    }
}

