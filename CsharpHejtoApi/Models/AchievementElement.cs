using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class AchievementElement
    {
        public AchievementAchievement? achievement { get; set; }
        public DateTime? createdAt { get; set; }
    }
}
