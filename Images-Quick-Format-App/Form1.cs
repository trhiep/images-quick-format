using Images_Quick_Format_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Images_Quick_Format_App
{
    public partial class Form1 : Form
    {
        List<ImageFile> imageFiles = null;
        int no = 1;

        public Form1()
        {
            InitializeComponent();
            
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.webp;*.tiff";
            openFileDialog.Title = "Select images";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog.FileNames)
                {
                    ImageFile imageFile = new ImageFile();
                    imageFile._no = no;
                    imageFile._imageName = Path.GetFileName(filePath);
                    imageFile._imagePath = Path.GetDirectoryName(filePath) + "\\" +imageFile._imageName;
                    imageFile._imageType = Path.GetExtension(filePath).Substring(1).ToUpper();
                    long fileSizeInBytes = new FileInfo(filePath).Length;
                    long fileSizeInKB = fileSizeInBytes / 1024;
                    imageFile._imageSize = fileSizeInKB.ToString() + " KB";
                    if (imageFiles == null)
                    {
                        imageFiles = new List<ImageFile>
                        {
                            imageFile
                        };
                    }
                    else
                    {
                        imageFiles.Add(imageFile);
                    }
                    no++;
                }
                if (imageFiles.Count > 0)
                {
                    dgvImgList.DataSource = imageFiles.ToList();
                    dgvImgList.Refresh();
                }
            }
        }

        private void newTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
