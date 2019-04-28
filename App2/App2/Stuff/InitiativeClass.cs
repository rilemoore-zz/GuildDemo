using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Stuff
{
    public class InitiativeClass
    {
        public int initiative;
        public string name;
        public int AC;
        public int HP;
        
        public void Sort(List<InitiativeClass> classlist)
        {
            
            bool going = false;
            while (going == false)
            {
                going = true;
                for(int i = 0; i < classlist.Count-1; i++)
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
            InitiativeClass temp = new InitiativeClass();
            temp.initiative = a.initiative;
            temp.name = a.name;
            temp.AC = a.AC;
            temp.HP = a.HP;

            a.initiative = b.initiative;
            a.name = b.name;
            a.AC = b.AC;
            a.HP = b.HP;

            b.initiative = temp.initiative;
            b.name = temp.name;
            b.AC = temp.AC;
            b.HP = temp.HP;
        }
    }
}
