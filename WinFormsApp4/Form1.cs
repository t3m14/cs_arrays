namespace WinFormsApp4
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
                    string[] arr = richTextBox1.Text.Split('\n');

                    int count = 0;

                    for (int i = 1; i < arr.Length - 1; i++)
                    {
                        if (Convert.ToSingle(arr[i]) > Convert.ToSingle(arr[i - 1]) && Convert.ToSingle(arr[i]) > Convert.ToSingle(arr[i + 1]))
                        {
                            count++;
                        }
                    }
                    label5.Text = Convert.ToString(count);
                    richTextBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            label5.Text = "";
        }
    }
}