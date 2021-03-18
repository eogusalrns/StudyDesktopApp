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
using System.Diagnostics;

namespace BookRentalShop
{
    public partial class FrmRental : MetroForm
    {
        #region 전역변수
        private bool IsNew = false;// false (수정) true (신규)
        private int selMemberIdx = 0;//선택된 회원번호
        private string selMemberName = "";//선택된 회웡이름
        #endregion
        #region 이벤트 영역
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
        public FrmRental()
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
                BtnSearchBook.Enabled = BtnSearchMember.Enabled = false;
                DtpRentalDate.Enabled = false;
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

            DtpRentalDate.CustomFormat = "yyyy-MM-dd";
            DtpRentalDate.Format = DateTimePickerFormat.Custom;
        }

        #endregion
        #region 커스텀 메서드 영역

        private void AsignToControls(DataGridViewRow selData)
        {
            TxtIdx.Text = selData.Cells[0].Value.ToString();
            selMemberIdx = (int)selData.Cells[1].Value;
            Debug.WriteLine($">>> selMemberIdx : {selMemberIdx}");
            TxtMemberName.Text = selData.Cells[2].Value.ToString();
            selBookIdx = (int)selData.Cells[3].Value;
            Debug.WriteLine($">>> selBookIdx : {selBookIdx}");
            TxtBookNames.Text = selData.Cells[4].Value.ToString();
            DtpRentalDate.Value = (DateTime)selData.Cells[5].Value;
            TxtReturnDate.Text = selData.Cells[6].Value == null? "":selData.Cells[6].Value.ToString();
            CboRentalState.SelectedValue = selData.Cells[7].Value;
        }
        private void InitCboData()
        {
            try
            {
                var temp = new Dictionary<string, string>();
                temp.Add("R", "대여중");
                temp.Add("T", "반납");

                CboRentalState.DataSource = new BindingSource(temp, null);
                CboRentalState.DisplayMember = "Value";
                CboRentalState.ValueMember = "Key";
                CboRentalState.SelectedIndex = -1;
                
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
                        query = @"INSERT INTO dbo.rentaltbl
                                        (memberIdx
                                        ,bookIdx
                                        ,rentalDate
                                        ,rentalState)
                                    VALUES
                                        (@memberIdx
                                        ,@bookIdx
                                        ,@rentalDate
                                        ,@rentalState)";
                    }
                    else//update
                    {
                        query = @"UPDATE [dbo].[rentaltbl]
                                              ,[returnDate] = GetDate()
                                              ,[rentalState] = @rentalState
                                         WHERE Idx = @Idx";
                    }

                    cmd.CommandText = query;

                    if (IsNew == true)
                    {
                        var pmemberIdx = new SqlParameter("@memberIdx", SqlDbType.Int);
                        pmemberIdx.Value = selMemberIdx;
                        cmd.Parameters.Add(pmemberIdx);

                        var pbookIdx = new SqlParameter("@bookIdx", SqlDbType.Int);
                        pbookIdx.Value = selBookIdx;
                        cmd.Parameters.Add(pbookIdx);

                        var prentalDate = new SqlParameter("@rentalDate", SqlDbType.Date);
                        prentalDate.Value = DtpRentalDate.Value;
                        cmd.Parameters.Add(prentalDate);

                        var prentalState = new SqlParameter("@rentalState", SqlDbType.Date);
                        prentalState.Value = CboRentalState.SelectedValue;
                        cmd.Parameters.Add(prentalState);
                    }
                    else//업데이트할때
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
                    var query = @"SELECT r.Idx
                                          ,memberIdx
	                                      ,m.Names as memberName
                                          ,bookIdx
	                                      ,b.Names as bookName
                                          ,rentalDate
                                          ,returnDate
                                          ,r.rentalState
                                    	  ,case r.rentalState 
			                                    when 'R' then '대여중'
			                                    when 'T' then '반납'
			                                    else '상태없음' 
	                                       end as StateDesc
                                      FROM dbo.rentaltbl as r
                                     inner join dbo.membertbl as m
                                        on r.memberIdx = m.idx
                                     inner join dbo.bookstbl as b
                                        on r.bookIdx = b.idx"; // 210318 Descriptions 추가
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
            var column = DgvData.Columns[1];//memberidx column
            column.Visible = false;
            column = DgvData.Columns[3];//bookidx column
            column.Visible = false;
            column = DgvData.Columns[7];//rentalstate column
            column.Visible = false;

            column = DgvData.Columns[0];
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        /// <summary>
        /// 입력값 유효성체크
        /// </summary>
        private bool CheckValidation()
        {
            if ( string.IsNullOrEmpty(TxtMemberName.Text) || string.IsNullOrEmpty(TxtBookNames.Text) ||
                DtpRentalDate.Value == null || CboRentalState.SelectedIndex < 0)
            {
                MetroMessageBox.Show(this, "빈값은 처리할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            selMemberIdx = selBookIdx = 0;
            selMemberName = selBookName = "";
            TxtBookNames.Text = TxtIdx.Text = TxtMemberName.Text =  "";
            DtpRentalDate.Value = DateTime.Now;
            CboRentalState.SelectedIndex = -1;
            TxtReturnDate.Text = "";
            TxtIdx.ReadOnly = true;
            BtnSearchBook.Enabled = BtnSearchMember.Enabled = true;
            DtpRentalDate.Enabled = true;
            IsNew = true;
        }
        #endregion


        private void BtnSearchMember_Click(object sender, EventArgs e)
        {
            FrmMemberPopup frm = new FrmMemberPopup();
            frm.StartPosition = FormStartPosition.CenterParent;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                selMemberIdx = frm.SelIdx;
                TxtMemberName.Text = selMemberName = frm.SelName;
            }
        }

        private int selBookIdx = 0;
        private string selBookName = "";

        private void BtnSearchBook_Click(object sender, EventArgs e)
        {
            FrmBooksPopup frm = new FrmBooksPopup();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                selBookIdx = frm.SelIdx;
                TxtBookNames.Text = selBookName = frm.SelName;
            }
        }
    }
}
