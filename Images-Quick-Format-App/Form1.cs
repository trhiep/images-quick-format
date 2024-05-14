using ImageMagick;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                    lblProgress.Text = "0 / " + imageFiles.Count + " Done";
                }
            }
        }

        private void newTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            if (imageFiles != null)
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileExtension = ".png";
                        if (cbxExportFormat.SelectedIndex == 1)
                        {
                            fileExtension = ".jpg";
                        }

                        disableFormContent();
                        prbSuccessBar.Minimum = 0;
                        prbSuccessBar.Maximum = imageFiles.Count;
                        prbSuccessBar.Value = 0;
                        int succeed = 0;
                        int failed = 0;
                        int count = 1;

                        await Task.Run(() =>
                        {
                            foreach (ImageFile image in imageFiles)
                            {
                                if (File.Exists(image._imagePath))
                                {
                                    using (MagickImage magickImage = new MagickImage(image._imagePath))
                                    {
                                        string filePath = folderBrowserDialog.SelectedPath + "\\" + Path.GetFileNameWithoutExtension(image._imagePath) + fileExtension;
                                        magickImage.Write(filePath);
                                        succeed++;
                                    }
                                }
                                else
                                {
                                    failed++;
                                }

                                // Cập nhật UI từ luồng giao diện người dùng
                                Invoke(new Action(() =>
                                {
                                    prbSuccessBar.Value += 1;
                                    lblProgress.Text = count + " / " + imageFiles.Count + " Done";
                                }));

                                count++;
                            }
                        });
                        enableFormContent();
                        MessageBox.Show("Saved images into " + folderBrowserDialog.SelectedPath + " successfully!\r\n" +
                                        "Succeed: " + succeed + ".\r\n" +
                                        "Failed: " + failed + ".\r\n");
                    }
                }
            } else
            {
                MessageBox.Show("Empty");
            }
           
        }

        private void disableFormContent()
        {
            btnImport.Enabled = false;
            btnExport.Enabled = false;
            cbxExportFormat.Enabled = false;
            cbxExportFormat.SelectedIndex = cbxExportFormat.SelectedIndex;
            dgvImgList.Enabled = false;
            mnsMainApp.Enabled = false;
        }

        private void enableFormContent()
        {
            btnImport.Enabled = true;
            btnExport.Enabled = true;
            cbxExportFormat.Enabled = true;
            cbxExportFormat.SelectedIndex = cbxExportFormat.SelectedIndex;
            dgvImgList.Enabled = true;
            mnsMainApp.Enabled = true;
        }
    }
}
