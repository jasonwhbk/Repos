using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace LearningAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading file!");
            Download();
            Console.ReadLine();
        }

        static  void Download()
        {

            Network.Download((message) => Console.WriteLine(value: "Download Complete" + message));
            //HttpClient client = new HttpClient();
            //var data = await client.GetStringAsync("http://www.jasonwh.com");
            //Console.WriteLine("Download Complete" + data);

        }


        class Network {

            static public void Download(Action<string> callback)
            {
                Task.Run(() => {
                Thread.Sleep(3000);
                callback("completed");
                });
            }
        }
    }
}
