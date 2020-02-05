using System;

namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory.Products
{
    public class HomingMissile : IMissile
    {
        public void Fire()
        {
            Console.WriteLine("Fire as Homing Missile");
        }
    }
}