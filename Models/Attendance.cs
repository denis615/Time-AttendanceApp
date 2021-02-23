using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Models
{
    public class Attendance
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }

        public DateTime PunchIn { get; set; }
        public DateTime PunchOut { get; set; }


    }
}
