namespace lab7._2_graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string[] s = str.Split(); // разбивает начальную строку на массив строк
            int x;
            string t = " ";

            int n = 0;
            try
            {
                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Количество повторений не может иметь отрицательное или нулевое значение!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат ввода данных!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
                n = (int)numericUpDown1.Value;
            bool flag = false;

            for (int i = 0; i < s.Length; i++)
            {
                x = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        x++;
                    }

                    if (x > n)
                    {
                        t = s[j];
                        flag = true;
                    }
                }
            }
            if (flag == false)
            {
                textBox2.Text += ($"Повторяющихся более {n} раз слов нет!") + Environment.NewLine;

            }
            else
            {
                textBox2.Text += ("Слово повторяется более " + n + " раз: ") + Environment.NewLine;
                textBox2.Text += (t) + Environment.NewLine;
            }
        }
    }
}