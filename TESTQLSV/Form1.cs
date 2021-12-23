using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Runtime.InteropServices;
using System.Data;
using DataTable = System.Data.DataTable;

namespace TESTQLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SINHVIEN[] SV = new SINHVIEN[100] ;
        int flag;
        int SL = 0;

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtHT.Text = "";
            txtMSSV.Text = "";
            txtDQT.Text = "";
            txtDKT.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if(flag==0)
            {
                SL = SL + 1;
                SV[SL] = new SINHVIEN();
                SV[SL].HoTen = txtHT.Text;
                SV[SL].MSSV = txtMSSV.Text;
                SV[SL].DQT = Convert.ToDouble(txtDQT.Text);
                SV[SL].DKT = Convert.ToDouble(txtDKT.Text);
                    int stt;
                    for(stt=1;stt-1<dgvQL.Rows.Count;stt++)
                    {
                        double stt1 = stt;
                    }
                dgvQL.Rows.Add(stt, SV[SL].HoTen, SV[SL].MSSV, SV[SL].DQT, SV[SL].DKT, SV[SL].DTK());
            }
            else
            {
                int index;
                index = dgvQL.CurrentRow.Index;
                SV[index + 1].HoTen = txtHT.Text;
                SV[index + 1].MSSV = txtMSSV.Text;
                SV[index + 1].DQT = Convert.ToDouble(txtDQT.Text);
                SV[index + 1].DKT = Convert.ToDouble(txtDKT.Text);
                dgvQL.Rows[index].Cells[1].Value = SV[index + 1].HoTen;
                dgvQL.Rows[index].Cells[2].Value = SV[index + 1].MSSV;
                dgvQL.Rows[index].Cells[3].Value = SV[index + 1].DQT;
                dgvQL.Rows[index].Cells[4].Value = SV[index + 1].DKT;
                dgvQL.Rows[index].Cells[5].Value = SV[index + 1].DTK();
                flag = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SV[0] = new SINHVIEN();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int index;
            index = dgvQL.CurrentRow.Index;

            txtHT.Text = Convert.ToString(dgvQL.Rows[index].Cells[1].Value);
            txtMSSV.Text = Convert.ToString(dgvQL.Rows[index].Cells[2].Value);
            txtDQT.Text = Convert.ToString(dgvQL.Rows[index].Cells[3].Value);
            txtDKT.Text = Convert.ToString(dgvQL.Rows[index].Cells[4].Value);
            flag = 1;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int index;
            index = dgvQL.CurrentRow.Index;

            dgvQL.Rows.RemoveAt(index);
            for (int stt = 0; stt < dgvQL.Rows.Count; stt++)
            {
                dgvQL.Rows[stt].Cells[0].Value = stt + 1;

            }
        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvQL.DataSource != null)
            {
                this.dgvQL.DataSource = null;
            }
            else
            {
                this.dgvQL.Rows.Clear();
            }
        }

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

            string file = "";   //biến cho Vị trí tệp Excel
            DataTable dt = new DataTable();   //container for our excel data

            DataRow row;
            DialogResult result = openFileDialog1.ShowDialog();  // Show the dialog.
            if (result == DialogResult.OK)   // Check if Result == "OK".
            {
                file = openFileDialog1.FileName; //lấy tên tệp với vị trí của tệp
                try

                {
                    //Tạo đối tượng cho Microsoft.Office.Interop.Excel sẽ được sử dụng để đọc tệp excel

                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

                    Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(file);

                    Microsoft.Office.Interop.Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];

                    Microsoft.Office.Interop.Excel.Range excelRange = excelWorksheet.UsedRange;


                    int rowCount = excelRange.Rows.Count;  //nhận số lượng hàng của dữ liệu excel

                    int colCount = excelRange.Columns.Count; // nhận số cột của dữ liệu excel

                    //Lấy Cột đầu tiên của tệp excel là Tên Cột                

                    for (int i = 1; i <= rowCount; i++)
                    {
                        for (int j = 1; j <= colCount; j++)
                        {
                            dt.Columns.Add(excelRange.Cells[i, j].Value2.ToString());
                        }
                        break;
                    }

                    //Nhận dữ liệu hàng của Excel
                    int rowCounter;  //Biến này được sử dụng cho số chỉ mục hàng
                    for (int i = 2; i <= rowCount; i++) //Vòng lặp cho hàng dữ liệu excel có sẵn
                    {
                        row = dt.NewRow();    //gán hàng mới cho DataTable
                                                rowCounter = 0;
                        for (int j = 1; j <= colCount; j++) //Vòng lặp cho cột dữ liệu excel có sẵn
                        {
                            //check if cell is empty
                            if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                            {
                                row[rowCounter] = excelRange.Cells[i, j].Value2.ToString();
                            }
                            else
                            {
                                row[i] = "";
                            }
                            
                            rowCounter++;
                        }
                        dt.Rows.Add(row);  //thêm hàng vào DataTable
                    }
                    
                    dgvQL.DataSource = dt; //gán DataTable làm Nguồn dữ liệu cho DataGridview

                    //Đóng và làm sạch quy trình excel
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    Marshal.ReleaseComObject(excelRange);
                    Marshal.ReleaseComObject(excelWorksheet);
                    excelWorkbook.Close();
                    Marshal.ReleaseComObject(excelWorkbook);

                    //quit 
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //using(OpenFileDialog openFileDialog1=new OpenFileDialog())
            //OpenFileDialog op = new OpenFileDialog();
            //op.InitialDirectory = @"D:\";
            //op.Title = "Browse Excel Files";
            //op.CheckFileExists = true;
            //op.CheckPathExists = true;
            //op.DefaultExt = "xls";
            //op.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm;*.csv";
            //op.FilterIndex = 2;
            //op.RestoreDirectory = true;
            //op.ReadOnlyChecked = true;
            //op.ShowReadOnly = true;
            //if (op.ShowDialog() == DialogResult.OK)
            //{
            //    openFileDialog1.FileName != "";
            //}

            

            //if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    //if (File.Exists(op.FileName))
            //    //{
            //    //    string[] Arr = null;
            //    //    Arr = op.FileName.Split('.');
            //    //    if (Arr.Length > 0)
            //    //    {
            //    //        if (Arr[Arr.Length - 1] == "xls")
            //    //            sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
            //    //            op.FileName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'";
            //    //    }
            //    //    else if (Arr[Arr.Length - 1] == "xlsx")
            //    //    {
            //    //        sConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + op.FileName + ";Extended Properties='Excel 12.0 Xml;HDR=YES';";
            //    //    }
            //    //}
            //    //FillData();
            //}

        }
        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++) { obj.Cells[1, i] = g.Columns[i - 1].HeaderText; }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        private void eXCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //export2Excel(dgvQL, @"D:\", "xuatfileExcel");
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"D:\";
            saveFileDialog1.Title = "Save Excel File";
            saveFileDialog1.DefaultExt = "xls";
            saveFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm;*.csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.ShowDialog();

            //if (saveFileDialog1.FileName != "")
            //{
            //    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
            //    export2Excel(dgvQL, @"D:\", "xuatfileExcel");
            //    fs.Close();
            //}
            export2Excel(dgvQL, /*@"D:\"*/saveFileDialog1.FileName, "");
        }

        private void tXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All file|*.*";
            saveFileDialog1.ShowDialog();
            string path = "";
            path = saveFileDialog1.FileName;
            StreamWriter fw = new StreamWriter(path);
            fw.WriteLine(dgvQL.Rows.Count);
            for (int i = 0; i < dgvQL.Rows.Count; i++)
            {
                string str = "";
                str += dgvQL.Rows[i].Cells[0].Value + " ";
                str += dgvQL.Rows[i].Cells[1].Value + " ";
                str += dgvQL.Rows[i].Cells[2].Value + " ";
                str += dgvQL.Rows[i].Cells[3].Value + " ";
                str += dgvQL.Rows[i].Cells[4].Value + " ";
                str += dgvQL.Rows[i].Cells[5].Value ;
              
                fw.WriteLine(str);
            }
            fw.Close();
        }

        private void btndiem_Click(object sender, EventArgs e)
        {
            //string str = "";
            //int i, min, max, j,max1;
            //int index;
            //index = dgvQL.CurrentRow.Index;


            //    //max = int.Parse((string)dgvQL.Rows[index].Cells[5].Value);

            //    for (j = 0; j-1 < dgvQL.Rows.Count; j++)
            //{
            //    max = int.Parse((string)dgvQL.Rows[j].Cells[5].Value);
            //    max1 = Math.Max(max, int.Parse((string)dgvQL.Rows[j].Cells[5].Value));
            //    str += max1;
            //}
            ////str += max1;
            ////int index;

            ////for (i = 0; i < dgvQL.Rows.Count; i++)
            ////    //index = dgvQL.CurrentRow.Index;
            ////dgvQL.Rows[i].Cells[5].Value = txtmax.Text ;
            ////max = Convert.ToInt32(txtmax.Text);
            ////for (i=1;i< dgvQL.Rows.Count;i++)
            ////    if(Convert.ToInt32(i)>max)
            ////    {
            ////        max = Convert.ToInt32(txtmax.Text);
            ////    }
            //txtmax.Text = str;
            //dgvQL.CurrentCell.RowIndex;
            //int rowindex = dgvQL.CurrentCell.RowIndex;
            //int columnindex = dgvQL.CurrentCell.ColumnIndex;

            //dgvQL.Rows[rowindex].Cells[columnindex].Value.ToString();

            double[] columnData = new double[dgvQL.Rows.Count];

            columnData = (from DataGridViewRow row in dgvQL.Rows
                         where row.Cells[5].FormattedValue.ToString() != string.Empty
                         select Convert.ToDouble(row.Cells[5].FormattedValue)).ToArray();

            if (columnData != null) 
            {
                txtmax.Text = columnData.Max().ToString();
            }
            else
            {
                txtmax.Text = "-1";
            }

        }

        private void btndiemmax_Click(object sender, EventArgs e)
        {
            double[] columnData = new double[dgvQL.Rows.Count];

            columnData = (from DataGridViewRow row in dgvQL.Rows
                          where row.Cells[5].FormattedValue.ToString() != string.Empty
                          select Convert.ToDouble(row.Cells[5].FormattedValue)).ToArray();

            if (columnData != null)
            {
                txtmax.Text = columnData.Max().ToString();
            }
            else
            {
                txtmax.Text = "-1";
            }
        }

        private void btndiemmin_Click(object sender, EventArgs e)
        {
            double[] columnData = new double[dgvQL.Rows.Count];

            columnData = (from DataGridViewRow row in dgvQL.Rows
                          where row.Cells[5].FormattedValue.ToString() != string.Empty
                          select Convert.ToDouble(row.Cells[5].FormattedValue)).ToArray();

            if (columnData != null)
            {
                txtmin.Text = columnData.Min().ToString();
            }
            else
            {
                txtmin.Text = "-1";
            }
        }

        private void btndiemAvg_Click(object sender, EventArgs e)
        {
            double[] columnData = new double[dgvQL.Rows.Count];

            columnData = (from DataGridViewRow row in dgvQL.Rows
                          where row.Cells[5].FormattedValue.ToString() != string.Empty
                          select Convert.ToDouble(row.Cells[5].FormattedValue)).ToArray();

            if (columnData != null)
            {
                txtdtb.Text = columnData.Average().ToString();
            }
            else
            {
                txtdtb.Text = "-1";
            }
        }
    }
}
