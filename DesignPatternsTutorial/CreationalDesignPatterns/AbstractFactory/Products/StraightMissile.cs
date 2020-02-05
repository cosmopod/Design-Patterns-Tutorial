using System;

namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory.Products
{
    public class StraightMissile : IMissile
    {
        public void Fire()
        {
            Console.WriteLine("Fire as Straight Missile");
        }
    }
}