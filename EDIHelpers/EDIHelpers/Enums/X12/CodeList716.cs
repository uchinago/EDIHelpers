using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Enums
{

    //TODO: Finish out this type of thing and then update all converters.
    public enum CodeList716
    {
        Blank, //null values
        GrpNotSupported, //1
        GrpVersionNotSupported, //2
        GrpTrailerMissing, //3
        GrpControlNumMisMatch, //4
        TransactionCountBad, //5
        GrpControlNumSyntax, //6
        AuthKeyNameUnknown, //10
        EncryptionKeyUnknown, //11

    }

}
