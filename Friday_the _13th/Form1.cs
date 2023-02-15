using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Friday_the__13th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DateTime Friday = new DateTime(Convert.ToInt32(textBox1.Text), 1, 13);
            List<string> md = new List<string>();
            for (int i = 0; i <= 12; i++)
            {
                Friday = Friday.AddMonths(1);
                string s1 = Friday.ToString("d dddd");
                Regex regex = new Regex(@"13 пят(\w*)");
                MatchCollection matches = regex.Matches(s1);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        md.Add(Friday.ToString("d MMMM"));
                    }
                }
            }
            
            foreach (var sussy in md) 
            {
                listBox1.Items.Add(sussy);//Вывод дат в листбокс
            }

        }
    
    }
}
