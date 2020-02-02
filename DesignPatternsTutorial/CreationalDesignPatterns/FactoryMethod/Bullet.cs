using System;

namespace DesignPatternsTutorial.CreationalDesignPatterns.FactoryMethod
{
    public class Bullet : IProjectile
    {
        public void Impact()
        {
            Console.WriteLine("Impact as Bullet");
        }
    }
}