using System.Collections.Generic;

namespace MVCApp.Services
{
    public class Testing : ITesting
    {
        public Testing()
        {
            ToDoList = new List<string>();
        }
    }
}
