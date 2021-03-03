using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MacApi1.Models
{
    public class Notification
    {
        public Notification()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string TranType { get; set; }
    }
}
