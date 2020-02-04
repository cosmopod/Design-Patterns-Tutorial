namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory
{
    public class AbstractFactoryApp
    {
        public void Initialize()
        {
            
        }

        public void Start()
        {
            ProjectileFactory bulletFactory = FactoryProducer.GetProjectileFactory(ProjectileMotion.Homing);
            Bullet homingBullet = bulletFactory.CreateBullet();
            homingBullet.Fire();
            
            ProjectileFactory missileFactory = FactoryProducer.GetProjectileFactory(ProjectileMotion.Straight);
            Missile straightMissile = missileFactory.CreateMissile();
            straightMissile.Fire();
        }
    }
}