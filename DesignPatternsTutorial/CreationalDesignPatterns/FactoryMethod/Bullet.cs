using System;

namespace DesignPatternsTutorial.CreationalDesignPatterns.FactoryMethod
{
    public class Bullet : IProjectile
    {
        public void Fire()
        {
            Console.WriteLine("Impact as Bullet");
        }
    }
}