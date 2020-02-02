namespace DesignPatternsTutorial.CreationalDesignPatterns.FactoryMethod
{
    public class MissileSpawner : ProjectileSpawner
    {
        public override IProjectile SpawnProjectile()
        {
            return new Missile();
        }
    }
}