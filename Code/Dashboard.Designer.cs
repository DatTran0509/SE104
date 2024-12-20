
using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using Image = System.Drawing.Image;

namespace Code
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinisize = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRoomRental = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonthlyRreport = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoomResearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMoving = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_CheckOut2 = new Code.All_user_control.UC_CheckOut();
            this.uC_Service1 = new Code.All_user_control.UC_Service();
            this.uC_Manage1 = new Code.All_User_Control.UC_Manage();
            this.uC_Service3 = new Code.All_user_control.UC_Service();
            this.uC_MonthlyReport1 = new Code.All_user_control.UC_MonthlyReport();
            this.uC_CheckOut1 = new Code.All_user_control.UC_CheckOut();
            this.uC_SearchRoom1 = new Code.UC_SearchRoom();
            this.uC_RentRoom1 = new Code.All_user_control.UC_RentRoom();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExit.Location = new System.Drawing.Point(9, 6);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnMinisize
            // 
            this.btnMinisize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinisize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinisize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinisize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinisize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnMinisize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinisize.ForeColor = System.Drawing.Color.White;
            this.btnMinisize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinisize.Image")));
            this.btnMinisize.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMinisize.Location = new System.Drawing.Point(11, 61);
            this.btnMinisize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(44, 34);
            this.btnMinisize.TabIndex = 1;
            this.btnMinisize.Click += new System.EventHandler(this.btnMinisize_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnRoomRental);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnMonthlyRreport);
            this.panel1.Controls.Add(this.btnRoomResearch);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Location = new System.Drawing.Point(91, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 86);
            this.panel1.TabIndex = 2;
            // 
            // btnRoomRental
            // 
            this.btnRoomRental.BorderRadius = 18;
            this.btnRoomRental.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRoomRental.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomRental.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomRental.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoomRental.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoomRental.FillColor = System.Drawing.Color.SlateBlue;
            this.btnRoomRental.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRoomRental.ForeColor = System.Drawing.Color.White;
            this.btnRoomRental.Location = new System.Drawing.Point(287, 2);
            this.btnRoomRental.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRoomRental.Name = "btnRoomRental";
            this.btnRoomRental.Size = new System.Drawing.Size(213, 75);
            this.btnRoomRental.TabIndex = 4;
            this.btnRoomRental.Text = "THUÊ PHÒNG";
            this.btnRoomRental.Click += new System.EventHandler(this.btnRoomRental_Click_1);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderRadius = 18;
            this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.FillColor = System.Drawing.Color.SlateBlue;
            this.btnCheckOut.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(835, 3);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(213, 75);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "THANH TOÁN";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click_1);
            // 
            // btnMonthlyRreport
            // 
            this.btnMonthlyRreport.BorderRadius = 18;
            this.btnMonthlyRreport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMonthlyRreport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMonthlyRreport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMonthlyRreport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMonthlyRreport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMonthlyRreport.FillColor = System.Drawing.Color.SlateBlue;
            this.btnMonthlyRreport.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMonthlyRreport.ForeColor = System.Drawing.Color.White;
            this.btnMonthlyRreport.Location = new System.Drawing.Point(1091, 5);
            this.btnMonthlyRreport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMonthlyRreport.Name = "btnMonthlyRreport";
            this.btnMonthlyRreport.Size = new System.Drawing.Size(213, 75);
            this.btnMonthlyRreport.TabIndex = 2;
            this.btnMonthlyRreport.Text = "BÁO CÁO THÁNG";
            this.btnMonthlyRreport.Click += new System.EventHandler(this.btnMonthlyRreport_Click_1);
            // 
            // btnRoomResearch
            // 
            this.btnRoomResearch.BorderRadius = 18;
            this.btnRoomResearch.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRoomResearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomResearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomResearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoomResearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoomResearch.FillColor = System.Drawing.Color.SlateBlue;
            this.btnRoomResearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRoomResearch.ForeColor = System.Drawing.Color.White;
            this.btnRoomResearch.Location = new System.Drawing.Point(561, 2);
            this.btnRoomResearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRoomResearch.Name = "btnRoomResearch";
            this.btnRoomResearch.Size = new System.Drawing.Size(213, 75);
            this.btnRoomResearch.TabIndex = 1;
            this.btnRoomResearch.Text = "TÌM KIẾM PHÒNG";
            this.btnRoomResearch.Click += new System.EventHandler(this.btnRoomResearch_Click_1);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderRadius = 18;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.FillColor = System.Drawing.Color.SlateBlue;
            this.btnAddRoom.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(17, 2);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(213, 75);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "THUÊ DỊCH VỤ";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.uC_CheckOut2);
            this.panel2.Controls.Add(this.uC_Service1);
            this.panel2.Controls.Add(this.uC_Manage1);
            this.panel2.Controls.Add(this.uC_Service3);
            this.panel2.Controls.Add(this.uC_MonthlyReport1);
            this.panel2.Controls.Add(this.uC_CheckOut1);
            this.panel2.Controls.Add(this.uC_SearchRoom1);
            this.panel2.Controls.Add(this.uC_RentRoom1);
            this.panel2.Location = new System.Drawing.Point(81, 165);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1388, 554);
            this.panel2.TabIndex = 3;
            // 
            // panelMoving
            // 
            this.panelMoving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelMoving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMoving.Location = new System.Drawing.Point(112, 98);
            this.panelMoving.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMoving.Name = "panelMoving";
            this.panelMoving.Size = new System.Drawing.Size(211, 7);
            this.panelMoving.TabIndex = 4;
            this.panelMoving.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMoving_Paint_1);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this;
            // 
            // uC_CheckOut2
            // 
            this.uC_CheckOut2.Location = new System.Drawing.Point(422, 108);
            this.uC_CheckOut2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.uC_CheckOut2.Name = "uC_CheckOut2";
            this.uC_CheckOut2.Size = new System.Drawing.Size(6, 6);
            this.uC_CheckOut2.TabIndex = 7;
            // 
            // uC_Service1
            // 
            this.uC_Service1.Location = new System.Drawing.Point(-2, 2);
            this.uC_Service1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Service1.Name = "uC_Service1";
            this.uC_Service1.Size = new System.Drawing.Size(1350, 552);
            this.uC_Service1.TabIndex = 0;
            this.uC_Service1.Load += new System.EventHandler(this.uC_Service1_Load);
            // 
            // uC_Manage1
            // 
            this.uC_Manage1.Location = new System.Drawing.Point(-1, -2);
            this.uC_Manage1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Manage1.Name = "uC_Manage1";
            this.uC_Manage1.Size = new System.Drawing.Size(1367, 556);
            this.uC_Manage1.TabIndex = 8;
            this.uC_Manage1.Load += new System.EventHandler(this.uC_Manage1_Load);
            // 
            // uC_Service3
            // 
            this.uC_Service3.Location = new System.Drawing.Point(-2, 2);
            this.uC_Service3.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Service3.Name = "uC_Service3";
            this.uC_Service3.Size = new System.Drawing.Size(1350, 552);
            this.uC_Service3.TabIndex = 6;
            // 
            // uC_MonthlyReport1
            // 
            this.uC_MonthlyReport1.Location = new System.Drawing.Point(-1, -2);
            this.uC_MonthlyReport1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_MonthlyReport1.Name = "uC_MonthlyReport1";
            this.uC_MonthlyReport1.Size = new System.Drawing.Size(1384, 552);
            this.uC_MonthlyReport1.TabIndex = 4;
            // 
            // uC_CheckOut1
            // 
            this.uC_CheckOut1.Location = new System.Drawing.Point(-2, -2);
            this.uC_CheckOut1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.uC_CheckOut1.Name = "uC_CheckOut1";
            this.uC_CheckOut1.Size = new System.Drawing.Size(1384, 552);
            this.uC_CheckOut1.TabIndex = 3;
            // 
            // uC_SearchRoom1
            // 
            this.uC_SearchRoom1.Location = new System.Drawing.Point(-1, 0);
            this.uC_SearchRoom1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.uC_SearchRoom1.Name = "uC_SearchRoom1";
            this.uC_SearchRoom1.Size = new System.Drawing.Size(1388, 552);
            this.uC_SearchRoom1.TabIndex = 2;
            // 
            // uC_RentRoom1
            // 
            this.uC_RentRoom1.Location = new System.Drawing.Point(-5, -2);
            this.uC_RentRoom1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_RentRoom1.Name = "uC_RentRoom1";
            this.uC_RentRoom1.Size = new System.Drawing.Size(1388, 552);
            this.uC_RentRoom1.TabIndex = 1;
            this.uC_RentRoom1.Load += new System.EventHandler(this.uC_RentRoom1_Load);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1456, 787);
            this.Controls.Add(this.panelMoving);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinisize);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoard_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnMinisize;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnRoomRental;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnMonthlyRreport;
        private Guna.UI2.WinForms.Guna2Button btnRoomResearch;
        private Panel panelMoving;
        private All_user_control.UC_Service addRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_user_control.UC_Service uC_Service1;
        private All_user_control.UC_MonthlyReport uC_MonthlyReport1;
        private All_user_control.UC_CheckOut uC_CheckOut1;
        private UC_SearchRoom uC_SearchRoom1;
        private All_user_control.UC_RentRoom uC_RentRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_user_control.UC_Service uC_Service3;
        private All_user_control.UC_CheckOut uC_CheckOut2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private All_User_Control.UC_Manage uC_Manage1;
    }
}