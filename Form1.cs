namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.LightGray;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void MessageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Информационное сообщение", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CreateFormBt_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
        private void CreateForm2BT_Click(object sender, EventArgs e)
        {
            form3.ShowDialog();
        }
    }
}