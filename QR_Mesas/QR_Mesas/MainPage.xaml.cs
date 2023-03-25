using System;
using Xamarin.Forms;
using System.IO;
using QRCoder;

namespace QR_Mesas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GenerateButton_Clicked(object sender, EventArgs e)
        {
            string codeValue = "Texto a codificar en el código QR";
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(codeValue, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new PngByteQRCode(qrCodeData);
            var qrCodeBytes = qrCode.GetGraphic(20);
            var qrCodeImage = ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));
            QrCodeContainer.Content = new Image { Source = qrCodeImage };
        }

        async private void ScanButton_Clicked(object sender, EventArgs e)
        {
            var scanner = DependencyService.Get<IQrScanningService>();
            var result = await scanner.ScanAsync();
            QrContentLabel.Text = result;
            // Usa el resultado del escaneo
        }
    }
}
