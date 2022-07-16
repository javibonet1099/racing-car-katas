using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter
{
    public class UnicodeFileToHtmlTextConverter : IConverter<string>
    {
        private readonly IUnicodeTextSource _textSource;

        // Moved to UnicodeTextSourceFromFile
        // to have different implementations
        //private string _fullFilenameWithPath;

        public UnicodeFileToHtmlTextConverter(string fullFilenameWithPath)
        {
            //_fullFilenameWithPath = fullFilenameWithPath;
            _textSource = new UnicodeTextSourceFromFile(fullFilenameWithPath);
        }

        public UnicodeFileToHtmlTextConverter(IUnicodeTextSource textSource)
        {
            this._textSource = textSource;
        }

        public string Convert()
        {
            using (TextReader unicodeFileStream = this._textSource.GetTextReader())
            {
                string html = string.Empty;

                string line = unicodeFileStream.ReadLine();
                while (line != null)
                {
                    html += HttpUtility.HtmlEncode(line);
                    html += "<br />";
                    line = unicodeFileStream.ReadLine();
                }

                return html;
            }
        }

        // Unnecessary code.
        //public string GetFilename()
        //{
        //    return _fullFilenameWithPath;
        //}

        // Changed to implementation of converter
        //public string ConvertToHtml()
        //{
        //    using (TextReader unicodeFileStream = File.OpenText(_fullFilenameWithPath))
        //    {
        //        string html = string.Empty;

        //        string line = unicodeFileStream.ReadLine();
        //        while (line != null)
        //        {
        //            html += HttpUtility.HtmlEncode(line);
        //            html += "<br />";
        //            line = unicodeFileStream.ReadLine();
        //        }

        //        return html;
        //    }
        //}
    }
}
