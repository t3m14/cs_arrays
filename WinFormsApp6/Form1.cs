namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            bool is_err = false;
            if (richTextBox1.Text != "")
            {

                try
                {
                    string[] s = richTextBox1.Text.Split('\n');

                    foreach (string el in s)
                    {
                        Convert.ToSingle(el);
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода, проверьте правильность введённых данных!");
                }
                if (!is_err)
                {

                    // получаем массив через ввод из richTextBox1
                    string[] mass = richTextBox1.Text.Split('\n');
                    for (int i = 0; i < mass.Length; i++)
                    {
                        if (Convert.ToSingle(mass[i]) >= 0)
                        {
                            richTextBox2.Text += mass[i] + '\n';


                        }
                    }
                    for (int i = 0; i < mass.Length; i++)
                    {
                        if (Convert.ToSingle(mass[i]) <= 0)
                        {
                            richTextBox2.Text += mass[i] + '\n';


                        }
                    }
                    if (mass.Length == 0)
                    {
                        richTextBox2.Text = "Нет элементов!";
                    }

                    richTextBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}