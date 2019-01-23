using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace PGM3
{
    class AsyncImg
    {
        public async static Task asyncConvolutionIa(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                Parallel.For(1, newImage.Size[0] / 4 - 1, i =>
                {
                    for (int j = 1; j < newImage.Size[1] / 4 - 1; j++)
                    {
                        int index = i * oldImage.Size[1] + j;
                        newImage.Values[index] =
                            oldImage.Values[index] * 0.6f +
                            oldImage.Values[index + 1] * 0.1f +
                            oldImage.Values[index - 1] * 0.1f +
                            oldImage.Values[index + oldImage.Size[1]] * 0.1f +
                            oldImage.Values[index - oldImage.Size[1]] * 0.1f;
                    }
                });
            });
        }

        public async static Task asyncConvolutionIb(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                Parallel.For(1, newImage.Size[0] / 4 - 1, i =>
                {
                    for (int j = newImage.Size[0] / 4 - 1; j < newImage.Size[1] * 2 / 4 - 1; j++)
                    {
                        int index = i * oldImage.Size[1] + j;
                        newImage.Values[index] =
                            oldImage.Values[index] * 0.6f +
                            oldImage.Values[index + 1] * 0.1f +
                            oldImage.Values[index - 1] * 0.1f +
                            oldImage.Values[index + oldImage.Size[1]] * 0.1f +
                            oldImage.Values[index - oldImage.Size[1]] * 0.1f;
                    }
                });
            });
        }

        public async static Task asyncConvolutionIc(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                Parallel.For(1, newImage.Size[0] / 4 - 1, i =>
                {
                    for (int j = (newImage.Size[0]) * 2 / 4 - 1; j < (newImage.Size[1]) * 3 / 4 - 1; j++)
                    {
                        int index = i * oldImage.Size[1] + j;
                        newImage.Values[index] =
                            oldImage.Values[index] * 0.6f +
                            oldImage.Values[index + 1] * 0.1f +
                            oldImage.Values[index - 1] * 0.1f +
                            oldImage.Values[index + oldImage.Size[1]] * 0.1f +
                            oldImage.Values[index - oldImage.Size[1]] * 0.1f;
                    }
                });
            });
        }

        public async static Task asyncConvolutionId(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                Parallel.For(1, newImage.Size[0] / 4 - 1, i =>
                {
                    for (int j = (newImage.Size[0]) * 3 / 4 - 1; j < newImage.Size[1] - 1; j++)
                    {
                        int index = i * oldImage.Size[1] + j;
                        newImage.Values[index] =
                            oldImage.Values[index] * 0.6f +
                            oldImage.Values[index + 1] * 0.1f +
                            oldImage.Values[index - 1] * 0.1f +
                            oldImage.Values[index + oldImage.Size[1]] * 0.1f +
                            oldImage.Values[index - oldImage.Size[1]] * 0.1f;
                    }
                });
            });
        }


        public async static Task asyncConvolutionIIa(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                Parallel.For((newImage.Size[0] - 1) / 4, (newImage.Size[0] - 1) * 2 / 4, i =>
                {
                    for (int j = 1; j < newImage.Size[1] / 4 - 1; j++)
                    {
                        int index = i * oldImage.Size[1] + j;
                        newImage.Values[index] =
                            oldImage.Values[index] * 0.6f +
                            oldImage.Values[index + 1] * 0.1f +
                            oldImage.Values[index - 1] * 0.1f +
                            oldImage.Values[index + oldImage.Size[1]] * 0.1f +
                            oldImage.Values[index - oldImage.Size[1]] * 0.1f;
                    }
                });
            });
        }

        public async static Task asyncConvolutionIIb(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                Parallel.For((newImage.Size[0] - 1) / 4, (newImage.Size[0] - 1) * 2 / 4, i =>
                {
                    for (int j = newImage.Size[1] / 4 - 1; j < newImage.Size[1] * 2 / 4 - 1; j++)
                    {
                        int index = i * oldImage.Size[1] + j;
                        newImage.Values[index] =
                            oldImage.Values[index] * 0.6f +
                            oldImage.Values[index + 1] * 0.1f +
                            oldImage.Values[index - 1] * 0.1f +
                            oldImage.Values[index + oldImage.Size[1]] * 0.1f +
                            oldImage.Values[index - oldImage.Size[1]] * 0.1f;
                    }
                });
            });
        }

        public async static Task asyncConvolutionIIc(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                Parallel.For((newImage.Size[0] - 1) / 4, (newImage.Size[0] - 1) * 2 / 4, i =>
                {
                    for (int j = (newImage.Size[0]) * 2 / 4 - 1; j < (newImage.Size[1]) * 3 / 4 - 1; j++)
                    {
                        int index = i * oldImage.Size[1] + j;
                        newImage.Values[index] =
                            oldImage.Values[index] * 0.6f +
                            oldImage.Values[index + 1] * 0.1f +
                            oldImage.Values[index - 1] * 0.1f +
                            oldImage.Values[index + oldImage.Size[1]] * 0.1f +
                            oldImage.Values[index - oldImage.Size[1]] * 0.1f;
                    }
                });
            });
        }

        public async static Task asyncConvolutionIId(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                Parallel.For((newImage.Size[0] - 1) / 4, (newImage.Size[0] - 1) * 2 / 4, i =>
                {
                    for (int j = (newImage.Size[0]) * 3 / 4 - 1; j < newImage.Size[1] - 1; j++)
                    {
                        int index = i * oldImage.Size[1] + j;
                        newImage.Values[index] =
                            oldImage.Values[index] * 0.6f +
                            oldImage.Values[index + 1] * 0.1f +
                            oldImage.Values[index - 1] * 0.1f +
                            oldImage.Values[index + oldImage.Size[1]] * 0.1f +
                            oldImage.Values[index - oldImage.Size[1]] * 0.1f;
                    }
                });
            });
        }

        public async static Task asyncConvolutionIIIa(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                Parallel.For((newImage.Size[0] - 1) * 2 / 4, (newImage.Size[0] - 1) * 3 / 4, i =>
                {
                    for (int j = 1; j < newImage.Size[1] / 4 - 1; j++)
                    {
                        int index = i * oldImage.Size[1] + j;
                        newImage.Values[index] =
                            oldImage.Values[index] * 0.6f +
                            oldImage.Values[index + 1] * 0.1f +
                            oldImage.Values[index - 1] * 0.1f +
                            oldImage.Values[index + oldImage.Size[1]] * 0.1f +
                            oldImage.Values[index - oldImage.Size[1]] * 0.1f;
                    }
                });
            });
        }

        public async static Task asyncConvolutionIIIb(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                Parallel.For((newImage.Size[0] - 1) * 2 / 4, (newImage.Size[0] - 1) * 3 / 4, i =>
                {
                    for (int j = newImage.Size[1] / 4 - 1; j < newImage.Size[1] * 2 / 4 - 1; j++)
                    {
                        int index = i * oldImage.Size[1] + j;
                        newImage.Values[index] =
                            oldImage.Values[index] * 0.6f +
                            oldImage.Values[index + 1] * 0.1f +
                            oldImage.Values[index - 1] * 0.1f +
                            oldImage.Values[index + oldImage.Size[1]] * 0.1f +
                            oldImage.Values[index - oldImage.Size[1]] * 0.1f;
                    }
                });
            });
        }

        public async static Task asyncConvolutionIIIc(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                Parallel.For((newImage.Size[0] - 1) * 2 / 4, (newImage.Size[0] - 1) * 3 / 4, i =>
                {
                    for (int j = (newImage.Size[0]) * 2 / 4 - 1; j < (newImage.Size[1]) * 3 / 4 - 1; j++)
                    {
                        int index = i * oldImage.Size[1] + j;
                        newImage.Values[index] =
                            oldImage.Values[index] * 0.6f +
                            oldImage.Values[index + 1] * 0.1f +
                            oldImage.Values[index - 1] * 0.1f +
                            oldImage.Values[index + oldImage.Size[1]] * 0.1f +
                            oldImage.Values[index - oldImage.Size[1]] * 0.1f;
                    }
                });
            });
        }

        public async static Task asyncConvolutionIIId(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                Parallel.For((newImage.Size[0] - 1) * 2 / 4, (newImage.Size[0] - 1) * 3 / 4, i =>
                {
                    for (int j = (newImage.Size[0]) * 3 / 4 - 1; j < newImage.Size[1] - 1; j++)
                    {
                        int index = i * oldImage.Size[1] + j;
                        newImage.Values[index] =
                            oldImage.Values[index] * 0.6f +
                            oldImage.Values[index + 1] * 0.1f +
                            oldImage.Values[index - 1] * 0.1f +
                            oldImage.Values[index + oldImage.Size[1]] * 0.1f +
                            oldImage.Values[index - oldImage.Size[1]] * 0.1f;
                    }
                });
            });
        }

        public async static Task asyncConvolutionIVa(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                Parallel.For((newImage.Size[0] - 1) * 3 / 4, newImage.Size[0] - 1, i =>
                {
                    for (int j = 1; j < newImage.Size[1] / 4 - 1; j++)
                    {
                        int index = i * oldImage.Size[1] + j;
                        newImage.Values[index] =
                            oldImage.Values[index] * 0.6f +
                            oldImage.Values[index + 1] * 0.1f +
                            oldImage.Values[index - 1] * 0.1f +
                            oldImage.Values[index + oldImage.Size[1]] * 0.1f +
                            oldImage.Values[index - oldImage.Size[1]] * 0.1f;
                    }
                });
            });
        }

        public async static Task asyncConvolutionIVb(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                Parallel.For((newImage.Size[0] - 1) * 3 / 4, newImage.Size[0] - 1, i =>
                {
                    for (int j = newImage.Size[1] / 4 - 1; j < newImage.Size[1] * 2 / 4 - 1; j++)
                    {
                        int index = i * oldImage.Size[1] + j;
                        newImage.Values[index] =
                            oldImage.Values[index] * 0.6f +
                            oldImage.Values[index + 1] * 0.1f +
                            oldImage.Values[index - 1] * 0.1f +
                            oldImage.Values[index + oldImage.Size[1]] * 0.1f +
                            oldImage.Values[index - oldImage.Size[1]] * 0.1f;
                    }
                });
            });
        }

        public async static Task asyncConvolutionIVc(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                Parallel.For((newImage.Size[0] - 1) * 3 / 4, newImage.Size[0] - 1, i =>
                {
                    for (int j = (newImage.Size[0]) * 2 / 4 - 1; j < (newImage.Size[1]) * 3 / 4 - 1; j++)
                    {
                        int index = i * oldImage.Size[1] + j;
                        newImage.Values[index] =
                            oldImage.Values[index] * 0.6f +
                            oldImage.Values[index + 1] * 0.1f +
                            oldImage.Values[index - 1] * 0.1f +
                            oldImage.Values[index + oldImage.Size[1]] * 0.1f +
                            oldImage.Values[index - oldImage.Size[1]] * 0.1f;
                    }
                });
            });
        }

        public async static Task asyncConvolutionIVd(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                Parallel.For((newImage.Size[0] - 1) * 3 / 4, newImage.Size[0] - 1, i =>
                {
                    for (int j = (newImage.Size[0]) * 3 / 4 - 1; j < newImage.Size[1] - 1; j++)
                    {
                        int index = i * oldImage.Size[1] + j;
                        newImage.Values[index] =
                            oldImage.Values[index] * 0.6f +
                            oldImage.Values[index + 1] * 0.1f +
                            oldImage.Values[index - 1] * 0.1f +
                            oldImage.Values[index + oldImage.Size[1]] * 0.1f +
                            oldImage.Values[index - oldImage.Size[1]] * 0.1f;
                    }
                });
            });
        }

        public async static Task asyncConvolutionTopBottomLine(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                //dla górnej linii
                for (int j = 1; j < newImage.Size[1] - 1; j++)
                {
                    int i = 0;
                    int index = i * newImage.Size[1] + j;
                    newImage.Values[index] =
                        oldImage.Values[index] * 0.6f +
                        oldImage.Values[index - 1] * 0.1f +
                        oldImage.Values[index + 1] * 0.1f +
                        oldImage.Values[index + oldImage.Size[0]] * 0.1f;
                }

                //dla dolnej linii
                for (int j = 1; j < oldImage.Size[1] - 1; j++)
                {
                    int i = 1023;
                    int index = i * oldImage.Size[1] + j;
                    newImage.Values[index] =
                        oldImage.Values[index] * 0.6f +
                        oldImage.Values[index - 1] * 0.1f +
                        oldImage.Values[index + 1] * 0.1f +
                        oldImage.Values[index - oldImage.Size[0]] * 0.1f;
                }
            });
        }

        public async static Task asyncConvolutionCornersLRLine(MyImage newImage, MyImage oldImage)
        {
            await Task.Run(() =>
            {
                //dla prawej linii
                for (int i = 1; i < newImage.Size[0] - 1; i++)
                {
                    int j = 1023;
                    int index = i * newImage.Size[1] + j;
                    newImage.Values[index] =
                        oldImage.Values[index] * 0.6f +
                        oldImage.Values[index - oldImage.Size[0]] * 0.1f +
                        oldImage.Values[index + oldImage.Size[0]] * 0.1f +
                        oldImage.Values[index - 1] * 0.1f;
                }

                //dla lewej linii
                for (int i = 1; i < newImage.Size[0] - 1; i++)
                {
                    int j = 0;
                    int index = i * newImage.Size[1] + j;
                    newImage.Values[index] =
                        oldImage.Values[index] * 0.6f +
                        oldImage.Values[index - oldImage.Size[0]] * 0.1f +
                        oldImage.Values[index + oldImage.Size[0]] * 0.1f +
                        oldImage.Values[index + 1] * 0.1f;
                }

                //górny lewy róg
                newImage.Values[0] =
                    oldImage.Values[0] * 0.6f +
                    oldImage.Values[0 + 1] * 0.1f +
                    oldImage.Values[0 + oldImage.Size[0]] * 0.1f;

                //górny prawy róg
                newImage.Values[oldImage.Size[1]] =
                    oldImage.Values[oldImage.Size[1]] * 0.6f +
                    oldImage.Values[oldImage.Size[1] - 1] * 0.1f +
                    oldImage.Values[oldImage.Size[1] + oldImage.Size[0]] * 0.1f;


                //dolny lewy róg
                newImage.Values[1023 * oldImage.Size[1]] =
                    oldImage.Values[1023 * oldImage.Size[1]] * 0.6f +
                    oldImage.Values[1023 * oldImage.Size[1] + 1] * 0.1f +
                    oldImage.Values[1023 * oldImage.Size[1] - oldImage.Size[0]] * 0.1f;

                //dolny prawy róg
                newImage.Values[1023 * oldImage.Size[1] + 1023] =
                oldImage.Values[1023 * oldImage.Size[1] + 1023] * 0.6f +
                oldImage.Values[1023 * oldImage.Size[1] + 1023 - 1] * 0.1f +
                oldImage.Values[1023 * oldImage.Size[1] + 1023 - oldImage.Size[1]] * 0.1f;
            });
        }
    }
}