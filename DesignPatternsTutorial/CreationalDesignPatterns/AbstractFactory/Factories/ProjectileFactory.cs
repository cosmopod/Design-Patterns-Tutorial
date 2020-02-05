using DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory.Products;

namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory.Factories
{
    public enum ProjectileMotion
    {
        Straight,
        Homing
    }

    public interface ProjectileFactory
    {
        IBullet CreateBullet();
        IMissile CreateMissile();
    }
}