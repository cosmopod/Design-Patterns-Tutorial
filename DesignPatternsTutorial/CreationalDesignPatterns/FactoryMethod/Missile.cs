using System;

namespace DesignPatternsTutorial.CreationalDesignPatterns.FactoryMethod
{
    public class Missile : IProjectile
    {
        public void Impact()
        {
            Console.WriteLine("Impact as Missile");
        }
    }
}