using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace PGM3
{
    class Program
    {
        static void Main(string[] args)
        {
            syncConvolution();
            asyncConvolution().Wait();

            Console.ReadKey();
        }


        static void syncConvolution()
        {
            MyImage image = new MyImage(1024, 1024);
            MyImage im = new MyImage(1024, 1024);
            im.CreateCheckerboard(8);

            Stopwatch clock = new Stopwatch();
            clock.Start();
            Console.WriteLine("Normal Convolution: ");

            for (int i = 0; i < 200; i++)
            {
                im.Convolution(image, im);
                im = image;
            }
            clock.Stop();
            Console.WriteLine(clock.Elapsed);
            ImageManager.saveImage(@"/Users//agatablachowiak/Desktop/sync_img.png", image);
        }


        static async Task<MyImage> asyncConvolution()
        {
            MyImage image = new MyImage(1024, 1024);
            MyImage im = new MyImage(1024, 1024);
            im.CreateCheckerboard(8);

            Console.WriteLine("Asynchronous Convolution");
            List<Task> tasks = new List<Task>();
            Stopwatch clock = new Stopwatch();
            clock.Start();

            for (int i = 0; i < 200; i++)
            {
                tasks.Add(AsyncImg.asyncConvolutionTopBottomLine(image, im));
                tasks.Add(AsyncImg.asyncConvolutionCornersLRLine(image, im));
                tasks.Add(AsyncImg.asyncConvolutionIa(image, im));
                tasks.Add(AsyncImg.asyncConvolutionIb(image, im));
                tasks.Add(AsyncImg.asyncConvolutionIc(image, im));
                tasks.Add(AsyncImg.asyncConvolutionId(image, im));
                tasks.Add(AsyncImg.asyncConvolutionIIa(image, im));
                tasks.Add(AsyncImg.asyncConvolutionIIb(image, im));
                tasks.Add(AsyncImg.asyncConvolutionIIc(image, im));
                tasks.Add(AsyncImg.asyncConvolutionIId(image, im));
                tasks.Add(AsyncImg.asyncConvolutionIIIa(image, im));
                tasks.Add(AsyncImg.asyncConvolutionIIIb(image, im));
                tasks.Add(AsyncImg.asyncConvolutionIIIc(image, im));
                tasks.Add(AsyncImg.asyncConvolutionIIId(image, im));
                tasks.Add(AsyncImg.asyncConvolutionIVa(image, im));
                tasks.Add(AsyncImg.asyncConvolutionIVb(image, im));
                tasks.Add(AsyncImg.asyncConvolutionIVc(image, im));
                tasks.Add(AsyncImg.asyncConvolutionIVd(image, im));

                await Task.WhenAll(tasks); //blocks the current thread until all pending tasks are complete
                tasks.Clear();

                im = image;
            }
            clock.Stop();
            Console.WriteLine(clock.Elapsed);
            ImageManager.saveImage(@"/Users//agatablachowiak/Desktop/async_img.png", image);
            return im;
        }
    }
}