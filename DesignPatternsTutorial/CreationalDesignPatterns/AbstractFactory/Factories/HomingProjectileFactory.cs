using DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory.Products;

namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory.Factories
{
    public class HomingProjectileFactory : ProjectileFactory
    {
        public IBullet CreateBullet()
        {
            return new HomingBullet();
        }

        public IMissile CreateMissile()
        {
            return new HomingMissile();
        }
    }
}