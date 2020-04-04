using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrandBlue.Models
{
    public class MoveList
    {
        public List<Move> ListOfMoves { get; set; }
        public MoveList()
        {
            ListOfMoves  = new List<Move>();
        }
    }
}
