namespace University_Course_Registration_System
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Interval = 50; // Optional if set in designer
            timer1.Tick += timer1_Tick; // Ensure it's wired
           
        }

      
        private void label2_Click(object sender, EventArgs e)
        {

        }
        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            Myprogressbar.Value = startpos;
            if (Myprogressbar.Value == 100)
            {
                
                timer1.Stop();
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          timer1.Start();
        }
    }
}
