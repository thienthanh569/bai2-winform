namespace bai1_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btCong_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
            double tong = so1 + so2;
            txtkq.Text = tong.ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
            double tong = so1 - so2;
            txtkq.Text = tong.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);
            double tong = so1 * so2;
            txtkq.Text = tong.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtso1.Text);
            double so2 = Convert.ToDouble(txtso2.Text);


            if (so2 == 0)
            {

            }
            else
            {
                double tong = so1 / so2;
                txtkq.Text = tong.ToString();

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
