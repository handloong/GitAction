using System;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http;

namespace ActionTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var url = $@"http://push.ijingniu.cn/send?key=7374a9ff1b8c4a04a3afb38cc96f1d35&head=gitAction&body={DateTime.Now:yyyyMMdd_HH:mm:ss}";

            var res = await url.GetAsync();
            Console.WriteLine(res.ResponseMessage);
            Console.WriteLine("Hello World!");
        }
    }
}
