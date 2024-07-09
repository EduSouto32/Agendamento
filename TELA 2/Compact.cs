using System;
using System.IO;
using System.IO.Compression;

public class Compact
{
    private readonly Logger _logger;

    public Compact(Logger logger)
    {
        _logger = logger;
    }

    public void Compactar(string pasta, string destino)
    {
        try
        {
            // Define o nome do arquivo .zip de saída
            string arquivoZip = destino + ".zip";

            // Verifica se a pasta do arquivo zip existe, se não, cria
            string zipDirectory = Path.GetDirectoryName(arquivoZip);
            if (!Directory.Exists(zipDirectory))
            {
                Directory.CreateDirectory(zipDirectory);
            }

            // Compacta a pasta
            ZipFile.CreateFromDirectory(pasta, arquivoZip, CompressionLevel.Optimal, false);
            _logger.AdicionarLog("Pasta compactada com sucesso.");
        }
        catch (Exception ex)
        {
            _logger.AdicionarLog($"Erro ao compactar a pasta: {ex.Message}", sucesso: false);
            MessageBox.Show($"Erro ao compactar a pasta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
