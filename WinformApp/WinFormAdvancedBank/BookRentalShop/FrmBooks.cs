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
    public partial class FrmBooks : MetroForm
    {
        #region 전역변수
        private bool IsNew = false;// false (수정) true (신규)
        #endregion
        #region 이벤트 영역
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
        public FrmBooks()
        {
            InitializeComponent();
        }
        private void FrmDivCode_Resize(object sender, EventArgs e)
        {
            DgvData.Height = ClientRectangle.Height - 90;
            groupBox1.Height = ClientRectangle.Height - 90;
        }

        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var selData = DgvData.Rows[e.RowIndex];
                AsignToControls(selData);
                IsNew = false;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (CheckValidation() == false) return;
            if (MetroMessageBox.Show(this, "삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            DeleteData();
            RefreshData();
            ClearInputs();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckValidation() == false) return;
            SaveData();
            RefreshData();
            ClearInputs();
        }

        private void FrmDivCode_Load(object sender, EventArgs e)
        {
            IsNew = true;
            InitCboData();//콤보박스 데이터 초기화
            RefreshData();

            DtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;
        }

        #endregion
        #region 커스텀 메서드 영역

        private void AsignToControls(DataGridViewRow selData)
        {
            TxtIdx.Text = selData.Cells[0].Value.ToString();
            TxtAuthor.Text = selData.Cells[1].Value.ToString();
            CboDivision.SelectedValue = selData.Cells[2].Value.ToString();//B001-B004
            //selData.Cells[3] division X
            TxtBookNames.Text = selData.Cells[4].Value.ToString();
            DtpReleaseDate.Value = (DateTime)selData.Cells[5].Value;
            TxtISBN.Text = selData.Cells[6].Value.ToString();
            TxtPrice.Text = selData.Cells[7].Value.ToString();
            TxtDescriptions.Text = selData.Cells[8].Value.ToString();
        }
        private void InitCboData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    var query = "SELECT Division, Names FROM dbo.divtbl";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    var temp = new Dictionary<string, string>();
                    while (reader.Read())
                    {
                        temp.Add(reader[0].ToString(), reader[1].ToString());// (key)B001,(value)공포스릴러2
                    }
                    CboDivision.DataSource = new BindingSource(temp, null);
                    CboDivision.DisplayMember = "Value";
                    CboDivision.ValueMember = "Key";
                    CboDivision.SelectedIndex = -1;
                }
            }
            catch
            {
            }
        }
        /// <summary>
        /// 삭제처리 프로세스
        /// </summary>
        private void DeleteData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    var query = "DELETE FROM [dbo].[bookstbl] " +
                                " WHERE[Idx] = @Idx";
                    cmd.CommandText = query;


                    SqlParameter pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    pIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(pIdx);

                    var result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        //삭제성공
                        MetroMessageBox.Show(this, "삭제 성공", "삭제",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //삭제실패
                        MetroMessageBox.Show(this, "삭제 실패", "삭제",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 입력처리 프로세스
        /// </summary>
        private void SaveData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    var query = "";

                    if (IsNew)//insert
                    {
                        query = @"INSERT INTO [dbo].[bookstbl]
                                                   ([Author]
                                                   ,[Division]
                                                   ,[Names]
                                                   ,[ReleaseDate]
                                                   ,[ISBN]
                                                   ,[Price]
                                                   ,[Descriptions])
                                             VALUES
                                                   (@Author
                                                   ,@Division
                                                   ,@Names
                                                   ,@ReleaseDate
                                                   ,@ISBN
                                                   ,@Price
                                                   ,@Descriptions)";
                    }
                    else//update
                    {
                        query = @"UPDATE [dbo].[bookstbl]
                                       SET [Author] = @Author
                                          ,[Division] = @Division
                                          ,[Names] = @Names
                                          ,[ReleaseDate] = @ReleaseDate
                                          ,[ISBN] = @ISBN
                                          ,[Price] = @Price
                                          ,[Descriptions] = @Descriptions
                                     WHERE Idx = @Idx";
                    }


                    cmd.CommandText = query;

                    var pAuthor = new SqlParameter("@Author", SqlDbType.NVarChar, 50);
                    pAuthor.Value = TxtAuthor.Text;
                    cmd.Parameters.Add(pAuthor);

                    var pDivision = new SqlParameter("@Division", SqlDbType.VarChar, 8);
                    pDivision.Value = CboDivision.SelectedValue;
                    cmd.Parameters.Add(pDivision);

                    var pNames = new SqlParameter("@Names", SqlDbType.NVarChar, 100);
                    pNames.Value = TxtBookNames.Text;
                    cmd.Parameters.Add(pNames);

                    var pReleaseDate = new SqlParameter("@ReleaseDate", SqlDbType.Date);
                    pReleaseDate.Value = DtpReleaseDate.Value;
                    cmd.Parameters.Add(pReleaseDate);

                    var pISBN = new SqlParameter("@ISBN", SqlDbType.VarChar, 200);
                    pISBN.Value = TxtISBN.Text;
                    cmd.Parameters.Add(pISBN);

                    var pPrice = new SqlParameter("@Price", SqlDbType.Decimal);
                    pPrice.Value = TxtPrice.Text;
                    cmd.Parameters.Add(pPrice);

                    var pDescriptions = new SqlParameter("@Descriptions", SqlDbType.NVarChar);
                    pDescriptions.Value = Helper.Common.ReplaceCmdText(TxtDescriptions.Text);
                    cmd.Parameters.Add(pDescriptions);



                    if (IsNew == false)//update일 때만 처리
                    {
                        var pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                        pIdx.Value = TxtIdx.Text;
                        cmd.Parameters.Add(pIdx);
                    }


                    var result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        //저장성공
                        MetroMessageBox.Show(this, "저장 성공", "저장",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //저장실패
                        MetroMessageBox.Show(this, "저장 실패", "저장",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshData();
            }
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
                                 ,ISBN
                                 ,Price
                                 ,Descriptions
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
            column = DgvData.Columns[8];//desciptions column
            column.Visible = false;

            column = DgvData.Columns[4];
            column.Width = 250;
            column.HeaderText = "도서명";

            column = DgvData.Columns[0];
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        /// <summary>
        /// 입력값 유효성체크
        /// </summary>
        private bool CheckValidation()
        {
            if ( string.IsNullOrEmpty(TxtAuthor.Text) || string.IsNullOrEmpty(TxtBookNames.Text) ||
                DtpReleaseDate.Value == null || CboDivision.SelectedIndex == -1 )
            {
                MetroMessageBox.Show(this, "빈값은 처리할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            TxtIdx.Text = TxtAuthor.Text = TxtPrice.Text = "";
            TxtBookNames.Text = TxtISBN.Text = TxtDescriptions.Text ="";
            DtpReleaseDate.Value = DateTime.Now;
            CboDivision.SelectedIndex = -1;
            TxtIdx.ReadOnly = true;
            IsNew = true;
        }
        #endregion

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtId_Click(object sender, EventArgs e)
        {

        }
    }
}
