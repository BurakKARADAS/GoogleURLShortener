using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Services;
using Google.Apis.Urlshortener.v1;

namespace GoogleURLShortener
{
    public partial class URLShortener : Form
    {
        public URLShortener()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.karadasburak.com/");
        }
        public string GoogleKisalt(string url)
        {
            UrlshortenerService service = new UrlshortenerService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyAKElkE1tIuqoIPAXL73_AywBAyrSLGF_4",
                ApplicationName = "UrlShortening",
            });

            var m = new Google.Apis.Urlshortener.v1.Data.Url();
            m.LongUrl = url;
            return service.Url.Insert(m).Execute().Id;
        }

        private void btnKisalt_Click(object sender, EventArgs e)
        {
            txtKisaAdres.Text = GoogleKisalt(txtAdres.Text);
        }
    }
}
