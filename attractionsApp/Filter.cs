using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attractionsApp
{
    internal class Filter
    {
        public string bd_name;
        public string name;
        public int checked_;
        public Filter(string bd_name, string name, int checked_)
        {
            this.bd_name = bd_name;
            this.name = name;
            this.checked_ = checked_;
        }
        public string GetFilter()
        {
            if (checked_ == 0)
                return "";
            return $" AND {bd_name} = 1";
        }
    }
}
