using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Stuff
{
    public class InitiativeClass
    {
        public int initiative;
        public string name;
        
        public void Sortyboy(List<InitiativeClass> classlist)
        {
            
            bool going = false;
            while (going == false)
            {
                going = true;
                for(int i = 0; i < 7; i++)
                {
                    if (classlist[i].initiative < classlist[i + 1].initiative)
                    {
                        Swap(classlist[i], classlist[i + 1]);
                        going = false;
                    }
                }
            }
        }

        public void Swap(InitiativeClass a, InitiativeClass b)
        {
            InitiativeClass temp = a;
            a = b;
            b = temp;
        }
    }
}
