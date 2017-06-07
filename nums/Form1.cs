using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace nums
{
    public partial class Form1 : Form
    {

        public class Num
        {
            public string text { get; set; }

            public int number { get; set; }

            public bool found { get; set; }

            public string type { get; set; }

            public string year { get; set; }

            public string date { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var str = "http://numbersapi.com/" + textBox1.Text + "/" + comboBox1.SelectedItem + "?json";
                var json = new WebClient().DownloadString(str);
                var num1 = JsonConvert.DeserializeObject<Num>(json);
                label1.Text = "Fact: " + num1.text;
                
            }
            catch 
            {
                label1.Text = "Wrong input format!";
            }
        }
    }
}
