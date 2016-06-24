using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    public enum Version
    {
        INVALID = -1,
        VANILLA = 1,
        TBC = 2,
        WOTLK = 3
    }

    class VersionHelper
    {
        public static Version toVersion(string str)
        {
            switch(str)
            {
                case "Vanilla":
                    return Version.VANILLA;
                    break;
                case "The Burning Crusade":
                    return Version.TBC;
                    break;
                case "Wrath of the Lich King":
                    return Version.WOTLK;
                    break;
            }

            return Version.INVALID;
        }
    }
}
