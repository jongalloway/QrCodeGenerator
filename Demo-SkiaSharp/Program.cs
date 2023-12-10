﻿//
// QR code generator library (.NET)
// https://github.com/manuelbl/QrCodeGenerator
//
// Copyright (c) 2021 Manuel Bleichenbacher
// Licensed under MIT License
// https://opensource.org/licenses/MIT
//

using System;
using System.IO;
using SkiaSharp;

namespace Net.Codecrete.QrCodeGenerator.Demo
{
    internal class Program
    {
        // Create a QR code and save it as a PNG.
        internal static void Main()
        {
            var text = "Hello, world!";
            var filename = "hello-world-QR.png";

            var qr = QrCode.EncodeText(text, QrCode.Ecc.Medium); // Create the QR code symbol

            qr.SaveAsPng(filename, scale: 10, border: 4);
            Console.WriteLine($"QR code has been saved as {Path.GetFullPath(filename)}");

            filename = "transparent-QR.png";
            qr.SaveAsPng(filename, 10, 4, SKColors.DarkBlue, SKColors.Transparent);
            Console.WriteLine($"QR code has been saved as {Path.GetFullPath(filename)}");
        }
    }
}
