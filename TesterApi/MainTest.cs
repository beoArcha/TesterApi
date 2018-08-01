using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TesterApi
{
    public partial class ApiTestApp : Form
    {
        private bool logged;
        private long userId;
        private long choosenService = 0;
        private long ordersUser;
        private long count;
        private string token;
        private string connectionAdress;
        private string cookie;
        private string[] listOfServices = { "b2b", "space" };

        public ApiTestApp()
        {
            InitializeComponent();
            b2bRadioButton.Checked = true;
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string authString = loginBox.Text + ":" + passBox.Text;
            authString = encodeBase64(authString);
            string service = listOfServices[choosenService];
            string adress = adressBox.Text + ":" + portNumericUpDown.Value.ToString();
            string response;
            logged = loginToService(service, adress, authString, out response);
            if (logged)
            {
                deserializeResponse(response, out userId, out token, choosenService);
                workingPanel.Visible = true;
                typeGroupBox.Enabled = false;
                connectionAdress = adress + "/" + service + "?";
            }
            else
            {
                workingPanel.Visible = false;
                typeGroupBox.Enabled = true;
                MessageBox.Show("Error");
            }
        }

        private void testingButton_Click(object sender, EventArgs e)
        {
            bool result;
            string service = listOfServices[choosenService];
            string adress = adressBox.Text + ":" + portNumericUpDown.Value.ToString();
            if (loginBox.Text != "" && passBox.Text != "")
            {
                string authString = loginBox.Text + ":" + passBox.Text;
                authString = encodeBase64(authString);
                result = testService(service, adress, authString);
            }
            else
            {
                result = testService(service, adress);
            }
            if (result)
                MessageBox.Show("connection established");
            else
                MessageBox.Show("no connection");
        }

        private static string encodeBase64(string entry)
        {
            byte[] base64 = Encoding.UTF8.GetBytes(entry);
            string encodedString = Convert.ToBase64String(base64);
            return encodedString;
        }

        private static bool loginToService(string serv, string adr, string auth, out string responseFromServer)
        {
            try
            {
                HttpWebRequest request;
                request = (HttpWebRequest)WebRequest.Create(adr + "/" + serv + "?login");
                request.Credentials = CredentialCache.DefaultCredentials;
                request.Headers["Authorization"] = auth;
                responseFromServer = InternetQuestion(request);
                return true;
            }
            catch
            {
                responseFromServer = "";
                return false;
            }
        }

        private static bool testService(string serv, string adr, string auth = "")
        {
            try
            {
                HttpWebRequest request;
                request = (HttpWebRequest)WebRequest.Create(adr + "/" + serv + "?test");
                request.Credentials = CredentialCache.DefaultCredentials;
                if (auth != "")
                    request.Headers["Authorization"] = auth;
                string responseFromServer = InternetQuestion(request);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static void deserializeResponse(string response, out long user, out string tokk, long type = 0)
        {
            switch (type)
            {
                case 0:
                    LoginB2BJSON lbj = JsonConvert.DeserializeObject<LoginB2BJSON>(response);
                    user = lbj.b2b_user;
                    tokk = lbj.Token;
                    break;

                case 1:
                    LoginSpaceJSON lsj = JsonConvert.DeserializeObject<LoginSpaceJSON>(response);
                    user = lsj.User;
                    tokk = lsj.Token;
                    break;

                default:
                    user = 0;
                    tokk = "";
                    break;
            }
        }

        private void typeGroupBox_RegionChanged(object sender, EventArgs e)
        {
            if (b2bRadioButton.Checked)
                choosenService = 0;
            else if (spaceRadioButton.Checked)
                choosenService = 1;
        }

        private void getOrderButton_Click(object sender, EventArgs e)
        {
            cookie = generatorCookie(userId, token);
            string sucess = "";
            ordersUser = (int)ordersNumericUpDown.Value;
            long iter = (int)getOrderNumericUpDown.Value;
            string it = String.Format("New querry {0}", iter);            
            timeListView.Items.Add(it);
            timeListView.Items[timeListView.Items.Count -1].ForeColor = Color.Red;
            for (int counter = 1; counter <= iter; counter++)
            {
                DateTime thDT = DateTime.Now;
                count = counter;
                try
                {
                    Thread t = new Thread(new ParameterizedThreadStart(Execute));
                    t.Name = count.ToString();
                    t.Start(counter);
                    sucess = "sucessful";
                }
                catch (Exception ex)
                {
                    sucess = "not sucessful " + ex.Message;
                }
                finally
                {
                    it = String.Format("{0} Thread {1} {2}", thDT, count, sucess);                    
                    timeListView.Items.Add(it);
                    timeListView.Items[timeListView.Items.Count -1].ForeColor = Color.Black;
                }
            }
        }

        private string generatorCookie(long user, string tok)
        {
            string resoult;
            resoult = String.Format("\"User\"={0};\"Token\"=\"{1}\";", user, tok);
            resoult = encodeBase64(resoult);
            return resoult;
        }

        public void Execute(object data)
        {
           
            long counting = (int)data;
            string score = "";
            string uri = String.Format("{0},\"\",\"\",{1},-1,-1,-1,1", ordersUser, counting);
            long comp = counting % 3;
            if (comp == 0)
                Thread.Sleep(2000);
            DateTime begDT = DateTime.Now;
            Stopwatch elapsedTime = new Stopwatch();
            try
            {
                string responseFromServer;
                uri = Uri.EscapeDataString(uri);
                elapsedTime = Stopwatch.StartNew();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(connectionAdress + "get_orders=" + uri);
                request.Credentials = CredentialCache.DefaultCredentials;
                request.Headers["Cookie"] = cookie;                
                responseFromServer = InternetQuestion(request);
                score = "sucessful";
            }
            catch
            {
                score = "not sucessful";
            }
            finally
            {
                DateTime endDT = DateTime.Now;
                elapsedTime.Stop();
                string it = String.Format("{0} - {1} Connection number {2} is {3} in time {4} ms, uri {5}", begDT, endDT, data, score, elapsedTime.ElapsedMilliseconds.ToString(), uri);
                timeListView.Invoke((MethodInvoker)delegate
                {
                    timeListView.Items.Add(it);
                    timeListView.Items[timeListView.Items.Count - 1].ForeColor = Color.BlueViolet;                    
                });
            }
        }

        private void timeListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private static string InternetQuestion(HttpWebRequest req)
        {
            HttpWebResponse response = (HttpWebResponse)req.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream, Encoding.UTF8);
            // Read the content.
            return reader.ReadToEnd();
        }
    }

    public class LoginB2BJSON
    {
        public string token_type { get; set; }
        public string Token { get; set; }
        public int b2b_user { get; set; }
        public int b2b_kontrahent { get; set; }
        public int b2b_payer { get; set; }
    }

    public class LoginSpaceJSON
    {
        public string Tokentype { get; set; }
        public string Token { get; set; }
        public int User { get; set; }
        public int Type { get; set; }
        public int Idworker { get; set; }
        public int Idsalesman { get; set; }
        public int Idgraffiti { get; set; }
        public int Idcompany { get; set; }
        public int Idpayer { get; set; }
    }
  
}
