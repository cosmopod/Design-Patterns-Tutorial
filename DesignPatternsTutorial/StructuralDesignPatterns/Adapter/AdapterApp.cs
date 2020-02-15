namespace DesignPatternsTutorial.StructuralDesignPatterns.Adapter
{
    public class AdapterApp
    {
        private void Start()
        {
            
        }

        private void Initialize()
        {
            CsvStatsImporter csvStatsImporter = new CsvStatsImporter();
            IStatsImporter csvAdapter = new CsvAdapter(csvStatsImporter);

            JsonStatsImporter jsonStatsImporter = new JsonStatsImporter();
            IStatsImporter jsonImporter = new JsonAdapter(jsonStatsImporter);

            var jsonImportedSettings = jsonImporter.FetchData();
            var csvIMportedSettings = csvAdapter.FetchData();
        }
    }
}