using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace GrandBlue.Models
{
    public class FrameDataList
    {
        private List<FrameData> mFrameDataList;
        private string mHeadingName;
        private string mSearchTerm;
        private string mCharCode;
        public List<FrameData> FrameData
        {
            get {
                return mFrameDataList;
            } set {
                mFrameDataList = value;
            }
        }
        public string HeadingName {
            get { 
                return mHeadingName; 
            } set { 
                mHeadingName = value; 
            } 
        }
        public string SearchTerm {
            get { 
                return mSearchTerm; 
            } set { 
                mSearchTerm = value; 
            }
        }
        public string CharacterCode
        {
            get {
                return mCharCode;
            } set {
                mCharCode = value;
            }
        }
        public FrameDataList()
        {
            mFrameDataList = new List<FrameData>();
        }
        public FrameDataList(SQLiteCommand cmd, string heading) {
            mHeadingName = heading;
            mFrameDataList = GetFrameDataList(cmd);
        }
        static private DataTable GetFrameDataTable(SQLiteCommand cmd)
        {
            SQLiteDataAdapter da;
            DataTable dt = new DataTable();
            da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        static private void PopulateList(List<FrameData> l, DataTable dt)
        {
            foreach (DataRow r in dt.Rows)
            {
                FrameData d = new FrameData();
                d.MoveID = (long)r["MoveID"];  
                d.MoveName = (string)r["MoveName"];
                d.Startup = (string)r["Startup"];
                d.Active = (string)r["Active"];
                d.Recovery = (string)r["Recovery"];
                d.OnBlock = (string)r["OnBlock"];
                d.OnHit = (string)r["OnHit"];
                d.Damage = (string)r["Damage"];
                d.GuardType = (string)r["GuardType"];
                d.CharacterID = (string)r["CharacterID"];
                d.PatchVersion = (string)r["PatchVersion"];
                d.SortID = (long)r["SortID"];
                d.AttackLevel = (string)r["AttackLevel"];
                d.Notes = (string)r["Notes"];
                d.MoveType = (string)r["MoveType"];
                d.Version = (string)r["Version"];
                d.ButtonID = r["ButtonID"] == DBNull.Value ? "" : (string)r["ButtonID"];
                l.Add(d);
            }
        }
        static private List<FrameData> GetFrameDataList(SQLiteCommand cmd)
        {
            List<FrameData> list = new List<FrameData>();
            PopulateList(list, GetFrameDataTable(cmd));
            return list;
        }
        static public List<FrameData> GenerateFrameDataList(SQLiteCommand cmd)
        {
            return GetFrameDataList(cmd);
        }
    }
}
