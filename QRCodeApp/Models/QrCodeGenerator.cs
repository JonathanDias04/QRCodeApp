using QRCoder;
using System.Drawing;

namespace QRCodeApp.Models
{
    public static class QrCodeGenerator
    {
        public static byte[] GenerateImage(string url)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            BitmapByteQRCode qrCode = new BitmapByteQRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(10);

            return qrCodeImage;
        }
    }
}
