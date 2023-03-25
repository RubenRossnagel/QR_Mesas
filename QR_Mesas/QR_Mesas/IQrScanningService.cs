using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QR_Mesas
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
