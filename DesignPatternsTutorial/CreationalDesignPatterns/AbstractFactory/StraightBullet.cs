using System;

namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory
{
    public class StraightBullet : Bullet
    {
        public void Fire()
        {
            Console.WriteLine("Fire as Straight bullet");
        }
    }
}