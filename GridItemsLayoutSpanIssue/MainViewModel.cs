using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridItemsLayoutSpanIssue
{
    public class MainViewModel
    {
        public List<string> Items { get; set; }
        public MainViewModel()
        {
            Items = new List<string>()
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };
        }
    }
}
