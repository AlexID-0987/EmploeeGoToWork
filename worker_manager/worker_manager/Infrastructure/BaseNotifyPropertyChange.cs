using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//Створюємо ітфраструктуру для сповіщення
namespace worker_manager.Infrastructure
{
    class BaseNotifyPropertyChange:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyOfPropertyChanged([CallerMemberName]string propertyName = " ")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
