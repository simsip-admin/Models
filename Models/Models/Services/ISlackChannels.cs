using Models.Models;
using Refit;
using System.Threading.Tasks;


namespace Models.Services
{
    public interface ISlackChannels
    {
        // https://slack.com/api/channels.list
        [Get("/channels.list")]
        Task<ChannelList> GetChannels(string token = "");
    }
}
