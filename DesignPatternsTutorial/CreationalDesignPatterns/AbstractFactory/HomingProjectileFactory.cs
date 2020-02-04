namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory
{
    public class HomingProjectileFactory : ProjectileFactory
    {
        public Bullet CreateBullet()
        {
            return new HomingBullet();
        }

        public Missile CreateMissile()
        {
            return new HomingMissile();
        }
    }
}