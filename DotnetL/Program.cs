
// Replace the placeholder with your Atlas connection string
using MongoDB.Bson;
using MongoDB.Driver;

const string connectionUri = "mongodb+srv://rubayethasanyasin1:O9tOMY0JrFMIqFBN@cluster0.f3udoep.mongodb.net/?retryWrites=true&w=majority";
var settings = MongoClientSettings.FromConnectionString(connectionUri);
// Set the ServerApi field of the settings object to Stable API version 1
settings.ServerApi = new ServerApi(ServerApiVersion.V1);
// Create a new client and connect to the server
var client = new MongoClient(settings);
// Send a ping to confirm a successful connection
try
{
    var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
    Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");

    var collection = client.GetDatabase("Books").GetCollection<BsonDocument>("book");

    var filter = Builders<BsonDocument>.Filter.Empty;

    var documents = collection.Find(filter).ToString();

    foreach (var document in documents)
    {
        Console.WriteLine(document);
    }
}
catch (Exception ex) { Console.WriteLine(ex); }


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
