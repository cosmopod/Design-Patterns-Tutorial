using System.Collections.Generic;

namespace DesignPatternsTutorial.StructuralDesignPatterns.Adapter
{
    public interface IStatsImporter
    {
        Dictionary<string, int> FetchData();
    }
}