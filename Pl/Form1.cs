using BLL;
using DOT;
using Newtonsoft.Json;

namespace Pl
{
    public partial class Form1 : Form
    {
        //BLL����� ����� ����� �
        Funcs f = new Funcs();
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            //����� ����� ����� �� ������ ����� ������- �� ����
            dataGridView1.DataSource = f.findPsukim(textBox1.Text, comboBox1.SelectedIndex);

        }


        //����� ������ ����� �����
        private void button3_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = f.findPsukimForNames(textBox4.Text);

        }

        // ����� ��� ����� �� ������� ���
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = f.listGimatri(textBox2.Text);
        }


        //����� ���� ����� �� ������� ���
        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = f.WordGimatri(textBox2.Text);

        }

        //���� ������� �������
        private void button6_Click(object sender, EventArgs e)
        {
            List<Search> ls = f.showLastSearches();
            dataGridView1.DataSource = ls;
        }

        //����� ������� ������� ����� ������ ���� ������ �� �������
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            LastSearch ls = new LastSearch() { lastSearch = f.lastSearches };
            string updatedJson = JsonConvert.SerializeObject(ls);
            StreamWriter lastSearches = new StreamWriter(@"C:\Users\This User\Desktop\�������\C#\������ ���\FindingProject\BLL\bin\Debug\net7.0\lastSearches.json");
            lastSearches.WriteLine(updatedJson);
            lastSearches.Close();
        }

        //��� ����� �����- ����� ������� ������ ������� �� �������� ��������
        private void Form1_Load(object sender, EventArgs e)
        {
            string Json = File.ReadAllText(@"C:\Users\This User\Desktop\�������\C#\������ ���\FindingProject\BLL\bin\Debug\net7.0\lastSearches.json");
            LastSearch ls = JsonConvert.DeserializeObject<LastSearch>(Json);
            f.lastSearches = ls.lastSearch;

        }

        //���� ������ ������ ���� ������ ���� '����� �����' ������
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //�� ����� ������ ��� ��� ���� '����� �����' ������� ������ �������� ������ 
            if (e.RowIndex < f.lastSearches.Count && (sender as DataGridView).Columns[0].HeaderText == "word")
                dataGridView1.DataSource = f.lastSearches[e.RowIndex].pasuks;

        }

        //����� �� ����� �������� ��������
        private void button2_Click_1(object sender, EventArgs e)
        {
            f.lastSearches.Clear();
        }
    }
}