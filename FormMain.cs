using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Reflection;

namespace ChineseConverter
{
    public partial class FormMain : Form
    {
        DataTable dtList = new DataTable();
        private ToolTip TipObject;
        private string OpenFileDefineExt = "";
        private string OpenFileDefineName = "";

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text += @"-V" + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            dtList.Columns.Add("序号");
            dtList.Columns.Add("文件名");
            dtList.Columns.Add("文件路径");

            dataGridView1.DataSource = dtList;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dataGridView1.Columns[0].MinimumWidth = 40;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].MinimumWidth = 150;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].MinimumWidth = 350;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.RowHeadersWidth = 25;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = dataGridView1.ColumnHeadersDefaultCellStyle.BackColor;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersHeight = 26;

            //dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            combobox_Option.SelectedIndex = 0;

            TipObject = new ToolTip();
            TipObject.AutoPopDelay = 10000;    //工具提示保持可见的时间期限
            TipObject.InitialDelay = 200;     //鼠标放上，自动打开提示的时间
            TipObject.ReshowDelay = 1000;       //鼠标离开，自动关闭提示的时间
            TipObject.ShowAlways = true;     //总是显示，即便空间非活动
            TipObject.UseAnimation = true;   //动画效果
            TipObject.UseFading = true;      //淡入淡出效果
            TipObject.IsBalloon = true;      //气球状外观
            TipObject.SetToolTip(this.textBox_Exts, "多个文件类型以半角逗号(,)分隔");
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            TabPageControlEnable(tabPageCommon, false);
            string strText = textBox_Source.Text;
            bool useChineseConvert = checkbox_MSChineseConvert.Checked;

            if (radioButton1.Checked == false)
            {
                Task.Factory.StartNew(() =>
                {
                    Stopwatch Watch = new Stopwatch();
                    Watch.Start();
                    strText = StringToSimlified(strText, useChineseConvert);
                    Invoke(new Action(() =>
                    {
                        Watch.Stop();
                        textBox_Result.Text = strText;
                        TabPageControlEnable(tabPageCommon, true);
                    }));
                });
            }
            else
            {
                Task.Factory.StartNew(() =>
                {
                    Stopwatch Watch = new Stopwatch();
                    Watch.Start();
                    strText = StringToTraditional(strText, useChineseConvert);
                    Invoke(new Action(() =>
                    {
                        Watch.Stop();
                        textBox_Result.Text = strText;
                        TabPageControlEnable(tabPageCommon, true);
                    }));
                });
            }
        }

        private void TabPageControlEnable(TabPage tabPage, bool isEnable = true)
        {
            foreach (Control item in tabPage.Controls)
            {
                if (item is Button)
                {
                    ((Button)item).Enabled = isEnable;
                }
                else if (item is TextBox)
                {
                    ((TextBox)item).Enabled = isEnable;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Enabled = isEnable;
                }
            }
        }

        private string StringToSimlified(string str, bool useChineseConverClass = true)
        {
            try
            {
                if (useChineseConverClass)
                {
                    return ChineseConvert.ToSimplified(str);
                }
                else
                {
                    return Microsoft.VisualBasic.Strings.StrConv(str, Microsoft.VisualBasic.VbStrConv.SimplifiedChinese, 0);
                }
            }
            catch (Exception)
            {
                return "";
            }
        }

        private string StringToTraditional(string str, bool useChineseConverClass = true)
        {
            try
            {
                if (useChineseConverClass)
                {
                    return ChineseConvert.ToTraditional(str);
                }
                else
                {
                    return Microsoft.VisualBasic.Strings.StrConv(str, Microsoft.VisualBasic.VbStrConv.TraditionalChinese, 0);
                }
            }
            catch (Exception)
            {
                return "";
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Source.Text = "";
            textBox_Result.Text = "";
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            LoadDirectoryFile(textBox_Path.Text.Trim());

            Cursor.Current = Cursors.Default;
        }

        private void button_OpenFolderDialog_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string path = OpenFolder();
            if (Directory.Exists(path))
            {
                textBox_Path.Text = path;

                button_Refresh_Click(null, null);
            }

            Cursor.Current = Cursors.Default;
        }

        private string OpenFolder()
        {
            string sPath = "";
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "选择文件目录";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                sPath = folder.SelectedPath;
            }
            return sPath;
        }

        private void button_ClearListView_Click(object sender, EventArgs e)
        {
            dtList.Rows.Clear();
            textBox_Path.Clear();
        }

        private void LoadDirectoryFile(string path)
        {
            if (Directory.Exists(path))
            {
                dtList.Rows.Clear();

                GetFile(path);
            }
        }

        private void GetFile(string path)
        {
            DirectoryInfo currendDir = new DirectoryInfo(path);
            FileInfo[] files = currendDir.GetFiles();
            DirectoryInfo[] dirs = currendDir.GetDirectories();

            foreach (FileInfo file in files)
            {
                string[] exts = textBox_Exts.Text.Split(',');

                foreach (string ext in exts)
                {
                    if (file.Extension.ToLower() == ext.ToLower().Replace("*", ""))
                    {
                        DataRow row = dtList.NewRow();
                        row[0] = (dtList.Rows.Count + 1).ToString();
                        row[1] = file.Name;
                        row[2] = file.FullName;
                        dtList.Rows.Add(row);
                    }
                }
            }

            Application.DoEvents();

            foreach (DirectoryInfo d in dirs)
            {
                GetFile(d.FullName);
            }
        }

        private void button_StartConvert_Click(object sender, EventArgs e)
        {
            string path = textBox_Path.Text.Trim();
            string format = combobox_Option.Text.Trim();
            bool useChineseConvert = checkbox_MSChineseConvert.Checked;
            int fileLength = dtList.Rows.Count;
            if (fileLength <= 0)
            {
                MessageBox.Show("待转换文件列表为空。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;

                pb_Convert.Value = 0;
                pb_Convert.Maximum = dtList.Rows.Count;
                button_StartConvert.Enabled = false;
                int cnt = 0;
                Stopwatch Watch = new Stopwatch();
                Watch.Start();

                foreach (DataRow item in dtList.Rows)
                {
                    string filePath = item[2].ToString();
                    Task.Factory.StartNew(() =>
                    {
                        if (format == "转为简体")
                        {
                            SaveFile(filePath, StringToSimlified(ReadFile(filePath), useChineseConvert));
                        }
                        else
                        {
                            SaveFile(filePath, StringToTraditional(ReadFile(filePath), useChineseConvert));
                        }
                        this.Invoke(new Action(() =>
                        {
                            cnt = cnt + 1;
                            pb_Convert.Value = cnt;
                            if (cnt >= fileLength)
                            {
                                Watch.Stop();
                                MessageBox.Show("转换完成，共处理" + pb_Convert.Value + "个文件，耗时" + string.Format("{0:0.###}", Watch.Elapsed.TotalSeconds) + "秒。", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                pb_Convert.Value = 0;
                                button_StartConvert.Enabled = true;
                                dtList.Rows.Clear();
                                textBox_Path.Clear();
                            }
                        }));
                    });
                }

                Cursor.Current = Cursors.Default;

            }
        }

        private bool SaveFile(string path, string text)
        {
            if (path.Trim() == "")
            {
                return false;
            }
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path); //如果文件存在则删除文件
                }

                var utf8WithBom = new System.Text.UTF8Encoding(checkBox1.Checked);  // 用true来指定包含bom
                StreamWriter swr = null;
                try
                {
                    swr = new StreamWriter(path, false, utf8WithBom);
                    swr.Write(text);
                }
                catch (Exception e)
                {
                }
                finally
                {
                    if (swr != null)
                    {
                        swr.Close();
                        swr.Dispose();
                    }
                }
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                MessageBox.Show(err.Message, "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string ReadFile(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    OpenFileDefineExt = Path.GetExtension(path);
                    OpenFileDefineName = Path.GetFileNameWithoutExtension(path);

                    using (StreamReader sr = new StreamReader(path))
                    {
                        StringBuilder sbText = new StringBuilder();

                        while (!sr.EndOfStream)
                        {
                            sbText.AppendLine(sr.ReadLine());
                        }
                        return sbText.ToString();
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    return err.Message;
                }
            }
            else
            {
                return "";
            }
        }

    }
}