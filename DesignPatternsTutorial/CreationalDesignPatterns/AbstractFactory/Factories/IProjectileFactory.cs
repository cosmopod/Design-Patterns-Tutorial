using DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory.Products;

namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory.Factories
{
    public enum ProjectileMotion
    {
        Straight,
        Homing
    }

    public interface IProjectileFactory
    {
        IBullet CreateBullet();
        IMissile CreateMissile();
    }
}