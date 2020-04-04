using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrandBlue.Models
{
    public class FrameData
    {        
        public int ID { get; set; }
        public long MoveID { get; set; }
        public string MoveName { get; set; }
        public string Startup { get; set; }
        public string Active { get; set; }
        public string Recovery { get; set; }
        public string OnBlock { get; set; }
        public string OnHit { get; set; }
        public string Damage { get; set; }
        public string GuardType { get; set; }
        public string CharacterID { get; set; }
        public string PatchVersion { get; set; }
        public long SortID { get; set; }
        public string AttackLevel { get; set; }
        public string Notes { get; set; }
        public string MoveType { get; set; }
        public string ButtonID { get; set; }
        public string Version { get; set; }
    }
}
