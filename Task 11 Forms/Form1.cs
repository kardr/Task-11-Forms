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

            public string Match_patter()
            {
                string s = "";
                MatchCollection m = r.Matches(text);
                foreach (Match x in m)
                {
                    s = "Содержит";
                    return s;
                }
                s = "Не содержит";
                return s;
            }

            public string Output_on_display()
            {
                string s = "";
                MatchCollection m = r.Matches(text);
                foreach (Match x in m)
                    s = x.Value;
                return s;
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
                Console.WriteLine(s);
                return s;
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
            string s = "";
            string text = "Мальчик проснулся в 09:00.";
            s += "ТЕКСТ:  " + text + "\n\r";
            string pattern = ("[0-2][0-9]:[0-6][0-9]");
            s += "ШАБЛОН:  " + pattern + "\n\r";
            information.Text = s.ToString();
            Regular myReg = new Regular(pattern, text);
            Console.WriteLine("СОДЕРЖИТ ЛИ ТЕКСТ ФРАГМЕНТЫ, СООТВЕТСТВУЮЩИЕ ШАБЛОНУ ПОЛЯ:");
            t_or_f.Text = myReg.Match_patter().ToString();
            Console.WriteLine("ФРАГМЕНТЫ ТЕКСТА, СООТВЕТСТВУЮЩИЕ ШАБЛОНУ ПОЛЯ:");
            print.Text = myReg.Output_on_display().ToString();
            Console.WriteLine();
            Console.WriteLine("УДАЛЕНИЕ ИЗ ТЕКСТА ФРАГМЕНТОВ, СООТВЕТСТВУЮЩИХ ШАБЛОНУ ПОЛЯ:");
            remore.Text = myReg.Delete().ToString();
            print.Text = myReg.Output_on_display().ToString();
        }
    }
}
