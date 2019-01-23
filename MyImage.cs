using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PGM3
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

        public void Convolution(MyImage newImage, MyImage oldImage)
        {
            for (int i = 1; i < newImage.Size[0] - 1; i++)
            {
                for (int j = 1; j < newImage.Size[1] - 1; j++)
                {
                    int index = i * oldImage.Size[1] + j;
                    newImage.Values[index] =
                        oldImage.Values[index] * 0.6f +
                        oldImage.Values[index + 1] * 0.1f +
                        oldImage.Values[index - 1] * 0.1f +
                        oldImage.Values[index + oldImage.Size[1]] * 0.1f +
                        oldImage.Values[index - oldImage.Size[1]] * 0.1f;
                }
            }

            //dla górnej linii
            for (int j = 1; j < oldImage.Size[1] - 1; j++)
            {
                int i = 0;
                int index = i * oldImage.Size[1] + j;
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

            //dla prawej linii
            for (int i = 1; i < oldImage.Size[0] - 1; i++)
            {
                int j = 1023;
                int index = i * oldImage.Size[1] + j;
                newImage.Values[index] =
                    oldImage.Values[index] * 0.6f +
                    oldImage.Values[index - oldImage.Size[0]] * 0.1f +
                    oldImage.Values[index + oldImage.Size[0]] * 0.1f +
                    oldImage.Values[index - 1] * 0.1f;
            }

            //dla lewej linii
            for (int i = 1; i < oldImage.Size[0] - 1; i++)
            {
                int j = 0;
                int index = i * oldImage.Size[1] + j;
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
        }

        public void CreateCheckerboard(int l)
        {
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    int index = i * size[1] + j;
                    int pixel_field_w = size[1] / l;
                    int pixel_field_h = size[0] / l;
                    if (((i / pixel_field_h) + (j / pixel_field_w)) % 2 == 0)
                        values[index] = 0;
                    else
                        values[index] = 1;
                }
            }
        }

        public float[] Values { get => values; set => values = value; }
        public int[] Size { get => size; set => size = value; }
    }
}