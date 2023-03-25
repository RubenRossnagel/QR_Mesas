using QR_Mesas.Droid;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Mobile;
[assembly: Dependency(typeof(QrScanningService))]
namespace QR_Mesas.Droid
{
    public class QrScanningService : IQrScanningService
    {
        public async Task<string> ScanAsync()
        {
            var options = new MobileBarcodeScanningOptions();
            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Escanea el código QR",
                BottomText = "Espera por favor"
            };
            var result = await scanner.Scan(options);
            return result.Text;
        }
    }
}