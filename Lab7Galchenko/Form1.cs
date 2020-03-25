using Lab7Galchenko.DTO;
using Lab7Galchenko.Services;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Lab7Galchenko
{
    public partial class mainForm : Form
    {
        private readonly ExportService _exportService;
        public mainForm()
        {
            _exportService = new ExportService();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sbmtBtn_Click(object sender, EventArgs e)
        {
            var exportData = new ExportFileDTO {
                FileName = $"{DateTime.Now.Hour}hh-{DateTime.Now.Minute}mm-{DateTime.Now.Second}ss",
                Phone = string.IsNullOrEmpty(this.txtPhone.Text) ? string.Empty : this.txtPhone.Text,
                UserName = string.IsNullOrEmpty(this.txtName.Text) ? string.Empty : this.txtName.Text
            };
            _exportService.ExportToTxtFile(exportData);
            
            MessageBox.Show($"Successfully written! Check your directory project folder.");
            Application.Exit();

        }
    }
}
