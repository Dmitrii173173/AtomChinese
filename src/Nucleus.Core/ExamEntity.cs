using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nucleus.Core
{
    public class ExamEntity
    {
        [Key]
        public long Id { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
