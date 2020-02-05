using DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory.Factories;

namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory
{
    public class AbstractFactoryApp
    {
        public void Initialize()
        {
        }

        public void Start()
        {
            var bulletFactory = FactoryProducer.GetProjectileFactory(ProjectileMotion.Homing);
            var homingBullet = bulletFactory.CreateBullet();
            homingBullet.Fire();

            var missileFactory = FactoryProducer.GetProjectileFactory(ProjectileMotion.Straight);
            var straightMissile = missileFactory.CreateMissile();
            straightMissile.Fire();
        }
    }
}