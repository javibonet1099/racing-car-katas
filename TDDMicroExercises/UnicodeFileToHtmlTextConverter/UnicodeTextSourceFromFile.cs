using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter
{
    /// <summary>
    /// Unicode text from file.
    /// </summary>
    public class UnicodeTextSourceFromFile : IUnicodeTextSource
    {
        private readonly string _fullFilenameWithPath;

        public UnicodeTextSourceFromFile(string fullFilenameWithPath)
        {
            this._fullFilenameWithPath = fullFilenameWithPath;
        }

        public TextReader GetTextReader()
        {
            return File.OpenText(this._fullFilenameWithPath);
        }
    }
}
