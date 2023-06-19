using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearsProjectResch
{
    internal class CountryNameHelp
    {
        //So with this class I can get the continentname and the Tag of the Button (which is the ID) from every continent, and then I can use it
        //wisely by my ShowContinentInfo Form, so that its easier, and that I can close my forms ecetera. 
        public static string continentname;
        private static string Continentname
        {
            get; set;
        }

        public static string bTag;
        private static string BTag
        {
            get; set;
        }
    }
}
