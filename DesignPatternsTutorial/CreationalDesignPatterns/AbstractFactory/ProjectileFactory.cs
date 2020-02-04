using DesignPatternsTutorial.CreationalDesignPatterns.FactoryMethod;

namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory
{
    public enum ProjectileMotion
    {
        Straight,
        Homing
    }

    public interface ProjectileFactory
    {
        Bullet CreateBullet();
        Missile CreateMissile();
    }
}