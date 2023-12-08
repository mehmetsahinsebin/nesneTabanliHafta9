using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesneTabanliHafta9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            radioButton1.Checked = false;
        }
        int index = 0;
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Araba car = new Araba(
                textBox1.Text,
                textBox2.Text,
                Convert.ToInt32(textBox3.Text),
                Convert.ToInt32(textBox4.Text),
                false
                );

            sayac++;
            listBox1.Items.Add("araba"+sayac);
            listBox2.Items.Add(car.marka);
            listBox3.Items.Add(car.model);
            listBox4.Items.Add(car.yil);
            listBox5.Items.Add(car.gunlukUcret);
     
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBox1.SelectedIndex;
            listBox2.SelectedIndex = index;
            listBox3.SelectedIndex = index;
            listBox4.SelectedIndex = index;
            listBox5.SelectedIndex = index;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fiyat;
            int toplam;

            fiyat = Convert.ToInt32(listBox5.SelectedItem);
            int gun;
            gun = Convert.ToInt32(textBox5.Text);

            toplam = gun * fiyat;

            label8.Text = toplam.ToString() + " TL";
        }
    }
}
