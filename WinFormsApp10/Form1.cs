namespace WinFormsApp10
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool is_err = false;
            if (richTextBox1.Text != "")
            {

                try
                {
                    string[] s = richTextBox1.Text.Split('\n');
                    Convert.ToInt32(textBox1);
                    Convert.ToInt32(textBox2);
                    Convert.ToInt32(textBox3);
                    Convert.ToInt32(textBox4);
                    foreach (string el in s)
                    {
                        Convert.ToInt32(el);
                    }
                }
                catch
                {
                    MessageBox.Show("ќшибка ввода, проверьте правильность введЄнных данных!");
                }
                if (!is_err)
                {

                    // получаем массив через ввод из richTextBox1
                    string[] arr = richTextBox1.Text.Split('\n');

                    int Nb = Convert.ToInt32(textBox1); // задаем размер партии
                    int N = Convert.ToInt32(textBox2); // задаем размер детали
                    int A = Convert.ToInt32(textBox3); // задаем значение интервала
                    int b = Convert.ToInt32(textBox4); // задаем допустимую погрешность

                    int count = 0; // счетчик бракованных деталей

                    foreach (string size in arr)
                    {
                        if (Convert.ToInt32(size) < A - b || Convert.ToInt32(size) > A + b)
                            count++; // увеличиваем счетчик при несоответствии
                    }

                    if (count == 0)
                        label5.Text = "ќтрицательный ответ"; // если бракованных деталей нет, выводитс€ отрицательный ответ
                    else
                        label5.Text = $"¬ партии имеетс€ {count} бракованных деталей"; // если бракованные детали есть, выводитс€ их количество
                }
            }
            else
            {
                MessageBox.Show("«аполните все пол€!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            richTextBox1.Text = "";
            label5.Text = "";
        }
    }
}