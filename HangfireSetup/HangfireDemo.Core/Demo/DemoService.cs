using System;
using System.Collections.Generic;
using System.Text;

namespace HangfireDemo.Core.Demo
{
    public interface IDemoService
    {
        void RunDemoTask();
    }

    public class DemoService : IDemoService
    {
       public void RunDemoTask()
        {
            Console.WriteLine("Denne task er kørt fra demo service");
        }

    }
}
