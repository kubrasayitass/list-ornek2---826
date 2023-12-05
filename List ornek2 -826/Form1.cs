using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_ornek2__826
{
    public partial class Form1 : Form
    {
        List<string> kisiler = new List<string>();
        int indexSira = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisiler.Add("efe");
            kisiler.Add("kübra");
            kisiler.Add("ömer");
            kisiler.Add("hayrunnisa");
            kisiler.Add("eymen");
            kisiler.Add("sukeyna");
            kisiler.Add("mehmet");

            listBox1.DataSource = kisiler.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kisiler.Add(txtKisi.Text);
             listBox1.DataSource = kisiler.ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(txtKisi.Text);
            if (durum)
            {
                MessageBox.Show("aradığınız kişi mevcut");
            }
            else
            {
                MessageBox.Show("aradığınız kişi mevcut değil");
            }
        }

        private void btnSira_Click(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(txtKisi.Text);
            if(sira > -1)
            {
                MessageBox.Show(txtKisi.Text + " " + sira + " . sırasındadır.");
            }
            else
            {
                MessageBox.Show(txtKisi.Text + " sıralamada yok");
            }
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(txtKisi.Text);
            if(sira > -1)
            {
                kisiler.RemoveAt(sira); // RemoveAt -> belirtilen index sırasındaki değeri siler.
            }

            listBox1.DataSource = kisiler.ToList(); // listBox güncelle.
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(txtKisi.Text);
            if (durum)
            {
                kisiler.Remove(txtKisi.Text); // kişi adı ile silme 
            }

            listBox1.DataSource =kisiler.ToList(); // Listbox güncelle
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKisi.Text = listBox1.SelectedValue.ToString();
            indexSira = listBox1.SelectedIndex;
            //listBox içindeki sırasını veriyor.
           // aynı sıralama list(kişiler) içinde geçerli.
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(indexSira.ToString());
            kisiler[indexSira] = txtKisi.Text;

            listBox1.DataSource = kisiler.ToList(); //listBox güncelle
        }

        private void btnArtan_Click(object sender, EventArgs e)
        {
            kisiler.Sort();

            listBox1.DataSource = kisiler.ToList(); //listBox güncelle
        }

        private void btnazaltan_Click(object sender, EventArgs e)
        {
            kisiler.Sort();
            kisiler.Reverse();

            listBox1.DataSource = kisiler.ToList(); //listBox güncelle
        }

        private void btnOgrenciSayisi_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[1].Length == 5)
                {
                    sayac++;
                }
            }
            MessageBox.Show("5 karakterli :" + sayac + "tane öğrenci mevcut");
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {

        }
    }
}
