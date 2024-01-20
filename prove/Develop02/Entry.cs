    public class Entry
    {
        public string _date = "";
        public string _prompt = "";
        public string _record = "";


        public void Display()
        {
            Console.WriteLine($"Date: {_date} - {_prompt} - {_record}");
        }
    }