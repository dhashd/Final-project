using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeNumber
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RSA rSA = new RSA();
            rSA.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PlayFair playfairForm = new PlayFair();
            playfairForm.Show();
        }
    }
}
