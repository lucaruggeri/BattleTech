using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BattleTech.BTCode
{
    public class GraphicUtilities
    {

        public static string SelectCover()
        {
            string cover = "Cover1";

            string[] covers = new string[] {
                "Cover1",
                "Cover2",
                "Cover3",
                "Cover4",
                "Cover5"
            };

            Random random = new Random();
            int randomNumber = random.Next(0, covers.Length); 
            
            return covers[randomNumber];
        }

    }
}