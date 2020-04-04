using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrandBlue.Data
{
    public class Properties
    {
        static public string GetButtonURL(string id)
        {
            switch(id)
            {
                case "L":
                    return @"/images/GBVS_L_Button.png";
                case "M":
                    return @"/images/GBVS_M_Button.png";
                case "H":
                    return @"/images/GBVS_H_Button.png";
                case "U":
                    return @"/images/GBVS_U_Button.png";
                default:
                    return "";
            }            
        }
        static public string GetEmbedURL(string link)
        {
            if(link.Contains("twitter.com"))
            {                
                return "https://publish.twitter.com/oembed?url=" + link + "&callback=?";
            }
            else if(link.Contains("youtube.com"))
            {
                return "https://noembed.com/embed?url=" + link;
            }
            return "";
        }

        static public string GetMoveClass(string s)
        {
            switch(s)
            {
                case "U":
                    return "unique";
                case "S":
                    return "special";
                case "SBA":
                    return "sba";
                case "SSBA":
                    return "ssba";
                default:
                    return "";
            }
        }
    }
}
