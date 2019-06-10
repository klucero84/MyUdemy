using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;

namespace MyUdemy
{
    public partial class PullToRefresh : ContentPage
    {
        IEnumerable<Employee> GetEmployees(string searchText = null){

           var employees =  new List<Employee>
            {
                new Employee{Name = "Mosh", ImageUrl="http://lorempixel.com/100/100/city"},
                new Employee{Name = "Joke", ImageUrl="http://lorempixel.com/100/100/city"}
            };
            if(String.IsNullOrWhiteSpace(searchText)){
                return employees;
            }
            return employees.Where(c => c.Name.StartsWith(searchText));

        }

        public PullToRefresh()
        {
            InitializeComponent();
            listView.ItemsSource = GetEmployees();
        }

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            listView.ItemsSource = GetEmployees();
            //listView.IsRefreshing = false;
            //OR
            listView.EndRefresh();
        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            listView.ItemsSource = GetEmployees(e.NewTextValue);
        }
    }
}
