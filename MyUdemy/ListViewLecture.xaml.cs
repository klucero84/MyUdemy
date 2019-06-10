using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyUdemy
{
    public partial class ListViewLecture : ContentPage
    {
        public ListViewLecture()
        {
            InitializeComponent();

            employeeListView.ItemsSource = new List<EmployeeGroup>
            {
                new EmployeeGroup("In", "In") {
                new Employee {Name = "Omar", ImageUrl="http://lorempixel.com/100/100/city/1", Status = "Clocked In"},

                },
                new EmployeeGroup("Out", "Out") {
                 new Employee {Name = "Abe", ImageUrl="http://lorempixel.com/100/100/city/5", Status = "Clocked Out"},


                },

                new EmployeeGroup("N/A", "N/A") {
                new Employee {Name = "Joey", ImageUrl="http://lorempixel.com/100/100/city/10", Status = "N/A"}

                }
            };
        }
    }
}
