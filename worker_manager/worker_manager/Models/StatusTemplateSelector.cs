using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace worker_manager.Models
{
    public class StatusTemplateSelector:DataTemplateSelector
    {
        public DataTemplate InputCanget { get; set; }
        public DataTemplate ExitChanget { get; set; }
        
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            GlobalPersone persone = item as GlobalPersone;
            if(persone ==null)
            {
                return base.SelectTemplate(item, container);
            };
            if(persone.PersonStatus==ChangetStatus.PersonStatus.Input)
            {
                return InputCanget;
            }
            else
            {
                return ExitChanget;
            }
        }
    }
}
