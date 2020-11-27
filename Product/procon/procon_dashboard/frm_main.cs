using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace procon_dashboard
{
    public partial class frm_main : Form
    {

        #region Controller
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_ping_Click(object sender, EventArgs e)
        {
            string url = txt_host.Text;
            var task = Ping(txt_host.Text, txt_token.Text);
            btn_ping.Enabled = false;
        }
        private void btn_matches_Click(object sender, EventArgs e)
        {
            string url = txt_host.Text;
            var task = Matches(txt_host.Text, txt_token.Text);
            Console.WriteLine("============================");
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            //1575028493591
            DateTime dd = UnixTimeToDateTime(0);
            Console.WriteLine("gio: "+dd);
            dd = dd.AddSeconds(30);
            Console.WriteLine("gio: " + dd);
        }

       



        private void cb_matchID_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        #endregion

        #region Connect API
        /// <summary>
        /// ping toi server
        /// </summary>
        /// <param name="url">Host</param>
        /// <param name="token">Token</param>
        /// <returns></returns>
        public async Task Ping(string url, string token)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Add("Authorization", txt_token.Text);
                Console.WriteLine("---- Ping -----");
                Console.WriteLine("toekn: "+token);
                var result = await client.GetAsync("ping");
                Console.WriteLine("ket qua server tra ve: " + result);
                MessageBox.Show(result.ReasonPhrase, ""+(int)result.StatusCode, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
       
                //bat nut lay toan bo thong tin truoc tran dau
                btn_matches.Enabled = (int)result.StatusCode == 200;
                btn_ping.Enabled = true;
            }
        }

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddMilliseconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        public async Task Matches(string url, string token)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Add("Authorization", txt_token.Text);
                Console.WriteLine("---- Matches -----");
                Console.WriteLine("toekn: " + token);
                var result = await client.GetAsync("matches");
                //Console.WriteLine("ket qua server tra ve: " + result);
                if (result.IsSuccessStatusCode)
                {
                    string body = await result.Content.ReadAsStringAsync();
                    Console.WriteLine("body: " + body);
                    JArray arr = JArray.Parse(body);
                    foreach (var item in arr)
                    {
                        Console.WriteLine("item: " + item);
                        JObject job = JObject.Parse(item.ToString());
                        frm_map frm_ = new frm_map( txt_token.Text, txt_host.Text, job.ToObject<Matche>());
                        frm_.Show();

                        //listMatches.Add(job.ToObject<Matche>());
                    }


                }
            }
        }
        #endregion

        private void txt_host_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
