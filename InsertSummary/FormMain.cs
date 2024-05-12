using System.Text.RegularExpressions;

namespace InsertSumury
{
    public partial class FormMain : Form
    {
        private Dictionary<int, string> dict_origin;
        private Dictionary<int, string> dict_summary;
        private const string path_summuries = ".\\..\\..\\..\\..\\resumos_politicas.csv";
        private const string path_texts = ".\\..\\..\\..\\..\\textos_politicas.csv";

        public FormMain()
        {
            InitializeComponent();
            dict_origin = [];
            dict_summary = [];
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dict_origin = CsvDataMapper.FromCsvToDict(path_texts);
            if (File.Exists(path_summuries))
                dict_summary = CsvDataMapper.FromCsvToDict(path_summuries);
        }

        private void Button_Find_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_id.Text, out int id))
            {
                textBox_original.Text = dict_origin[id];
                textBox_summary.Text = dict_summary[id];
            }
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_id.Text, out int id))
            {
                int maxId = 0; 
                foreach (var item in dict_origin.Keys)
                    if (item > maxId) maxId = item;
                id++;
                for (int i = id; i < maxId; i++)
                {
                    if (dict_origin.TryGetValue(i, out string? value1))
                    {
                        textBox_id.Text = i.ToString();
                        textBox_original.Text = value1;
                        if (dict_summary.TryGetValue(i, out string? value2))
                            textBox_summary.Text = value2;
                        else
                            dict_summary[i] = textBox_summary.Text = "";
                        break;
                    }
                }
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_id.Text, out int id))
            {
                dict_summary[id] = textBox_summary.Text;
                CsvDataMapper.SaveDictToCsv(dict_summary, path_summuries);
            }
        }

        private void TextBox_Id_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.Text = Regex.Replace(textBox.Text, "[^0-9]", "");
                textBox.SelectionStart = textBox.Text.Length;
            }
            if (textBox_id.Text == "")
            {
                textBox_original.Text = "";
                textBox_summary.Text = "";
            }
        }
    }
}
