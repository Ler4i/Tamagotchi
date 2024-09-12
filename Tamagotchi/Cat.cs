using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    internal class Cat : Base
    {
        public string Name;
        
        public int LevelVivacity = 100;//бодрость
        public int LevelJoy = 100;//радость
        public int LevelHunger = 100;//голод 
        public int LevelOfAffection = 100;//ласка

        
        

        public override void GetVivacity(int val)
        {
            if (LevelVivacity <= 20 & val<80) { 
                LevelVivacity+=val;
            }
        }

        public override void GetJoy(int val)
        {
            if (LevelJoy <= 40 & val < 60)
            {
                LevelJoy+=val;
            }
        }

        public override void GetSatiety(int val)
        {
            if (LevelHunger <= 30 & val < 70)
            {
                LevelHunger+=val;
            }
        }

        public void GetAffection(int val)
        {
            if (LevelOfAffection <= 50 & val < 50)
            {
                LevelOfAffection += val;
            }
        }

        public int timer = 20;//секунд
        public override void ReducingNeeds()
        {
            while (timer != -1)
            {
                timer--;
                LevelVivacity -= 5;
                LevelJoy -= 3;
                LevelHunger -= 2;
                LevelOfAffection -= 4;
                OutputOfIntermediateNeeds();
                Thread.Sleep(1000);
            }
        }

        public void OutputOfIntermediateNeeds()
        {
            if (timer == 15 || timer == 10 || timer == 5 || timer == 0) //найти другой способ! 
            {
                if (LevelVivacity != 0 || LevelJoy != 0 || LevelHunger != 0 || LevelOfAffection != 0)
                {
                    Console.WriteLine("1)бодрость = " + LevelVivacity +
                "\n 2)радость = " + LevelJoy + "\n 3)голод = " + LevelHunger + "\n 4)ласка = " + LevelOfAffection);
                }
                else
                {
                    Console.WriteLine("Ваш питомец умер из-за недостатка одной из потребностей!");
                }
            }
        }
    }
}
