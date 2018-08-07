using System.Collections.Generic;

namespace PassingData.ViewModels
{
    public class TodoViewModel
    {
        public string Title { get; set; }
        public List<string> Tasks { get; set; }
        public bool IsComplete { get; set; }
    }
}