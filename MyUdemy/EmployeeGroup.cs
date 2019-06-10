using System;
using System.Collections.Generic;
namespace MyUdemy
{
    public class EmployeeGroup : List<Employee>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set;  }//iOS list Index, won't work on Android? 
        public EmployeeGroup(string title, string shortTitle)
        {
            Title = title;
            ShortTitle = shortTitle;
        }
    }
}
