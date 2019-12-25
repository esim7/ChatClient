using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Message
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string From { get; set; }
        public DateTime SendTime { get; set; } = DateTime.Now;
        public string Text { get; set; }
    }
}
