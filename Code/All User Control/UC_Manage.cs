using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace Code.All_User_Control
{
    public partial class UC_Manage : UserControl
    {
        function fn = new function();
        public UC_Manage()
        {
            InitializeComponent();
        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRentRoom_Click(object sender, EventArgs e)
        {
            if (txtTypeService.Text != "" && txtNewPrice.Text != "")
            {
                string typeService = txtTypeService.Text;
                string query;

                // Cập nhật SoLuongKhachToiDa
                if (typeService == "SoLuongKhachToiDa")
                {
                    int newValue = Convert.ToInt32(txtNewPrice.Text);
                    if (newValue > 0)
                    {
                        query = "UPDATE THAMSO SET SoLuongKhachToiDa = " + newValue;
                        fn.setData(query, "Cập nhật số lượng khách tối đa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập một số nguyên lớn hơn 0 cho số lượng khách tối đa.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                // Cập nhật giá trị float trong THAMSO
                else if (typeService.StartsWith("Gia") || typeService.StartsWith("Ty")|| typeService.StartsWith("He"))
                {
                    float newValue = (float)Convert.ToDouble(txtNewPrice.Text);
                    if (newValue > 0)
                    {
                        
                        // Cập nhật giá trị vào bảng LoaiPhong
                        if (typeService == "GiaPhongLoaiA")
                        {
                            query = "UPDATE LOAIPHONG SET GIA = " + newValue + " WHERE MALPH = 'LP01'";
                            fn.setData(query, "");

                            query = "UPDATE THAMSO SET GiaPhongLoaiA = " + newValue + "";
                            fn.setData(query, "Cập nhật giá phong loại A thành công!");

                        }
                        else if (typeService == "GiaPhongLoaiB")
                        {
                            query = "UPDATE LOAIPHONG SET GIA = " + newValue + " WHERE MALPH = 'LP02'";
                            fn.setData(query, "");

                            query = "UPDATE THAMSO SET GiaPhongLoaiB = " + newValue + "";
                            fn.setData(query, "Cập nhật giá phong loại B thành công!");
                        }
                        else if (typeService == "GiaPhongLoaiC")
                        {
                            query = "UPDATE LOAIPHONG SET GIA = " + newValue + " WHERE MALPH = 'LP03'";
                            fn.setData(query, "");

                            query = "UPDATE THAMSO SET GiaPhongLoaiC = " + newValue + "";
                            fn.setData(query, "Cập nhật giá phong loại C thành công!");
                        }
                        // Cập nhật giá trị vào bảng LoaiDichVu
                        else if (typeService.StartsWith("GiaDichVuLoai"))
                        {
                            int dichVuIndex = Convert.ToInt32(typeService.Replace("GiaDichVuLoai", "")); // Lấy số cuối
                            string tmp = dichVuIndex.ToString();
                            string maLoaiDichVu = "LDV" + tmp; // Tạo mã dịch vụ LDV1, LDV2,...
                            query = "UPDATE LOAIDICHVU SET DONGIA = " + newValue + " WHERE MALDV = '" + maLoaiDichVu + "'";
                            fn.setData(query, "");

                            query = "UPDATE THAMSO SET GiaDichVuLoai" + tmp + " = " + newValue;
                            fn.setData(query, $"Cập nhật giá dịch vụ loại {tmp} thành công!");
                        }
                        else if(typeService == "TyLePhuThu")
                        {
                            query = "UPDATE THAMSO SET " + typeService + " = " + newValue;
                            fn.setData(query, "Cập nhật giá trị tỷ lệ phụ thu thành công!");
                        }
                        else if(typeService == "HeSoPhuThuKhachNuocNgoai")
                        {
                            query = "UPDATE THAMSO SET " + typeService + " = " + newValue;
                            fn.setData(query, "Cập nhật giá trị hệ số phụ thu khách nước ngoài thành công!");
                        }
                      
                    }
                    else
                    {   
                        MessageBox.Show("Vui lòng nhập giá trị lớn hơn 0 cho dịch vụ.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Tham số không hợp lệ!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            /*else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }



        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtTypeService_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
