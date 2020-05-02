using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAsimilados.Resources
{
    class StringWritterWithEncoding : StringWriter
    { 
        public StringWritterWithEncoding( Encoding encoding): base()
        {
            this.m_encoding = encoding;
        }
        private readonly Encoding m_encoding;
        public override Encoding Encoding
        {
            get { return this.m_encoding; }
        }
    }
}
