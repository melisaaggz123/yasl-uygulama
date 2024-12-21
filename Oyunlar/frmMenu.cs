using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OYUN  
{
    public partial class frmMenu : Form
    {

        int size;           
        string path = "";   
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)   
        {
            {
                OpenFileDialog filePathDialog = new OpenFileDialog();   
                filePathDialog.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff" +
                "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|";        
                filePathDialog.Title = "Resim Seç";       
                if (filePathDialog.ShowDialog() == DialogResult.OK)   
                {
                    try     
                    {
                        path = filePathDialog.FileName;     
                        pic1.Image = Image.FromFile(path);  
                    }
                    catch (Exception)   //Hvis dette ikke går:
                    {
                        MessageBox.Show("Resim Yüklenirken Hata Oluştu");    
                        throw;
                        
                    }
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)    
        {
            size = Convert.ToInt32(numSize.Text);       
            int size0 = size - 1;                      
            Point missingPiece;                         

            switch (cmbMissing.Text)                    
            {
                case "Ortada":
                    missingPiece = new Point(size0 / 2, size0 / 2);
                    break;
                case "Sağ Alt":
                    missingPiece = new Point(size0, size0);
                    break;
                case "Sol Alt":
                    missingPiece = new Point(0, size0);
                    break;
                case "Sağ Üst":
                    missingPiece = new Point(size0, 0);
                    break;
                case "Sol Üst":
                default:
                    missingPiece = new Point(0, 0);
                    break;
            }
            frmGame frmgame = new frmGame(size, missingPiece, path);      
            frmgame.ShowDialog();                                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
