using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaskList.Models
{
    public class Tasks
    {
        private bool status { get; set; }
        private int taskId { get; set; }
        private string titulo { get; set; }
        private string descricao { get; set; }
    }
}
