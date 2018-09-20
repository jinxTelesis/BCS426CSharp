using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace BCS426AndreLussierLab2
{
    public partial class Program
    {
        public partial class Message
        {
            public Message(string title, string body, PRIORITYTYPE priority, IPAddress destAdd)
            {
                count++;
                this.title = title;
                this.body = body;
                this.priority = priority;
                this.destinationAddress = destAdd;


            }

            public PRIORITYTYPE Priority
            {
                get
                {
                    return priority;
                }

                set
                {
                    priority = value;
                }
            }

        }

    }
}
