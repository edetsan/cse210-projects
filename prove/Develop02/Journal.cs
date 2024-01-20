using System;
    
    public class Journal
    {
        public List<Entry> _entries = new List<Entry>();
        public void DisplayJournal()
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }

        public void SaveFile()
        {
            Console.WriteLine("What is the filename?");
            string file = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($" Date: {entry._date}|{entry._prompt}|{entry._record}");
                }
            };
        }
        public void LoadFile()
        {
            Console.WriteLine("What is the filename?");
            string fileName = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(fileName);
            _entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                Entry reader = new Entry();
                reader._date = parts[0];
                reader._prompt = parts[1];
                reader._record = parts[2];
                _entries.Add(reader);
            }
        }     
    }