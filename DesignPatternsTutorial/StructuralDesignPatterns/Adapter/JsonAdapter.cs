using System.Collections.Generic;

namespace DesignPatternsTutorial.StructuralDesignPatterns.Adapter
{
    public class JsonAdapter : IStatsImporter
    {
        private readonly JsonStatsImporter _jsonStatsImporter;

        public JsonAdapter(JsonStatsImporter jsonStatsImporter)
        {
            _jsonStatsImporter = jsonStatsImporter;
        }

        public Dictionary<string, int> FetchData()
        {
          return  _jsonStatsImporter.FetchDataFromJsonFile();
        }
    }
}