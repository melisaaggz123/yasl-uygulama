using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OYUN.Giriş
{
    public partial class minimentaltest : Form
    {
        public minimentaltest()
        {
            InitializeComponent();
        }

        private void btnbitir_Click(object sender, EventArgs e)
        {
            int[] mevsim;
            if (cmbmevsim.SelectedIndex == 0)
            {
                mevsim = new int[] { 3, 4, 5 };
            }
            else if (cmbmevsim.SelectedIndex == 1)
            {
                mevsim = new int[] { 6, 7, 8 };
            }
            else if (cmbmevsim.SelectedIndex == 2)
            {
                mevsim = new int[] { 9, 10, 11 };
            }
            else
            {
                mevsim = new int[] { 12, 1, 2 };
            }

            int ay = 0;
            ay = cmbay.SelectedIndex;
            string yil = cmbyil.Text;
            int toplampuan = 0;
            if (yil == DateTime.Now.Year.ToString())
            {
                toplampuan = toplampuan + 1;
            }
            if ((ay + 1).ToString() == DateTime.Now.Month.ToString())
            {
                toplampuan = toplampuan + 1;
            }
            if ((cmbayinkaci.Text) == DateTime.Now.Day.ToString())
            {
                toplampuan = toplampuan + 1;
            }
            if (mevsim.Contains(DateTime.Now.Month))
            {
                toplampuan = toplampuan + 1;
            }
            string cevap1 = lblmasa.Text;
            string cevap2 = lblkalem.Text;
            string cevap3 = lblbayrak.Text;
            string[] cevaplar = new string[] { cevap1, cevap2, cevap3 };

            foreach (var secilenler in listsecenek.CheckedItems)
            {
                if (cevaplar.Contains(secilenler) && listsecenek.CheckedItems.Count == 3)
                {
                    toplampuan = toplampuan + 1;
                }
            }
            MessageBox.Show($"Puanınız: {toplampuan}");


        }

        private void btnbasla_Click(object sender, EventArgs e)
        {
            lblbayrak.Visible = true;
            lblkalem.Visible = true;
            lblmasa.Visible = true;
            tmrhatirla.Start();
        }
        private void tmrhatirla_Tick(object sender, EventArgs e)
        {
            // 5 saniye sonra etiketleri gizle
            lblbayrak.Visible = false;
            lblkalem.Visible = false;
            lblmasa.Visible = false;

            // Timer'ı durdur
            tmrhatirla.Stop();
            listsecenek.Visible = true;
            tmrsec.Start();
        }

        private void tmrsec_Tick(object sender, EventArgs e)
        {
            listsecenek.Visible = false;
            tmrsec.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}