using System;
using ZXing.Common;

namespace ZXing.Mobile
{
    internal class BarcodeWriter<T>
    {
        public BarcodeFormat Format { get; set; }
        public EncodingOptions Options { get; set; }
        public object Renderer { get; set; }

        internal object Write(string text)
        {
            throw new NotImplementedException();
        }
    }
}