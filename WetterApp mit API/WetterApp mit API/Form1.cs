using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WetterApp_mit_API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 80; // Setzt das Intervall auf 100 Millisekunden
            timer.Tick += (s, args) => {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1); // Entfernt das letzte Zeichen
                }
                else
                {
                    timer.Stop(); // Stoppt den Timer, wenn der gesamte Text entfernt wurde
                }
            };
            timer.Start(); // Startet den Timer
        }
    }
}
