namespace CS_0510
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mybutton.Text = "あー押されちゃった";
            mybutton.Left = 0;
            //button1.Visible = false;
            MessageBox.Show("何見てんだ(^-^#)コノヤロー");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}