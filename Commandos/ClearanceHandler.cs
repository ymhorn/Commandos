using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal static class ClearanceHandler
    {
        public static string GetName(string commanderRank, string name, string codeName)
        {
            if (commanderRank == "General")
            {
                return name;
            }
            else if (commanderRank == "Colonel")
            {
                return codeName;
            }
            else
            {
                return "Sorry, this is clasified information.";
            }
        }
    }
}
