using System.Text.RegularExpressions;

namespace InsertSumury
{
    internal class CsvDataMapper
    {
        public static Dictionary<int,string> FromCsvToDict(string filePath)
        {
            var dict = new Dictionary<int, string>(100);
            try
            {
                // Verifica se o arquivo existe
                if (File.Exists(filePath))
                {
                    // Abre o arquivo para leitura
                    using var reader = new StreamReader(filePath);
                    int id = -1;
                    // Lê o arquivo linha por linha
                    while (!reader.EndOfStream)
                    {
                        string? line = reader.ReadLine();
                        if (line != null)
                        {
                            // Tratamento pois dados em células são multilinhas
                            // Verifica se realmente é inicio de linha CSV
                            if (Regex.IsMatch(line, @"^\d+,"""))
                            {
                                var values = line.Split(',');
                                if (values.Length > 0)
                                {
                                    if (int.TryParse(values[0], out id))
                                        dict[id] = string.Join(',', values.Skip(1))[1..^1].Replace("\"\"","\"");
                                }
                            }
                            else if (id > 0)
                                dict[id] += line;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao ler o arquivo: " + ex.Message);
            }
            return dict;
        }

        public static void SaveDictToCsv(Dictionary<int, string> dictionary, string filePath)
        {
            try
            {
                using var sw = new StreamWriter(filePath);
                sw.WriteLine("id,summary");
                // Escreve cada par chave-valor como uma linha no arquivo CSV
                foreach (var pair in dictionary)
                {
                    // Substitui aspas duplas por aspas duplas duplicadas
                    var escapedValue = pair.Value.Replace("\"", "\"\"");
                    sw.WriteLine($"{pair.Key},\"{escapedValue}\"");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o arquivo CSV: " + ex.Message);
            }
        }
    }
}
