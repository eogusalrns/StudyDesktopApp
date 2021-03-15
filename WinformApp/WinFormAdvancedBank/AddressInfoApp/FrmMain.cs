using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressInfoApp
{
    public partial class FrmMain : Form
    {
        string connString = "Data Source=127.0.0.1;Initial Catalog = PMS; Persist Security Info=True;" +
            "User ID = sa;Password=mssql_p@ssw0rd!";
        public FrmMain()
        {
            InitializeComponent();
            TxtIdx.Focus();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            RefreshData();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtIdx.Text, out int result);
            if (result > 0)
            {
                MessageBox.Show("초기화를 진행하십시오");
                return;
            }
            if (string.IsNullOrEmpty(TxtFullName.Text) || string.IsNullOrEmpty(MtbMobile.Text))
            {
                MessageBox.Show("값을 입력하세요."); 
                return;
            }
                
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = $"INSERT INTO dbo.Address" +
                    $" (FullName, " +
                    $" Mobile, " +
                    $" Address, " +
                    $" RegId, " +
                    $" RegDate) " +
                    $" VALUES " +
                    $" ('{TxtFullName.Text}'," +
                    $"  '{MtbMobile.Text.Replace("-","")}'," +
                    $"  '{TxtAddr.Text}'," +
                    $"  'admin'," +
                    $"  GETDATE() ); ";

                SqlCommand cmd = new SqlCommand(query, conn);
                if(cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("입력 성공");
                }
                else
                {
                    MessageBox.Show("입력 실패");
                }
            }
            RefreshData();
            ClearInput();
        }

        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                //SSMS 테이블 스크립팅 메뉴활용
                string query = "SELECT Idx " +
                               "     , FullName " +
                               "     , Mobile " +
                               "     , Address " +
                               "  FROM dbo.Address ";
                //SqlCommand, SqlDataReader or Object 사용방법 1
                //SqlDataAdapter, DataSet
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DgvAddress.DataSource = ds.Tables[0];
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtIdx.Text, out int result);
            if (result == 0)
            {
                MessageBox.Show("데이터를 선택하세요");
                return;
            }
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = $"UPDATE Address " +
                    $" SET " +
                    $" FullName = '{TxtFullName.Text}'," +
                    $" Mobile = '{MtbMobile.Text.Replace("-","")}' ," +
                    $" Address = '{TxtAddr.Text}' ," +
                    $" ModId = 'admin'," +
                    $" ModDate = GETDATE()" +
                    $" WHERE Idx = {result} ";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("수정 성공");
                else
                    MessageBox.Show("수정 실패");
            }
            ClearInput();
            RefreshData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtIdx.Text, out int result);
            if (result == 0)
            {
                MessageBox.Show("데이터를 선택하세요");
                return;
            }
            using(SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = $"DELETE FROM Address WHERE idx = {result}";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("삭제 성공");
                else
                    MessageBox.Show("삭제 실패");
            }
            ClearInput();
            RefreshData();
        }

        private void MtbMobile_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar == 13)
            {
                TxtAddr.Focus();
            }
        }

        private void TxtAddr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MtbMobile.Focus();
            }
        }

        private void TxtIdx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtFullName.Focus();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RefreshData();
            ClearInput();
        }

        private void ClearInput()
        {
            TxtIdx.Text = TxtFullName.Text = TxtAddr.Text = MtbMobile.Text = "";
        }


        private void DgvAddress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectData = DgvAddress.Rows[e.RowIndex].Cells;
            TxtIdx.Text = selectData[0].Value.ToString();
            TxtFullName.Text = selectData[1].Value.ToString();
            MtbMobile.Text = selectData[2].Value.ToString();
            TxtAddr.Text = selectData[3].Value.ToString();
        }

        private void DgvAddress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectData = DgvAddress.Rows[e.RowIndex].Cells;
            TxtIdx.Text = selectData[0].Value.ToString();
            TxtFullName.Text = selectData[1].Value.ToString();
            MtbMobile.Text = selectData[2].Value.ToString();
            TxtAddr.Text = selectData[3].Value.ToString();
        }
    }
}
