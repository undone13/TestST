using System;
using System.Globalization;
using System.Threading;
using System.Diagnostics;
using Microsoft.Win32;
using System.Net;
using Newtonsoft.Json;
using System.Data;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Text;

namespace TestST
{
    
    public partial class Form1 : Form
    {
        List<Universitate> jsonData;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //DATE PERSONALE----------------------------------------------------------------    

            string date = Properties.Resources.date_personale;
            string[] linii = date.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            Label nume_prenume = new Label()
            {
                Text = linii[0] + " " + linii[1],
                Location = new Point(10, 10),
                Size = new Size(100, 20) 
            };
            Label nr_telefon = new Label()
            {
                Text = linii[2],
                Location = new Point(10, 30),
                Size = new Size(100, 20)
            };
            tab_date.Controls.Add(nume_prenume);
            tab_date.Controls.Add(nr_telefon);

        }


        //SCHIMBARE ORA---------------------------------------------------------------------
        RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart req = new ThreadStart(Thread);
            Thread reqThread = new Thread(req);
            reqThread.Start();
            SchimbareOra("h:mm tt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThreadStart req = new ThreadStart(Thread);
            Thread reqThread = new Thread(req);
            reqThread.Start();
            SchimbareOra("h:mm");
        }

        public void SchimbareOra(string format)
        {
            regKey.SetValue("sShortTime", format);
            var winExp = Process.GetProcessesByName("explorer");
            foreach (var exp in winExp)
            {
                exp.Kill();
            }
        }
        public void Thread()
        {
            Label lbl = new Label();
            lbl.Location = new Point(180, 10);
            lbl.Text = System.DateTime.Now.ToString(regKey.GetValue("sShortTime").ToString());

            this.Invoke(new MethodInvoker(delegate ()
            {
                tab_ora.Controls.Add(lbl);
            }
            ));
        }

        //----------------------------------------------------------------------------------//

        
        //UNIVERSITATI----------------------------------------------------------------------
        public void ThreadUniversitati()
        {
            var client = new HttpClient();
            var ep = new Uri("http://universities.hipolabs.com/search?name=middle");
            var res = client.GetAsync(ep).Result;
            var JSON = res.Content.ReadAsStringAsync().Result;
            jsonData = JsonConvert.DeserializeObject<List<Universitate>>(JSON);

            if(res != null)
            {
                var dist = 0; var limit = 500;
                foreach (var item in jsonData)
                {
                    Label lb1 = new Label(); 
                    lb1.Text = item.name;
                    lb1.Location = new Point(10, dist + 10);
                    lb1.AutoSize = true;
                    lb1.Click += (s, e) => {
                        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                        {
                            string url = item.web_pages[0];
                            url = url.Replace("&", "^&");
                            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                        }
                    };

                    Label lb2 = new Label();
                    lb2.Text = item.country;
                    lb2.Location = new Point(10, dist + 30);
                    lb2.AutoSize = true;

                    Label lb3 = new Label();
                    lb3.Text = item.alpha_two_code;
                    lb3.Location = new Point(10, dist + 50);
                    lb3.AutoSize = true;

                    dist += 80;
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        tab_univ.Controls.Add(lb1); tab_univ.Controls.Add(lb2); tab_univ.Controls.Add(lb3);
                    }
                    ));
                }
            }
            
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.Visible = false;
            tab_univ.AutoScroll = true;
            ThreadStart req = new ThreadStart(ThreadUniversitati);
            Thread reqThread = new Thread(req);
            reqThread.Start();

        }

        //-----------------------------------------------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            if(jsonData != null)
            {
                string fileName = @"C:\Users\bogda\source\repos\TestST\TestST\bin\Debug\net6.0-windows\date_universitati.txt";
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    foreach (var item in jsonData)
                    {
                            sw.WriteLine(item.name + "\t" + item.country + "\t" + item.alpha_two_code + "\t" + item.web_pages[0]);
                    }
                }
                

            }
            else
            {
                MessageBox.Show("Nu exista date");
            }
        }



    }


    //CLASE-----------------------------------------------------------------------------
    public class Universitate
    {
        public string[] web_pages { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string alpha_two_code { get; set; }
    }

    
}