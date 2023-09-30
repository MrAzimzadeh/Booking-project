
using CorePackage.Core.DataAcces.MongoDB.MongoSettings;
using CorePackage.Entities.Abstract;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CorePackage.Core.DataAcces.MongoDB.Concrete
{
    public class MongoRepository<TDocument> : IMongoRepository<TDocument>
        where TDocument : class, IEntity
    {
        private readonly IMongoCollection<TDocument> _collection;

        private protected string GetCollectionName(Type documentType)
        {
            return ((BsonCollectionAttribute)documentType.GetCustomAttributes(typeof(BsonCollectionAttribute), true).FirstOrDefault())?.CollectionName;
        }
        public MongoRepository(IDatabseSettings databseSettings)
        {
            var database = new MongoClient("mongodb+srv://azimzada:baku2022@cluster0.woltrzy.mongodb.net/?retryWrites=true&w=majority&appName=AtlasApp").GetDatabase("CatalogServiceDB");
            _collection = database.GetCollection<TDocument>(GetCollectionName(typeof(
                TDocument)));
        }

        public List<TDocument> GetAll()
        {

            return _collection.Find(FilterDefinition<TDocument>.Empty).ToList();
        }

        public TDocument Get(string id)
        {
            var filter = Builders<TDocument>.Filter.Eq("_id", ObjectId.Parse(id));

            return _collection.Find(filter).FirstOrDefault();
        }

        public void Add(TDocument model)
        {
            //  Bu Mongo DB nin _contexti Kimi bir seydir!!!
            _collection.InsertOne(model);
        }
        public void Update(string id, TDocument entity)
        {
            // Id NI TAPIB 
            var filter = Builders<TDocument>.Filter.Eq("_id", ObjectId.Parse(id));

            // uPDATE eDIR 
            _collection.ReplaceOne(filter, entity);
        }

        public void Remove(string id)
        {
            // Id NI TAPIB 
            var filter = Builders<TDocument>.Filter.Eq("_id", ObjectId.Parse(id));

            // uPDATE eDIR 
            _collection.DeleteOne(filter);
        }
    }
}
