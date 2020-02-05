using System;
using DesignPatternsTutorial.CreationalDesignPatterns.Builder;

namespace DesignPatternsTutorial
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Wizard wizard = new Wizard();
            
            wizard.SetCauldron(new HealPotionCauldron());
            wizard.MakePotion();
            Potion potion = wizard.GetPotion();
            Console.WriteLine(potion.BaseIngredient);
        }
    }
}