using System;
using System.IO;
using System.Xml.Serialization;

public class BackupConfig
{
    public string Origem { get; set; }
    public string Destino { get; set; }
    public int DiasDeRetencao { get; set; }
    public int Horas { get; set; }
    public int Minutos { get; set; }

    public void Save(string filePath)
    {
        var serializer = new XmlSerializer(typeof(BackupConfig));

        // Criar um temporário para armazenar os valores formatados
        var configFormatted = new BackupConfig
        {
            Origem = this.Origem,
            Destino = this.Destino,
            DiasDeRetencao = this.DiasDeRetencao,
            Horas = this.Horas,
            Minutos = this.Minutos
        };

        using (var writer = new StreamWriter(filePath))
        {
            writer.WriteLine($"<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            writer.WriteLine($"<BackupConfig xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">");
            writer.WriteLine($"  <Origem>{configFormatted.Origem}</Origem>");
            writer.WriteLine($"  <Destino>{configFormatted.Destino}</Destino>");
            writer.WriteLine($"  <DiasDeRetencao>{configFormatted.DiasDeRetencao}</DiasDeRetencao>");
            writer.WriteLine($"  <Horas>{configFormatted.Horas:D2}</Horas>");
            writer.WriteLine($"  <Minutos>{configFormatted.Minutos:D2}</Minutos>");
            writer.WriteLine($"</BackupConfig>");
        }
    }

    public static BackupConfig Load(string filePath)
    {
        var serializer = new XmlSerializer(typeof(BackupConfig));
        using (var reader = new StreamReader(filePath))
        {
            return (BackupConfig)serializer.Deserialize(reader);
        }
    }
}
