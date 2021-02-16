using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Proiect_Diploma
{
    public partial class RC4 : Form
    {
        string c, c1;
      
        public RC4()
        {
            InitializeComponent();
        }

        //buton pentru iesire aplicatie
        private void BtnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //buton pentru stergere campuri
        private void BtnStergere_Click(object sender, EventArgs e)
        {
            txtclar.Clear();
            txtcriptat.Clear();
            txtdecriptat.Clear();
        }
        //buton deschidere fisier
        private void monitor1_Click(object sender, EventArgs e)
        {
            txtclar.Clear();
            txtcriptat.Clear();
            txtdecriptat.Clear();
            OpenFileDialog folder = new OpenFileDialog();
            string cale = @"C:\Users\RaZwAn\Desktop\Proiect_diploma_2019";
            folder.InitialDirectory = cale;
            folder.Filter = "Fisiere txt (*.txt)|*.txt|Toate fisierele (*.*)|*.*";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                string text;
                try
                {
                    StreamReader citeste = new StreamReader(folder.FileName);
                    text = citeste.ReadLine();
                    while (text != null)
                    {
                        txtclar.Text += text + "\r\n";
                        text = citeste.ReadLine();
                    }
                    citeste.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Fisierul a fost incarcat cu succes!");
        }
        //buton pentru salvarea fisierelor criptate
        private void BtnSalveazaFisier_Click(object sender, EventArgs e)
        {
            SaveFileDialog folder = new SaveFileDialog();
            string cale = @"C:\Users\RaZwAn\Desktop\Proiect_diploma_2019";
            folder.InitialDirectory = cale;
            folder.Filter = "Fisiere txt (*.txt)|*.txt| Toate fisierele (*.*)|*.*";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter fisier = new StreamWriter(folder.FileName, false);
                    string s = txtcriptat.Text;
                    string[] cuvinte = s.Split(' ');
                    foreach (string cuvant in cuvinte)
                    {
                        fisier.WriteLine(cuvant);
                    }
                    fisier.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //buton pentru generare de chei
        private void BtnGenerareCheie_Click(object sender, EventArgs e)
        {
            Random aleator = new Random();
            int lungime = aleator.Next(5, 16);
            txtcheie.Text = Proiect_Diploma.Clasa_RC4.generareCheie(lungime);
        }
        //buton pentru criptare fisier 
        private void BtnCriptare_Click(object sender, EventArgs e)
        {
            string cale = @"C:\Users\RaZwAn\Desktop\Proiect_diploma_2019";
           //folosit la decriptare
            Proiect_Diploma.Clasa_RC4 rc4 = new Proiect_Diploma.Clasa_RC4(txtcheie.Text, txtclar.Text);
            c = Proiect_Diploma.Clasa_RC4.ConvBininHex(rc4.CriptDecript());
            //folosit pentru criptare
            string textclar = txtclar.Text.Replace(" ", "");
            Proiect_Diploma.Clasa_RC4 rc41 = new Proiect_Diploma.Clasa_RC4(txtcheie.Text, textclar.Replace("\r\n", ""));
            c1 = Proiect_Diploma.Clasa_RC4.ConvBininHex(rc41.CriptDecript());

            //mesaj criptat RC4
            for (int i = 0; i < c1.Length; i++)
            {
               using (StreamWriter fisier = File.AppendText(@"C:\Users\RaZwAn\Desktop\Trupoiu Razvan\Proiect_Diploma_2019\Proiect_Diploma\valCriptate.txt"))
                {
                    if (i % 2 == 0)
                        txtcriptat.AppendText(c1[i].ToString());
                    else
                        txtcriptat.AppendText(c1[i] + " ");
                    fisier.Close();
                }
            }

            rc4.Text = Proiect_Diploma.Clasa_RC4.ConvHexinBin(c);
            MessageBox.Show("Fisierul a fost criptat cu succes!");
        }
        //buton pentru decriptare fisier
        private void BtnDecriptare_Click(object sender, EventArgs e)
        {
            Proiect_Diploma.Clasa_RC4 rc4 = new Proiect_Diploma.Clasa_RC4(txtcheie.Text, txtclar.Text);
            rc4.Text = Proiect_Diploma.Clasa_RC4.ConvHexinBin(c);
            txtdecriptat.Text = rc4.CriptDecript();                              
        }             
        
    }
}
