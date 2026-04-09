// ============================================
// Program #199 — TemplateMethod
// Category  : 20_Design_Patterns
// Difficulty: [Intermediate]
// Description: Template method pattern for a data export pipeline
// ============================================

using System;

namespace CSharp30Programs.Design_Patterns
{
    abstract class DataExporter
    {
        public void Export()
        {
            ReadData();
            ProcessData();
            WriteData();
            Console.WriteLine("Export pipeline completed.
");
        }

        protected abstract void ReadData();
        protected abstract void ProcessData();
        protected abstract void WriteData();
    }

    class CsvExporter : DataExporter
    {
        protected override void ReadData() => Console.WriteLine("Reading CSV data...");
        protected override void ProcessData() => Console.WriteLine("Processing CSV records...");
        protected override void WriteData() => Console.WriteLine("Writing CSV output...");
    }

    class JsonExporter : DataExporter
    {
        protected override void ReadData() => Console.WriteLine("Reading JSON data...");
        protected override void ProcessData() => Console.WriteLine("Processing JSON payload...");
        protected override void WriteData() => Console.WriteLine("Writing JSON output...");
    }

    class Program_199_TemplateMethod
    {
        static void Main(string[] args)
        {
            DataExporter csv = new CsvExporter();
            DataExporter json = new JsonExporter();

            csv.Export();
            json.Export();
        }
    }
}
