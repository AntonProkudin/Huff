using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ComponentPro;
using ComponentPro.Compression;
using ComponentPro.IO;
using System.IO.Compression;
namespace ProkudinZipArhivator
{
    public partial class MainForm : Form
    {
        Zip zip = new Zip();

        CreateForm f2;
        ArchForm f3;
        UnpackingForm f5;

        string filePath = "C:\\Users\\anton\\OneDrive\\Рабочий стол";
        private bool isFile = false;
        private string currentlySelectedItemName = "";

        public MainForm()
        {
            InitializeComponent();
            ComponentPro.Licensing.Common.LicenseManager.SetLicenseKey("4D16A969F0F8F1D9E38A0247B79E83AFEDE5B17C8C9CBDC298C2D334EF ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Create(object sender, EventArgs e)
        {
            f2 = new CreateForm();
            f2.ShowDialog();
        }

        private void Add(object sender, EventArgs e)
        {
            f3 = new ArchForm();
            f3.ShowDialog();
        }

        private void unpacking(object sender, EventArgs e)
        {
            f5 = new UnpackingForm();
            f5.ShowDialog();
        }
    }
}
