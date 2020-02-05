using System;

namespace DesignPatternsTutorial.CreationalDesignPatterns.Builder
{
    public class BuilderApp
    {
        public void Initialize()
        {
            
        }

        public void Start()
        {
            Wizard wizard = new Wizard();
            
            wizard.SetCauldron(new HealPotionCauldron());
            wizard.MakePotion();
            Potion healPotion = wizard.GetPotion();
            Console.WriteLine(healPotion.BaseIngredient);
            
            wizard.SetCauldron(new LovePotionCauldron());
            wizard.MakePotion();
            Potion lovePotion = wizard.GetPotion();
            Console.WriteLine(lovePotion.Enhancer);
        }
    }
}