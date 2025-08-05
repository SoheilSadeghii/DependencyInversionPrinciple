using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class EmailNotification
    {
        public void Send(string message)
        {
            // To Do: Send Message
        }
    }

    public class DatabaseManager
    {
        public void Add()
        {

        }

        public void Remove()
        {

        }

        public void Update()
        {

        }
    }
}
