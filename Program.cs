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
            //
            // one of the constructors is in the other file
            //
            private static int count;
            private string title { get; set; }
            private string body { get; set; }
            public enum PRIORITYTYPE { HIGH, MEDIUM, LOW };
            private IPAddress destinationAddress;
            private readonly int version = 1;
            public PRIORITYTYPE priority;

            

            static Message()
            {
                Console.WriteLine("current value of count is: " + count);
            }

            // one of the constructors is in the other file
            // one of the constructors is in the other file


            public string TitleAndBody() => this.title + this.body;


            public Message() : this("supreme lord of the dance", "Jim", PRIORITYTYPE.HIGH, IPAddress.Loopback)
            {

            }

            public override string ToString()
            {
                return "title : " + title + "this is the body: " + body + " priority: " + priority + "destination IP: " + destinationAddress;
            }

            public override bool Equals(object obj) // pleaes comment back if this is not the correct way
            {
                Message test = obj as Message;

                if (test == null)
                {
                    return false;
                }
                else
                {
                   Message test2 = (Message)test;
                   if(test2.title == this.title)
                   {
                       return true;
                   }
                   else
                    {
                        return false;
                    }
                }
            }

            // one of the constructors is in the other file

            public int getVersion()
            {
                return this.version;
            }

            public IPAddress destinationAddress2
            {
                get => this.destinationAddress;

                set
                {
                    this.destinationAddress = value;
                }
            }
        }
    }
}
