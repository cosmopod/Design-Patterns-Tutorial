namespace DesignPatternsTutorial.CreationalDesignPatterns.Singleton
{
    public class SingletonApp
    {
        public void Start()
        {
            
        }

        public void Initialize()
        {
            AudioManager.Instance.PlayClip("StartGame");
            AudioManager.Instance.PlayClip("OpenMenu");
        }
    }
}