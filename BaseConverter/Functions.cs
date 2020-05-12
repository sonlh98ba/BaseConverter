using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConverter
{
    public class Functions
    {



        public static string ConvertTo10Front(string FromNumber, int q)
        {
            string result = "";

            int numresult = 0;

            int n = FromNumber.Length;

            for (int i = 0; i < n;i++ )
            {
                int x=0;
                if (q == 16)
                {
                    if (FromNumber[i].ToString() == "A") x = 10;
                    if (FromNumber[i].ToString() == "B") x = 11;
                    if (FromNumber[i].ToString() == "C") x = 12;
                    if (FromNumber[i].ToString() == "D") x = 13;
                    if (FromNumber[i].ToString() == "E") x = 14;
                    if (FromNumber[i].ToString() == "F") x = 15;
                }
                if (FromNumber[i] >= '0' && FromNumber[i] <='9') x = Convert.ToInt32(FromNumber[i].ToString());
                
                if (x < q) numresult = numresult +  x * LuyThua(q, n - i - 1);
                else
                {
                    return "A";
                }

                if ((FromNumber[i] >= 'A' && FromNumber[i] <= 'F') && (q != 16)) return "A";
                
            }

            result = numresult.ToString();

            return result;
        }

        public static string ConvertFrom10Front(string FromNumber, int q)
        {
            string result = "";
            int num = Convert.ToInt32(FromNumber);
            int r = 1;
            int s = 0;
            while (r != 0)
            {
                r = num / q;
                s = num % q;
                num = r;
                if (s < 10)
                {
                    result = s.ToString() + result;
                }

                if (s == 10)
                {
                    result = "A" + result;
                }

                if (s == 11)
                {
                    result = "B" + result;
                }

                if (s == 12)
                {
                    result = "C" + result;
                }

                if (s == 13)
                {
                    result = "D" + result;
                }

                if (s == 14)
                {
                    result = "E" + result;
                }

                if (s == 15)
                {
                    result = "F" + result;
                }

            }
            return result;
        }


        
        public static int LuyThua(int num, int somu)
        {
            int result = num;

                for (int i = 1; i < somu; i++)
                {
                    result = result * num;
                }

            if (somu == 0) result = 1;

            return result;
        }

        public static double LuyThuaAm(int num, int somu)
        {
            double result = 1;

            for (int i = 0; i > somu; i--)
            {
                result = result / num;
            }

            return result;
        }


        public static string ConvertTo10Back(string FromNumber, int q)
        {
            string result = "";

            double total = 0;

            for (int i = 1; i < FromNumber.Length + 1;i++ )
            {
                double x = 0;
                if (q == 16)
                {
                    if (FromNumber[i-1].ToString() == "A") x = 10;
                    if (FromNumber[i-1].ToString() == "B") x = 11;
                    if (FromNumber[i-1].ToString() == "C") x = 12;
                    if (FromNumber[i-1].ToString() == "D") x = 13;
                    if (FromNumber[i-1].ToString() == "E") x = 14;
                    if (FromNumber[i-1].ToString() == "F") x = 15;
                }
                if (FromNumber[i-1] >= '0' && FromNumber[i-1] <= '9') x = Convert.ToDouble(FromNumber[i-1].ToString());

                if (x < q) total = total + x * LuyThuaAm(q, -i);
                else
                    return "A";
                if ((FromNumber[i-1] >= 'A' && FromNumber[i-1] <= 'F') && (q != 16)) return "A";
            }

            result = total.ToString();
            return result;
        }

        public static string ConvertFrom10Back(string FromNumber, int q)
        {
            string result = "";
            double num = Convert.ToDouble(FromNumber);
            int r = 0;
            double s=1;
            while (s!=0)
            {
                r = (int)(num * q);
                s = (num * q) - r;
                num = s;

                if (r < 10)
                {
                    result = result + r.ToString();
                }

                if (r == 10)
                {
                    result = result + "A";
                }

                if (r == 11)
                {
                    result = result + "B";
                }

                if (r == 12)
                {
                    result = result + "C";
                }

                if (r == 13)
                {
                    result = result + "D";
                }

                if (r == 14)
                {
                    result = result + "E";
                }

                if (r == 15)
                {
                    result = result + "F";
                }
                
            }

            return result;
        }
        
    }
}
