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
            richTextBox2.Text = "";
            bool is_err = false;
            if (textBox1.Text != "" && richTextBox1.Text != "")
            {

                try
                {
                    string[] s = richTextBox1.Text.Split('\n');
                    Convert.ToSingle(textBox1.Text);
                    Convert.ToSingle(textBox2.Text);
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
                    float M = Convert.ToSingle(textBox1.Text);
                    float L = Convert.ToSingle(textBox2.Text);
                    ;
                    for (int i = 0; i < mass.Length; i++)
                    {
                        if(L <= M - 1 && L >= 0)
                        {
                            if (Convert.ToSingle(mass[i]) > Convert.ToSingle(i) && Convert.ToSingle(mass[i]) % M == L)
                            {
                                richTextBox2.Text += mass[i] + '\n';
                            }
                        }
                    }
                    if (mass.Length == 0)
                    {
                        richTextBox2.Text = "Нет таких элементов.";
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