using System;
using System.Threading.Tasks;
namespace MacApi1.Models
{
    public interface IHubClient
    {
        Task BroadcastMessage();
    }
}
