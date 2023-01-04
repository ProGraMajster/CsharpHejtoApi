using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHejtoApi.Models
{
    [Serializable]
    public class UserDetailsResponse
    {
        public string? username { get; set; }
        public Avatar? avatar { get; set; }
        public Background? background { get; set; }
        public string? status { get; set; }
        public List<AchievementElement>? achievements { get; set; }
        public Stats? stats { get; set; }
        public Interactions? interactions { get; set; }
        public string? currentRank { get; set; }
        public string? currentColor { get; set; }
        public bool? verified { get; set; }
        public bool? sponsor { get; set; }
        public DateTime? createdAt { get; set; }
        public UserDetailsResponseLinks? links { get; set; }
    }
}
