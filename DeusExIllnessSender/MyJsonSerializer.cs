using System.IO;
using Newtonsoft.Json;

namespace DeusExIllnessSender
{
  internal class MyJsonSerializer : JsonSerializer
  {
    private static MyJsonSerializer DefaultSerializer { get; } = new MyJsonSerializer();

    public static string SerializeToJsonString(object data)
    {
      if (data == null)
        return null;

      var stringWriter = new StringWriter();
      DefaultSerializer.Serialize(stringWriter, data);
      return stringWriter.ToString();
    }

    public static TDataType DeserializeJson<TDataType> ( string data) where TDataType : class
    {
      if (string.IsNullOrEmpty(data))
        return null;

      var reader = new StringReader(data);
      return (TDataType)DefaultSerializer.Deserialize(reader, typeof(TDataType));
    }

    private MyJsonSerializer()
    {
      MissingMemberHandling = MissingMemberHandling.Ignore;
      NullValueHandling = NullValueHandling.Include;
      TypeNameHandling = TypeNameHandling.None;
    }
  }
}
