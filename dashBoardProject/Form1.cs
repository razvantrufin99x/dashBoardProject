namespace dashBoardProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            this.cadran1.writeValue(21.5f);
            this.cadran1.drawCadran(100.0f, 6.0f, 6.0f, Color.Red, 20.0f, 100.0f, 100.0f);
           
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 360; i++)
            {
                this.cadran1.writeValue(21.5f+i);
                this.cadran1.drawCadran(100.0f, 6.0f, 6.0f, Color.Red, 20.0f, 100.0f, 100.0f);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           
        }
    }
}