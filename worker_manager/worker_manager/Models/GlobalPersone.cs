using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Клас виглядає завеликим, але хотів застосувати парадігму інкапсуляції.

namespace worker_manager.Models
{
    class GlobalPersone
    {
      
        private int Id;
        private string Name;
        private string Adress;
        private string BirthDay;
        private string Phone;
        private double Salary;
        private string Input;
        private string Exit;
        
        public int ID
        {
            get { return Id; }
            set
            {
                if(value!=0)
                {
                    Id = value;
                }
                else
                {
                    Id = 555;
                }
            }
        }
        public string NAME
        {
            get { return Name; }
            set
            {
                if (value != null)
                {
                    Name = value;
                    
                }
                else
                {
                    Name = null;
                }
            }
        }
        public string ADRESS
        {
            get { return Adress; }
            set
            {
                if (value != null)
                {
                    Adress = value;
                }
                else
                {
                    Adress = null;
                }
            }
        }
        public string BIRTHDAY
        {
            get { return BirthDay; }
            set
            {
                if (value != null)
                {
                    BirthDay = value;
                }
                else
                {
                    BirthDay = null;
                }
            }
        }

        public string PHONE
        {
            get { return Phone; }
            set
            {
                if (value != null)
                {
                    Phone = value;
                }
                else
                {
                    Phone = null;
                }
            }
        }
        
        public double SALARY
        {
            get { return Salary; }
            set
            {
                if (value != 0.0)
                {
                    Salary = value;
                }
                else
                {
                    Salary = 0.34;
                }
            }
        }
        public ChangetPozition.PersonPozition PersonPozition { get; set; }
        public ChangetStatus.PersonStatus PersonStatus { get; set; }
        public string INPUT
        {
            get { return Input; }
            set
            {
                if (value != null)
                {
                    Input = value;
                }
                else
                {
                    Input = null;
                }
            }
        }
        public string EXIT
        {
            get { return Exit; }
            set
            {
                if (value != null)
                {
                    Exit = value;
                }
                else
                {
                    Exit = null;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
