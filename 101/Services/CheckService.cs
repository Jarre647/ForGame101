using _101.Dictionaries;
using _101.Models;
using System.Threading.Tasks;

namespace _101.Services
{
    static class CheckService
    {
        public static async Task<int> Check(ScorePlayerModel player)
        {
            if (player.Score > VersionGameDictionary.VersionGame[player.VersionGame].ExceededLimit)
            {
                await PronounceService.RunPronounce(Enums.Instance.ExceededLimit, player.Name);
                return player.Score;
            }
            if (player.Score == VersionGameDictionary.VersionGame[player.VersionGame].Reset)
            {
                await PronounceService.RunPronounce(Enums.Instance.Reset, player.Name);
                return 0;
            }
            if (player.Score == VersionGameDictionary.VersionGame[player.VersionGame].HalfReset)
            {
                await PronounceService.RunPronounce(Enums.Instance.HalfReset, player.Name);
                return player.Score / 2;
            }
            if (player.Score > VersionGameDictionary.VersionGame[player.VersionGame].CloseToTheLimit)
            {
                await PronounceService.RunPronounce(Enums.Instance.CloseToTheLimit, player.Name);
                return player.Score;
            }          
            return player.Score;
        }
    }
}
