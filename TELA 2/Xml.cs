using System;
using System.IO;
using System.Xml.Serialization;

public class BackupConfig
{
    public string Origem { get; set; }
    public string Destino { get; set; }
    public int DiasDeRetencao { get; set; }
}

public class Agenda
{
    public int Horas { get; set; }
    public int Minutos { get; set; }
}

[XmlRoot("ConfigWrapper")]
public class ConfigWrapper
{
    public BackupConfig BackupConfig { get; set; }
    public Agenda Agenda { get; set; }

    public void Save(string filePath)
    {
        var serializer = new XmlSerializer(typeof(ConfigWrapper));
        using (var writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, this);
        }
    }

    public static ConfigWrapper Load(string filePath)
    {
        var serializer = new XmlSerializer(typeof(ConfigWrapper));
        using (var reader = new StreamReader(filePath))
        {
            return (ConfigWrapper)serializer.Deserialize(reader);
        }
    }
}
