using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App2
{
    public class MainViewModel
    {
        public ObservableCollection<string> Names { get; set; } = new ObservableCollection<string>();
        public int count = 0;

        public ICommand AddItemCommand { get; set; }
        public MainViewModel()
        {
            AddItemCommand = new Command(AddItems);

        }

        public void AddItems()
        {
            count++;
            Names.Add($"Name #{count}");
            Names.Add("hello");
        }
    }
}
