namespace DesignPatternsTutorial.CreationalDesignPatterns.FactoryMethod
{
    public class BulletSpawner : ProjectileSpawner
    {
        public override IProjectile SpawnProjectile()
        {
            return new Bullet();
        }
    }
}