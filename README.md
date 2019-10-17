# ChineseConverter
批量转换简繁体文件工具，转换的文件可适用于 VisualStudio （带签名）。

转换的文件如果不带签名则可能运行时网页出错。

今天准备转换一个繁体中文的 webapplication 为简体，近万个文件需要处理，网上找了没有合适的工具，参考网上的代码，完成本工具。

欢迎反馈。


比较细致的控制 datagridview 的代码：

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
