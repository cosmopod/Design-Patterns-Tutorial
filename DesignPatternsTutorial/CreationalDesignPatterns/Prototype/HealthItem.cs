using System;

namespace DesignPatternsTutorial.CreationalDesignPatterns.Prototype
{
    public class HealthItem : ICloneable
    {
        public String Name;
        public int HealingPoints;
        
        public ICloneable Clone()
        {
            return (ICloneable) this.MemberwiseClone();
        }
    }
}