using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Enums
{
    /// <summary>
    /// In this case blank means to ignore the value
    /// </summary>
    public enum YesNo
    {
        Blank, //null
        Yes,  //Y
        No,   //N
        Unknown,  //U
        NotApplicable //W
    }


}
