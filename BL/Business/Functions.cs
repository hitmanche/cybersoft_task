using CL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Business
{
    public static class Functions
    {
        public static AliveType GetAliveType(string prmKey)
        {
            switch (prmKey)
            {
                case "1":
                    return AliveType.Enemy;
                case "2":
                    return AliveType.Human;
                case "3":
                    return AliveType.Distance;
            }
            return AliveType.None;
        }

    }
}
