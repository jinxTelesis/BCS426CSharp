using System;


namespace TestConsoleApp1
{
    delegate void TestDelegate();

    delegate void TestDelegate2(string s);

    




    class Program
    {
        static void Main(string[] args)
        {


            Action<string> anonLambda = s =>
            {
                Console.WriteLine(s);
            };

            Func<int, int> f = y =>
            {
                return y * y;
            };

            int squareMe;
            squareMe = f(50);
            Console.WriteLine(squareMe);
            
        }  
    }

    public class Secretary
    {
        public class CallEventArgs : EventArgs {
            public string Caller { get; set; }

            public CallEventArgs(string caller)
            {
                Caller = caller;
            }
        }
        public event EventHandler<CallEventArgs> CallEvent;

        public void FireCallEvent(string caller)
        {
            if(CallEvent == null)
            {
                return;
            }

            Secretary.CallEventArgs eventArgs = new Secretary.CallEventArgs(caller);

            CallEvent(this, eventArgs);
        }


    }

}
