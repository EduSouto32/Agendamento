using System;
using System.IO;

public class Logger
{
    private readonly string _logPath;

    public Logger(string logPath)
    {
        _logPath = logPath;
        // Verifica se a pasta do log existe, se não, cria
        string logDirectory = Path.GetDirectoryName(logPath);
        if (!Directory.Exists(logDirectory))
        {
            Directory.CreateDirectory(logDirectory);
        }
    }

    public void AdicionarLog(string mensagem, bool sucesso = true)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(_logPath, true))
            {
                string tipoMensagem = sucesso ? "SUCESSO" : "ERRO";
                writer.WriteLine($"[{DateTime.Now}] [{tipoMensagem}] {mensagem}");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao adicionar log: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
