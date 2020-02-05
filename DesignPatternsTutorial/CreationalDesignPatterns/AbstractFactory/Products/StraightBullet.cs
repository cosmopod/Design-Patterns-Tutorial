using System;

namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory.Products
{
    public class StraightBullet : IBullet
    {
        public void Fire()
        {
            Console.WriteLine("Fire as Straight bullet");
        }
    }
}