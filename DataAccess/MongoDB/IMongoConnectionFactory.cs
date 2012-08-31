using MongoDB.Driver;

namespace BasicMVC4.DataAccess.MongoDB
{
    public interface IMongoConnectionFactory
    {
        MongoDatabase Create();
    }
}