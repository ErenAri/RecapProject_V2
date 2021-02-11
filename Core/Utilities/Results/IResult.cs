using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; }
        String Message { get; }
    }
}
