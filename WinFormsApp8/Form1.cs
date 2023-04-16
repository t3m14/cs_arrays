namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool is_err = false;
            if (textBox1.Text != "" && richTextBox1.Text != "")
            {

                try
                {
                    string[] s = richTextBox1.Text.Split('\n');
                    Convert.ToInt32(textBox1.Text);
                    foreach (string el in s)
                    {
                        Convert.ToInt32(el);
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
                    int M = Convert.ToInt32(textBox1.Text);
                    int L = Convert.ToInt32(textBox2.Text);
                    ;
                    for (int i = 0; i < mass.Length; i++)
                    {
                        if (Convert.ToInt32(mass[i]) > i && Convert.ToInt32(mass[i]) % M == L)
                        {
                            richTextBox2.Text += mass[i] + '\n';
                        }
                    }
                    richTextBox1.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";

                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}