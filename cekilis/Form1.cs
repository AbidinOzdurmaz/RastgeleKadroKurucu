using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cekilis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rtxt_Oynayacaklar_TextChanged(object sender, EventArgs e)
        {
            lbl_Katılımcı_Sayısı.Text = rtxt_Oynayacaklar.Lines.Count().ToString(); //Lines.Count() methodu satırları sayıyor
            if (rtxt_Oynayacaklar.Lines.Count() > 0)
            {
                n_Miktar.Maximum = rtxt_Oynayacaklar.Lines.Count();
            }
            else
            {
                n_Miktar.Minimum = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtg_Kadro1.ColumnCount = 1;
            dtg_Kadro1.Columns[0].Name = "Kadro 1";

            dtg_Kadro2.ColumnCount = 1;
            dtg_Kadro2.Columns[0].Name = "Kadro 2";

        }

        private void dtg_Kadro1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Kadro_Click(object sender, EventArgs e)
        {
           
            int Katılimci_Sayisi=Convert.ToInt32(n_Miktar.Text);
            List<String> ListKatilimcilar = new List<String>(rtxt_Oynayacaklar.Text.Split('\n'));


            if (rtxt_Oynayacaklar.Text=="")
            {
                MessageBox.Show("Oynayacakları Girmelisiniz");
            }
            else
            {
                dtg_Kadro1.Rows.Clear();
                dtg_Kadro2.Rows.Clear();

                Random Uret = new Random();
                for (int i = 0; i < Katılimci_Sayisi/2; i++)
                {
                    
                    int kadro1 = Uret.Next(0, ListKatilimcilar.Count);
                    dtg_Kadro1.Rows.Add(ListKatilimcilar[kadro1]);
                    ListKatilimcilar.Remove(ListKatilimcilar[kadro1]);

                    int kadro2 = Uret.Next(0, ListKatilimcilar.Count);
                    dtg_Kadro2.Rows.Add(ListKatilimcilar[kadro2]);
                    ListKatilimcilar.Remove(ListKatilimcilar[kadro2]);


                }
            }
        }

        private void dtg_Kadro2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void n_Miktar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            rtxt_Oynayacaklar.Clear();
            dtg_Kadro1.Rows.Clear();
            dtg_Kadro2.Rows.Clear();
            n_Miktar.Value=1;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
