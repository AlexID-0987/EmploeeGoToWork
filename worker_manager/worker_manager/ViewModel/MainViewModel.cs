using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using worker_manager.Models;

namespace worker_manager.ViewModel
{
    class MainViewModel
    {
        public ObservableCollection<GlobalPersone> globalPeople { get; set; }
        public StatusTemplateSelector StatusTemplateSelector;
        public string SelectedString { get; set; }
        public MainViewModel()
        {
            globalPeople = new ObservableCollection<GlobalPersone>(Persone.GetPeople());
            
        }
    }
}
