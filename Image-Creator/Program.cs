﻿using Image_Creator.Filters;
using Image_Creator.Tools;
using System;
using System.Drawing;

namespace Image_Creator
{
    class Program
    {
        static void Main(string[] args)
        {
            BitmapImage image = new BitmapImage(Console.ReadLine());
            if (image.Source != null)
            {
                CRTFilter.Apply(ref image);
                Console.WriteLine("Image Loaded Successfully");
            }
        }
    }
}
