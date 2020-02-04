using System;

namespace DesignPatternsTutorial.CreationalDesignPatterns.FactoryMethod
{
    public class Missile : IProjectile
    {
        public void Fire()
        {
            Console.WriteLine("Impact as Missile");
        }
    }
}