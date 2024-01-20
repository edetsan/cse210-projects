    public class PromptGenerator
    {
        public List<string> _prompts = new List<string>
        {
            "What is something that really made me happy today?",
            "What are tree things that I felt gratefull for today?",
            "what is something that imapacted my day in a positive way today?",
            "Who played an importan part of my day today and how?",
            "If I had one thing I could do over today, what would it be?",
            "Is there anything I wish I could have handled in a different way?",
            "What act of love did I do today?",
            "Is there anything that made me feel sad today?"
        };

        public string GetPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }
    }