namespace CachedProgramsList
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.datagEntries = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkExists = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateModification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.comboFilterOptions = new System.Windows.Forms.ComboBox();
            this.csmPath = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.moreInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picWorking = new System.Windows.Forms.PictureBox();
            this.btTheme = new System.Windows.Forms.Button();
            this.btCancelFilter = new System.Windows.Forms.Button();
            this.btFilter = new System.Windows.Forms.Button();
            this.btLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagEntries)).BeginInit();
            this.csmPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWorking)).BeginInit();
            this.SuspendLayout();
            // 
            // datagEntries
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.Control;
            this.datagEntries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.datagEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagEntries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.datagEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagEntries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagEntries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagEntries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.datagEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtName,
            this.chkExists,
            this.dateCreation,
            this.dateModification,
            this.txtPath});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagEntries.DefaultCellStyle = dataGridViewCellStyle20;
            this.datagEntries.EnableHeadersVisualStyles = false;
            this.datagEntries.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.datagEntries.Location = new System.Drawing.Point(1, 33);
            this.datagEntries.Name = "datagEntries";
            this.datagEntries.RowHeadersVisible = false;
            this.datagEntries.Size = new System.Drawing.Size(697, 460);
            this.datagEntries.TabIndex = 1;
            this.datagEntries.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagEntries_CellMouseDown);
            // 
            // txtName
            // 
            this.txtName.FillWeight = 93.27411F;
            this.txtName.HeaderText = "Name";
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            // 
            // chkExists
            // 
            this.chkExists.FillWeight = 50F;
            this.chkExists.HeaderText = "Exists";
            this.chkExists.Name = "chkExists";
            this.chkExists.ReadOnly = true;
            this.chkExists.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chkExists.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chkExists.Width = 59;
            // 
            // dateCreation
            // 
            dataGridViewCellStyle18.Format = "G";
            dataGridViewCellStyle18.NullValue = null;
            this.dateCreation.DefaultCellStyle = dataGridViewCellStyle18;
            this.dateCreation.FillWeight = 93.27411F;
            this.dateCreation.HeaderText = "Creation Date";
            this.dateCreation.Name = "dateCreation";
            this.dateCreation.ReadOnly = true;
            this.dateCreation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateCreation.Width = 115;
            // 
            // dateModification
            // 
            dataGridViewCellStyle19.Format = "G";
            dataGridViewCellStyle19.NullValue = null;
            this.dateModification.DefaultCellStyle = dataGridViewCellStyle19;
            this.dateModification.FillWeight = 93.27411F;
            this.dateModification.HeaderText = "Modification Date";
            this.dateModification.Name = "dateModification";
            this.dateModification.ReadOnly = true;
            this.dateModification.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateModification.Width = 115;
            // 
            // txtPath
            // 
            this.txtPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtPath.FillWeight = 93.27411F;
            this.txtPath.HeaderText = "Path";
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(443, 7);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(187, 20);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // comboFilterOptions
            // 
            this.comboFilterOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFilterOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilterOptions.FormattingEnabled = true;
            this.comboFilterOptions.Items.AddRange(new object[] {
            "Name",
            "Creation Date",
            "Modification Date",
            "Path"});
            this.comboFilterOptions.Location = new System.Drawing.Point(296, 6);
            this.comboFilterOptions.Name = "comboFilterOptions";
            this.comboFilterOptions.Size = new System.Drawing.Size(142, 21);
            this.comboFilterOptions.TabIndex = 4;
            // 
            // csmPath
            // 
            this.csmPath.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPathToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.moreInfoToolStripMenuItem});
            this.csmPath.Name = "csmPath";
            this.csmPath.Size = new System.Drawing.Size(131, 76);
            // 
            // openPathToolStripMenuItem
            // 
            this.openPathToolStripMenuItem.Name = "openPathToolStripMenuItem";
            this.openPathToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.openPathToolStripMenuItem.Text = "Open path";
            this.openPathToolStripMenuItem.Click += new System.EventHandler(this.openPathToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // moreInfoToolStripMenuItem
            // 
            this.moreInfoToolStripMenuItem.Name = "moreInfoToolStripMenuItem";
            this.moreInfoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.moreInfoToolStripMenuItem.Text = "More info";
            this.moreInfoToolStripMenuItem.Click += new System.EventHandler(this.moreInfoToolStripMenuItem_Click);
            // 
            // picWorking
            // 
            this.picWorking.Image = ((System.Drawing.Image)(resources.GetObject("picWorking.Image")));
            this.picWorking.Location = new System.Drawing.Point(63, 2);
            this.picWorking.Name = "picWorking";
            this.picWorking.Size = new System.Drawing.Size(40, 29);
            this.picWorking.TabIndex = 7;
            this.picWorking.TabStop = false;
            this.picWorking.Visible = false;
            // 
            // btTheme
            // 
            this.btTheme.BackColor = System.Drawing.SystemColors.Control;
            this.btTheme.BackgroundImage = global::CachedProgramsList.Properties.Resources.light;
            this.btTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTheme.Location = new System.Drawing.Point(2, 2);
            this.btTheme.Name = "btTheme";
            this.btTheme.Size = new System.Drawing.Size(30, 30);
            this.btTheme.TabIndex = 6;
            this.btTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTheme.UseVisualStyleBackColor = false;
            this.btTheme.Click += new System.EventHandler(this.btTheme_Click);
            // 
            // btCancelFilter
            // 
            this.btCancelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelFilter.BackColor = System.Drawing.Color.Transparent;
            this.btCancelFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCancelFilter.BackgroundImage")));
            this.btCancelFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelFilter.Enabled = false;
            this.btCancelFilter.Location = new System.Drawing.Point(665, 2);
            this.btCancelFilter.Name = "btCancelFilter";
            this.btCancelFilter.Size = new System.Drawing.Size(30, 30);
            this.btCancelFilter.TabIndex = 5;
            this.btCancelFilter.UseVisualStyleBackColor = false;
            this.btCancelFilter.Click += new System.EventHandler(this.btCancelFilter_Click);
            // 
            // btFilter
            // 
            this.btFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFilter.BackgroundImage = global::CachedProgramsList.Properties.Resources.search;
            this.btFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFilter.Location = new System.Drawing.Point(635, 2);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(30, 30);
            this.btFilter.TabIndex = 2;
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // btLog
            // 
            this.btLog.BackColor = System.Drawing.Color.Transparent;
            this.btLog.BackgroundImage = global::CachedProgramsList.Properties.Resources.log;
            this.btLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLog.Location = new System.Drawing.Point(33, 2);
            this.btLog.Name = "btLog";
            this.btLog.Size = new System.Drawing.Size(30, 30);
            this.btLog.TabIndex = 0;
            this.btLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLog.UseVisualStyleBackColor = false;
            this.btLog.Click += new System.EventHandler(this.btLog_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 494);
            this.Controls.Add(this.picWorking);
            this.Controls.Add(this.btTheme);
            this.Controls.Add(this.btCancelFilter);
            this.Controls.Add(this.comboFilterOptions);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btFilter);
            this.Controls.Add(this.datagEntries);
            this.Controls.Add(this.btLog);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(525, 200);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "CachedProgramsList";
            ((System.ComponentModel.ISupportInitialize)(this.datagEntries)).EndInit();
            this.csmPath.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWorking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLog;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.DataGridView datagEntries;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox comboFilterOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkExists;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateModification;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPath;
        private System.Windows.Forms.Button btCancelFilter;
        private System.Windows.Forms.ContextMenuStrip csmPath;
        private System.Windows.Forms.ToolStripMenuItem openPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem moreInfoToolStripMenuItem;
        private System.Windows.Forms.Button btTheme;
        private System.Windows.Forms.PictureBox picWorking;
    }
}

