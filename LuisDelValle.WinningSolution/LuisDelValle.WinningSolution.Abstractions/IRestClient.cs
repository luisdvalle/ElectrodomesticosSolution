using System.Collections.Generic;
using System.Threading.Tasks;

namespace LuisDelValle.WinningSolution.Abstractions
{
    public interface IRestClient<T>
    {
        string Host { get; set; }
        string Path { get; set; }

        Task<T> GetResponseAsync();
    }
}
