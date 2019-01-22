using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace PGM
{
    class Program2
    {
        delegate MyImage DelegateType();
        static List<DelegateType> del = new List<DelegateType>();

        static void Main(string[] args)
        {
            MyImage img = new MyImage(1024, 1024);
            img.CreateCheckerboard(8);

            Stopwatch clock = new Stopwatch();
            clock.Start();
            Console.WriteLine("Non async method");
            nonAsyncMethod(img);
            clock.Stop();
            Console.WriteLine(clock.Elapsed);

            Stopwatch clock2 = new Stopwatch();
            clock2.Start();
            Console.WriteLine("Async method");
            asyncMethod(img);
            clock2.Stop();
            Console.WriteLine(clock2.Elapsed);

            ImageManager.saveImage(@"/Users//agatablachowiak/Desktop/img.pgn", img);
            Console.ReadKey();

        }

        static void nonAsyncMethod(MyImage img)
        {
            for (int i = 0; i < 200; i++)
            {
                img = img.convolution();
                //Console.WriteLine(i);
            }
        }

        static void asyncMethod(MyImage img)
        {
            for (int i = 0; i < 200; i++)
            {
                del.Add(new DelegateType(img.convolution));
            }
            List<IAsyncResult> ars = new List<IAsyncResult>();
            for (int i = 0; i < 200; i++)
            {
                ars.Add(del[i].BeginInvoke(null, null));
            }

            List<MyImage> images = new List<MyImage>();
            for (int i = 0; i < 200; i++)
            {
                images.Add(del[i].EndInvoke(ars[i]));
            }
        }

    }
}