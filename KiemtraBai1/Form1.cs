using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemtraBai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void kiemtra_Click(object sender, EventArgs e)
        {
          double a = double.Parse(texta.Text);
          double b = double.Parse(textb.Text);
          double c = double.Parse(textc.Text);
            double chuVi;
            double dienTich;
            double cc;

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                label6.Visible = true;
                label7.Visible = true;
                textChuvi.Visible = true;
                textDientich.Visible = true;
                textKiemtra.Text = "Thoã mãn 3 cạnh của tam giác";
                chuVi = a + b + c;
                cc = (a + b + c) / 2;
                dienTich = Math.Sqrt(cc * (cc - a) * (cc - b) * (cc - c));
                textChuvi.Text = chuVi.ToString() + " cm";
                textDientich.Text = dienTich.ToString() + " cm2";
            }
            else
            {
                textKiemtra.Text = "Đây không phải là tam giác";
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            texta.Text = " ";
            textb.Text = " ";
            textc.Text = " ";
            textKiemtra.Text = " ";

            label6.Visible = false;
            label7.Visible = false;
            textChuvi.Visible = false;
            textDientich.Visible = false;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn thật sự muốn thoát", "Thông báo", MessageBoxButtons.YesNoCancel);
            Application.Exit();

        }
    }
}
