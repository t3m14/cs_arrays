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
                        Convert.ToInt32(el);
                    }
                }
                catch
                {
                    MessageBox.Show("������ �����, ��������� ������������ �������� ������!");
                }
                if (!is_err)
                {

                    // �������� ������ ����� ���� �� richTextBox1
                    string[] arr = richTextBox1.Text.Split('\n');

                    int count = 0;

                    for (int i = 1; i < arr.Length - 1; i++)
                    {
                        if (Convert.ToInt32(arr[i]) > Convert.ToInt32(arr[i - 1]) && Convert.ToInt32(arr[i]) > Convert.ToInt32(arr[i + 1]))
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
                MessageBox.Show("��������� ��� ����!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            label5.Text = "";
        }
    }
}