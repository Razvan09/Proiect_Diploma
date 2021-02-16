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
    public partial class AES : Form
    {
        public AES()
        {
            InitializeComponent();
        }
        //buton de generare a cheii
        private void BtnGenereazaCheie_Click(object sender, EventArgs e)
        {
            Proiect_Diploma.Clasa_AES.setKey();
            Proiect_Diploma.Clasa_AES.setIV();
            txtcheie.Text = Clasa_AES.GenerareCheie(32);           
        }       
        //buton pentru incarcare fisier
        private void BtnDeschideFisier_Click(object sender, EventArgs e)
        {
            txtclar.Clear();       
            txtcriptat.Clear();
            txtdecripteaza.Clear();
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
        }
        //buton salvare fisier criptat
        private void BtnSalvareFisier_Click(object sender, EventArgs e)
        {
            SaveFileDialog folder = new SaveFileDialog();
            string cale = @"C:\Users\RaZwAn\Desktop\Proiect_diploma_2019";
            folder.InitialDirectory = cale;
            folder.Filter = "Fisiere txt (*.txt)|*.txt";
            //Toate fisierele (*.*)|*.*";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter fisier = new StreamWriter(folder.FileName, false);
                    fisier.WriteLine(txtcriptat.Text);
                    fisier.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //buton pentru criptare
        private void BtnCripteaza_Click(object sender, EventArgs e)
        {
            txtcriptat.Text = Proiect_Diploma.Clasa_AES.Criptare(txtclar.Text);
        }
        //buton pentru decriptare
        private void BtnDecripteaza_Click(object sender, EventArgs e)
        {
            txtdecripteaza.Text = Proiect_Diploma.Clasa_AES.Decriptare(txtcriptat.Text);
        }
        //buton pentru stergere campuri
        private void BtnSterge_Click(object sender, EventArgs e)
        {
            txtcriptat.Clear();
            txtclar.Clear();
            txtdecripteaza.Clear();
        }
        //buton pentru iesire din aplicatie
        private void BtnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
