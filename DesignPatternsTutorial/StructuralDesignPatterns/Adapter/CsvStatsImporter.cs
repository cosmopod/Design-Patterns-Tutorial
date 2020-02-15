using System.Collections.Generic;

namespace DesignPatternsTutorial.StructuralDesignPatterns.Adapter
{
    public class CsvStatsImporter
    {
        public Dictionary<string, int> FetchDataFromCsvFile()
        {
            var gameSettings = new Dictionary<string, int>();
            gameSettings.Add("Life", 100);
            return gameSettings;
        }
    }
}