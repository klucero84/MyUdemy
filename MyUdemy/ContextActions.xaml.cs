using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MyUdemy
{
    public partial class ContextActions : ContentPage
    {
        //using observable collections will notify listview of changes to the list
        //and refresh itself
        private ObservableCollection<Employee> _employees;
       
        public ContextActions()
        {
            InitializeComponent();
            _employees = new  ObservableCollection<Employee>{
               new Employee { Name = "john", Status = "Hello" },
				 new Employee { Name = "Jay", Status = "Hello" }
            };

            listView.ItemsSource = _employees;
                
        }
        void Call_Clicked(object sender, System.EventArgs e)
		{
            //gets us reference to the item
            var menuItem = sender as MenuItem;
            var employee = menuItem.CommandParameter as Employee;

            DisplayAlert("Call",employee.Name, "OK");
		}

        void Delete_Clicked(object sender, System.EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Employee;
            _employees.Remove(contact);
        }
    }
}
