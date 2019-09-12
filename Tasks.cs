using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaskList.Models
{
    public class Tasks
    {
        [Required]
        private bool status { get; set; }
        private int taskId { get; set; }
        [Required]
        private string titulo { get; set; }
        private string descricao { get; set; }
    }
}
