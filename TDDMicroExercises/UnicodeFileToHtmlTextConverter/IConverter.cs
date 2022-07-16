using System;
using System.Collections.Generic;
using System.Text;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter
{
    interface IConverter<T>
    {
        /// <summary>
        /// Converts to specific type.
        /// </summary>
        /// <returns>Element.</returns>
        T Convert();
    }
}
