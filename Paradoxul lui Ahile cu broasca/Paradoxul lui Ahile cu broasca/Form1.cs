using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paradoxul_lui_Ahile_cu_broasca
{
    public partial class Form1 : Form
    {
        System.Drawing.Graphics Desen;
        System.Drawing.Pen Creion_albastru;
        System.Drawing.SolidBrush Pensula_albastra;
        System.Drawing.SolidBrush Radiera;
        int i,pas,v_o, pas_o;
        public Form1()
        {
            InitializeComponent();
            Desen = this.CreateGraphics();
            Creion_albastru = new System.Drawing.Pen(System.Drawing.Color.Blue);
            Pensula_albastra = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
            Radiera = new System.Drawing.SolidBrush(this.BackColor);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Deseneaza();

        }
        void Deseneaza()
        {
            Desen.Clear(this.BackColor);
            Desen.DrawRectangle(Creion_albastru, 10, 100, this.Width-10, 20);
            Desen.DrawRectangle(Creion_albastru, 10, 180, this.Width-10, 20);

            for (i = 1; i <= this.Width-10; i += 10)
            {
                Desen.DrawLine(Creion_albastru, 20 + i, 100, 20 + i, 120);
                Desen.DrawLine(Creion_albastru, 20 + i, 180, 20 + i, 200);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Deseneaza();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pas == 1000)
            { 
                pas = 0;
                pas_o = 0;
            }
            Desen.FillRectangle(Radiera, 12 + pas, 102, 8, 18);
            pas=pas+10;
            Desen.FillRectangle(Pensula_albastra, 12 + pas, 102, 8, 18);
            if (pas > 300)
            {

                for (v_o = 1; v_o <= 2; v_o++)
                {
                    Desen.FillRectangle(Radiera, 12 + pas_o, 182, 8, 18);
                    pas_o = pas_o + 10;
                    Desen.FillRectangle(Pensula_albastra, 12 + pas_o, 182, 8, 18);
                }
            }
       
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
