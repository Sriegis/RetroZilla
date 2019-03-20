using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Retrozilla
{
    public class RetroZillaHub : Hub 
    {
        public async Task PublishComment(string author, string text)
        {
            await Clients.Others.SendAsync("PublishComment", author, text);
        }
    }
}
