namespace DesignPatternsTutorial.CreationalDesignPatterns.AbstractFactory
{
    public interface ProjectileFactory
    {
        void CreateBullet();
        void CreateMissile();
    }
}