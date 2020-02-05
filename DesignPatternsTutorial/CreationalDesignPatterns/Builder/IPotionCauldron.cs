namespace DesignPatternsTutorial.CreationalDesignPatterns.Builder
{
    public interface IPotionCauldron
    {
        void SetPotionBase();
        void SetMainIngredient();
        void SetEnhancers();
        Potion GetPotion();
    }
}