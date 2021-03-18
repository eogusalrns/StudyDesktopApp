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
    public partial class FrmMemberPopup : MetroForm
    {
        #region
        private int selMemberIdx = 0;//선택된 회원번호
        private string selMemberName = "";//선택된 회웡이름
        public int SelIdx { get; set; }
        public string SelName { get; set; }
        #endregion
        public FrmMemberPopup()
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
                    var query = @"SELECT [Idx]
                                      ,[Names]
                                      ,[Levels]
                                      ,[Addr]
                                      ,[Mobile]
                                      ,[Email]
                                  FROM [dbo].[membertbl]";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "membertbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "membertbl";
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            SelName = (string)DgvData.SelectedRows[0].Cells[1].Value;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmMemberPopup_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
