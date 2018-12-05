using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_Task_WPF_Andre_Lussier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int grandTotal = 0;
        string file1 = "C:\\Users\\dremo\\OneDrive\\Desktop\\WPFFile1.txt";
        string file2 = "C:\\Users\\dremo\\OneDrive\\Desktop\\WPFFile2.txt";

        public MainWindow()
        {
            InitializeComponent();
        }

        private Object myLock = new object();

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Action a1 = delegate () { CalculateFileSum(file1); };
            Action a2 = delegate () { CalculateFileSum(file2); };

            Task t1 = new Task(a1);
            Task t2 = new Task(a2);

            t1.Start();
            t2.Start();
        }

        
        //int total = 0;


        void CalculateFileSum(string filename)
        {
            int fileTotal = 0;
            int textBoxTotal = 0;
            using (StreamReader sr = File.OpenText(filename))
            {
                
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    fileTotal += Convert.ToInt32(s);
                }

                lock(myLock) // lock is just an instance of object
                {
                    Action a = delegate () { textBoxTotal = Convert.ToInt32(TotalTextBox.Text); };
                    TotalTextBox.Dispatcher.Invoke(a);
                     
                    grandTotal = fileTotal + textBoxTotal;

                    Action c = delegate () { TotalTextBox.Text = Convert.ToString(grandTotal); };
                    TotalTextBox.Dispatcher.Invoke(c);
                }
            }
        }
    }
}
