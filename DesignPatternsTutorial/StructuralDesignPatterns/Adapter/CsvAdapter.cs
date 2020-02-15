using System.Collections.Generic;

namespace DesignPatternsTutorial.StructuralDesignPatterns.Adapter
{
    public class CsvAdapter : IStatsImporter
    {

        private readonly CsvStatsImporter _csvStatsImporter;

        public CsvAdapter(CsvStatsImporter csvStatsImporter)
        {
            _csvStatsImporter = csvStatsImporter;
        }

        public Dictionary<string, int> FetchData()
        {
           return _csvStatsImporter.FetchDataFromCsvFile();
        }
    }
}