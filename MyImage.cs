﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PGM
{
    class MyImage
    {
        private float[] values;
        private int[] size;

        public MyImage(int width, int height)
        {
            this.Size = new int[2];
            Size[0] = height;
            Size[1] = width;
            values = new float[height * width];
            for (int i = 0; i < height * width; i++)
            {
                values[i] = 0;
            }
        }

        public MyImage convolution()
        {
            MyImage img = new MyImage(size[1], size[0]);

            for (int i = 1; i < size[0] - 1; i++)
            {
                for (int j = 1; j < size[1] - 1; j++)
                {
                    int index = i * size[1] + j;
                    img.values[index] =
                        values[index] * 0.6f +
                        values[index + 1] * 0.1f +
                        values[index - 1] * 0.1f +
                        values[index + size[1]] * 0.1f +
                        values[index - size[1]] * 0.1f;
                }
            }

            //dla górnej linii
            for (int j = 1; j < size[1] - 1;j++)
            {
                int i = 0;
                int index = i * size[1] + j;
                img.values[index] =
                    values[index] * 0.6f +
                    values[index - 1] * 0.1f +
                    values[index + 1] * 0.1f +
                    values[index + size[0]] * 0.1f;
            }

            //dla dolnej linii
            for (int j = 1; j < size[1] - 1;j++)
            {
                int i = 1023;
                int index = i * size[1] + j;
                img.values[index] =
                    values[index] * 0.6f +
                    values[index - 1] * 0.1f +
                    values[index + 1] * 0.1f +
                    values[index - size[0]] * 0.1f;
            }

            //dla prawej linii
            for (int i = 1; i < size[0] - 1;i++)
            {
                int j = 1023;
                int index = i * size[1] + j;
                img.values[index] =
                    values[index] * 0.6f +
                    values[index - size[0]] * 0.1f +
                    values[index + size[0]] * 0.1f +
                    values[index - 1] * 0.1f;
            }

            //dla lewej linii
            for (int i = 1; i < size[0] - 1; i++)
            {
                int j = 0;
                int index = i * size[1] + j;
                img.values[index] =
                    values[index] * 0.6f +
                    values[index - size[0]] * 0.1f +
                    values[index + size[0]] * 0.1f +
                    values[index + 1] * 0.1f;
            }


            //górny lewy róg
            img.values[0] =
                values[0] * 0.6f +
                values[0 + 1] * 0.1f +
                values[0 + size[0]] * 0.1f;

            //górny prawy róg
            img.values[size[1]] =
                values[size[1]] * 0.6f +
                values[size[1] - 1] * 0.1f +
                values[size[1] + size[0]];

            //dolny lewy róg
            img.values[size[0] * size[1] - 1023] =
                values[size[0] * size[1] - 1023] * 0.6f +
                values[size[0] * size[1] - 1023 + 1] * 0.1f +
                values[size[0] * size[1] - 1023 - size[1]] * 0.1f;

            //dolny prawy róg
            img.values[1023 * size[1]] =
                values[1023 * size[1]] * 0.6f +
                values[1023 * size[1] - 1] * 0.1f +
                values[1023 * size[1] - size[0]] * 0.1f;

            return img;
        }


        internal Task<MyImage> CenterPixelsAsync(MyImage img)
        {
            img = new MyImage(size[1], size[0]);

            return Task.Run(() =>
            {
                for (int i = 1; i < size[0] - 1; i++)
                {
                    for (int j = 1; j < size[1] - 1; j++)
                    {
                        int index = i * size[1] + j;
                        img.values[index] =
                            values[index] * 0.6f +
                            values[index + 1] * 0.1f +
                            values[index - 1] * 0.1f +
                            values[index + size[1]] * 0.1f +
                            values[index - size[1]] * 0.1f;
                    }
                }
                return img;
            });
        }

        internal Task<MyImage> TopPixelsAsync(MyImage img)
        {
            img = new MyImage(size[1], size[0]);

            return Task.Run(() =>
            {
                for (int j = 1; j < size[1] - 1; j++)
                {
                    int i = 0;
                    int index = i * size[1] + j;
                    img.values[index] =
                        values[index] * 0.6f +
                        values[index - 1] * 0.1f +
                        values[index + 1] * 0.1f +
                        values[index + size[0]] * 0.1f;
                }
                return img;
            });
        }

        internal Task<MyImage> BottomPixelsAsync(MyImage img)
        {
            img = new MyImage(size[1], size[0]);

            return Task.Run(() =>
            {
                for (int j = 1; j < size[1] - 1; j++)
                {
                    int i = 1023;
                    int index = i * size[1] + j;
                    img.values[index] =
                        values[index] * 0.6f +
                        values[index - 1] * 0.1f +
                        values[index + 1] * 0.1f +
                        values[index - size[0]] * 0.1f;
                }
                return img;
            });
        }

        internal Task<MyImage>RightPixelsAsync(MyImage img)
        {
            img = new MyImage(size[1], size[0]);

            return Task.Run(() =>
            {
                for (int i = 1; i < size[0] - 1; i++)
                {
                    int j = 1023;
                    int index = i * size[1] + j;
                    img.values[index] =
                        values[index] * 0.6f +
                        values[index - size[0]] * 0.1f +
                        values[index + size[0]] * 0.1f +
                        values[index - 1] * 0.1f;
                }
                return img;
            });
        }

        internal Task<MyImage> LeftPixelsAsync(MyImage img)
        {
            img = new MyImage(size[1], size[0]);

            return Task.Run(() =>
            {
                for (int i = 1; i < size[0] - 1; i++)
                {
                    int j = 0;
                    int index = i * size[1] + j;
                    img.values[index] =
                        values[index] * 0.6f +
                        values[index - size[0]] * 0.1f +
                        values[index + size[0]] * 0.1f +
                        values[index + 1] * 0.1f;
                }
                return img;
            });
        }


        public MyImage asyncconvolution(MyImage img)
        {
            img = new MyImage(size[1], size[0]);

            TopPixelsAsync(img);
            BottomPixelsAsync(img);
            RightPixelsAsync(img);
            LeftPixelsAsync(img);

            //górny lewy róg
            img.values[0] =
                values[0] * 0.6f +
                values[0 + 1] * 0.1f +
                values[0 + size[0]] * 0.1f;

            //górny prawy róg
            img.values[size[1]] =
                values[size[1]] * 0.6f +
                values[size[1] - 1] * 0.1f +
                values[size[1] + size[0]];

            //dolny lewy róg
            img.values[size[0] * size[1] - 1023] =
                values[size[0] * size[1] - 1023] * 0.6f +
                values[size[0] * size[1] - 1023 + 1] * 0.1f +
                values[size[0] * size[1] - 1023 - size[1]] * 0.1f;

            //dolny prawy róg
            img.values[1023 * size[1]] =
                values[1023 * size[1]] * 0.6f +
                values[1023 * size[1] - 1] * 0.1f +
                values[1023 * size[1] - size[0]] * 0.1f;

            return img;
        }


        public void CreateCheckerboard(int l)
        {
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    int index = i * size[1] + j;
                    int liczba_pikseli_na_pole_w = size[1] / l;
                    int liczba_pikseli_na_pole_h = size[0] / l;
                    if (((i / liczba_pikseli_na_pole_h) + (j / liczba_pikseli_na_pole_w)) % 2 == 0)
                        values[index] = 0;
                    else
                        values[index] = 1;
                }
            }
        }

        public void printConsole()
        {
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    int index = i * size[1] + j;
                    Console.Write("{0}\t", values[index]);
                }
                Console.WriteLine();
            }
        }

        public float[] Values { get => values; set => values = value; }
        public int[] Size { get => size; set => size = value; }
    }
}