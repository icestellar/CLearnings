using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class ExtratorValorDeArgumentosURL
    {
        public string URL { get; }
        private readonly string _argumentos; 
        //public ExtratorValorDeArgumentosURL(string url)
        //{
        //    if (url == null) throw new ArgumentNullException(nameof(url), "string nula");
        //    if (url == "") throw new ArgumentException("Nao e permitido string vazia", nameof(url));
        //}
        public ExtratorValorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url)) throw new ArgumentException("O argumento Url nao pode ser vazio ou nulo", nameof(url));
            URL = url;
            _argumentos = url.Substring(url.IndexOf("?")+1);
        }

        public string GetValor(string nomeDoParametro)
        {
            string termo = nomeDoParametro.ToLower() + "=";
            int indiceTermo = _argumentos.IndexOf(termo);
            //string resultado: _argumentos.Substring(indiceTermo + termo.Length);
            if (_argumentos.Substring(indiceTermo + termo.Length).IndexOf("&") == -1) return _argumentos.Substring(indiceTermo + termo.Length);
            return _argumentos.Substring(indiceTermo + termo.Length).Remove(_argumentos.Substring(indiceTermo + termo.Length).IndexOf("&"));
        }


    }
}
