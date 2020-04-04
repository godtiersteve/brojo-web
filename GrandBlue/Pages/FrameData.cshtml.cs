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
    public class FrameDataModel : PageModel
    {        
        public List<FrameDataList> FrameDataLists { get; set; }
        public void OnGet()
        {
            FrameDataLists = new List<FrameDataList>();

            string normalSelect = @"SELECT * FROM FrameData WHERE CharacterID = @charID AND MoveType = 'N' ORDER BY SortId ASC";
            string specialSelect = @"SELECT * FROM FrameData WHERE CharacterID = @charID AND MoveType = 'S' ORDER BY SortId ASC";
            string throwSelect = @"SELECT * FROM FrameData WHERE CharacterID = @charID AND MoveType = 'T' ORDER BY SortId ASC";
            string uniqueSelect = @"SELECT * FROM FrameData WHERE CharacterID = @charID AND MoveType = 'U' ORDER BY SortId ASC";
            string superSelect = @"SELECT * FROM FrameData WHERE CharacterID = @charID AND (MoveType = 'SBA' OR MoveType = 'SSBA') ORDER BY SortId ASC";
            string autoSelect = @"SELECT * FROM FrameData WHERE CharacterID = @charID AND MoveType = 'A' ORDER BY SortId ASC";

            SQLiteConnection conn = new SQLiteConnection(@"Data Source=wwwroot\db\db.db;New=False");
            conn.Open();

            SQLiteCommand normalCmd = conn.CreateCommand();
            normalCmd.CommandText = normalSelect;
            normalCmd.Parameters.AddWithValue("@charID", RouteData.Values["chara"]);

            SQLiteCommand specialCmd = conn.CreateCommand();
            specialCmd.CommandText = specialSelect;
            specialCmd.Parameters.AddWithValue("@charID", RouteData.Values["chara"]);

            SQLiteCommand throwCmd = conn.CreateCommand();
            throwCmd.CommandText = throwSelect;
            throwCmd.Parameters.AddWithValue("@charID", RouteData.Values["chara"]);

            SQLiteCommand uniqueCmd = conn.CreateCommand();
            uniqueCmd.CommandText = uniqueSelect;
            uniqueCmd.Parameters.AddWithValue("@charID", RouteData.Values["chara"]);

            SQLiteCommand superCmd = conn.CreateCommand();
            superCmd.CommandText = superSelect;
            superCmd.Parameters.AddWithValue("@charID", RouteData.Values["chara"]);

            SQLiteCommand autoCmd = conn.CreateCommand();
            autoCmd.CommandText = autoSelect;
            autoCmd.Parameters.AddWithValue("@charID", RouteData.Values["chara"]);

            FrameDataLists.Add(new FrameDataList(normalCmd, "Normal Moves"));
            FrameDataLists.Add(new FrameDataList(specialCmd, "Special Moves"));
            FrameDataLists.Add(new FrameDataList(throwCmd, "Throws"));
            FrameDataLists.Add(new FrameDataList(uniqueCmd, "Unique Actions"));
            FrameDataLists.Add(new FrameDataList(superCmd, "Skybound Arts"));
            FrameDataLists.Add(new FrameDataList(autoCmd, "Auto-Combos"));
        }
    }
}