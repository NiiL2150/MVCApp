using System.Collections.Generic;

namespace MVCApp.Models
{
    public class TestViewModel
    {
        public int Counter { get; set; }
        public List<string> ToDoList { get; set; }
        public TestViewModel()
        {
            Counter = 0;
            ToDoList = new List<string>();
        }
    }
}
