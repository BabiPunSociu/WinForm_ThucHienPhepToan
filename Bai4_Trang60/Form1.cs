using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_Trang60
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void txtA_Enter(object sender, EventArgs e)
		{
			TextBox txt = (TextBox)sender;
			txt.BackColor = Color.DeepPink;
			/*
            if(txtA.Text != "" && txtB.Text != "")
            {
                grbPhepTinh.Enabled = true;
                grbSoSanh.Enabled = true;
            }    
            */
		}

		private void txtA_Leave(object sender, EventArgs e)
		{
			TextBox txt = (TextBox)sender;
			txt.BackColor = Color.White;
		}

		private void txtA_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
			{
				e.Handled = true;
			}
			if (e.KeyChar == 13 && txtA.Text != "" && txtB.Text != "") // ENTER
			{
				grbPhepTinh.Enabled = true;
				grbSoSanh.Enabled = true;
				txtKetQua.Enabled = true;
			}
			if (txtA.Text.Trim() == "" && e.KeyChar == 13)
			{
				txtA.Focus();
				return;
			}
			if (txtB.Text.Trim() == "" && e.KeyChar == 13)
			{
				txtB.Focus();
				return;
			}

		}

		private void rdoCong_CheckedChanged(object sender, EventArgs e)
		{
			/*
            if (txtA.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số A");
                txtA.Focus();
                return;
            }
            if (txtB.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số B");
                txtB.Focus();
                return;
            }
            */

			if (rdoCong.Checked)
			{
				double tong = double.Parse(txtA.Text) + double.Parse(txtB.Text);
				txtKetQua.Text = tong.ToString();
			}
			else if (rdoTru.Checked)
			{
				double tong = double.Parse(txtA.Text) - double.Parse(txtB.Text);
				txtKetQua.Text = tong.ToString();
			}
			else if (rdoNhan.Checked)
			{
				double tong = double.Parse(txtA.Text) * double.Parse(txtB.Text);
				txtKetQua.Text = tong.ToString();
			}
			else if (rdoChia.Checked)
			{
				if (Double.Parse(txtB.Text) == 0)
				{
					txtKetQua.Text = "Mẫu = 0";
					return;
				}
				double tong = double.Parse(txtA.Text) / double.Parse(txtB.Text);
				txtKetQua.Text = tong.ToString();
			}
		}

		private void chkMax_CheckedChanged(object sender, EventArgs e)
		{
			lblMax.Text = "";
			if (chkMax.Checked == true)
			{
				lblMax.Text = (double.Parse(txtA.Text) > double.Parse(txtB.Text) ? double.Parse(txtA.Text) : double.Parse(txtB.Text)).ToString();
			}

		}
		private void chkMin_CheckedChanged(object sender, EventArgs e)
		{
			lblMin.Text = "";
			if (chkMin.Checked == true)
			{
				lblMin.Text = (double.Parse(txtA.Text) < double.Parse(txtB.Text) ? double.Parse(txtA.Text) : double.Parse(txtB.Text)).ToString();
			}
		}
		private void btnClear_Click(object sender, EventArgs e)
		{
			txtA.Text = "";
			txtB.Text = "";

			txtKetQua.Text = "";
			txtKetQua.Enabled = false;

			rdoCong.Checked = false;
			rdoTru.Checked = false;
			rdoNhan.Checked = false;
			rdoChia.Checked = false;
			grbPhepTinh.Enabled = false;

			chkMax.Checked = false;
			chkMin.Checked = false;
			lblMax.Text = "";
			lblMin.Text = "";
			grbSoSanh.Enabled = false;

			txtA.Focus();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				// user clicked yes
				this.Close();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}


	}
}
