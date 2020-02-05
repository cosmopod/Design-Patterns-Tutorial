using DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory.Products;

namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory.Factories
{
    public class StraightProjectileFactory : IProjectileFactory
    {
        public IBullet CreateBullet()
        {
            return new StraightBullet();
        }

        public IMissile CreateMissile()
        {
            return new StraightMissile();
        }
    }
}