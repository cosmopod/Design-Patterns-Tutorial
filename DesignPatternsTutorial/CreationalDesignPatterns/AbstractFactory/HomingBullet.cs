using System;

namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory
{
    public class HomingBullet : Bullet
    {
        public void Fire()
        {
            Console.WriteLine("Fire as Homing bullet");
        }
    }
}