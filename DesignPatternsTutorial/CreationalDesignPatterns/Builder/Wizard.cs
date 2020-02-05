namespace DesignPatternsTutorial.CreationalDesignPatterns.Builder
{
    public class Wizard
    {
        private IPotionCauldron _potionCauldron;
        
        public void SetCauldron(IPotionCauldron potionCauldron)
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