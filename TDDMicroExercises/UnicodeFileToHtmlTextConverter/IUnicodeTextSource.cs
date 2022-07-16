using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter
{
    /// <summary>
    /// Different text sources.
    /// </summary>
    public interface IUnicodeTextSource
    {
        /// <summary>
        /// Gets a text reader.
        /// </summary>
        /// <returns></returns>
        TextReader GetTextReader();
    }
}
