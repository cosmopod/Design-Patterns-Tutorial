namespace DesignPatternsTutorial.CreationalDesignPatterns.Builder
{
    public class LovePotionCauldron : IPotionCauldron
    {
        private Potion _potion;

        public LovePotionCauldron()
        {
            _potion = new Potion();
        }

        public void SetPotionBase()
        {
            _potion.BaseIngredient = "Red Wine";
        }

        public void SetMainIngredient()
        {
            _potion.MainIngredient = "Teaspoon Fennel";
        }

        public void SetEnhancers()
        {
            _potion.Enhancer = "Teaspoon Vervain";
        }

        public Potion GetPotion()
        {
            return _potion;
        }
    }
}