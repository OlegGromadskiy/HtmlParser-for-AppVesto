using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HtmlParser_AppVestoTestTask_
{
    class Command : ICommand
    {
        Action<object> execute; 
        public event EventHandler CanExecuteChanged;
        
        public Command(Action<object> action)
        {
            execute = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            execute.Invoke(parameter);
        }
    }
}
