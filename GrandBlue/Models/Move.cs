using GrandBlue.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GrandBlue.Models
{
    public class Move
    {
        public string Name { get; set; }
        public string Input { get; set; }
        public string Details { get; set; }
        public string Type { get; set; }
        public string CssClass { get; set; }

        public enum MoveType
        {
            Normal,
            Special,
            SBA,
            SSBA
        }
        public void MapData(DataRow d)
        {
            Name = d["Name"] == DBNull.Value ? "" : (string)d["Name"];
            Input = d["Input"] == DBNull.Value ? "" : (string)d["Input"];
            Details = d["Details"] == DBNull.Value ? "" : (string)d["Details"];
            Type = d["Type"] == DBNull.Value ? "" : (string)d["Type"];
            CssClass = Properties.GetMoveClass(Type);
        }
        public Move(DataRow dr = null)
        {
            if(dr != null) {
                MapData(dr);
            }
        }        
    }
}
