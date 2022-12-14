namespace lab7._1_graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            str = textBox1.Text;
            int index1, index2;
            string str1, str2, result;
            if (String.IsNullOrEmpty(str))
            {
                MessageBox.Show("Пустая строка!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!str.Contains("(") || !str.Contains(")"))
            {
                MessageBox.Show("Строка не содержит круглых скобок", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            else
            {
                textBox2.Text += ("Исходная строка: " + str) + Environment.NewLine;

                index1 = str.IndexOf("("); //индекс круглых скобок
                index2 = str.IndexOf(")");
                str1 = str.Substring(0, index1 + 1); //извлекает подстроку из данного экземпляра
                str2 = str.Substring(index2);
                result = str1 + str2;
                textBox2.Text += ("Измененная строка: " + result);
            }

        }
    }
}