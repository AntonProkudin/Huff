using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentPro.Compression;
using ComponentPro.IO;
using ComponentPro;

namespace ProkudinZipArhivator
{
    public partial class UnpackingForm : Form
    {
        Huffman huffman = new Huffman();
        Zip zip = new Zip();

        public UnpackingForm()
        {
            InitializeComponent();
            ComponentPro.Licensing.Common.LicenseManager.SetLicenseKey("4D16A969F0F8F1D9E38A0247B79E83AFEDE5B17C8C9CBDC298C2D334EF ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "zip files (*.zip)|*.zip|All files (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = dialog.FileName;
                Put1.Text = filename;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = folderBrowserDialog1.ShowDialog();
            //Надпись выше окна контрола
            folderBrowserDialog1.Description = "Поиск папки";
            string folderName = "";
            if (dialogresult == DialogResult.OK)
            {
                //Извлечение имени папки
                folderName = folderBrowserDialog1.SelectedPath;
            }
            textBox1.Text = folderName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Put1.Text.Contains(".zip"))
            {
                if (!textBox1.Text.Equals(""))
                {
                    zip.Open(@Put1.Text);

                    ArchiveItemCollection col = (ArchiveItemCollection)zip.ListDirectory(new NameSearchCondition(""));
                    List<string> name = new List<string>();
                    foreach (ArchiveItem archiveFile in col)
                    {
                        name.Add(archiveFile.Name);
                    }
                    foreach (string nameNext in name)
                    {
                        zip.ExtractFiles(nameNext, textBox1.Text);
                        System.IO.FileInfo file = new System.IO.FileInfo(textBox1.Text + @"\" + nameNext);
                        long size = file.Length;
                        if (size > 256)
                        {
                            huffman.DecompressFile(textBox1.Text + "\\" + nameNext, textBox1.Text + "\\" + nameNext);
                            string s = textBox1.Text + "\\" + nameNext;
                            System.IO.File.Move(s, s.Remove(s.Length - 4));
                            System.IO.File.Delete(textBox1.Text + @"\" + nameNext);
                        }
                    }
                    zip.Close();
                    MessageBox.Show("Архив раскрыт!");
                }
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void Put1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
