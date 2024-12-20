using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code
{
    public partial class Login : Form
    {
        function fn = new function();
        string query;
        public Login()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select MANV, SDT from NHANVIEN where MANV = '" + txtUsername.Text + "' and SDT = '" + txtPassword.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                labelError.Visible = false;
                DashBoard db = new DashBoard();
                this.Hide();
                db.Show();

            }
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }

        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }
    }
}