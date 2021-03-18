using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookRentalShop
{
    public partial class FrmBooksPopup : MetroForm
    {
        public int SelIdx { get; set; }
        public string SelName { get; set; }
        public FrmBooksPopup()
        {
            InitializeComponent();
        }
        
        private void RefreshData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    var query = @"SELECT Idx
                                 ,Author
	                             ,b.Division
                                 ,d.Names as 장르
                                 ,b.Names
                                 ,ReleaseDate
                             FROM dbo.bookstbl as b
                            Inner join dbo.divtbl as d
                               on d.Division = b.Division"; // 210318 Descriptions 추가
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "bookstbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "bookstbl";
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //데이터그리드뷰 컬럼(Division,Descriptions) 화면에서 안보이게
            var column = DgvData.Columns[2];//division column
            column.Visible = false;

            column = DgvData.Columns[4];
            column.Width = 250;
            column.HeaderText = "도서명";

            column = DgvData.Columns[0];
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            DgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        
        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void FrmBooksPopup_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (DgvData.SelectedRows.Count == 0)
            {
                MetroMessageBox.Show(this, "데이터를 선택하세요", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SelIdx = (int)DgvData.SelectedRows[0].Cells[0].Value;
            SelName = (string)DgvData.SelectedRows[0].Cells[4].Value;

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
