using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parabola____grid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int i = 0, lat, h;
            float x, ymax, y = 0, y_v = 0, k;
            System.Drawing.Graphics Desen;
            Desen = this.CreateGraphics();
            System.Drawing.Pen Creion_gri_d;
            Creion_gri_d = new System.Drawing.Pen(System.Drawing.Color.LightGray);
            System.Drawing.Pen Creion_gri;
            Creion_gri = new System.Drawing.Pen(System.Drawing.Color.Gray);
            Desen.Clear(this.BackColor);
            System.Drawing.Pen Creion_rosu;
            Creion_rosu = new System.Drawing.Pen(System.Drawing.Color.Red);
            //Grid 
            // linii verticale
            for (i = 0; i <= this.Width; i += 10)
            {
                if (i % 50 == 0)
                    Desen.DrawLine(Creion_gri, i, 0, i, this.Height);
                else
                    Desen.DrawLine(Creion_gri_d, i, 0, i, this.Height);
            }
            // linii orizontale

            for (i = 0; i <= this.Height; i += 10)
            {
                if (i % 50 == 0)
                    Desen.DrawLine(Creion_gri, 0, i, this.Width, i);
                else
                    Desen.DrawLine(Creion_gri_d, 0, i, this.Width, i);
            }
            // Trasare grafic x*x
            h = this.Height - 50;
            i = 0;
            lat = this.Width - 20;
            ymax = (lat / 2) * (lat / 2); // ymax pe intervalul -lat/2... lat/2 este (lat/2)^2
            k = h / ymax; // factorul de scala
            for (x = -lat / 2; x <= lat / 2; x++)
            {
                y = h - k * x * x; // y=k*x^2
                Desen.DrawLine(Creion_rosu, i - 1, y_v, i, y);
                y_v = y;
                i += 1;
            }
        }
    }
}
