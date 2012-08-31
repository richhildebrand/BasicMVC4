using System.IO;

namespace BasicMVC4.Infrastructure
{
    public interface ISerializationProvider
    {
        byte[] Serialize<T>(T obj);

        T Deserialize<T>(byte[] bytes);

        T Deserialize<T>(Stream stream);
    }
}
