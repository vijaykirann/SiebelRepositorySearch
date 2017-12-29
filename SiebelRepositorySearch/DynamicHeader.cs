using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiebelRepositorySearch
{
    public class DynamicHeader
    {
        
        public string[] DynHeader(string GroupHeader)
        {
            string[] array = new string[5];
            switch (GroupHeader)
            {
                case "Applet User Property Value":array[0] = "Test";

                    break;
                default:
                    array[0] = "Default";
                    break;
            }

            return array;
        }
    }
}
