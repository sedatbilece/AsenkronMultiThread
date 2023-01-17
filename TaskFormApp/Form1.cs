using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskFormApp
{


    public partial class Form1 : Form
    {
        public int counter { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //string data = ReadFile();
            string data =await ReadFileAsync();
            richTextBox1.Text= data;
        }

        private void BtnCounter_Click(object sender, EventArgs e)
        {

            textBoxCounter.Text = counter++.ToString(); 

        }

        private void textBoxCounter_TextChanged(object sender, EventArgs e)
        {

        }


        private string ReadFile()
        {
            string data = null;
            
            using (StreamReader s = new StreamReader("dosya.txt"))
            {
                Thread.Sleep(3000);
                data =s.ReadToEnd();
            }
            return data;
        }


        private async Task<string> ReadFileAsync()
        {
            string data = null;

            using (StreamReader s = new StreamReader("dosya.txt"))
            {
                 await Task.Delay(3000);
                data = await s.ReadToEndAsync();
            }
            return data;

        }
    }
}
