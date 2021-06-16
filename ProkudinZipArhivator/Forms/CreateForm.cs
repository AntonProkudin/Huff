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
    public partial class CreateForm : Form
    {
        Zip zip = new Zip();
        string nameZip = "null";
        string put = "null";

        public CreateForm()
        {
            InitializeComponent();
            ComponentPro.Licensing.Common.LicenseManager.SetLicenseKey("4D16A969F0F8F1D9E38A0247B79E83AFEDE5B17C8C9CBDC298C2D334EF ");
        }

        private void search(object sender, EventArgs e)
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
            Put.Text = folderName;
        }

        private void Create(object sender, EventArgs e)
        {
            if (!Name.Text.Equals(""))
            {
                nameZip = Name.Text + ".zip";
            }
            if (!Put.Text.Equals(""))
            {
                put = Put.Text;
            }
            if (!nameZip.Equals("null") && !put.Equals("null"))
            {
                archiveCreate();
                zip.Close();
                MessageBox.Show("Архив создан!");
                this.Close();
            }
            else
                MessageBox.Show("Заполните все поля!");
        }
        public void archiveCreate()
        {
            zip.Create(put + @"\" + nameZip);
            zip.AddFiles("ReadMe.txt");
        }

        private void Put_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
