using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PYKE
{

    public partial class Form2 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
     (
         int nLeftRect,     // x-coordinate of upper-left corner
         int nTopRect,      // y-coordinate of upper-left corner
         int nRightRect,    // x-coordinate of lower-right corner
         int nBottomRect,   // y-coordinate of lower-right corner
         int nWidthEllipse, // height of ellipse
         int nHeightEllipse // width of ellipse
     );
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        int q;
        int g;
        int count = 0;
        int flag = 0;


        private void Form2_Load(object sender, EventArgs e)
        {
            Random ran = new Random();
            dynamic y = ran.Next(10);//Max range
            g = y;
            string guesscard = y.ToString();

        }

        private void circuleButton1_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (q > g)
            {

                if (g == 0)
                {
                    g = 1;
                }
                if (g == 1)
                {
                    pictureBox6.Visible = true;

                    if (flag == 0)
                    {
                        pictureBox36.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox37.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox38.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox39.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox40.Visible = true;

                    }
                }
                if (g != 1)
                {
                    pictureBox6.Visible = false;
                }
                if (g == 2)
                {
                    pictureBox7.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox41.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox42.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox43.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox44.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox45.Visible = true;

                    }
                }
                if (g != 2)
                {
                    pictureBox7.Visible = false;
                }
                if (g == 3)
                {
                    pictureBox8.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox46.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox47.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox48.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox49.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox50.Visible = true;

                    }
                }
                if (g != 3)
                {
                    pictureBox8.Visible = false;
                }
                if (g == 4)
                {
                    pictureBox9.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox51.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox52.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox53.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox54.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox55.Visible = true;

                    }
                }
                if (g != 4)
                {
                    pictureBox9.Visible = false;
                }
                if (g == 5)
                {
                    pictureBox10.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox56.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox57.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox58.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox59.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox60.Visible = true;

                    }
                }
                if (g != 5)
                {
                    pictureBox10.Visible = false;
                }
                if (g == 6)
                {
                    pictureBox11.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox61.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox62.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox63.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox64.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox65.Visible = true;

                    }
                }
                if (g != 6)
                {
                    pictureBox11.Visible = false;
                }
                if (g == 7)
                {
                    pictureBox12.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox66.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox67.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox68.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox69.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox70.Visible = true;

                    }
                }
                if (g != 7)
                {
                    pictureBox12.Visible = false;
                }
                if (g == 8)
                {
                    pictureBox14.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox71.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox72.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox73.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox74.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox75.Visible = true;

                    }
                }
                if (g != 8)
                {
                    pictureBox14.Visible = false;
                }
                if (g == 9)
                {
                    pictureBox15.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox76.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox77.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox78.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox79.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox80.Visible = true;

                    }
                }
                if (g != 9)
                {
                    pictureBox15.Visible = false;
                }
                if (g == 10)
                {
                    pictureBox16.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox81.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox82.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox83.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox84.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox85.Visible = true;

                    }
                }
                if (g != 10)
                {
                    pictureBox16.Visible = false;
                }
                if (g == 11)
                {
                    pictureBox17.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox86.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox87.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox88.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox89.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox90.Visible = true;

                    }
                }
                if (g != 11)
                {
                    pictureBox17.Visible = false;
                }
                if (g == 12)
                {
                    pictureBox18.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox91.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox92.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox93.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox94.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox95.Visible = true;

                    }
                }
                if (g != 12)
                {
                    pictureBox18.Visible = false;
                }
                if (g == 13)
                {
                    pictureBox19.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox96.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox97.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox98.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox99.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox100.Visible = true;

                    }
                }
                if (g != 13)
                {
                    pictureBox19.Visible = false;
                }
                Form3 f3 = new Form3();
                f3.ShowDialog();
                flag++;
                if(flag==5)
                {
                    flag = 0;
                    pictureBox36.Visible = false;
                    pictureBox37.Visible = false;
                    pictureBox38.Visible = false;
                    pictureBox39.Visible = false;
                    pictureBox40.Visible = false;
                    pictureBox41.Visible = false;
                    pictureBox42.Visible = false;
                    pictureBox43.Visible = false;
                    pictureBox44.Visible = false;
                    pictureBox45.Visible = false;
                    pictureBox46.Visible = false;
                    pictureBox47.Visible = false;
                    pictureBox48.Visible = false;
                    pictureBox49.Visible = false;
                    pictureBox50.Visible = false;
                    pictureBox51.Visible = false;
                    pictureBox52.Visible = false;
                    pictureBox53.Visible = false;
                    pictureBox54.Visible = false;
                    pictureBox55.Visible = false;
                    pictureBox56.Visible = false;
                    pictureBox57.Visible = false;
                    pictureBox58.Visible = false;
                    pictureBox59.Visible = false;
                    pictureBox60.Visible = false;
                    pictureBox61.Visible = false;
                    pictureBox62.Visible = false;
                    pictureBox63.Visible = false;
                    pictureBox64.Visible = false;
                    pictureBox65.Visible = false;
                    pictureBox66.Visible = false;
                    pictureBox67.Visible = false;
                    pictureBox68.Visible = false;
                    pictureBox69.Visible = false;
                    pictureBox70.Visible = false;
                    pictureBox71.Visible = false;
                    pictureBox72.Visible = false;
                    pictureBox73.Visible = false;
                    pictureBox74.Visible = false;
                    pictureBox75.Visible = false;
                    pictureBox76.Visible = false;
                    pictureBox77.Visible = false;
                    pictureBox78.Visible = false;
                    pictureBox79.Visible = false;
                    pictureBox80.Visible = false;
                    pictureBox81.Visible = false;
                    pictureBox82.Visible = false;
                    pictureBox83.Visible = false;
                    pictureBox84.Visible = false;
                    pictureBox85.Visible = false;
                    pictureBox86.Visible = false;
                    pictureBox87.Visible = false;
                    pictureBox88.Visible = false;
                    pictureBox89.Visible = false;
                    pictureBox90.Visible = false;
                    pictureBox91.Visible = false;
                    pictureBox92.Visible = false;
                    pictureBox93.Visible = false;
                    pictureBox94.Visible = false;
                    pictureBox95.Visible = false;
                    pictureBox96.Visible = false;
                    pictureBox97.Visible = false;
                    pictureBox98.Visible = false;
                    pictureBox99.Visible = false;
                    pictureBox100.Visible = false;
                }
                count++;
                label6.Text = count.ToString();
                pictureBox3.Visible = false;
                pictureBox13.Visible = false;
                pictureBox4.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                Random ran = new Random();
                dynamic y = ran.Next(13);//Max range
                g = y;

                pictureBox6.Visible = false;

                pictureBox7.Visible = false;

                pictureBox8.Visible = false;

                pictureBox9.Visible = false;

                pictureBox10.Visible = false;

                pictureBox11.Visible = false;

                pictureBox12.Visible = false;

                pictureBox14.Visible = false;

                pictureBox15.Visible = false;

                pictureBox16.Visible = false;

                pictureBox17.Visible = false;

                pictureBox18.Visible = false;

                pictureBox19.Visible = false;

                string guesscard = y.ToString();

            }
            else
            {

                if (g == 0)
                {
                    g = 1;
                }
                if (g == 1)
                {
                    pictureBox6.Visible = true;
                }
                if (g != 1)
                {
                    pictureBox6.Visible = false;
                }
                if (g == 2)
                {
                    pictureBox7.Visible = true;
                }
                if (g != 2)
                {
                    pictureBox7.Visible = false;
                }
                if (g == 3)
                {
                    pictureBox8.Visible = true;
                }
                if (g != 3)
                {
                    pictureBox8.Visible = false;
                }
                if (g == 4)
                {
                    pictureBox9.Visible = true;
                }
                if (g != 4)
                {
                    pictureBox9.Visible = false;
                }
                if (g == 5)
                {
                    pictureBox10.Visible = true;
                }
                if (g != 5)
                {
                    pictureBox10.Visible = false;
                }
                if (g == 6)
                {
                    pictureBox11.Visible = true;
                }
                if (g != 6)
                {
                    pictureBox11.Visible = false;
                }
                if (g == 7)
                {
                    pictureBox12.Visible = true;
                }
                if (g != 7)
                {
                    pictureBox12.Visible = false;
                }
                if (g == 8)
                {
                    pictureBox14.Visible = true;
                }
                if (g != 8)
                {
                    pictureBox14.Visible = false;
                }
                if (g == 9)
                {
                    pictureBox15.Visible = true;
                }
                if (g != 9)
                {
                    pictureBox15.Visible = false;
                }
                if (g == 10)
                {
                    pictureBox16.Visible = true;
                }
                if (g != 10)
                {
                    pictureBox16.Visible = false;
                }
                if (g == 11)
                {
                    pictureBox17.Visible = true;
                }
                if (g != 11)
                {
                    pictureBox17.Visible = false;
                }
                if (g == 12)
                {
                    pictureBox18.Visible = true;
                }
                if (g != 12)
                {
                    pictureBox18.Visible = false;
                }
                if (g == 13)
                {
                    pictureBox19.Visible = true;
                }
                if (g != 13)
                {
                    pictureBox19.Visible = false;
                }
                Form4 f4 = new Form4();
                f4.ShowDialog();
                pictureBox3.Visible = false;
                pictureBox13.Visible = false;
                pictureBox4.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                Random ran = new Random();
                dynamic y = ran.Next(13);//Max range
                g = y;

                pictureBox6.Visible = false;

                pictureBox7.Visible = false;

                pictureBox8.Visible = false;

                pictureBox9.Visible = false;

                pictureBox10.Visible = false;

                pictureBox11.Visible = false;

                pictureBox12.Visible = false;

                pictureBox14.Visible = false;

                pictureBox15.Visible = false;

                pictureBox16.Visible = false;

                pictureBox17.Visible = false;

                pictureBox18.Visible = false;

                pictureBox19.Visible = false;

                string guesscard = y.ToString();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

            Random r = new Random();
            int x = r.Next(13);//Max range
            q = x;
            if (x == 0)
            {
                x = 1;
            }
            if (x == 1)
            {
                pictureBox21.Visible = true;
            }
            if (x != 1)
            {
                pictureBox21.Visible = false;
            }
            if (x == 2)
            {
                pictureBox22.Visible = true;
            }
            if (x != 2)
            {
                pictureBox22.Visible = false;
            }
            if (x == 3)
            {
                pictureBox23.Visible = true;
            }
            if (x != 3)
            {
                pictureBox23.Visible = false;
            }
            if (x == 4)
            {
                pictureBox24.Visible = true;
            }
            if (x != 4)
            {
                pictureBox24.Visible = false;
            }
            if (x == 5)
            {
                pictureBox25.Visible = true;
            }
            if (x != 5)
            {
                pictureBox25.Visible = false;
            }
            if (x == 6)
            {
                pictureBox26.Visible = true;
            }
            if (x != 6)
            {
                pictureBox26.Visible = false;
            }
            if (x == 7)
            {
                pictureBox27.Visible = true;
            }
            if (x != 7)
            {
                pictureBox27.Visible = false;
            }
            if (x == 8)
            {
                pictureBox28.Visible = true;
            }
            if (x != 8)
            {
                pictureBox28.Visible = false;
            }
            if (x == 9)
            {
                pictureBox29.Visible = true;
            }
            if (x != 9)
            {
                pictureBox29.Visible = false;
            }
            if (x == 10)
            {
                pictureBox30.Visible = true;
            }
            if (x != 10)
            {
                pictureBox30.Visible = false;
            }
            if (x == 11)
            {
                pictureBox31.Visible = true;
            }
            if (x != 11)
            {
                pictureBox31.Visible = false;
            }
            if (x == 12)
            {
                pictureBox32.Visible = true;
            }
            if (x != 12)
            {
                pictureBox32.Visible = false;
            }
            if (x == 13)
            {
                pictureBox33.Visible = true;
            }
            if (x != 13)
            {
                pictureBox33.Visible = false;
            }
            pictureBox3.Visible = true;
            pictureBox13.Visible = true;
            pictureBox4.Visible = true;
            label3.Visible = true;
            label2.Visible = true;
            label4.Visible = true;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (q < g)
            {

                if (g == 0)
                {
                    g = 1;
                }
                if (g == 1)
                {
                    pictureBox6.Visible = true;

                    if (flag == 0)
                    {
                        pictureBox36.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox37.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox38.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox39.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox40.Visible = true;

                    }
                }
                if (g != 1)
                {
                    pictureBox6.Visible = false;
                }
                if (g == 2)
                {
                    pictureBox7.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox41.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox42.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox43.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox44.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox45.Visible = true;

                    }
                }
                if (g != 2)
                {
                    pictureBox7.Visible = false;
                }
                if (g == 3)
                {
                    pictureBox8.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox46.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox47.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox48.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox49.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox50.Visible = true;

                    }
                }
                if (g != 3)
                {
                    pictureBox8.Visible = false;
                }
                if (g == 4)
                {
                    pictureBox9.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox51.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox52.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox53.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox54.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox55.Visible = true;

                    }
                }
                if (g != 4)
                {
                    pictureBox9.Visible = false;
                }
                if (g == 5)
                {
                    pictureBox10.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox56.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox57.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox58.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox59.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox60.Visible = true;

                    }
                }
                if (g != 5)
                {
                    pictureBox10.Visible = false;
                }
                if (g == 6)
                {
                    pictureBox11.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox61.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox62.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox63.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox64.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox65.Visible = true;

                    }
                }
                if (g != 6)
                {
                    pictureBox11.Visible = false;
                }
                if (g == 7)
                {
                    pictureBox12.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox66.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox67.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox68.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox69.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox70.Visible = true;

                    }
                }
                if (g != 7)
                {
                    pictureBox12.Visible = false;
                }
                if (g == 8)
                {
                    pictureBox14.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox71.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox72.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox73.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox74.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox75.Visible = true;

                    }
                }
                if (g != 8)
                {
                    pictureBox14.Visible = false;
                }
                if (g == 9)
                {
                    pictureBox15.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox76.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox77.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox78.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox79.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox80.Visible = true;

                    }
                }
                if (g != 9)
                {
                    pictureBox15.Visible = false;
                }
                if (g == 10)
                {
                    pictureBox16.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox81.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox82.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox83.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox84.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox85.Visible = true;

                    }
                }
                if (g != 10)
                {
                    pictureBox16.Visible = false;
                }
                if (g == 11)
                {
                    pictureBox17.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox86.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox87.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox88.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox89.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox90.Visible = true;

                    }
                }
                if (g != 11)
                {
                    pictureBox17.Visible = false;
                }
                if (g == 12)
                {
                    pictureBox18.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox91.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox92.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox93.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox94.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox95.Visible = true;

                    }
                }
                if (g != 12)
                {
                    pictureBox18.Visible = false;
                }
                if (g == 13)
                {
                    pictureBox19.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox96.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox97.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox98.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox99.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox100.Visible = true;

                    }
                }
                if (g != 13)
                {
                    pictureBox19.Visible = false;
                }
                Form3 f3 = new Form3();
                f3.ShowDialog();
                count++;
                flag++;
                if (flag == 5)
                {
                    flag = 0;
                    pictureBox36.Visible = false;
                    pictureBox37.Visible = false;
                    pictureBox38.Visible = false;
                    pictureBox39.Visible = false;
                    pictureBox40.Visible = false;
                    pictureBox41.Visible = false;
                    pictureBox42.Visible = false;
                    pictureBox43.Visible = false;
                    pictureBox44.Visible = false;
                    pictureBox45.Visible = false;
                    pictureBox46.Visible = false;
                    pictureBox47.Visible = false;
                    pictureBox48.Visible = false;
                    pictureBox49.Visible = false;
                    pictureBox50.Visible = false;
                    pictureBox51.Visible = false;
                    pictureBox52.Visible = false;
                    pictureBox53.Visible = false;
                    pictureBox54.Visible = false;
                    pictureBox55.Visible = false;
                    pictureBox56.Visible = false;
                    pictureBox57.Visible = false;
                    pictureBox58.Visible = false;
                    pictureBox59.Visible = false;
                    pictureBox60.Visible = false;
                    pictureBox61.Visible = false;
                    pictureBox62.Visible = false;
                    pictureBox63.Visible = false;
                    pictureBox64.Visible = false;
                    pictureBox65.Visible = false;
                    pictureBox66.Visible = false;
                    pictureBox67.Visible = false;
                    pictureBox68.Visible = false;
                    pictureBox69.Visible = false;
                    pictureBox70.Visible = false;
                    pictureBox71.Visible = false;
                    pictureBox72.Visible = false;
                    pictureBox73.Visible = false;
                    pictureBox74.Visible = false;
                    pictureBox75.Visible = false;
                    pictureBox76.Visible = false;
                    pictureBox77.Visible = false;
                    pictureBox78.Visible = false;
                    pictureBox79.Visible = false;
                    pictureBox80.Visible = false;
                    pictureBox81.Visible = false;
                    pictureBox82.Visible = false;
                    pictureBox83.Visible = false;
                    pictureBox84.Visible = false;
                    pictureBox85.Visible = false;
                    pictureBox86.Visible = false;
                    pictureBox87.Visible = false;
                    pictureBox88.Visible = false;
                    pictureBox89.Visible = false;
                    pictureBox90.Visible = false;
                    pictureBox91.Visible = false;
                    pictureBox92.Visible = false;
                    pictureBox93.Visible = false;
                    pictureBox94.Visible = false;
                    pictureBox95.Visible = false;
                    pictureBox96.Visible = false;
                    pictureBox97.Visible = false;
                    pictureBox98.Visible = false;
                    pictureBox99.Visible = false;
                    pictureBox100.Visible = false;
                }
                label6.Text = count.ToString();
                pictureBox3.Visible = false;
                pictureBox13.Visible = false;
                pictureBox4.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                Random ran = new Random();
                dynamic y = ran.Next(13);//Max range
                g = y;

                pictureBox6.Visible = false;

                pictureBox7.Visible = false;

                pictureBox8.Visible = false;

                pictureBox9.Visible = false;

                pictureBox10.Visible = false;

                pictureBox11.Visible = false;

                pictureBox12.Visible = false;

                pictureBox14.Visible = false;

                pictureBox15.Visible = false;

                pictureBox16.Visible = false;

                pictureBox17.Visible = false;

                pictureBox18.Visible = false;

                pictureBox19.Visible = false;

                string guesscard = y.ToString();
            }
            else
            {

                if (g == 0)
                {
                    g = 1;
                }
                if (g == 1)
                {
                    pictureBox6.Visible = true;
                }
                if (g != 1)
                {
                    pictureBox6.Visible = false;
                }
                if (g == 2)
                {
                    pictureBox7.Visible = true;
                }
                if (g != 2)
                {
                    pictureBox7.Visible = false;
                }
                if (g == 3)
                {
                    pictureBox8.Visible = true;
                }
                if (g != 3)
                {
                    pictureBox8.Visible = false;
                }
                if (g == 4)
                {
                    pictureBox9.Visible = true;
                }
                if (g != 4)
                {
                    pictureBox9.Visible = false;
                }
                if (g == 5)
                {
                    pictureBox10.Visible = true;
                }
                if (g != 5)
                {
                    pictureBox10.Visible = false;
                }
                if (g == 6)
                {
                    pictureBox11.Visible = true;
                }
                if (g != 6)
                {
                    pictureBox11.Visible = false;
                }
                if (g == 7)
                {
                    pictureBox12.Visible = true;
                }
                if (g != 7)
                {
                    pictureBox12.Visible = false;
                }
                if (g == 8)
                {
                    pictureBox14.Visible = true;
                }
                if (g != 8)
                {
                    pictureBox14.Visible = false;
                }
                if (g == 9)
                {
                    pictureBox15.Visible = true;
                }
                if (g != 9)
                {
                    pictureBox15.Visible = false;
                }
                if (g == 10)
                {
                    pictureBox16.Visible = true;
                }
                if (g != 10)
                {
                    pictureBox16.Visible = false;
                }
                if (g == 11)
                {
                    pictureBox17.Visible = true;
                }
                if (g != 11)
                {
                    pictureBox17.Visible = false;
                }
                if (g == 12)
                {
                    pictureBox18.Visible = true;
                }
                if (g != 12)
                {
                    pictureBox18.Visible = false;
                }
                if (g == 13)
                {
                    pictureBox19.Visible = true;
                }
                if (g != 13)
                {
                    pictureBox19.Visible = false;
                }
                Form4 f4 = new Form4();
                f4.ShowDialog();
                pictureBox3.Visible = false;
                pictureBox13.Visible = false;
                pictureBox4.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                Random ran = new Random();
                dynamic y = ran.Next(13);//Max range
                g = y;

                pictureBox6.Visible = false;

                pictureBox7.Visible = false;

                pictureBox8.Visible = false;

                pictureBox9.Visible = false;

                pictureBox10.Visible = false;

                pictureBox11.Visible = false;

                pictureBox12.Visible = false;

                pictureBox14.Visible = false;

                pictureBox15.Visible = false;

                pictureBox16.Visible = false;

                pictureBox17.Visible = false;

                pictureBox18.Visible = false;

                pictureBox19.Visible = false;

                string guesscard = y.ToString();
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (q == g)
            {

                if (g == 0)
                {
                    g = 1;
                }
                if (g == 1)
                {
                    pictureBox6.Visible = true;

                    if (flag == 0)
                    {
                        pictureBox36.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox37.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox38.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox39.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox40.Visible = true;

                    }
                }
                if (g != 1)
                {
                    pictureBox6.Visible = false;
                }
                if (g == 2)
                {
                    pictureBox7.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox41.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox42.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox43.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox44.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox45.Visible = true;

                    }
                }
                if (g != 2)
                {
                    pictureBox7.Visible = false;
                }
                if (g == 3)
                {
                    pictureBox8.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox46.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox47.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox48.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox49.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox50.Visible = true;

                    }
                }
                if (g != 3)
                {
                    pictureBox8.Visible = false;
                }
                if (g == 4)
                {
                    pictureBox9.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox51.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox52.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox53.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox54.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox55.Visible = true;

                    }
                }
                if (g != 4)
                {
                    pictureBox9.Visible = false;
                }
                if (g == 5)
                {
                    pictureBox10.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox56.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox57.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox58.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox59.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox60.Visible = true;

                    }
                }
                if (g != 5)
                {
                    pictureBox10.Visible = false;
                }
                if (g == 6)
                {
                    pictureBox11.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox61.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox62.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox63.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox64.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox65.Visible = true;

                    }
                }
                if (g != 6)
                {
                    pictureBox11.Visible = false;
                }
                if (g == 7)
                {
                    pictureBox12.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox66.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox67.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox68.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox69.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox70.Visible = true;

                    }
                }
                if (g != 7)
                {
                    pictureBox12.Visible = false;
                }
                if (g == 8)
                {
                    pictureBox14.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox71.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox72.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox73.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox74.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox75.Visible = true;

                    }
                }
                if (g != 8)
                {
                    pictureBox14.Visible = false;
                }
                if (g == 9)
                {
                    pictureBox15.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox76.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox77.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox78.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox79.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox80.Visible = true;

                    }
                }
                if (g != 9)
                {
                    pictureBox15.Visible = false;
                }
                if (g == 10)
                {
                    pictureBox16.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox81.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox82.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox83.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox84.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox85.Visible = true;

                    }
                }
                if (g != 10)
                {
                    pictureBox16.Visible = false;
                }
                if (g == 11)
                {
                    pictureBox17.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox86.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox87.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox88.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox89.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox90.Visible = true;

                    }
                }
                if (g != 11)
                {
                    pictureBox17.Visible = false;
                }
                if (g == 12)
                {
                    pictureBox18.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox91.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox92.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox93.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox94.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox95.Visible = true;

                    }
                }
                if (g != 12)
                {
                    pictureBox18.Visible = false;
                }
                if (g == 13)
                {
                    pictureBox19.Visible = true;
                    if (flag == 0)
                    {
                        pictureBox96.Visible = true;

                    }
                    if (flag == 1)
                    {
                        pictureBox97.Visible = true;

                    }
                    if (flag == 2)
                    {
                        pictureBox98.Visible = true;

                    }
                    if (flag == 3)
                    {
                        pictureBox99.Visible = true;

                    }
                    if (flag == 4)
                    {
                        pictureBox100.Visible = true;

                    }
                }
                if (g != 13)
                {
                    pictureBox19.Visible = false;
                }
                Form3 f3 = new Form3();
                f3.ShowDialog();
                count++;
                flag++;
                if (flag == 5)
                {
                    flag = 0;
                    pictureBox36.Visible = false;
                    pictureBox37.Visible = false;
                    pictureBox38.Visible = false;
                    pictureBox39.Visible = false;
                    pictureBox40.Visible = false;
                    pictureBox41.Visible = false;
                    pictureBox42.Visible = false;
                    pictureBox43.Visible = false;
                    pictureBox44.Visible = false;
                    pictureBox45.Visible = false;
                    pictureBox46.Visible = false;
                    pictureBox47.Visible = false;
                    pictureBox48.Visible = false;
                    pictureBox49.Visible = false;
                    pictureBox50.Visible = false;
                    pictureBox51.Visible = false;
                    pictureBox52.Visible = false;
                    pictureBox53.Visible = false;
                    pictureBox54.Visible = false;
                    pictureBox55.Visible = false;
                    pictureBox56.Visible = false;
                    pictureBox57.Visible = false;
                    pictureBox58.Visible = false;
                    pictureBox59.Visible = false;
                    pictureBox60.Visible = false;
                    pictureBox61.Visible = false;
                    pictureBox62.Visible = false;
                    pictureBox63.Visible = false;
                    pictureBox64.Visible = false;
                    pictureBox65.Visible = false;
                    pictureBox66.Visible = false;
                    pictureBox67.Visible = false;
                    pictureBox68.Visible = false;
                    pictureBox69.Visible = false;
                    pictureBox70.Visible = false;
                    pictureBox71.Visible = false;
                    pictureBox72.Visible = false;
                    pictureBox73.Visible = false;
                    pictureBox74.Visible = false;
                    pictureBox75.Visible = false;
                    pictureBox76.Visible = false;
                    pictureBox77.Visible = false;
                    pictureBox78.Visible = false;
                    pictureBox79.Visible = false;
                    pictureBox80.Visible = false;
                    pictureBox81.Visible = false;
                    pictureBox82.Visible = false;
                    pictureBox83.Visible = false;
                    pictureBox84.Visible = false;
                    pictureBox85.Visible = false;
                    pictureBox86.Visible = false;
                    pictureBox87.Visible = false;
                    pictureBox88.Visible = false;
                    pictureBox89.Visible = false;
                    pictureBox90.Visible = false;
                    pictureBox91.Visible = false;
                    pictureBox92.Visible = false;
                    pictureBox93.Visible = false;
                    pictureBox94.Visible = false;
                    pictureBox95.Visible = false;
                    pictureBox96.Visible = false;
                    pictureBox97.Visible = false;
                    pictureBox98.Visible = false;
                    pictureBox99.Visible = false;
                    pictureBox100.Visible = false;
                }
                label6.Text = count.ToString();
                pictureBox3.Visible = false;
                pictureBox13.Visible = false;
                pictureBox4.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                Random ran = new Random();
                dynamic y = ran.Next(13);//Max range
                g = y;

                pictureBox6.Visible = false;

                pictureBox7.Visible = false;

                pictureBox8.Visible = false;

                pictureBox9.Visible = false;

                pictureBox10.Visible = false;

                pictureBox11.Visible = false;

                pictureBox12.Visible = false;

                pictureBox14.Visible = false;

                pictureBox15.Visible = false;

                pictureBox16.Visible = false;

                pictureBox17.Visible = false;

                pictureBox18.Visible = false;

                pictureBox19.Visible = false;

                string guesscard = y.ToString();

            }
            else
            {

                if (g == 0)
                {
                    g = 1;
                }
                if (g == 1)
                {
                    pictureBox6.Visible = true;
                }
                if (g != 1)
                {
                    pictureBox6.Visible = false;
                }
                if (g == 2)
                {
                    pictureBox7.Visible = true;
                }
                if (g != 2)
                {
                    pictureBox7.Visible = false;
                }
                if (g == 3)
                {
                    pictureBox8.Visible = true;
                }
                if (g != 3)
                {
                    pictureBox8.Visible = false;
                }
                if (g == 4)
                {
                    pictureBox9.Visible = true;
                }
                if (g != 4)
                {
                    pictureBox9.Visible = false;
                }
                if (g == 5)
                {
                    pictureBox10.Visible = true;
                }
                if (g != 5)
                {
                    pictureBox10.Visible = false;
                }
                if (g == 6)
                {
                    pictureBox11.Visible = true;
                }
                if (g != 6)
                {
                    pictureBox11.Visible = false;
                }
                if (g == 7)
                {
                    pictureBox12.Visible = true;
                }
                if (g != 7)
                {
                    pictureBox12.Visible = false;
                }
                if (g == 8)
                {
                    pictureBox14.Visible = true;
                }
                if (g != 8)
                {
                    pictureBox14.Visible = false;
                }
                if (g == 9)
                {
                    pictureBox15.Visible = true;
                }
                if (g != 9)
                {
                    pictureBox15.Visible = false;
                }
                if (g == 10)
                {
                    pictureBox16.Visible = true;
                }
                if (g != 10)
                {
                    pictureBox16.Visible = false;
                }
                if (g == 11)
                {
                    pictureBox17.Visible = true;
                }
                if (g != 11)
                {
                    pictureBox17.Visible = false;
                }
                if (g == 12)
                {
                    pictureBox18.Visible = true;
                }
                if (g != 12)
                {
                    pictureBox18.Visible = false;
                }
                if (g == 13)
                {
                    pictureBox19.Visible = true;
                }
                if (g != 13)
                {
                    pictureBox19.Visible = false;
                }
                Form4 f4 = new Form4();
                f4.ShowDialog();
                pictureBox3.Visible = false;
                pictureBox13.Visible = false;
                pictureBox4.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                Random ran = new Random();
                dynamic y = ran.Next(13);//Max range
                g = y;

                pictureBox6.Visible = false;

                pictureBox7.Visible = false;

                pictureBox8.Visible = false;

                pictureBox9.Visible = false;

                pictureBox10.Visible = false;

                pictureBox11.Visible = false;

                pictureBox12.Visible = false;

                pictureBox14.Visible = false;

                pictureBox15.Visible = false;

                pictureBox16.Visible = false;

                pictureBox17.Visible = false;

                pictureBox18.Visible = false;

                pictureBox19.Visible = false;

                string guesscard = y.ToString();
            }
        }
       
        private void label12_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            dynamic y = ran.Next(13);//Max range
            g = y;
            string guesscard = y.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        
    }
    

}
