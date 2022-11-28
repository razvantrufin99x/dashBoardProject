using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashBoardProject
{
    public partial class cadran : UserControl
    {
        public cadran()
        {
            InitializeComponent();
        }
        public float cadranValue = 0;
        public void writeValue(float pcv) { cadranValue = pcv; }    
        public float readValue() { return cadranValue; }
        public Pen penMain = new Pen(Color.Black, 10);
        public float raza;
        public float pozitiex;
        public float pozitiey;
        public Color culoare;
        public float grosime;
        public float dimx;
        public float dimy;

        public void drawCadran(float praza, float ppozitiex, float ppozitiey, Color pculoare, float pgrosime, float pdimx, float pdimy)
        {
            penMain.Color = pculoare;
            penMain.Width = pgrosime;
            raza = praza;
            pozitiex = ppozitiex;
            pozitiey  = ppozitiey; 
            culoare = pculoare;
            grosime = pgrosime;
            dimx = pdimx;
            dimy = pdimy;

            //this.g.DrawEllipse( penMain, ppozitiex, ppozitiey, pdimx, pdimy);
            this.g.DrawArc(penMain, ppozitiex, ppozitiey, pdimx, pdimy, 1, cadranValue);
        }

       
        public Graphics g;
        private void cadran_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();

        }
    }
}
