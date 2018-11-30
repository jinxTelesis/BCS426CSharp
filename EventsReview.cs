using System;

namespace TestConsoleApp1
{
    delegate void TestDelegate();

    delegate void TestDelegate2(string s);

    




    class Program
    {
        static void Main(string[] args)
        {

            TestDelegate td = null;

            

            td = new TestDelegate(Giants);

            td += Jets;

            td();

            TestDelegate td2 = null;
            td2 = new TestDelegate(Giants);
            td2 += Jets;

            Z(td2);


            Team t = new Team();

            t.m_Name = "Boys";

            TestDelegate td3 = new TestDelegate(t.ShowName);

            td3();

            t.m_Name = "Girls";
            td();


            TestDelegate2 td4 = new TestDelegate2(Show);
            td4("C# is awesome");

            // no parameter version
            Action ad1 = null;

            ad1 = new Action(Giants);
            ad1();

            // one parameter version 
            Action<string> ad2 = null;
            ad2 = new Action<string>(Show);
            ad2("C# is awesome");

            //Action<string, int> ad3 = null;
            //ad3 = new Action<string, int>(ShowTwo);

            Func<int> fd = null;
            fd = new Func<int>(GetNum);
            int num = fd(); // Calls GetNum method 

            Func<string, int> fd2 = null;
            fd2 = new Func<string, int>(ConvertStringToNum);
            int num2 = fd2("100");

            Action<string> anonDel = delegate (string s)
            {
                Console.WriteLine(s);
            };

            Action<string> annonDel = s =>
            {
                Console.WriteLine(s);
            };

            annonDel("WOoow");

            Func<int, int> f = y =>
            {
                return y * y;
            };

            int sqNum;
            sqNum = f(20);
            Console.WriteLine(sqNum);




            anonDel("Go mom!");


            Secretary s = new Secretary();

            Employee e1 = new Employee();
            Employee e2 = new Employee();

            e1.name = "Jane";
            e2.name = "Bob";

            s.CallEvent += e1.HandlePhoneCall;
            s.CallEvent += e2.HandlePhoneCall;

            s.FireCallEvent();

            Console.WriteLine("Remove e1 as listener...");
            s.CallEvent -= e1.HandlePhoneCall;
            s.FireCallEvent();

            void Giants()
            {
                Console.WriteLine("Go Giants");
            }

            void Jets()
            {
                Console.WriteLine("Go Jets");
            }

            void Cowboys()
            {
                Console.WriteLine("Go Cowboys");
            }

            Console.ReadLine();

            // method that takes a delegate as a parameter

            void Z(TestDelegate e)
            {
                // the delegate will run both giants and jets

                e();
            }

            void Show(string displayString)
            {
                Console.WriteLine(displayString);
            }

            int GetNum()
            {
                return Convert.ToInt32(Console.ReadLine());
            }

           

        }

        static int ConvertStringToNum(string s)
        {
            return Convert.ToInt32(s);
        }

        class Team
        {
            public string m_Name;

            public void ShowName()
            {
                Console.WriteLine(m_Name);
            }
        }

        public class Secretary
        {

            public event Action CallEvent;

            public void FireCallEvent()
            {
                if(CallEvent == null)
                {
                    return;
                }

                CallEvent();
            }
        }

        class Employee
        {
            public string name;

            public void HandlePhoneCall()
            {
                Console.WriteLine(name);
                Console.WriteLine("Phone call event handled");
            }


        }


    }
}
