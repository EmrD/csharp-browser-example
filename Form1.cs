using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void git_button_Click(object sender, EventArgs e)
        {
            var url = url_input.Text;

            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                webBrowser1.Navigate(new Uri(url));
            }
            else if (!url.StartsWith("http://")|| !url.StartsWith("https://"))
            {
                url = "https://" + url_input.Text;
                var result = MessageBox.Show("URL Tamamlandı: " + url.ToString() + ". Bu URL'ye yönlendirilmek istiyor musunuz?", "Otomatik Tamamlama Hizmeti", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    webBrowser1.Navigate(new Uri(url));
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
        }



        private void url_input_TextChanged(object sender, EventArgs e)
        {}

        private void geri_button_Click(object sender, EventArgs e)
        {
            try 
            { 
                webBrowser1.GoBack();
            }
            catch 
            {
                return;    
            }
        }

        private void ileri_button_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
    }
}