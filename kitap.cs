using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OYUN
{
    public partial class kitap : Form
    {
        public kitap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\melis\Downloads\_Ay Işığı Sokağı_ Stefan Zweig sesli kitap tek parça Akın ALTAN.wav";
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\melis\Downloads\_İnsan ne ile yaşar_ bölüm_ _insan ne ile yaşar_ Tolstoy sesli kitap okuyan Akın ALTAN.wav";
            player.Play();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
