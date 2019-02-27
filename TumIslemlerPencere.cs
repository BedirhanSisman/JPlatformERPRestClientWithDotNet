using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPlatformRestClientInC
{
    public partial class TumIslemlerPencere : Form
    {
        #region SINGLETON
        private static TumIslemlerPencere instance = null;

        private TumIslemlerPencere()
        {
            InitializeComponent();
            componentleriDoldur();
        }

        public static TumIslemlerPencere CreateInstance()
        {
            if(instance == null)
            {
                instance = new TumIslemlerPencere();
            }

            return instance;
        }
        #endregion

        #region COMMON FUNCTIONS
        private void EXITButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("REST Client'ı kapatmak istediğinize emin misiniz?", "KAPAT", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                instance = null;
                this.Dispose();
            }
        }

        #region Clear PlaceHolders
        private void FONKOrderSlipRef_Enter(object sender, EventArgs e)
        {
            FONKOrderSlipRef.Clear();
            FONKOrderSlipRef.ForeColor = Color.Black;
        }

        private void FONKVoucherTypeRef_Enter(object sender, EventArgs e)
        {
            FONKVoucherTypeRef.Clear();
            FONKVoucherTypeRef.ForeColor = Color.Black;
        }

        private void FONKDispatchType_Enter(object sender, EventArgs e)
        {
            FONKDispatchType.Clear();
            FONKDispatchType.ForeColor = Color.Black;
        }
        #endregion

        #region Create PlaceHolders
        private void FONKOrderSlipRef_Leave(object sender, EventArgs e)
        {
            if(FONKOrderSlipRef.Text == "")
            {
                FONKOrderSlipRef.ForeColor = Color.Gray;
                FONKOrderSlipRef.Text = "orderSlipRef";
            }
        }

        private void FONKVoucherTypeRef_Leave(object sender, EventArgs e)
        {
            if (FONKVoucherTypeRef.Text == "")
            {
                FONKVoucherTypeRef.ForeColor = Color.Gray;
                FONKVoucherTypeRef.Text = "voucherTypeRef";
            }
        }

        private void FONKDispatchType_Leave(object sender, EventArgs e)
        {
            if (FONKDispatchType.Text == "")
            {
                FONKDispatchType.ForeColor = Color.Gray;
                FONKDispatchType.Text = "dispatchType";
            }
        }
        #endregion

        public void componentleriDoldur()
        {
            GETClientToken.Text = InformationsOfServerDTO.ClientToken;
            GETAuthToken.Text = InformationsOfServerDTO.AuthToken;
            GETUsername.Text = InformationsOfServerDTO.UserName;
            GETBaseURI.Text = getBaseURIOfAllRequests();

            POSTClientToken.Text = InformationsOfServerDTO.ClientToken;
            POSTAuthToken.Text = InformationsOfServerDTO.AuthToken;
            POSTUsername.Text = InformationsOfServerDTO.UserName;
            POSTBaseURI.Text = getBaseURIOfAllRequests();

            PUTClientToken.Text = InformationsOfServerDTO.ClientToken;
            PUTAuthToken.Text = InformationsOfServerDTO.AuthToken;
            PUTUsername.Text = InformationsOfServerDTO.UserName;
            PUTBaseURI.Text = getBaseURIOfAllRequests();

            PATCHClientToken.Text = InformationsOfServerDTO.ClientToken;
            PATCHAuthToken.Text = InformationsOfServerDTO.AuthToken;
            PATCHUsername.Text = InformationsOfServerDTO.UserName;
            PATCHBaseURI.Text = getBaseURIOfAllRequests();

            DELETEClientToken.Text = InformationsOfServerDTO.ClientToken;
            DELETEAuthToken.Text = InformationsOfServerDTO.AuthToken;
            DELETEUsername.Text = InformationsOfServerDTO.UserName;
            DELETEBaseURI.Text = getBaseURIOfAllRequests();

            FONKClientToken.Text = InformationsOfServerDTO.ClientToken;
            FONKAuthToken.Text = InformationsOfServerDTO.AuthToken;
            FONKUserName.Text = InformationsOfServerDTO.UserName;
            FonkBaseURI.Text = "http://" + InformationsOfServerDTO.Host + ":" + InformationsOfServerDTO.Port + "/logo/restservices/rest/order/doorderdispatch";

            STATEClientToken.Text = InformationsOfServerDTO.ClientToken;
            STATEAuthToken.Text = InformationsOfServerDTO.AuthToken;
            STATEUsername.Text = InformationsOfServerDTO.UserName;
            STATEBaseURI.Text = "http://" + InformationsOfServerDTO.Host + ":" + InformationsOfServerDTO.Port + "/logo/restservices/rest/dostatechange";

            SQLClientToken.Text = InformationsOfServerDTO.ClientToken;
            SQLAuthToken.Text = InformationsOfServerDTO.AuthToken;
            SQLUsername.Text = InformationsOfServerDTO.UserName;
            SQLBaseURI.Text = "http://" + InformationsOfServerDTO.Host + ":" + InformationsOfServerDTO.Port + "/logo/restservices/rest/dataQuery/executeSelectQuery";

            #region TextBox PlaceHolders
            //FONKOrderSlipRef
            FONKOrderSlipRef.ForeColor = Color.Gray;
            FONKOrderSlipRef.Text = "orderSlipRef";
            //FONKDispatchType
            FONKDispatchType.ForeColor = Color.Gray;
            FONKDispatchType.Text = "dispatchType";
            //FONKVoucherTypeRef
            FONKVoucherTypeRef.ForeColor = Color.Gray;
            FONKVoucherTypeRef.Text = "voucherTypeRef";
            #endregion
        }

        public string getBaseURIOfAllRequests()
        {
            return "http://" + InformationsOfServerDTO.Host + ":" + InformationsOfServerDTO.Port + "/logo/restservices/rest/v1.0/";
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
        
        private void TumIslemlerPencere_Activated(object sender, EventArgs e)
        {
            componentleriDoldur();
        }

        //default form kapatma işlemini override ediyorum
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            instance = null;

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "REST Client'ı kapatmak istediğinize emin misiniz?", "KAPAT", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region GET
        private void GETRequestButton_Click(object sender, EventArgs e)
        {
            GETResponseArea.Text = "";
            GETStatusCodeArea.Text = "";
            sendGETRequest();
        }
        
        public void sendGETRequest()
        {
            string urlPathForRequest = getBaseURIOfAllRequests();
            urlPathForRequest = urlPathForRequest + GETExtURI.Text.Trim();

            WebRequest webrequest = WebRequest.Create(urlPathForRequest);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/json";      
            webrequest.Headers.Add("auth-token", getEncodedAuthToken());

            try
            {
                var response = (HttpWebResponse)webrequest.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                GETResponseArea.Text = JsonHelper.FormatJson(responseString);
                GETStatusCodeArea.Text = Convert.ToString(response.StatusCode);
            }
            catch (Exception e)
            {
                GETResponseArea.Text = e.Message;
                GETStatusCodeArea.Text = "Error!";
            }
        }
        #endregion

        #region POST
        private void sendPostRequestButton_Click(object sender, EventArgs e)
        {
            POSTResponseArea.Text = "";
            POSTStatusCodeArea.Text = "";
            sendPOSTRequest();
        }

        public void sendPOSTRequest()
        {
            string urlPathForRequest = getBaseURIOfAllRequests();
            urlPathForRequest = urlPathForRequest + POSTExURI.Text.Trim();

            var postData = Encoding.ASCII.GetBytes(POSTRequestBodyEntry.Text);

            WebRequest webrequest = WebRequest.Create(urlPathForRequest);
            webrequest.Method = "POST";
            webrequest.ContentType = "application/json";
            webrequest.Headers.Add("auth-token", getEncodedAuthToken());

            try
            {
                using (var stream = webrequest.GetRequestStream())
                {
                    stream.Write(postData, 0, postData.Length);
                }

                var response = (HttpWebResponse)webrequest.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                POSTResponseArea.Text = JsonHelper.FormatJson(responseString);
                POSTStatusCodeArea.Text = Convert.ToString(response.StatusCode);
            }
            catch (Exception e)
            {
                POSTResponseArea.Text = e.Message;
                POSTStatusCodeArea.Text = "Error!";
            }

        }
        #endregion

        #region PUT
        private void SendPutRequestButton_Click(object sender, EventArgs e)
        {
            PUTResponseArea.Text = "";
            PUTStatusCode.Text = "";
            sendPUTRequest();
        }

        public void sendPUTRequest()
        {
            string urlPathForRequest = getBaseURIOfAllRequests();
            urlPathForRequest = urlPathForRequest + PUTExURI.Text.Trim() + "/" + PUTIDURI.Text.Trim();

            var postData = Encoding.ASCII.GetBytes(PUTRequestBody.Text);

            WebRequest webrequest = WebRequest.Create(urlPathForRequest);
            webrequest.Method = "PUT";
            webrequest.ContentType = "application/json";
            webrequest.Headers.Add("auth-token", getEncodedAuthToken());

            try
            {
                using (var stream = webrequest.GetRequestStream())
                {
                    stream.Write(postData, 0, postData.Length);
                }

                var response = (HttpWebResponse)webrequest.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                PUTResponseArea.Text = JsonHelper.FormatJson(responseString);
                PUTStatusCode.Text = Convert.ToString(response.StatusCode);
            }
            catch (Exception e)
            {
                PUTResponseArea.Text = e.Message;
                PUTStatusCode.Text = "Error!";
            }
        }
        #endregion

        #region PATCH
        private void SendPatchRequestButton_Click(object sender, EventArgs e)
        {
            PATCHResponseArea.Text = "";
            PATCHStatusCodeArea.Text = "";
            sendPATCHRequest();
        }

        public void sendPATCHRequest()
        {
            string urlPathForRequest = getBaseURIOfAllRequests();
            urlPathForRequest = urlPathForRequest + PATCHExURI.Text.Trim() + "/patch/" + PATCHIDURI.Text.Trim();

            var postData = Encoding.ASCII.GetBytes(PATCHRequestBodyArea.Text);

            //açıklamalar
            WebRequest webrequest = WebRequest.Create(urlPathForRequest);
            webrequest.Method = "PUT";
            webrequest.ContentType = "application/json";
            webrequest.Headers.Add("auth-token", getEncodedAuthToken());

            try
            {
                using (var stream = webrequest.GetRequestStream())
                {
                    stream.Write(postData, 0, postData.Length);
                }

                var response = (HttpWebResponse)webrequest.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                PATCHResponseArea.Text = JsonHelper.FormatJson(responseString);
                PATCHStatusCodeArea.Text = Convert.ToString(response.StatusCode);
            }
            catch (Exception e)
            {
                PATCHResponseArea.Text = e.Message;
                PATCHStatusCodeArea.Text = "Error!";
            }
        }
        #endregion

        #region DELETE
        private void sendDeleteRequestButton_Click(object sender, EventArgs e)
        {
            DELETEResponseArea.Text = "";
            DELETEStatusCodeArea.Text = "";
            sendDELETERequest();
        }

        public void sendDELETERequest()
        {
            string urlPathForRequest = getBaseURIOfAllRequests();
            urlPathForRequest = urlPathForRequest + DELETEExURI.Text.Trim() + "/" + DELETEIDURI.Text.Trim();

            WebRequest webrequest = WebRequest.Create(urlPathForRequest);
            webrequest.Method = "DELETE";
            webrequest.ContentType = "application/json";
            webrequest.Headers.Add("auth-token", getEncodedAuthToken());

            try
            {
                var response = (HttpWebResponse)webrequest.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                DELETEResponseArea.Text = JsonHelper.FormatJson(responseString);
                DELETEStatusCodeArea.Text = Convert.ToString(response.StatusCode);

                if(DELETEStatusCodeArea.Text == "NoContent")
                {
                    DELETEResponseArea.Text = DELETEIDURI.Text.Trim() + " ID'li kart " + DELETEExURI.Text.Trim() + " browser'ından silinmiştir.";
                }
            }
            catch (Exception e)
            {
                DELETEResponseArea.Text = e.Message;
                DELETEStatusCodeArea.Text = "Error!";
            }
        }
        #endregion

        #region ORNEK FONKSIYON 1
        private void sendFONKRequestButton_Click(object sender, EventArgs e)
        {
            FONKSonURLArea.Text = "";
            FONKResponseArea.Text = "";
            FONKStatusCodeArea.Text = "";
            siparisSevket();
        }

        public void siparisSevket()
        {
            string urlPathForRequest = "http://" + InformationsOfServerDTO.Host + ":" + InformationsOfServerDTO.Port + "/logo/restservices/rest/order/doorderdispatch?orderSlipRef=" + FONKOrderSlipRef.Text.Trim() + "&dispatchType=" + FONKDispatchType.Text.Trim() + "&voucherTypeRef=" + FONKVoucherTypeRef.Text.Trim();

            WebRequest webrequest = WebRequest.Create(urlPathForRequest);
            webrequest.Method = "PUT";
            webrequest.ContentType = "application/json";
            webrequest.Headers.Add("auth-token", getEncodedAuthToken());

            try
            {
                var response = (HttpWebResponse)webrequest.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                FONKResponseArea.Text = JsonHelper.FormatJson(responseString);
                FONKStatusCodeArea.Text = Convert.ToString(response.StatusCode);
                FONKSonURLArea.Text = urlPathForRequest;
            }
            catch (Exception e)
            {
                FONKResponseArea.Text = e.Message;
                FONKStatusCodeArea.Text = "Error!";
                FONKSonURLArea.Text = urlPathForRequest;
            }
        }
        #endregion

        #region ORNEK FONKSIYON 2
        private void STATEChangeButton_Click(object sender, EventArgs e)
        {
            STATEEndURL.Text = "";
            STATEResponseCodeArea.Text = "";
            STATEStatusCodeArea.Text = "";
            durumunuDegistir();
        }

        public void durumunuDegistir()
        {
            string urlPathForRequest = "http://" + InformationsOfServerDTO.Host + ":" + InformationsOfServerDTO.Port + "/logo/restservices/rest/dostatechange";

            var postData = Encoding.ASCII.GetBytes(STATERequestBody.Text);

            //açıklamalar
            WebRequest webrequest = WebRequest.Create(urlPathForRequest);
            webrequest.Method = "PUT";
            webrequest.ContentType = "application/json";
            webrequest.Headers.Add("auth-token", getEncodedAuthToken());

            try
            {
                using (var stream = webrequest.GetRequestStream())
                {
                    stream.Write(postData, 0, postData.Length);
                }

                var response = (HttpWebResponse)webrequest.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                STATEResponseCodeArea.Text = JsonHelper.FormatJson(responseString);
                STATEStatusCodeArea.Text = Convert.ToString(response.StatusCode);
                STATEEndURL.Text = urlPathForRequest;
            }
            catch (Exception e)
            {
                STATEResponseCodeArea.Text = e.Message;
                STATEStatusCodeArea.Text = "Error!";
                STATEEndURL.Text = urlPathForRequest;
            }
        }
        #endregion

        #region SQL Sorgusu
        private void sendSQLRequestButton_Click(object sender, EventArgs e)
        {
            SQLEndURL.Text = "";
            SQLResponseArea.Text = "";
            SQLStatusCodeArea.Text = "";
            sendSQLNativeQueryRequest();
        }

        public void sendSQLNativeQueryRequest()
        {
            string urlPathForRequest = "http://" + InformationsOfServerDTO.Host + ":" + InformationsOfServerDTO.Port + "/logo/restservices/rest/dataQuery/executeSelectQuery";

            string RequestBodyForNativeQuery = "{\r\n" +
            "  \"jsonFormat\": " + SQLJsonFormat.Text.Trim() + ",\r\n" +
            "  \"querySqlText\": \"" + SQLNativeQuery.Text.Trim() + "\",\r\n" +
            "  \"maxCount\": " + SQLMaxCount.Text.Trim() + "\r\n" +
            "}";

            var postData = Encoding.ASCII.GetBytes(RequestBodyForNativeQuery);

            //açıklamalar
            WebRequest webrequest = WebRequest.Create(urlPathForRequest);
            webrequest.Method = "POST";
            webrequest.ContentType = "application/json";
            webrequest.Headers.Add("auth-token", getEncodedAuthToken());

            try
            {
                using (var stream = webrequest.GetRequestStream())
                {
                    stream.Write(postData, 0, postData.Length);
                }

                var response = (HttpWebResponse)webrequest.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                SQLResponseArea.Text = JsonHelper.FormatJson(responseString);
                SQLStatusCodeArea.Text = Convert.ToString(response.StatusCode);
                SQLEndURL.Text = urlPathForRequest;
            }
            catch (Exception e)
            {
                SQLResponseArea.Text = e.Message;
                SQLStatusCodeArea.Text = "Error!";
                SQLEndURL.Text = urlPathForRequest;
            }
        }
        #endregion


    }
}
