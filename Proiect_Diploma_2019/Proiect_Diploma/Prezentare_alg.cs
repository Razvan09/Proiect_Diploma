using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proiect_Diploma
{
    public partial class Prezentare_alg : Form
    {
        
        public Prezentare_alg()
        {
            InitializeComponent();
        }     

        private void aes1_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            aes.Show();
        }

        private void rc41_Click(object sender, EventArgs e)
        {
            RC4 rc4 = new RC4();
            rc4.Show();
        }

        private void BtnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInfoRC4_Click(object sender, EventArgs e)
        {
            RC4_Info rc4inf = new RC4_Info();
            rc4inf.Show();
             
        }

        private void BtnInfoAES_Click(object sender, EventArgs e)
        {
            AES_Info aesinf = new AES_Info();
            aesinf.Show();
             
        }
    }
}
