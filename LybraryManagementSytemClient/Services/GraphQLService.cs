using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using System;
using System.Threading.Tasks;
namespace LybraryManagementSytemClient.Services
{
    

    public class GraphQLService
    {
        private readonly GraphQLHttpClient _client;

        public GraphQLService()
        {
            var uri = new Uri("http://localhost:5146/graphql/");
            _client = new GraphQLHttpClient(uri, new NewtonsoftJsonSerializer());
        }

        public async Task<T> ExecuteQueryAsync<T>(string query)
        {
            var request = new GraphQLRequest { Query = query };
            var response = await _client.SendQueryAsync<T>(request);
            return response.Data;
        }

        public async Task<T> ExecuteMutationAsync<T>(string mutation)
        {
            var request = new GraphQLRequest { Query = mutation };
            var response = await _client.SendMutationAsync<T>(request);
            return response.Data;
        }
    }
}
