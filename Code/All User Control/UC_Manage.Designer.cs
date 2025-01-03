namespace Code.All_User_Control
{
    partial class UC_Manage
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
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTypeService = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNewPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdjust = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(166, 114);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(157, 21);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Loại đơn giá cần thay đổi";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(582, 114);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(78, 21);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Đơn giá mới";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // txtTypeService
            // 
            this.txtTypeService.BackColor = System.Drawing.Color.Transparent;
            this.txtTypeService.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtTypeService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTypeService.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTypeService.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTypeService.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTypeService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtTypeService.ItemHeight = 30;
            this.txtTypeService.Items.AddRange(new object[] {
            "GiaPhongLoaiA",
            "GiaPhongLoaiB",
            "GiaPhongLoaiC",
            "GiaDichVuLoai1",
            "GiaDichVuLoai2",
            "GiaDichVuLoai3",
            "GiaDichVuLoai4",
            "GiaDichVuLoai5",
            "TyLePhuThu",
            "HeSoPhuThuKhachNuocNgoai",
            "SoLuongKhachToiDa"});
            this.txtTypeService.Location = new System.Drawing.Point(166, 145);
            this.txtTypeService.Margin = new System.Windows.Forms.Padding(2);
            this.txtTypeService.Name = "txtTypeService";
            this.txtTypeService.Size = new System.Drawing.Size(244, 36);
            this.txtTypeService.TabIndex = 7;
            this.txtTypeService.SelectedIndexChanged += new System.EventHandler(this.txtTypeService_SelectedIndexChanged);
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPrice.DefaultText = "";
            this.txtNewPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtNewPrice.ForeColor = System.Drawing.Color.Black;
            this.txtNewPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPrice.Location = new System.Drawing.Point(582, 141);
            this.txtNewPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.PasswordChar = '\0';
            this.txtNewPrice.PlaceholderText = "Nhập giá mới";
            this.txtNewPrice.SelectedText = "";
            this.txtNewPrice.Size = new System.Drawing.Size(314, 33);
            this.txtNewPrice.TabIndex = 20;
            this.txtNewPrice.TextChanged += new System.EventHandler(this.txtRoomNo_TextChanged);
            // 
            // btnAdjust
            // 
            this.btnAdjust.BorderRadius = 18;
            this.btnAdjust.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnAdjust.BorderThickness = 1;
            this.btnAdjust.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnAdjust.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAdjust.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdjust.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdjust.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdjust.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdjust.FillColor = System.Drawing.Color.White;
            this.btnAdjust.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnAdjust.ForeColor = System.Drawing.Color.Black;
            this.btnAdjust.Location = new System.Drawing.Point(1130, 447);
            this.btnAdjust.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Size = new System.Drawing.Size(135, 45);
            this.btnAdjust.TabIndex = 27;
            this.btnAdjust.Text = "Lưu";
            this.btnAdjust.Click += new System.EventHandler(this.btnRentRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tùy chỉnh đơn giá ";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdjust);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.txtTypeService);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Manage";
            this.Size = new System.Drawing.Size(1349, 547);
            this.Load += new System.EventHandler(this.btnRentRoom_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox txtTypeService;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPrice;
        private Guna.UI2.WinForms.Guna2Button btnAdjust;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
