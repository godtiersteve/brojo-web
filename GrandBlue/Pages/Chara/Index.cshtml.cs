using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using GrandBlue.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrandBlue
{
    public class CharaModel : PageModel
    {        
        public MoveList MoveList { get; set; }
        public Character Character { get; set; }
        public void OnGet()
        {
            MoveList = new MoveList();
            Character = new Character();
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=wwwroot\db\db.db;New=False");
            conn.Open();

            string selectText = @"SELECT * FROM MoveList ORDER BY SortID ASC";
            string charSelect = @"SELECT * FROM Characters";
            SQLiteCommand selectCmd = conn.CreateCommand();
            selectCmd.CommandText = selectText;
            SQLiteDataAdapter da;
            DataTable dt = new DataTable();
            da = new SQLiteDataAdapter(selectCmd);
            da.Fill(dt);
            foreach(DataRow r in dt.Rows)
            {
                MoveList.ListOfMoves.Add(new Move(r));
            }

            SQLiteCommand charSelectCmd = conn.CreateCommand();
            charSelectCmd.CommandText = charSelect;
            SQLiteDataAdapter chrDa = new SQLiteDataAdapter(charSelectCmd);
            DataTable charDt = new DataTable();
            chrDa.Fill(charDt);
            if(charDt.Rows.Count > 0) {
                Character = new Character(charDt.Rows[0]);
            }
            

        }
    }
}
