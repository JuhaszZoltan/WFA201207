using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA201207
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Random rnd = new Random();

        private void GombraKattintas(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "QTYA!")
            {
                (sender as Button).Text = "MATKA!";
            }
            else (sender as Button).Text = "QTYA!";


            var szinek = new Color[] { Color.Green, Color.Aqua, Color.Silver };


            (sender as Button).BackColor = szinek[rnd.Next(szinek.Length)];

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                (sender as Button).Font = new Font("Times New Roman", 20);
            }
            else if (e.Button == MouseButtons.Middle)
            {
                (sender as Button).Font = new Font("Comic Sans MS", 20);
            }
        }
    }
}
