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
    public partial class f2ndConverter : Form
    {
        public f2ndConverter()
        {
            InitializeComponent();
        }

        public string From10;
        public string To2;
        public string From32;
        public int slength;

        private void btnConvert10to2_Click(object sender, EventArgs e)
        {
            try
            {
                From10 = int.Parse(txt10.Text).ToString();
                string medial = Functions.ConvertFrom10Front(From10, 2).ToString(); // Biến trung gian
                
                for (int i = 0; i * 8 < medial.Length; i++) slength = (i + 1) * 8; // Độ dài cần thiết cho số nhị phân

                for (int i = medial.Length; i < slength; i++) medial = "0" + medial;
                
                string result = "";

                // Lấy số bù 1 (Đảo ngược số nhị phân)
                for (int i = 0; i < medial.Length; i++)
                {
                    if (medial[i] == '1') result = result + "0";
                    else result = result + "1";
                }
                
                // Lấy số bù 2 (thêm 1)
                result = (Convert.ToInt32(Functions.ConvertTo10Front(result, 2)) + 1).ToString();
                result = Functions.ConvertFrom10Front(result, 2);

                // Tách 4 kí tự thành một nhóm (cho dễ nhìn và kiểm tra)
                medial = result;
                result = "";
                                
                for (int i = 0; i < medial.Length; i++)
                {
                    if (i % 4 == 0) result = result + " " + medial[i];
                    else result = result + medial[i];
                }
                result = result.Substring(1);
                
                txt2.Text = result;
            }
            catch
            {
                MessageBox.Show("Có lỗi!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            From32 = txtFrom32.Text;
            int count = 0;
            double result = 0;
            int muresult = 0; 
            string m = From32.Substring(9);
            string mu = From32.Substring(1,8);

            // Kiểm tra vi phạm cơ số


            for (int i = 0; i < From32.Length;i++ )
            {
                if (From32[i]!='1' && From32[i]!='0')
                {
                    MessageBox.Show("Chưa đúng định dạng!");
                    txtFrom32.Clear();
                    txtFrom32.Focus();
                    return;
                }

                count = count + 1;
            }

            // Kiếm tra đủ 32 số


            if (count!=32)
            {
                MessageBox.Show("Chưa đúng định dạng!");
                txtFrom32.Clear();
                txtFrom32.Focus();
                return;
            }

            // Kiểm tra quy ước đặc biệt


            if (From32 == "00000000000000000000000000000000" || From32 == "10000000000000000000000000000000")
            {
                txtResult.Text = "0";
                return;
            }

            if (m == "00000000000000000000000" && mu == "11111111")
            {
                txtResult.Text = "Vô cực";
                return;
            }

            if (m != "00000000000000000000000" && mu == "11111111")
            {
                txtResult.Text = "Not a Number - NaN";
                return;
            }


            // Bắt đầu xử lý

            result = 1 + Convert.ToDouble(Functions.ConvertTo10Back(m, 2));
            muresult = Convert.ToInt32(Functions.ConvertTo10Front(mu, 2)) - 127;
            if (muresult > 0)
            {
                muresult = Functions.LuyThua(2, muresult);
                result = result * muresult;
            }

            else
            {
                double muresult2 = Functions.LuyThuaAm(2, muresult);
                result = result * muresult2;
            }

            if (From32[0] == '1') result = result * -1;
            txtResult.Text = result.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void f2ndConverter_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void f2ndConverter_Load(object sender, EventArgs e)
        {

        }
    }
}
