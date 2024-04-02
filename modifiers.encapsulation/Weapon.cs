using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modifiers.encapsulation
{
    internal class Weapon
    {
        public int BulletCapacity; 
        public int BulletCount; 
        public int DischargeTime; 
        public bool ShootingMode;
        public Weapon(int bulletCapacity, int bulletCount, int dischargeTime, bool shootingMode)
        {
            BulletCapacity = bulletCapacity;
            BulletCount = bulletCapacity; 
            DischargeTime = dischargeTime;
            ShootingMode = shootingMode;
        }

        public void Shoot()
        {
            if (BulletCount>0)
            {
                Console.WriteLine("Gulle atildi.");
                BulletCount--;
            }
            else
            {
                Console.WriteLine("Daraqda gulle qalmayib.");
            }
        }
        


        public void Fire()
        {
            int remainBullets = BulletCount;
            int timeFinish = remainBullets * DischargeTime;
            Console.WriteLine($"Hamisi ateslendi. {timeFinish} saniyeye bitdi.");
        }




        public int GetRemainBulletCount()
        {
            return BulletCapacity - BulletCount;
        }



        public void Reload()
        {
            BulletCount = BulletCapacity; 
            Console.WriteLine("Daraq yeniden dolduruldu.");
        }




        public void ChangeFireMode()
        {
            ShootingMode = !ShootingMode;
        }



    }
}
