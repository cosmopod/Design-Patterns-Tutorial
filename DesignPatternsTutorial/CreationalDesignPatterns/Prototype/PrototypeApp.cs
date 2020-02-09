using System.Collections.Generic;

namespace DesignPatternsTutorial.CreationalDesignPatterns.Prototype
{
    public class PrototypeApp
    {
        private void Start()
        {
        }

        private void Initialize()
        {
            HealthItem senzuBean = new HealthItem();
            senzuBean.Name = "Sensu Bean";
            senzuBean.HealingPoints = 100;
            
            List<ICloneable> Inventory = new List<ICloneable>();
            
            //add 10 healing beans to inventory
            for (int i = 0; i < 10; i++)
            {
                Inventory.Add(senzuBean.Clone());
            }
        }
    }
}