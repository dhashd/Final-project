using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace primeNumber
{
    public partial class RSA : Form
    {
        public RSA()
        {
            InitializeComponent();
        }
        public int GCD(int a, int b)
        {
            int i, j, gcd = 1;
            j = (a < b) ? a : b;
            for (i = 1; i <= j; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    gcd = i;
                }
            }
            return gcd;
        }

        //Function IsPrime() I get from stackoverflow.com/questions/15743192/check-if-number-is-prime-number
        public static bool IsPrime(int num)
        {
            int ctr = 0;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    ctr++;
                    break;
                }
            }
            if (ctr == 0 && num != 1)
                return true;
            else
                return false;
        
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            int num, i, ctr;
            int eNum = 0;
            int bat_dau = Convert.ToInt32(numericUpDown1.Value);
            int ket_thuc = Convert.ToInt32(numericUpDown2.Value);
            List<int> mangso = new List<int>();
            for (num = 1; num <= 1000; num++)
            {
                ctr = 0;
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                if (ctr == 0 && num != 1)
                {
                    mangso.Add(num);
                }
            }
            int NNum = bat_dau * ket_thuc;
            textBox2.Text = NNum.ToString();
            int phiNum = (bat_dau - 1) * (ket_thuc - 1);
            textBox3.Text = phiNum.ToString();
            //foreach (int so in mangso.Reverse<int>())
            foreach (int so in mangso.Reverse<int>())
            {
                if (GCD(so, phiNum) == 1)
                {
                    eNum = so;
                    textBox1.Text = eNum.ToString();
                    break;
                }
                else
                { }
            }
            double dNum = 0;
            double res = 0;
            for (dNum = 2; ; dNum++)
            {
                res = (dNum * eNum) % phiNum;
                if (res == 1)
                {
                    textBox4.Text = dNum.ToString();
                    break;
                }
            }
            label7.Text = "Pulic key: (" + eNum + "," + NNum + ")";
            label8.Text = "Private key: (" + dNum + "," + NNum + ")";
            //}
            //else
            //{
            // MessageBox.Show("Vui lòng chọn số nguyên tố!");
            //}                        
        }
        List<BigInteger> mang = new List<BigInteger>();
        List<BigInteger> giaima = new List<BigInteger>();
        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            BigInteger number = 0;
            string encrypt = "";

            string s = textBox7.Text;
            int eNum = Convert.ToInt32(textBox1.Text);
            int N = Convert.ToInt32(textBox2.Text);

            foreach (char c in s)
            {
                number = BigInteger.Pow((int)c, eNum) % N;
                //Console.Write("encrypt text: "+(char)number);
                encrypt += (char)number;
                mang.Add(number);

            }
            string mh = "";
            foreach (BigInteger c in mang)
            {
                mh += (char)c;
            }
            textBox5.Text = mh;
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            int dNum = Convert.ToInt32(textBox4.Text);
            int N = Convert.ToInt32(textBox2.Text);
            textBox6.Clear();
            string mh = "";
            BigInteger number1 = 0;
            string decrypt = "";
            foreach (BigInteger c in mang)
            {
                number1 = BigInteger.Pow(c, dNum) % N;
                giaima.Add(number1);
                decrypt += (char)number1;

            }
            foreach (BigInteger a in giaima)
            {
                mh+=(char)a;
            }
            textBox6.Text = mh;           
        }
    }
}
