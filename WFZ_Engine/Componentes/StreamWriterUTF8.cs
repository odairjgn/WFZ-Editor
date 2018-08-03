using System.IO;
using System.Text;

namespace WFZ_Engine.Componentes
{
    public class StreamWriterUTF8 : StreamWriter
    {
        public override Encoding Encoding => Encoding.UTF8;

        public StreamWriterUTF8(Stream stream) : base(stream)
        {
        }

        public StreamWriterUTF8(Stream stream, Encoding encoding) : base(stream, encoding)
        {
        }

        public StreamWriterUTF8(Stream stream, Encoding encoding, int bufferSize) : base(stream, encoding, bufferSize)
        {
        }

        public StreamWriterUTF8(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) : base(stream, encoding, bufferSize, leaveOpen)
        {
        }

        public StreamWriterUTF8(string path) : base(path)
        {
        }

        public StreamWriterUTF8(string path, bool append) : base(path, append)
        {
        }

        public StreamWriterUTF8(string path, bool append, Encoding encoding) : base(path, append, encoding)
        {
        }

        public StreamWriterUTF8(string path, bool append, Encoding encoding, int bufferSize) : base(path, append, encoding, bufferSize)
        {
        }
    }
}
