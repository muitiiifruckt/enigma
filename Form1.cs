using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_project
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush brush1 = new SolidBrush(Color.Green);
       
        Pen pen1 = new Pen(Color.Black,2);
        Font myFont = new Font("Arial", 20, FontStyle.Bold);

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics gr = panel1.CreateGraphics();

            /// первый ряд
   
            gr.DrawEllipse(pen1, 50, 10, 60, 60);
            gr.FillEllipse(brush1, 50, 10, 60, 60);

            gr.DrawEllipse(pen1, 150, 10,60, 60);
            gr.FillEllipse(brush1, 150, 10, 60, 60);

            gr.DrawEllipse(pen1, 250, 10, 60, 60);
            gr.FillEllipse(brush1, 250, 10, 60, 60);

            gr.DrawEllipse(pen1, 350, 10, 60, 60);
            gr.FillEllipse(brush1, 350, 10, 60, 60);

            gr.DrawEllipse(pen1, 450, 10, 60, 60);
            gr.FillEllipse(brush1, 450, 10, 60, 60);

            gr.DrawEllipse(pen1, 550, 10, 60, 60);
            gr.FillEllipse(brush1, 550, 10, 60, 60);

            gr.DrawEllipse(pen1, 650, 10, 60, 60);
            gr.FillEllipse(brush1, 650, 10, 60, 60);

            gr.DrawEllipse(pen1, 750, 10, 60, 60);
            gr.FillEllipse(brush1, 750, 10, 60, 60);

            gr.DrawEllipse(pen1, 850, 10, 60, 60);
            gr.FillEllipse(brush1, 850, 10, 60, 60);

            gr.DrawEllipse(pen1, 950, 10, 60, 60);
            gr.FillEllipse(brush1, 950, 10, 60, 60);


            /// первый ряд

            /// второй ряд

            gr.DrawEllipse(pen1, 100, 90, 60, 60);
            gr.FillEllipse(brush1, 100, 90, 60, 60);

            gr.DrawEllipse(pen1, 200, 90, 60, 60);
            gr.FillEllipse(brush1, 200, 90, 60, 60);

            gr.DrawEllipse(pen1, 300, 90, 60, 60);
            gr.FillEllipse(brush1, 300, 90, 60, 60);

            gr.DrawEllipse(pen1, 400, 90, 60, 60);
            gr.FillEllipse(brush1, 400, 90, 60, 60);

            gr.DrawEllipse(pen1, 500, 90, 60, 60);
            gr.FillEllipse(brush1, 500, 90, 60, 60);

            gr.DrawEllipse(pen1, 500, 90, 60, 60);
            gr.FillEllipse(brush1, 500, 90, 60, 60);

            gr.DrawEllipse(pen1, 600, 90, 60, 60);
            gr.FillEllipse(brush1, 600, 90, 60, 60);

            gr.DrawEllipse(pen1, 700, 90, 60, 60);
            gr.FillEllipse(brush1, 700, 90, 60, 60);

            gr.DrawEllipse(pen1, 800, 90, 60, 60);
            gr.FillEllipse(brush1, 800, 90, 60, 60);

            gr.DrawEllipse(pen1, 800, 90, 60, 60);
            gr.FillEllipse(brush1, 800, 90, 60, 60);

            gr.DrawEllipse(pen1, 900, 90, 60, 60);
            gr.FillEllipse(brush1, 900, 90, 60, 60);

            //// второй ряд
            

            //// третий ряд 

            gr.DrawEllipse(pen1, 150, 170, 60, 60);
            gr.FillEllipse(brush1, 150, 170, 60, 60);

            gr.DrawEllipse(pen1, 250, 170, 60, 60);
            gr.FillEllipse(brush1,250, 170, 60, 60);

            gr.DrawEllipse(pen1, 350, 170, 60, 60);
            gr.FillEllipse(brush1, 350, 170, 60, 60);

            gr.DrawEllipse(pen1, 450, 170, 60, 60);
            gr.FillEllipse(brush1, 450, 170, 60, 60);

            gr.DrawEllipse(pen1, 550, 170, 60, 60);
            gr.FillEllipse(brush1, 550, 170, 60, 60);

            gr.DrawEllipse(pen1, 650, 170, 60, 60);
            gr.FillEllipse(brush1, 650, 170, 60, 60);

            gr.DrawEllipse(pen1, 750, 170, 60, 60);
            gr.FillEllipse(brush1, 750, 170, 60, 60);

            //// третий ряд

            /// первый ряд
            gr.DrawString("Q", myFont, Brushes.Red, new Point(65, 25));
            gr.DrawString("W", myFont, Brushes.Red, new Point(165, 25));
            gr.DrawString("E", myFont, Brushes.Red, new Point(265, 25));
            gr.DrawString("R", myFont, Brushes.Red, new Point(365, 25));
            gr.DrawString("T", myFont, Brushes.Red, new Point(465, 25));
            gr.DrawString("Y", myFont, Brushes.Red, new Point(565, 25));
            gr.DrawString("U", myFont, Brushes.Red, new Point(665, 25));
            gr.DrawString("I", myFont, Brushes.Red, new Point(765, 25));
            gr.DrawString("O", myFont, Brushes.Red, new Point(865, 25));
            gr.DrawString("P", myFont, Brushes.Red, new Point(965, 25));
            /// первый ряд
            /// 
            /// 
            /// второй ряд 
            gr.DrawString("A", myFont, Brushes.Red, new Point(115, 105));
            gr.DrawString("S", myFont, Brushes.Red, new Point(215, 105));
            gr.DrawString("D", myFont, Brushes.Red, new Point(315, 105));
            gr.DrawString("F", myFont, Brushes.Red, new Point(415, 105));
            gr.DrawString("G", myFont, Brushes.Red, new Point(515, 105));
            gr.DrawString("H", myFont, Brushes.Red, new Point(615, 105));
            gr.DrawString("J", myFont, Brushes.Red, new Point(715, 105));
            gr.DrawString("K", myFont, Brushes.Red, new Point(815, 105));
            gr.DrawString("L", myFont, Brushes.Red, new Point(915, 105));
            /// второй ряд 

            //// третий ряд 
            gr.DrawString("Z", myFont, Brushes.Red, new Point(165, 185));
            gr.DrawString("X", myFont, Brushes.Red, new Point(265, 185));
            gr.DrawString("C", myFont, Brushes.Red, new Point(365, 185));
            gr.DrawString("V", myFont, Brushes.Red, new Point(465, 185));
            gr.DrawString("B", myFont, Brushes.Red, new Point(565, 185));
            gr.DrawString("N", myFont, Brushes.Red, new Point(665, 185));
            gr.DrawString("M", myFont, Brushes.Red, new Point(765, 185));

            //// третий ряд 
            ///
            gr.DrawEllipse(pen1, button1.Location.X, button1.Location.Y, 90, 90);
            gr.FillEllipse(brush1, button1.Location.X, button1.Location.Y, 90, 90);
        }



        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics gr = panel1.CreateGraphics();
            SolidBrush brush1 = new SolidBrush(Color.Yellow);
            if (e.Button == MouseButtons.Left);
            gr.DrawEllipse(pen1, 50, 10, 60, 60);
            gr.FillEllipse(brush1, 50, 10, 60, 60);
            gr.DrawString("Q", myFont, Brushes.Red, new Point(65, 25));
            gr.Dispose();
        }

        

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics gr = panel1.CreateGraphics();
            SolidBrush brush1 = new SolidBrush(Color.Yellow);
            if (e.Button == MouseButtons.Left) ;
            gr.DrawEllipse(pen1, 100, 90, 60, 60);
            gr.FillEllipse(brush1, 100, 90, 60, 60);
            gr.DrawString("A", myFont, Brushes.Red, new Point(115, 105));
            gr.Dispose();
        }
    }
}
