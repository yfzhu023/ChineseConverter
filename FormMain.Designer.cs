namespace ChineseConverter
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCommon = new System.Windows.Forms.TabPage();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkbox_MSChineseConvert = new System.Windows.Forms.CheckBox();
            this.button_Convert = new System.Windows.Forms.Button();
            this.textBox_Source = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.tabPageBatch = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_ClearListView = new System.Windows.Forms.Button();
            this.combobox_Option = new System.Windows.Forms.ComboBox();
            this.button_OpenFolderDialog = new System.Windows.Forms.Button();
            this.button_StartConvert = new System.Windows.Forms.Button();
            this.textBox_Exts = new System.Windows.Forms.TextBox();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_Convert = new System.Windows.Forms.ProgressBar();
            this.tabControlMain.SuspendLayout();
            this.tabPageCommon.SuspendLayout();
            this.tabPageBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageCommon);
            this.tabControlMain.Controls.Add(this.tabPageBatch);
            this.tabControlMain.Location = new System.Drawing.Point(5, 5);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.Padding = new System.Drawing.Point(12, 3);
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(775, 550);
            this.tabControlMain.TabIndex = 4;
            // 
            // tabPageCommon
            // 
            this.tabPageCommon.Controls.Add(this.textBox_Result);
            this.tabPageCommon.Controls.Add(this.radioButton2);
            this.tabPageCommon.Controls.Add(this.radioButton1);
            this.tabPageCommon.Controls.Add(this.checkbox_MSChineseConvert);
            this.tabPageCommon.Controls.Add(this.button_Convert);
            this.tabPageCommon.Controls.Add(this.textBox_Source);
            this.tabPageCommon.Controls.Add(this.button_Clear);
            this.tabPageCommon.Controls.Add(this.button_Save);
            this.tabPageCommon.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommon.Name = "tabPageCommon";
            this.tabPageCommon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommon.Size = new System.Drawing.Size(767, 524);
            this.tabPageCommon.TabIndex = 0;
            this.tabPageCommon.Text = "文本转换";
            this.tabPageCommon.UseVisualStyleBackColor = true;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Result.Location = new System.Drawing.Point(6, 279);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Result.Size = new System.Drawing.Size(755, 239);
            this.textBox_Result.TabIndex = 5;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(96, 253);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 16);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "繁体转简体";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 253);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 16);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "简体转繁体";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkbox_MSChineseConvert
            // 
            this.checkbox_MSChineseConvert.AutoSize = true;
            this.checkbox_MSChineseConvert.Checked = true;
            this.checkbox_MSChineseConvert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_MSChineseConvert.Location = new System.Drawing.Point(185, 253);
            this.checkbox_MSChineseConvert.Name = "checkbox_MSChineseConvert";
            this.checkbox_MSChineseConvert.Size = new System.Drawing.Size(120, 16);
            this.checkbox_MSChineseConvert.TabIndex = 2;
            this.checkbox_MSChineseConvert.Text = "使用微软转换方案";
            this.checkbox_MSChineseConvert.UseVisualStyleBackColor = true;
            // 
            // button_Convert
            // 
            this.button_Convert.Location = new System.Drawing.Point(556, 250);
            this.button_Convert.Name = "button_Convert";
            this.button_Convert.Size = new System.Drawing.Size(64, 23);
            this.button_Convert.TabIndex = 0;
            this.button_Convert.Text = "转换";
            this.button_Convert.UseVisualStyleBackColor = true;
            this.button_Convert.Click += new System.EventHandler(this.button_Convert_Click);
            // 
            // textBox_Source
            // 
            this.textBox_Source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Source.Location = new System.Drawing.Point(6, 6);
            this.textBox_Source.Multiline = true;
            this.textBox_Source.Name = "textBox_Source";
            this.textBox_Source.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Source.Size = new System.Drawing.Size(755, 238);
            this.textBox_Source.TabIndex = 0;
            // 
            // button_Clear
            // 
            this.button_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Clear.Location = new System.Drawing.Point(626, 250);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(64, 23);
            this.button_Clear.TabIndex = 1;
            this.button_Clear.Text = "清空";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Location = new System.Drawing.Point(696, 250);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(64, 23);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "保存";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // tabPageBatch
            // 
            this.tabPageBatch.Controls.Add(this.dataGridView1);
            this.tabPageBatch.Controls.Add(this.checkBox1);
            this.tabPageBatch.Controls.Add(this.button_Refresh);
            this.tabPageBatch.Controls.Add(this.button_ClearListView);
            this.tabPageBatch.Controls.Add(this.combobox_Option);
            this.tabPageBatch.Controls.Add(this.button_OpenFolderDialog);
            this.tabPageBatch.Controls.Add(this.button_StartConvert);
            this.tabPageBatch.Controls.Add(this.textBox_Exts);
            this.tabPageBatch.Controls.Add(this.textBox_Path);
            this.tabPageBatch.Controls.Add(this.label2);
            this.tabPageBatch.Controls.Add(this.label4);
            this.tabPageBatch.Controls.Add(this.label1);
            this.tabPageBatch.Controls.Add(this.label3);
            this.tabPageBatch.Controls.Add(this.pb_Convert);
            this.tabPageBatch.Location = new System.Drawing.Point(4, 22);
            this.tabPageBatch.Name = "tabPageBatch";
            this.tabPageBatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBatch.Size = new System.Drawing.Size(767, 524);
            this.tabPageBatch.TabIndex = 1;
            this.tabPageBatch.Text = "文件转换";
            this.tabPageBatch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 62);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(687, 427);
            this.dataGridView1.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(212, 499);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(42, 16);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "BOM";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Refresh.Location = new System.Drawing.Point(697, 34);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(64, 23);
            this.button_Refresh.TabIndex = 4;
            this.button_Refresh.Text = "刷新列表";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_ClearListView
            // 
            this.button_ClearListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ClearListView.Location = new System.Drawing.Point(697, 6);
            this.button_ClearListView.Name = "button_ClearListView";
            this.button_ClearListView.Size = new System.Drawing.Size(64, 23);
            this.button_ClearListView.TabIndex = 2;
            this.button_ClearListView.Text = "清空列表";
            this.button_ClearListView.UseVisualStyleBackColor = true;
            this.button_ClearListView.Click += new System.EventHandler(this.button_ClearListView_Click);
            // 
            // combobox_Option
            // 
            this.combobox_Option.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.combobox_Option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_Option.FormattingEnabled = true;
            this.combobox_Option.Items.AddRange(new object[] {
            "转为简体",
            "转为繁体"});
            this.combobox_Option.Location = new System.Drawing.Point(74, 497);
            this.combobox_Option.Name = "combobox_Option";
            this.combobox_Option.Size = new System.Drawing.Size(132, 20);
            this.combobox_Option.TabIndex = 6;
            // 
            // button_OpenFolderDialog
            // 
            this.button_OpenFolderDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OpenFolderDialog.Location = new System.Drawing.Point(627, 6);
            this.button_OpenFolderDialog.Name = "button_OpenFolderDialog";
            this.button_OpenFolderDialog.Size = new System.Drawing.Size(64, 23);
            this.button_OpenFolderDialog.TabIndex = 1;
            this.button_OpenFolderDialog.Text = "浏览";
            this.button_OpenFolderDialog.UseVisualStyleBackColor = true;
            this.button_OpenFolderDialog.Click += new System.EventHandler(this.button_OpenFolderDialog_Click);
            // 
            // button_StartConvert
            // 
            this.button_StartConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_StartConvert.Location = new System.Drawing.Point(697, 495);
            this.button_StartConvert.Name = "button_StartConvert";
            this.button_StartConvert.Size = new System.Drawing.Size(64, 23);
            this.button_StartConvert.TabIndex = 8;
            this.button_StartConvert.Text = "开始转换";
            this.button_StartConvert.UseVisualStyleBackColor = true;
            this.button_StartConvert.Click += new System.EventHandler(this.button_StartConvert_Click);
            // 
            // textBox_Exts
            // 
            this.textBox_Exts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Exts.Location = new System.Drawing.Point(74, 35);
            this.textBox_Exts.Name = "textBox_Exts";
            this.textBox_Exts.Size = new System.Drawing.Size(617, 21);
            this.textBox_Exts.TabIndex = 3;
            this.textBox_Exts.Text = "*.cs,*.aspx,*.sql";
            // 
            // textBox_Path
            // 
            this.textBox_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Path.Location = new System.Drawing.Point(74, 8);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.ReadOnly = true;
            this.textBox_Path.Size = new System.Drawing.Size(547, 21);
            this.textBox_Path.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "文件类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "文件列表：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件目录：";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "转换选项：";
            // 
            // pb_Convert
            // 
            this.pb_Convert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Convert.Location = new System.Drawing.Point(260, 495);
            this.pb_Convert.Name = "pb_Convert";
            this.pb_Convert.Size = new System.Drawing.Size(431, 22);
            this.pb_Convert.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "中文简繁体转换工具";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCommon.ResumeLayout(false);
            this.tabPageCommon.PerformLayout();
            this.tabPageBatch.ResumeLayout(false);
            this.tabPageBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageCommon;
        private System.Windows.Forms.CheckBox checkbox_MSChineseConvert;
        private System.Windows.Forms.Button button_Convert;
        private System.Windows.Forms.TextBox textBox_Source;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TabPage tabPageBatch;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_ClearListView;
        private System.Windows.Forms.ComboBox combobox_Option;
        private System.Windows.Forms.Button button_OpenFolderDialog;
        private System.Windows.Forms.Button button_StartConvert;
        private System.Windows.Forms.TextBox textBox_Exts;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pb_Convert;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

