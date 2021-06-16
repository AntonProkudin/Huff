using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentPro;
using ComponentPro.Compression;
using ComponentPro.IO;

namespace ProkudinZipArhivator
{
    public partial class ArchForm : Form
    {
        Zip zip = new Zip();
        Huffman huffman = new Huffman();

        public ArchForm()
        {
            InitializeComponent();
            ComponentPro.Licensing.Common.LicenseManager.SetLicenseKey("4D16A969F0F8F1D9E38A0247B79E83AFEDE5B17C8C9CBDC298C2D334EF ");
        }

        private void Search1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "zip files (*.zip)|*.zip|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = dialog.FileName;
            Put1.Text = filename;
        }
        private void Search2(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //   dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = dialog.FileName;
            Put2.Text = filename;
        }

        private void Add(object sender, EventArgs e)
        {
            if (Put1.Text.Contains(".zip"))
            {
                if (!Put2.Text.Equals(""))
                {
                        string nameT = System.IO.Path.GetFileName(Put2.Text);
                        zip.Open(@Put1.Text);
                        System.IO.FileInfo file = new System.IO.FileInfo(@Put2.Text);
                        long size = file.Length;
                        if (size > 256)
                        {
                            huffman.CompressFile(@Put2.Text, nameT + ".huf");
                            zip.AddFiles(nameT + ".huf");
                            System.IO.File.Delete(nameT + ".huf");
                        }
                        else
                        {
                            zip.AddFiles(@Put2.Text);
                            MessageBox.Show("Внимание, название файла не поменялось, т.к файл не был сжат перед архивированием!");
                        }

                        zip.Close();
                    MessageBox.Show("Файл добавлен!");
                }
            }
            else
                MessageBox.Show("Заполните все поля!");
        }

        private void Put1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Put2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
