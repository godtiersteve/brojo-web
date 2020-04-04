using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GrandBlue.Models
{
    public class Character
    {
        public string CharacterID { get; set; }
        public string Name { get; set; }
        public long Stamina { get; set; }
        public long Prejump { get; set; }
        public long Backdash { get; set; }
        public string Description { get; set; }

        public Character(DataRow dr = null)
        {
            if(dr != null)
            {
                CharacterID = dr["CharacterID"] == DBNull.Value ? "" : (string)dr["CharacterID"];
                Name = dr["Name"] == DBNull.Value ? "" : (string)dr["Name"];                
                Stamina = dr["Stamina"] == DBNull.Value ? 0 : (long)dr["Stamina"];
                Prejump = dr["Prejump"] == DBNull.Value ? 0 : (long)dr["Prejump"];
                Backdash = dr["Backdash"] == DBNull.Value ? 0 : (long)dr["Backdash"];
                Description = dr["Description"] == DBNull.Value ? "" : (string)dr["Description"];

            }
        }
    }
}
