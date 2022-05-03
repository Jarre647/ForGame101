using _101.Enums;

namespace _101.Models
{
    public class ScorePlayerModel
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public VersionGameEnum VersionGame { get; set; } = VersionGameEnum.Extended;
    }
}
