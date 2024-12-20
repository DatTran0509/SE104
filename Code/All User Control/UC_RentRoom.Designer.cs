using System.Drawing;
using System.Windows.Forms;
using System;

namespace Code.All_user_control
{
    partial class UC_RentRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCusAddr = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCusName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtRoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunna2textbox = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnRentRoom = new Guna.UI2.WinForms.Guna2Button();
            this.txtCusCMND = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCusType = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMale = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtFemale = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtOther = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNumberCus = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(152, 201);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(45, 21);
            this.guna2HtmlLabel5.TabIndex = 16;
            this.guna2HtmlLabel5.Text = "CMND";
            // 
            // txtCusAddr
            // 
            this.txtCusAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusAddr.DefaultText = "";
            this.txtCusAddr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusAddr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusAddr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusAddr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusAddr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusAddr.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtCusAddr.ForeColor = System.Drawing.Color.Black;
            this.txtCusAddr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusAddr.Location = new System.Drawing.Point(152, 370);
            this.txtCusAddr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCusAddr.Name = "txtCusAddr";
            this.txtCusAddr.PasswordChar = '\0';
            this.txtCusAddr.PlaceholderText = "Nhập vào địa chỉ( Nếu có )";
            this.txtCusAddr.SelectedText = "";
            this.txtCusAddr.Size = new System.Drawing.Size(495, 31);
            this.txtCusAddr.TabIndex = 15;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(154, 348);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(44, 21);
            this.txtPrice.TabIndex = 14;
            this.txtPrice.Text = "Địa chỉ";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(152, 146);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(68, 21);
            this.guna2HtmlLabel3.TabIndex = 12;
            this.guna2HtmlLabel3.Text = "Loại khách";
            // 
            // txtCusName
            // 
            this.txtCusName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusName.DefaultText = "";
            this.txtCusName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusName.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtCusName.ForeColor = System.Drawing.Color.Black;
            this.txtCusName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusName.Location = new System.Drawing.Point(152, 101);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.PasswordChar = '\0';
            this.txtCusName.PlaceholderText = "Nhập vào tên khách hàng";
            this.txtCusName.SelectedText = "";
            this.txtCusName.Size = new System.Drawing.Size(498, 33);
            this.txtCusName.TabIndex = 11;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(152, 78);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(100, 21);
            this.guna2HtmlLabel2.TabIndex = 10;
            this.guna2HtmlLabel2.Text = "Tên khách hàng";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(739, 309);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(67, 21);
            this.guna2HtmlLabel4.TabIndex = 22;
            this.guna2HtmlLabel4.Text = "Ngày thuê";
            // 
            // txtRoomType
            // 
            this.txtRoomType.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRoomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomType.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtRoomType.ForeColor = System.Drawing.Color.Black;
            this.txtRoomType.ItemHeight = 30;
            this.txtRoomType.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.txtRoomType.Location = new System.Drawing.Point(740, 101);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(499, 36);
            this.txtRoomType.TabIndex = 21;
            this.txtRoomType.SelectedIndexChanged += new System.EventHandler(this.txtRoomType_SelectedIndexChanged);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(742, 137);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(62, 21);
            this.guna2HtmlLabel6.TabIndex = 20;
            this.guna2HtmlLabel6.Text = "Số phòng";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNo.DefaultText = "";
            this.txtRoomNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtRoomNo.ForeColor = System.Drawing.Color.Black;
            this.txtRoomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNo.Location = new System.Drawing.Point(742, 160);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.PasswordChar = '\0';
            this.txtRoomNo.PlaceholderText = "Nhập vào số phòng";
            this.txtRoomNo.SelectedText = "";
            this.txtRoomNo.Size = new System.Drawing.Size(498, 33);
            this.txtRoomNo.TabIndex = 19;
            // 
            // gunna2textbox
            // 
            this.gunna2textbox.BackColor = System.Drawing.Color.Transparent;
            this.gunna2textbox.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.gunna2textbox.ForeColor = System.Drawing.Color.Black;
            this.gunna2textbox.Location = new System.Drawing.Point(739, 78);
            this.gunna2textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunna2textbox.Name = "gunna2textbox";
            this.gunna2textbox.Size = new System.Drawing.Size(72, 21);
            this.gunna2textbox.TabIndex = 18;
            this.gunna2textbox.Text = "Loại phòng";
            // 
            // btnRentRoom
            // 
            this.btnRentRoom.BorderRadius = 18;
            this.btnRentRoom.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnRentRoom.BorderThickness = 1;
            this.btnRentRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnRentRoom.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnRentRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRentRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRentRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRentRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRentRoom.FillColor = System.Drawing.Color.White;
            this.btnRentRoom.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnRentRoom.ForeColor = System.Drawing.Color.Black;
            this.btnRentRoom.Location = new System.Drawing.Point(1102, 422);
            this.btnRentRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRentRoom.Name = "btnRentRoom";
            this.btnRentRoom.Size = new System.Drawing.Size(135, 45);
            this.btnRentRoom.TabIndex = 26;
            this.btnRentRoom.Text = "Lưu";
            this.btnRentRoom.Click += new System.EventHandler(this.btnRentRoom_Click_1);
            // 
            // txtCusCMND
            // 
            this.txtCusCMND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusCMND.DefaultText = "";
            this.txtCusCMND.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusCMND.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusCMND.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusCMND.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusCMND.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusCMND.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtCusCMND.ForeColor = System.Drawing.Color.Black;
            this.txtCusCMND.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusCMND.Location = new System.Drawing.Point(152, 224);
            this.txtCusCMND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCusCMND.Name = "txtCusCMND";
            this.txtCusCMND.PasswordChar = '\0';
            this.txtCusCMND.PlaceholderText = "Nhập vào CMND";
            this.txtCusCMND.SelectedText = "";
            this.txtCusCMND.Size = new System.Drawing.Size(495, 31);
            this.txtCusCMND.TabIndex = 27;
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.Checked = true;
            this.txtCheckIn.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.txtCheckIn.FillColor = System.Drawing.Color.White;
            this.txtCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtCheckIn.Location = new System.Drawing.Point(740, 337);
            this.txtCheckIn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtCheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.Size = new System.Drawing.Size(180, 29);
            this.txtCheckIn.TabIndex = 28;
            this.txtCheckIn.Value = new System.DateTime(2024, 9, 2, 12, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(59, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "Thuê phòng";
            // 
            // txtCusType
            // 
            this.txtCusType.AutoSize = true;
            this.txtCusType.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusType.CheckedState.BorderRadius = 0;
            this.txtCusType.CheckedState.BorderThickness = 0;
            this.txtCusType.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusType.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtCusType.Location = new System.Drawing.Point(152, 168);
            this.txtCusType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCusType.Name = "txtCusType";
            this.txtCusType.Size = new System.Drawing.Size(147, 24);
            this.txtCusType.TabIndex = 30;
            this.txtCusType.Text = "Khách nước ngoài";
            this.txtCusType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtCusType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtCusType.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.txtCusType.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtCusType.UncheckedState.BorderRadius = 0;
            this.txtCusType.UncheckedState.BorderThickness = 0;
            this.txtCusType.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Checked = true;
            this.txtCheckOut.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.txtCheckOut.FillColor = System.Drawing.Color.White;
            this.txtCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtCheckOut.Location = new System.Drawing.Point(1057, 337);
            this.txtCheckOut.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtCheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(180, 29);
            this.txtCheckOut.TabIndex = 32;
            this.txtCheckOut.Value = new System.DateTime(2024, 9, 2, 12, 0, 0, 0);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(1057, 309);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(100, 21);
            this.guna2HtmlLabel1.TabIndex = 31;
            this.guna2HtmlLabel1.Text = "Ngày trả phòng";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(414, 146);
            this.guna2HtmlLabel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(55, 21);
            this.guna2HtmlLabel7.TabIndex = 34;
            this.guna2HtmlLabel7.Text = "Giới tính";
            // 
            // txtMale
            // 
            this.txtMale.AutoSize = true;
            this.txtMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMale.CheckedState.BorderRadius = 0;
            this.txtMale.CheckedState.BorderThickness = 0;
            this.txtMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMale.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtMale.Location = new System.Drawing.Point(414, 168);
            this.txtMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMale.Name = "txtMale";
            this.txtMale.Size = new System.Drawing.Size(60, 24);
            this.txtMale.TabIndex = 35;
            this.txtMale.Text = "Nam";
            this.txtMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtMale.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.txtMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtMale.UncheckedState.BorderRadius = 0;
            this.txtMale.UncheckedState.BorderThickness = 0;
            this.txtMale.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txtFemale
            // 
            this.txtFemale.AutoSize = true;
            this.txtFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFemale.CheckedState.BorderRadius = 0;
            this.txtFemale.CheckedState.BorderThickness = 0;
            this.txtFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFemale.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtFemale.Location = new System.Drawing.Point(500, 168);
            this.txtFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFemale.Name = "txtFemale";
            this.txtFemale.Size = new System.Drawing.Size(48, 24);
            this.txtFemale.TabIndex = 36;
            this.txtFemale.Text = "Nữ";
            this.txtFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtFemale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtFemale.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.txtFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtFemale.UncheckedState.BorderRadius = 0;
            this.txtFemale.UncheckedState.BorderThickness = 0;
            this.txtFemale.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txtOther
            // 
            this.txtOther.AutoSize = true;
            this.txtOther.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOther.CheckedState.BorderRadius = 0;
            this.txtOther.CheckedState.BorderThickness = 0;
            this.txtOther.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOther.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtOther.Location = new System.Drawing.Point(593, 168);
            this.txtOther.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(60, 24);
            this.txtOther.TabIndex = 37;
            this.txtOther.Text = "Khác";
            this.txtOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtOther.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtOther.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.txtOther.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtOther.UncheckedState.BorderRadius = 0;
            this.txtOther.UncheckedState.BorderThickness = 0;
            this.txtOther.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(154, 269);
            this.guna2HtmlLabel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(83, 21);
            this.guna2HtmlLabel8.TabIndex = 38;
            this.guna2HtmlLabel8.Text = "Số điện thoại";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(152, 296);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderText = "Nhập vào SĐT( Nếu có )";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(495, 31);
            this.txtPhoneNumber.TabIndex = 39;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(154, 413);
            this.guna2HtmlLabel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(35, 21);
            this.guna2HtmlLabel9.TabIndex = 40;
            this.guna2HtmlLabel9.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(152, 436);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Nhập vào Email( Nếu có )";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(495, 31);
            this.txtEmail.TabIndex = 41;
            // 
            // txtNumberCus
            // 
            this.txtNumberCus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberCus.DefaultText = "";
            this.txtNumberCus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumberCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumberCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberCus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberCus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberCus.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtNumberCus.ForeColor = System.Drawing.Color.Black;
            this.txtNumberCus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberCus.Location = new System.Drawing.Point(742, 245);
            this.txtNumberCus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumberCus.Name = "txtNumberCus";
            this.txtNumberCus.PasswordChar = '\0';
            this.txtNumberCus.PlaceholderText = "Nhập vào số lượng KH";
            this.txtNumberCus.SelectedText = "";
            this.txtNumberCus.Size = new System.Drawing.Size(495, 31);
            this.txtNumberCus.TabIndex = 42;
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(742, 224);
            this.guna2HtmlLabel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(97, 21);
            this.guna2HtmlLabel10.TabIndex = 43;
            this.guna2HtmlLabel10.Text = "Số lượng khách";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_RentRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.txtNumberCus);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.txtFemale);
            this.Controls.Add(this.txtMale);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.txtCheckOut);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtCusType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCheckIn);
            this.Controls.Add(this.txtCusCMND);
            this.Controls.Add(this.btnRentRoom);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.gunna2textbox);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.txtCusAddr);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_RentRoom";
            this.Size = new System.Drawing.Size(1350, 552);
            this.Enter += new System.EventHandler(this.UC_RentRoom_Enter);
            this.Leave += new System.EventHandler(this.UC_RentRoom_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtCusAddr;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtCusName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox txtRoomType;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel gunna2textbox;
        private Guna.UI2.WinForms.Guna2Button btnRentRoom;
        private Guna.UI2.WinForms.Guna2TextBox txtCusCMND;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtCheckIn;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox txtCusType;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtCheckOut;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2CheckBox txtOther;
        private Guna.UI2.WinForms.Guna2CheckBox txtFemale;
        private Guna.UI2.WinForms.Guna2CheckBox txtMale;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtNumberCus;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}