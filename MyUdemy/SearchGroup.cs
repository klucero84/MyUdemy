using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyUdemy
{
    //need to notify list when a search is deleted from SearchGroup, 
    //so a ObservableCollection is used instead of a List
    public class SearchGroup : ObservableCollection<Search>
    {
        public string Title { get; set; }
        public SearchGroup(string title, IEnumerable<Search> searches = null)
        :base (searches)
        {
            Title = title;
        }
    }
}
