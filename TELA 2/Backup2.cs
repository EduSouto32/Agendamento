﻿using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

public class Backup2
{
    private readonly string _origem;
    private readonly string _destino;
    private readonly Logger _logger;
    private readonly Compact _compactador;

    public Backup2(string origem, string destino, Logger logger, Compact compactador)
    {
        _origem = origem;
        _destino = destino;
        _logger = logger;
        _compactador = compactador;

        if (!Directory.Exists(_destino))
        {
            Directory.CreateDirectory(_destino);
        }
    }

    public async Task ExecutarBackupAsync(int diasDeRetencao)
    {
        try
        {
            if (!Directory.Exists(_origem))
            {
                _logger.AdicionarLog("Erro ao encontrar a pasta de origem", sucesso: false);
                return;
            }

            string nomeArquivoBackup = $"backup_{DateTime.Now:dd-MM-yyyy}.zip";
            string arquivoZip = Path.Combine(_destino, nomeArquivoBackup);
            await CompactarPastaAsync(_origem, arquivoZip);

            GerenciarHistoricoBackups(diasDeRetencao);
        }
        catch (Exception ex)
        {
            _logger.AdicionarLog($"Erro ao executar backup: {ex.Message}", sucesso: false);
        }
    }

    private async Task CompactarPastaAsync(string pasta, string arquivoZip)
    {
        try
        {
            // Verificar se o arquivo ZIP já existe e excluir se necessário
            if (File.Exists(arquivoZip))
            {
                File.Delete(arquivoZip);
                _logger.AdicionarLog($"Arquivo ZIP existente '{arquivoZip}' excluído.");
            }

            await Task.Run(() => ZipFile.CreateFromDirectory(pasta, arquivoZip, CompressionLevel.Optimal, false));
            _logger.AdicionarLog("Pasta compactada com sucesso.");
        }
        catch (Exception ex)
        {
            _logger.AdicionarLog($"Erro ao compactar a pasta: {ex.Message}", sucesso: false);
        }
    }

    private void GerenciarHistoricoBackups(int dias)
    {
        try
        {
            var arquivosBackup = Directory.GetFiles(_destino, "*.zip")
                                          .Select(f => new FileInfo(f))
                                          .OrderByDescending(f => f.CreationTime)
                                          .ToList();

            DateTime dataAtual = DateTime.Now;
            foreach (var arquivo in arquivosBackup)
            {
                if ((dataAtual - arquivo.CreationTime).TotalDays > dias) // dias de retenção
                {
                    DateTime dataModificacao = arquivo.LastWriteTime; // Obter a data de modificação antes de excluir
                    arquivo.Delete();

                    // Use a data de modificação armazenada para formatação
                    string dataFormatada = dataModificacao.ToString("dd-MM-yyyy");
                    _logger.AdicionarLog($"Backup antigo ({dataFormatada}) removido.");
                }
            }
        }
        catch (Exception ex)
        {
            _logger.AdicionarLog($"Erro ao gerenciar histórico de backups: {ex.Message}", sucesso: false);
        }
    }
}
