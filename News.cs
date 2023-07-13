using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSNews
{
    internal class News
    {
        public string link { get; set; }    
        public string title { get; set; }   
        public string desc { get; set; }

        public override string ToString()
        {
            return this.title;
        }
    }
}
