using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class AchievementAchievement
    {
        public string? name { get; set; }
        public string? slug { get; set; }
        public string? description { get; set; }
        public UserIcon? icon { get; set; }
        public DateTime? createdAt { get; set; }
        public AchievementLinks? links { get; set; }
    }
}
