namespace AppHelloWorld.Services.RequestProvider
{
    public interface IRequestProvider
    {
        Task<TSend> PostAsync<TSend>(string uri, TSend data, string token = "");
    }
}
