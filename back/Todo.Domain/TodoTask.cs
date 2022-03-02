using System;
using System.Collections.Generic;

#nullable disable

namespace Todo.Domain.Models
{
    
    public partial class TodoTask
    {
        public decimal Id { get; set; }
        public string Status { get; set; }
        public string Details { get; set; }
    }
}
