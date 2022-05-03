using _101.Enums;
using _101.Models;
using System.Collections.Generic;

namespace _101.Dictionaries
{
    public static class VersionGameDictionary
    {
        public static Dictionary<VersionGameEnum, VersionGameSettingsModel> VersionGame = new Dictionary<VersionGameEnum, VersionGameSettingsModel>
        {
            { VersionGameEnum.Extended, new VersionGameSettingsModel { CloseToTheLimit = 180, ExceededLimit = 202, HalfReset = 200, Reset = 202 } },
            { VersionGameEnum.Standart, new VersionGameSettingsModel { CloseToTheLimit = 80, ExceededLimit = 101, HalfReset = 100, Reset = 101 } }
        };
    }
}
