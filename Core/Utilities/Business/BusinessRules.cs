using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Core.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            List<IResult> results = new List<IResult>();
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    results.Add(logic);
                }
            }
            return null;
        }
    }
}
