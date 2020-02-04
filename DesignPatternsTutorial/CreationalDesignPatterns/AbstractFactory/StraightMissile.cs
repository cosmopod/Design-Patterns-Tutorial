using System;

namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory
{
    public class StraightMissile : Missile
    {
        public void Fire()
        {
            Console.WriteLine("Fire as Straight Missile");
        }
    }
}