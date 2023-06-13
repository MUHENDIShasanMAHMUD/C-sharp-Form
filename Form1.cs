using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şehirler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                if (GidilenSehirlerListBox.SelectedItems.Count > 0)
                {
                    foreach (var item in GidilenSehirlerListBox.SelectedItems)
                    {
                        SehirlerListBox.Items.Add(item);
                    }

                    for (int i = GidilenSehirlerListBox.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        GidilenSehirlerListBox.Items.Remove(GidilenSehirlerListBox.SelectedItems[i]);
                    }
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SehirlerListBox.SelectedItems.Count > 0)
            {
                foreach (var item in SehirlerListBox.SelectedItems)
                {
                    GidilenSehirlerListBox.Items.Add(item);
                }

                for (int i = SehirlerListBox.SelectedItems.Count - 1; i >= 0; i--)
                {
                    SehirlerListBox.Items.Remove(SehirlerListBox.SelectedItems[i]);
                }
            }
        }

        private void SolaAktarButton_Click(object sender, EventArgs e)
        {
            if (GidilenSehirlerListBox.SelectedItems.Count > 0)
            {
                foreach (var item in GidilenSehirlerListBox.SelectedItems)
                {
                    SehirlerListBox.Items.Add(item);
                }

                for (int i = GidilenSehirlerListBox.SelectedItems.Count - 1; i >= 0; i--)
                {
                    GidilenSehirlerListBox.Items.Remove(GidilenSehirlerListBox.SelectedItems[i]);
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
      
                string arananSehir = ArananSehirTextBox.Text;

                // Şehirler ListBox'ında arama yap
                if (SehirlerListBox.Items.Contains(arananSehir))
                {
                    SehirlerListBox.SelectedItem = arananSehir;
                }

                // Gidilen Şehirler ListBox'ında arama yap
                if (GidilenSehirlerListBox.Items.Contains(arananSehir))
                {
                    GidilenSehirlerListBox.SelectedItem = arananSehir;
                }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
           
                string silinecekSehir = SilinecekSehirTextBox.Text;

                // Şehirler ListBox'ında silme işlemi
                if (SehirlerListBox.Items.Contains(silinecekSehir))
                {
                    SehirlerListBox.Items.Remove(silinecekSehir);
                }

                // Gidilen Şehirler ListBox'ında silme işlemi
                if (GidilenSehirlerListBox.Items.Contains(silinecekSehir))
                {
                    GidilenSehirlerListBox.Items.Remove(silinecekSehir);
                }
            

        }

        private void btn3_Click(object sender, EventArgs e)
        {
             string sehir = EklenecekSehirTextBox.Text;

                if (sehir != "")
                {
                    if (sehirlerRadioButton.Checked)
                    {
                        SehirlerListBox.Items.Add(sehir);
                    }
                    else if (gidilenSehirlerRadioButton.Checked)
                    {
                        GidilenSehirlerListBox.Items.Add(sehir);
                    }

                    EklenecekSehirTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Lütfen bir şehir giriniz.");
                }
         

        }

        private void GidilenSehirlerList_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
