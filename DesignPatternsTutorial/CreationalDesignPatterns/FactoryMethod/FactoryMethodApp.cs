namespace DesignPatternsTutorial.CreationalDesignPatterns.FactoryMethod
{
    public class FactoryMethodApp
    {
        private ProjectileSpawner _missileSpawner, _bulletSpawner;

        public void Initialize()
        {
            _missileSpawner = new MissileSpawner();
            _bulletSpawner = new BulletSpawner();
        }

        public void Start()
        {
            IProjectile missile = _missileSpawner.SpawnProjectile();
            missile.Fire();

            IProjectile bullet = _bulletSpawner.SpawnProjectile();
            bullet.Fire();
        }
    }
}