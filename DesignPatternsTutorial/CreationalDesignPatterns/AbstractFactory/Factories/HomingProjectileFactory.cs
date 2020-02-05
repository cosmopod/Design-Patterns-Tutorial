using DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory.Products;

namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory.Factories
{
    public class HomingProjectileFactory : IProjectileFactory
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