using System;
using Microsoft.AspNetCore.SignalR;
namespace MacApi1.Models
{
    public class BroadcastHub : Hub<IHubClient>
    {
        public BroadcastHub()
        {
        }
    }
}
