using DICT.CSharp.LessonOne.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DICT.CSharp.LessonOne
{
    public partial class Form1 : Form
    {
        public delegate void Del(string message);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoTask_Click(object sender, EventArgs e)
        {
            IEmployee employee;

            employee = new Developer();
            lblDoTask.Text = employee.DoTask();


            // Instantiate the delegate.
            Del handler = HelloWorld;

            // Call the delegate.
            handler("Hello World");
        }
        
        public static void HelloWorld(string message)
        {
            System.Console.WriteLine(message);
        }
        
        public static void WorldHello(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
