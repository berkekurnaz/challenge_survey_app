using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using QRCoder;

namespace AChallenge.QrCodeCreator
{
    public static class GenerateQrCoder
    {
        public static Byte[] Generate(string qrCodeId)
        {
            QRCodeGenerator _qrCode = new QRCodeGenerator();
            QRCodeData _qrCodeData = _qrCode.CreateQrCode(qrCodeId, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(_qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return BitmapToBytesCode(qrCodeImage);
        }

        private static Byte[] BitmapToBytesCode(Bitmap image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
    }
}
