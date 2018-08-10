using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SerializationRepository
{
    /*
     設立介面將 Xml 及 Json Serializabl Method分別實作
     方便未來需求進行抽換
         */
    /// <summary>
    /// XmlSerializable or JsonSerializable.
    /// </summary>
    public interface ISerializer
{
    string Serialize(object o);
    List<T> Deserialize<T>(string s);
    //T Deserialize<T>(string s); // TODO 單一類別序列化，依後續有需求再實作
    bool SerializeToFile(object o, string path);
    List<T> SerializeFromFile<T>(string path);
}
#region XmlSerializable
public class XmlSerializable : ISerializer
{
    private XmlSerializer _XmlSerializer;
    public XmlSerializable(XmlSerializer _XmlSerializer)
    {
        this._XmlSerializer = _XmlSerializer;
    }
    public string Serialize(object o)
    {
        StringBuilder sb = new StringBuilder();
        StringWriter writer = new StringWriter(sb);
        _XmlSerializer.Serialize(writer, o);
        return sb.ToString();
    }

    public List<T> Deserialize<T>(string s)
    {
        XmlDocument xdoc = new XmlDocument();
        try
        {
            xdoc.LoadXml(s);
            XmlNodeReader reader = new XmlNodeReader(xdoc.DocumentElement);
            object obj = _XmlSerializer.Deserialize(reader);

            return (List<T>)obj;
        }
        catch
        {
            return default(List<T>);
        }
    }

    public bool SerializeToFile(object o, string path)
    {
        try
        {
            string content = Serialize(o);
            using (var writer = new StreamWriter(path, false))
            {
                writer.Write(content);
                writer.Close();
            }
            return true;
        }
        catch (Exception ex) { /*Log Here or Throw Custom Exception.*/ }
        return false;
    }

    public List<T> SerializeFromFile<T>(string path)
    {
        using (var reader = new StreamReader(path))
        {
            return Deserialize<T>(reader.ReadToEnd());
        }
    }
}
#endregion

#region JsonSerializable
public class JsonSerializable : ISerializer
{
    public JsonSerializable()
    {
        JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };
    }
    public string Serialize(object o)
    {
        return JsonConvert.SerializeObject(o);
    }

    public List<T> Deserialize<T>(string s)
    {
        try
        {
            return JsonConvert.DeserializeObject<List<T>>(s);
        }
        catch
        {
            return default(List<T>);
        }
    }

    public bool SerializeToFile(object o, string path)
    {
        try
        {
            string content = Serialize(o);
            using (var writer = new StreamWriter(path))
            {
                writer.Write(content);
                writer.Close();
            }
            return true;
        }
        catch (Exception ex) { /*Log Here or Throw Custom Exception.*/ }
        return false;
    }

    public List<T> SerializeFromFile<T>(string path)
    {
        FileStream fsFile = new FileStream($@"{path}", FileMode.OpenOrCreate);
        using (var reader = new StreamReader(fsFile))
        {
            return Deserialize<T>(reader.ReadToEnd());
        }
    }
}
#endregion
}
