namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory
{
    public class StraightProjectileFactory : ProjectileFactory
    {
        public Bullet CreateBullet()
        {
            return new StraightBullet();
        }

        public Missile CreateMissile()
        {
            return new StraightMissile();
        }
    }
}