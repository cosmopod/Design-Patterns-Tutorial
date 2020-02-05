namespace DesignPatternsTutorial.CreationalDesignPatterns.Builder
{
    public class Wizard
    {
        private readonly IPotionCauldron _potionCauldron;

        public Wizard(IPotionCauldron potionCauldron)
        {
            _potionCauldron = potionCauldron;
        }

        public Potion GetPotion()
        {
            return _potionCauldron.GetPotion();
        }

        public void MakePotion()
        {
            _potionCauldron.SetPotionBase();
            _potionCauldron.SetMainIngredient();
            _potionCauldron.SetEnhancers();
        }
    }
}