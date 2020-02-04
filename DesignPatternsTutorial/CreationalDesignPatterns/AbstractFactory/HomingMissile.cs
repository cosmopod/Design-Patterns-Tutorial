using System;

namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory
{
    public class HomingMissile : Missile
    {
        public void Fire()
        {
            Console.WriteLine("Fire as Homing Missile");
        }
    }
}