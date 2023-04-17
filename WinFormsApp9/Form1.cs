namespace WinFormsApp9
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
                    string[] arr = richTextBox1.Text.Split('\n');
                    for (int i = 0; i < arr.Length - 1; i += 2)
                    {
                        int temp = Convert.ToInt32(arr[i]);
                        arr[i] = arr[i + 1];
                        arr[i + 1] = Convert.ToString(temp);
                    }
                    foreach (string num in arr)
                    {
                        richTextBox1.Text += num + '\n';
                    }


                    richTextBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
    }
}