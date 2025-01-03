using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Code.All_user_control
{
    public partial class UC_Service : UserControl
    {
        function fn = new function();
        string query;
        public UC_Service()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        public int CalNumberDate()
        {
            int yearStart = txtStart.Value.Year;
            int monthStart = txtStart.Value.Month;
            int dayStart = txtStart.Value.Day;
            int yearEnd = txtFinish.Value.Year;
            int monthEnd = txtFinish.Value.Month;
            int dayEnd = txtFinish.Value.Day;

            if (yearStart == yearEnd)
            {
                if (monthStart == monthEnd)
                {
                    return dayEnd - dayStart;
                }
                else
                {
                    if (monthStart == 1 || monthStart == 3 || monthStart == 5 || monthStart == 7 || monthStart == 8 || monthStart == 10 || monthStart == 12)
                    {
                        return (31 - dayStart) + dayEnd;
                    }
                    else
                    {
                        return (30 - dayStart) + dayEnd;
                    }
                }
            }
            else
            {
                return (31 - dayStart) + dayEnd;
            }

        }

        private void btnRentService_Click(object sender, EventArgs e)
        {
            query = "SELECT SoLuongKhachToiDa, GiaPhongLoaiA, GiaPhongLoaiB, GiaPhongLoaiC, GiaDichVuLoai1, GiaDichVuLoai2, GiaDichVuLoai3, GiaDichVuLoai4, GiaDichVuLoai5, HeSoPhuThuKhachNuocNgoai, TylePhuThu FROM THAMSO";
            DataSet ds = fn.getData(query);
            int SoLuongKhachToiDa = Convert.ToInt32(ds.Tables[0].Rows[0]["SoLuongKhachToiDa"]);
            float GiaPhongLoaiA = Convert.ToSingle(ds.Tables[0].Rows[0]["GiaPhongLoaiA"]);
            float GiaPhongLoaiB = Convert.ToSingle(ds.Tables[0].Rows[0]["GiaPhongLoaiB"]);
            float GiaPhongLoaiC = Convert.ToSingle(ds.Tables[0].Rows[0]["GiaPhongLoaiC"]);
            float TyLePhuThu = 1 + Convert.ToSingle(ds.Tables[0].Rows[0]["TylePhuThu"]);
            float GiaDichVuLoai1 = Convert.ToSingle(ds.Tables[0].Rows[0]["GiaDichVuLoai1"]);
            float GiaDichVuLoai2 = Convert.ToSingle(ds.Tables[0].Rows[0]["GiaDichVuLoai2"]);
            float GiaDichVuLoai3 = Convert.ToSingle(ds.Tables[0].Rows[0]["GiaDichVuLoai3"]);
            float GiaDichVuLoai4 = Convert.ToSingle(ds.Tables[0].Rows[0]["GiaDichVuLoai4"]);
            float GiaDichVuLoai5 = Convert.ToSingle(ds.Tables[0].Rows[0]["GiaDichVuLoai5"]);
            float HeSoPhuThuKhachNuocNgoai = Convert.ToSingle(ds.Tables[0].Rows[0]["HeSoPhuThuKhachNuocNgoai"]);
            if (txtName.Text != "" && txtStart.Text != "" && txtFinish.Text != "" && txtNumber.Text != "" && txtService.Text != "")
            {

                String name = txtName.Text;
                String service = txtService.Text;
                Int64 number = Int64.Parse(txtNumber.Text);
                String start = txtStart.Text;
                String end = txtFinish.Text;
                double price = 0;
                string serviceno = "";
                int numberday = CalNumberDate();

                if(numberday < 0)
                {
                    MessageBox.Show("Vui lòng chọn ngày thuê dịch vụ phù hợp!", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(number<0)
                {
                    MessageBox.Show("Vui lòng không chọn số lượng dịch vụ là số âm!", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
                else
                {
               
                    if (txtService.Text == "Giặt ủi quần áo")
                    {
                        serviceno = "LDV1";


                        price = number * GiaDichVuLoai1 * numberday;


                    }
                    if (txtService.Text == "Cho thuê xe máy")
                    {
                        serviceno = "LDV2";

                        price = number * GiaDichVuLoai2 * numberday;
                    }
                    if (txtService.Text == "Thu đổi ngoại tệ")
                    {
                        serviceno = "LDV3";
                        price = number * GiaDichVuLoai3;

                    }
                    if (txtService.Text == "Đón khách")
                    {
                        serviceno = "LDV4";
                        if (number <= 5)
                        {
                            price = 0;
                        }
                        else
                        {

                            price = (number - 5) * GiaDichVuLoai4 * numberday;
                        }
                    }
                    if (txtService.Text == "Buffet sáng")
                    {
                        serviceno = "LDV5";

                        price = number * GiaDichVuLoai5 * numberday;
                    }

                    string MATP = Find_MATP(name);

                    if (MATP == "none")
                    {
                        MessageBox.Show("CMND Không hợp lệ. Vui lòng nhập lại thông tin", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        clearAll();
                    }
                    else
                    {
                        query = "insert into DICHVU (MALDV, MATP, NGBATDAUDV, NGKETTHUCDV, SOLUONGDV, TONGTIENDV) values ('" + serviceno + "','" + MATP + "', CONVERT(DATETIME, '" + start + "', 103), CONVERT(DATETIME, '" + end + "', 103), " + number + ", " + price + ")";
                        fn.setData(query, "Đã thuê dịch vụ thành công");

                        UC_Service_Load(this, null);
                        clearAll();
                    }
                }

            }
            else
            {
                MessageBox.Show("Xin vui lòng điền đầy đủ thông tin", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        public string Find_MATP(string name)
        {
            query = "select THUEPHONG.MATP " +
                    "from THUEPHONG " +
                    "inner join KHACHHANG " +
                    "on THUEPHONG.MAKH = KHACHHANG.MAKH and KHACHHANG.CMND = N'" + name + "';";
            DataSet ds = fn.getData(query);

            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }

            return "none";
        }

        public void clearAll()
        {
            txtName.Clear();
            txtService.SelectedIndex = -1;
            txtNumber.Clear();
        }

        private void UC_Service_Load(object sender, EventArgs e)
        {
            query = "select LOAIDICHVU.TENDV as [Tên loại DV],  KHACHHANG.CMND as [CMND], FORMAT(NGBATDAUDV, 'dd/MM/yyyy HH:mm:ss') as [Ngày bắt đầu], FORMAT(NGKETTHUCDV, 'dd/MM/yyyy HH:mm:ss') as [Ngày kết thúc], LOAIDICHVU.MOTA as [ Mô tả ], SOLUONGDV as [ Số lượng ], TONGTIENDV as [Tổng tiền] from DICHVU inner join LOAIDICHVU on DICHVU.MALDV = LOAIDICHVU.MALDV inner join THUEPHONG on THUEPHONG.MATP = DICHVU.MATP inner join KHACHHANG on KHACHHANG.MAKH = THUEPHONG.MAKH;";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

            // Tính tỷ lệ phần trăm chiều rộng cho mỗi cột
            float[] columnWidths = { 15, 15, 20, 20, 20, 10, 10 };
            float totalWidth = dataGridView1.Width - dataGridView1.RowHeadersWidth;

            dataGridView1.RowTemplate.Height = 50;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = (int)(totalWidth * (columnWidths[i] / 100));
            }
        }

        private void txtStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFinish_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtService_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}