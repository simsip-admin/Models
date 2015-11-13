using Models.Models;
using Refit;
using System.Threading.Tasks;
using Models.Models.Methods.Channels;

namespace Models.Services
{
    public interface ISlackChannels
    {
        // https://slack.com/api/channels.list
        [Get("/channels.list")]
        Task<ChannelsListResponse> GetChannels(string token = "");
    }
}
