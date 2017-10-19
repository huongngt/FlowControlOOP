using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Flow_String
{
    public class MenuItem
    {
        public string option;
        public Action RelatedAction { get; set; }
        public string Description;

        public void ExecuteEntry()
        {
            RelatedAction.Invoke();
        }
    }
}
