using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuaySo
{
    public partial class Form1 : Form
    {
        string[] strImage;
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            picBox1.BackgroundImage = Image.FromFile(@"Images/so0.png");
            picBox2.BackgroundImage = Image.FromFile(@"Images/so0.png");
            picBox3.BackgroundImage = Image.FromFile(@"Images/so0.png");
            strImage = new string[]
            {
                "so0.png","so1.png","so2.png","so3.png","so4.png","so5.png","so6.png","so7.png","so8.png","so9.png"
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int milliseconds = 200;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(milliseconds);
                picBox1.BackgroundImage = Image.FromFile(@"Images/" + strImage[i]);
                picBox2.BackgroundImage = Image.FromFile(@"Images/" + strImage[i]);
                picBox3.BackgroundImage = Image.FromFile(@"Images/" + strImage[i]);
            }
        }
    }
}
