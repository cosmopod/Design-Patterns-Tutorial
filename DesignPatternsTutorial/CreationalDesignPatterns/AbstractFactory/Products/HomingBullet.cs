using System;

namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory.Products
{
    public class HomingBullet : IBullet
    {
        public void Fire()
        {
            Console.WriteLine("Fire as Homing bullet");
        }
    }
}