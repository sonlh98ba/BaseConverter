using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseConverter
{
    public partial class fBaseConverter : Form
    {

        public string FromNumberFront;
        public string FromNumberBack;
        public fBaseConverter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtFromNumberFront.Text = "";
            txtFromNumberBack.Text = "";
            txtToNumber2.Text = "";
            txtToNumber8.Text = "";
            txtToNumber10.Text = "";
            txtToNumber16.Text = "";
            txtFromNumberFront.Focus();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            FromNumberFront = txtFromNumberFront.Text;
            FromNumberBack = txtFromNumberBack.Text;
            try
            {
                string num2ndfront = "";
                string num2ndback="";
                //Chuyển số ban đầu sang hệ 10

                num2ndfront = Functions.ConvertTo10Front(FromNumberFront, Convert.ToInt32(txtBase.Text));
                num2ndback = Functions.ConvertTo10Back(FromNumberBack, Convert.ToInt32(txtBase.Text));
                //if (rdbBase2.Checked==true) { num2ndfront = Functions.ConvertTo10Front(FromNumberFront, 2); num2ndback = Functions.ConvertTo10Back(FromNumberBack,2); }
                //if (rdbBase8.Checked==true) { num2ndfront = Functions.ConvertTo10Front(FromNumberFront, 8); num2ndback = Functions.ConvertTo10Back(FromNumberBack,8); }
                //if (rdbBase10.Checked==true) { num2ndfront = Functions.ConvertTo10Front(FromNumberFront, 10); num2ndback = Functions.ConvertTo10Back(FromNumberBack,10); }
                //if (rdbBase16.Checked == true) { num2ndfront = Functions.ConvertTo10Front(FromNumberFront, 16); num2ndback = Functions.ConvertTo10Back(FromNumberBack, 16); }
                
                //Sau đó chuyển lại qua các hệ khác
                txtToNumber2.Text = Functions.ConvertFrom10Front(num2ndfront, Convert.ToInt32(txtEnd.Text)) + " , " + Functions.ConvertFrom10Back(num2ndback, Convert.ToInt32(txtEnd.Text));
                //txtToNumber8.Text = Functions.ConvertFrom10Front(num2ndfront, 8) + " , " + Functions.ConvertFrom10Back(num2ndback, 8);
                //txtToNumber10.Text = Functions.ConvertFrom10Front(num2ndfront, 10) + " , " + Functions.ConvertFrom10Back(num2ndback, 10);
                //txtToNumber16.Text = Functions.ConvertFrom10Front(num2ndfront, 16) + " , " + Functions.ConvertFrom10Back(num2ndback, 16);
            }
            catch
            {
                MessageBox.Show("Có lỗi khi chuyển đổi!", "Thông báo!");
            }

            
        }

        private void btn2ndConverter_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2ndConverter f = new f2ndConverter();
            f.ShowDialog();
            this.Show();
            txtFromNumberFront.Focus();
        }


    }
}
