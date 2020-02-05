namespace DesignPatternsTutorial.CreationalDesignPatterns.Builder
{
    public class HealPotionCauldron : IPotionCauldron
    {
        private readonly Potion _potion;
        
        public HealPotionCauldron()
        {
            _potion = new Potion();
        }

        public void SetPotionBase()
        {
            _potion.BaseIngredient = "Water";
        }

        public void SetMainIngredient()
        {
            _potion.MainIngredient = "Dittany";
        }

        public void SetEnhancers()
        {
            _potion.Enhancer = "Dragon Liver";
        }

        public Potion GetPotion()
        {
            return _potion;
        }
    }
}