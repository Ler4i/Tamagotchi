using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    internal abstract class Base
    {
        public abstract void GetVivacity(int val);//получение бодрости
        public abstract void GetJoy(int val);//получение радости
        public abstract void GetSatiety(int val);//получение сытости

        public abstract void ReducingNeeds();
    }
}
