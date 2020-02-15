using System;
using System.Collections.Generic;

namespace DesignPatternsTutorial.StructuralDesignPatterns.Adapter
{
    public class JsonStatsImporter
    {
        public Dictionary<string, int> FetchDataFromJsonFile()
        {
            var gameSettings = new Dictionary<string, int>();
            gameSettings.Add("Life", 100);
            return gameSettings;
        }
    }
}