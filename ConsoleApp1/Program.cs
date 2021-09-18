using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkflowEngine();

            var notify = new Notify();
            notify.Add(new EmailNotify());
            notify.Add(new SmsNotify());

            workflow.Add(notify);
            workflow.Add(new UploadCloud());
            workflow.Add(new WebService());

            var videoRecord = new VideoRecord();
            workflow.Add(videoRecord);

            workflow.Run();

            Console.ReadLine();
        }
    }
}
