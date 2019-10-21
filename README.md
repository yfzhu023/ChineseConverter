# ChineseConverter
批量转换简繁体文件工具，转换的文件可适用于 VisualStudio （带签名）。

转换的文件如果不带签名则可能运行时网页出错。

今天准备转换一个繁体中文的 webapplication 为简体，近万个文件需要处理，网上找了没有合适的工具，参考网上的代码，完成本工具。

欢迎反馈。


比较细致的控制 datagridview 的代码：

dataGridView1.MultiSelect = false;<br/>
dataGridView1.ReadOnly = true;<br/>
dataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;<br/>
dataGridView1.AllowUserToAddRows = false;<br/>
dataGridView1.AllowUserToDeleteRows = false;<br/>
dataGridView1.AllowUserToResizeRows = false;<br/>
dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;<br/>
<br/>
dataGridView1.Columns[0].MinimumWidth = 40;<br/>
dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;<br/>
dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;<br/>
dataGridView1.Columns[1].MinimumWidth = 150;<br/>
dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;<br/>
dataGridView1.Columns[2].MinimumWidth = 350;<br/>
dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;<br/>
dataGridView1.RowHeadersWidth = 25;<br/>
<br/>
dataGridView1.EnableHeadersVisualStyles = false;<br/>
dataGridView1.RowHeadersDefaultCellStyle.BackColor = dataGridView1.ColumnHeadersDefaultCellStyle.BackColor;<br/>
dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;<br/>
dataGridView1.ColumnHeadersHeight = 26;<br/>
<br/>
//dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;<br/>
dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
