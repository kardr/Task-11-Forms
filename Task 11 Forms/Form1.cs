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

namespace Task_11_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Regular
        {

            public Regular(string pattern, string txt)
            {
                r = new Regex(pattern);
                text = txt;
            }
            private Regex r;
            private string text;

            public bool Match_patter()
            {
                MatchCollection m = r.Matches(text);
                foreach (Match x in m)
                {
                    return true;
                }
                return false;
            }

            public string Output_on_display()
            {
                string s = "";
                MatchCollection m = r.Matches(text);
                foreach (Match x in m)
                    s += "\n\r" + x.Value+ "\n\r";
                return s ;
            }

            public string Delete()
            {
                MatchCollection m = r.Matches(text);
                string s = text;
                foreach (Match x in m)
                {
                    int i = s.IndexOf(x.Value);
                    int l = x.Value.Length;
                    s = s.Remove(i, l);
                }
                return  s;
            }

            public Regex R
            {
                get { return r; }
                set { r = value; }
            }
            public string Text
            {
                get { return text; }
                set { text = value; }
            }

        }

        private void Botton_Click(object sender, EventArgs e)
        {
            string text = "Мальчик проснулся в 11:50, а должен был проснуться в 09:00.";
            textBox1.Text += text;
            string pattern = ("[0-2][0-9]:[0-6][0-9]");
            textBox2.Text += pattern;
            Regular myReg = new Regular(pattern, text);
            if (myReg.Match_patter())
            {
                textBox3.Text += "Содержит";
            }
            else
            {
                textBox3.Text +=  "Не содержит";
            }
            textBox4.Text += myReg.Output_on_display();
            textBox5.Text += myReg.Text = myReg.Delete();
            textBox5.Text += myReg.Output_on_display();
        }
    }
}
