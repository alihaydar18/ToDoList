using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Title} - {(IsCompleted ? "Tamamlandı" : "Tamamlanmadı")}";
        }
    }
}
