using System.IO;
using System.Xml.Serialization;

public class BackupConfig
{
    public string Origem { get; set; }
    public string Destino { get; set; }
    public int DiasDeRetencao { get; set; }

    public void Save(string filePath)
    {
        var serializer = new XmlSerializer(typeof(BackupConfig));
        using (var writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, this);
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
