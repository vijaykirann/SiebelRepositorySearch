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
                case "Applet Control User Property": array[0] = "Applet Control User Property Value"; array[1] = "Applet"; array[2] = "Control Name"; array[3] = "Cntrl User Prop"; array[4] = "Cntrl User Prop Val"; break;
                case "Applet Dynamic Drilldown Destination": array[0] = "Applet Dynamic Drilldown Destination"; array[1] = "Applet"; array[2] = " Drilldown"; array[3] = " Dynamic Drilldown Destination"; array[4] = " Dynamic Drilldown Destination Value"; break;
                case "Applet Browser Script": array[0] = "Applet Browser Script"; array[1] = "Applet"; array[2] = " Browser Script Method"; array[3] = ""; array[4] = ""; break;
                case "Applet Search Spec": array[0] = "Applet Search Spec"; array[1] = "Applet"; array[2] = "Applet Search Spec"; array[3] = ""; array[4] = ""; break;
                case "Applet Server Script": array[0] = "Applet Server Script"; array[1] = "Applet"; array[2] = " Server Script Method"; array[3] = ""; array[4] = ""; break;
                case "Applet User Property": array[0] = "Applet User Property Value"; array[1] = "Applet"; array[2] = " User Property"; array[3] = "User Property Value"; array[4] = ""; break;
                case "Applet List Column User Property": array[0] = "Applet List Column User Property"; array[1] = "Applet"; array[2] = "List Coloumn"; array[3] = "List Column User Property"; array[4] = "List Column User Property Value"; break;
                case "Applet List Column User Property Value": array[0] = "Applet List Column User Property Value"; array[1] = "Applet"; array[2] = "List Coloumn"; array[3] = "List Column User Property"; array[4] = "List Column User Property Value"; break;
                default:
                    array[0] = "Default";
                    break;
            }

            return array;
        }
    }
}
