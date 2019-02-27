using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPlatformRestClientInC
{
    public partial class AnaEkran : Form
    {
        #region FIELDS
        string HOST;
        string PORT;
        string USER_NAME;
        string PASSWORD;
        string CLIENT_TOKEN;
        string FIRM_NO;
        string LANGUAGE;
        string AUTH_TOKEN;
        #endregion

        #region SWAGGER UI
        public string URL { get; private set; }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Unable to open link that was clicked." + URL);
            }
        }

        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            URL = "http://" + hostEntry.Text + ":" + portEntry.Text + "/logo/restdocs/";
            System.Diagnostics.Process.Start(URL);
        }
        #endregion

        #region CONSTRUCTOR
        public AnaEkran()
        {
            InitializeComponent();
        }
        #endregion

        #region AUTH TOKEN & ENCODING
        public string GetAuthTokenFromResponseAreaOfMainWindow(string response)
        {
            string[] bolunmusJson = response.Split('"');

            response = bolunmusJson[7];

            return response;
        }

        public string getEncodedAuthToken()
        {
            string CLIENT_TOKEN_EN = InformationsOfServerDTO.ClientToken;
            string AUTH_TOKEN_EN = InformationsOfServerDTO.AuthToken;
            string USERNAME = InformationsOfServerDTO.UserName;

            string temp = CLIENT_TOKEN_EN + ":" + AUTH_TOKEN_EN + ":" + USERNAME;

            string returnValue = System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(temp));

            return returnValue;
        }
        #endregion

        #region LOGIN, LOGOUT & EXIT
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginRequestButton_Click(object sender, EventArgs e)
        {
            HOST = hostEntry.Text.Trim();
            PORT = portEntry.Text.Trim();
            USER_NAME = userEntry.Text.Trim();
            PASSWORD = passwordEntry.Text.Trim();
            CLIENT_TOKEN = clientTokenEntry.Text.Trim();
            FIRM_NO = firmEntry.Text.Trim();
            LANGUAGE = languageEntry.Text.Trim();

            string HEADER = USER_NAME + ":" + PASSWORD + ":" + CLIENT_TOKEN + ":" + FIRM_NO + ":" + LANGUAGE;

            string basicAuth = "Basic " + System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(HEADER));

            try
            {
                HttpWebRequest webrequest = (HttpWebRequest)System.Net.WebRequest.Create("http://" + HOST + ":" + PORT + "/logo/restservices/rest/login");
                webrequest.Method = "POST";
                webrequest.Accept = "application/json";
                webrequest.ContentType = "application/json";
                webrequest.Headers.Add("Authorization", basicAuth);

                var response = (HttpWebResponse)webrequest.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                responseArea.Text = JsonHelper.FormatJson(responseString);
                statusCodeArea.Text = Convert.ToString(response.StatusCode);
            }
            catch (Exception er)
            {
                responseArea.Text = er.Message;
                statusCodeArea.Text = "Error!";
            }

            if (statusCodeArea.Text == "OK")
            {
                AUTH_TOKEN = GetAuthTokenFromResponseAreaOfMainWindow(responseArea.Text);

                InformationsOfServerDTO.Host = HOST;
                InformationsOfServerDTO.Port = PORT;
                InformationsOfServerDTO.UserName = USER_NAME;
                InformationsOfServerDTO.Password = PASSWORD;
                InformationsOfServerDTO.ClientToken = CLIENT_TOKEN;
                InformationsOfServerDTO.FirmNo = FIRM_NO;
                InformationsOfServerDTO.Language = LANGUAGE;
                InformationsOfServerDTO.AuthToken = AUTH_TOKEN;

                TumIslemlerPencere.CreateInstance().Show();
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            if (statusCodeArea.Text == "OK")
            {
                string urlPathForRequest = "http://" + HOST + ":" + PORT + "/logo/restservices/rest/logout";

                WebRequest webrequest = WebRequest.Create(urlPathForRequest);
                webrequest.Method = "POST";
                webrequest.ContentType = "application/json";
                webrequest.Headers.Add("auth-token", getEncodedAuthToken());

                try
                {
                    var response = (HttpWebResponse)webrequest.GetResponse();

                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                    responseArea.Text = JsonHelper.FormatJson(responseString);
                    statusCodeArea.Text = Convert.ToString(response.StatusCode);
                    TumIslemlerPencere.CreateInstance().Hide();
                }
                catch (Exception err)
                {
                    responseArea.Text = err.Message;
                    statusCodeArea.Text = "Error!";
                }
            }
            else
            {
                MessageBox.Show("LOGOUT olmadan önce LOGIN olmanız gerekir :)");
            }
        }
        #endregion

        #region OVERRIDE METHODS
        //default form kapatma işleminin override hali
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Programdan çıkış yapmak istediğinize emin misiniz?", "KAPAT", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
