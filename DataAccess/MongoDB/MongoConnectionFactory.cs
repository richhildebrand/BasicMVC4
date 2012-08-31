using MongoDB.Driver;

namespace BasicMVC4.DataAccess.MongoDB
{
    public class MongoConnectionFactory : IMongoConnectionFactory
    {
        private readonly string connectionString;

        public MongoConnectionFactory(string connectionString)
        {
            //this.connectionString = connectionString;
           this.connectionString = "mongodb://appharbor_84fa7eec-c589-43d6-8103-818c9826dea6:lmld4hk90707gti16pvogpp46k@ds037407-a.mongolab.com:37407/appharbor_84fa7eec-c589-43d6-8103-818c9826dea6";
        }

        public MongoDatabase Create()
        {
            return MongoDatabase.Create(connectionString);
        }
    }
}