using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter.Tests
{
    public class UnicodeTextSourceStub : IUnicodeTextSource
    {
        private readonly string _text;

        public UnicodeTextSourceStub(string text)
        {
            this._text = text;
        }
        public TextReader GetTextReader()
        {
            return new StringReader(this._text);
        }
    }
}
