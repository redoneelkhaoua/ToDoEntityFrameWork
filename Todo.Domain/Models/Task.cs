using System;
using System.Collections.Generic;

#nullable disable

namespace Todo.Domain.Models
{
    public partial class Task
    {
        public decimal Id { get; set; }
        public string Statue { get; set; }
        public string Details { get; set; }
    }
}
