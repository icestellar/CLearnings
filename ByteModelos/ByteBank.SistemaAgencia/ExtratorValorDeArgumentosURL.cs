using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class ExtratorValorDeArgumentosURL
    {
        public ExtratorValorDeArgumentosURL(string url)
        {
            if (url == null) throw new ArgumentNullException(nameof(url), "string nula");
            if (url == "") throw new ArgumentException("Nao e permitido string vazia", nameof(url));
        }
    }
}
