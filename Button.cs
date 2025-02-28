using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    public delegate void ClickHandler();

    
    class Button
    {
        public event ClickHandler OnClick; 

        
        public void Click()
        {
            Console.WriteLine("Button is Clicked!");
            OnClick?.Invoke(); 
        }
    }
}