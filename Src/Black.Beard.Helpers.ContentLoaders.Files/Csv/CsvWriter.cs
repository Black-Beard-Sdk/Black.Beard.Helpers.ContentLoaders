using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bb.Csv
{


    /// <summary>
    /// manage csv file
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    /// <example>
    /// <code lang="C#">
    /// <![CDATA[
    /// 
    ///    var fileToRead = new FileInfo(Path.Combine("...", "read.csv"));
    ///    var fileToWrite = new FileInfo(Path.Combine("...", "write.csv"));
    ///
    ///    using (var writer = fileToWrite.OpenToWriteCsv())
    ///    {
    ///
    ///        writer.WriteHeaders("Id", "value");
    ///
    ///        foreach (var item2 in fileToRead.ReadBigCsvToJson(true))
    ///        {
    ///            var id = item2["Id"].GetValue<int>();
    ///            var id = item2["Value"].GetValue<int>();
    ///            writer.WriteLine(id, value);
    ///        }
    ///
    ///    }
    /// ]]>
    /// </code>
    /// </example>
    public class CsvWriter : IDisposable
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CsvWriter"/> class.
        /// </summary>
        /// <param name="delimiter">The delimiter.</param>
        /// <param name="quote">The quote.</param>
        /// <param name="escape">The escape.</param>
        public CsvWriter(string delimiter = ";", string quote = null, string escape = "\\")
        {
            this._delimiter = delimiter ?? ";";
            this._quote = quote ?? string.Empty;
            this._escape = escape ?? string.Empty;
        }

        /// <summary>
        /// Writes the header.
        /// </summary>
        /// <param name="hearders">The header list.</param>
        public CsvWriter WriteHeaders(params string[] hearders)
        {
            WriteLine(hearders);
            return this;
        }

        /// <summary>
        /// Writes the specified datas.
        /// </summary>
        /// <param name="datas">The datas.</param>
        public CsvWriter WriteLines(IEnumerable<object[]> datas)
        {
            
            foreach (var item in datas)
                WriteLine(item);

            return this;

        }

        public CsvWriter WriteLine(params object[] datas)
        {

            if (!_initialized)
            {
                _length = datas.Length;
                _initialized = true;
            }
            else
            {
                if (datas.Length < _length)
                    Array.Resize(ref datas, _length);
                
                else if (datas.Length > _length)
                    throw new InvalidDataException("Invalid data length");
            }

            bool t = false;
            foreach (var item in datas)
            {

                if (t)
                    _writer.Write(_delimiter);

                if (!string.IsNullOrEmpty(_quote))
                {
                    _writer.Write(_quote);
                    WriteValue(item, _quote);
                    _writer.Write(_quote);
                }
                else
                    WriteValue(item, _delimiter);

                t = true;

            }

            _writer.WriteLine();

            return this;

        }

        private void WriteValue(object data, string toEscape)
        {

            string value;

            if (data == null)
                value = string.Empty;

            else if (data is string s)
                value = s;
            else
            {
                value = data?.ToString() ?? string.Empty;
            }

            if (!string.IsNullOrEmpty(_escape))
                _writer.Write(value.Replace(toEscape, _escape + toEscape));
            else
                _writer.Write(value);

        }

        #region file

        public CsvWriter Open(string file, Encoding encoding = null)
        {
            var e = encoding ?? Encoding.UTF8;
            _stream = System.IO.File.OpenWrite(file);
            _writer = new System.IO.StreamWriter(_stream, e);

            return this;

        }

        public CsvWriter Open(FileInfo file, Encoding encoding = null)
        {
            var e = encoding ?? Encoding.UTF8;
            _stream = file.OpenWrite();
            _writer = new System.IO.StreamWriter(_stream, e);

            return this;

        }


        public void Close()
        {
            _writer?.Close();
            _stream?.Close();
        }

        public void Flush()
        {
            _writer?.Flush();
            _stream?.Flush();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Flush();
                    Close();
                    _writer?.Dispose();
                    _stream?.Dispose();
                }

                disposedValue = true;
            }
        }

        #endregion file


        private readonly string _delimiter;
        private readonly string _quote;
        private readonly string _escape;
        private FileStream _stream;
        private StreamWriter _writer;
        private bool disposedValue;
        private int _length;
        private bool _initialized;

        public void Dispose()
        {
            // Ne changez pas ce code. Placez le code de nettoyage dans la méthode 'Dispose(bool disposing)'
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

}
