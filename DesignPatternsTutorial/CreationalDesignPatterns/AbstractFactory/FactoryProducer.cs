using System;

namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory
{
    public class FactoryProducer
    {
        public static ProjectileFactory GetProjectileFactory(ProjectileMotion projectileMotionType)
        {
            switch (projectileMotionType)
            {
                case ProjectileMotion.Straight:
                    return new StraightProjectileFactory();
                    break;
                case ProjectileMotion.Homing:
                    return new HomingProjectileFactory();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(projectileMotionType), projectileMotionType, null);
            }
        }
    }
}