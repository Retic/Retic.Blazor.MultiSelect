using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DELMESample.Models
{
    public class MessageRecord
    {
        public MessageRecord(string message, DateTimeOffset sent)
        {
            Message = message;
            Sent = sent;
        }

        public virtual string Message { get; set; }
        public virtual DateTimeOffset Sent { get; set; }
        public virtual bool Verified { get; set; }
    }
}
