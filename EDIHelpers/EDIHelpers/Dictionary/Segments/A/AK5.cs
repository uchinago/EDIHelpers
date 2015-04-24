namespace EDIHelpers.Dictionary.Segments
{
    public class AK5Seg : SegmentBase
    {
        public AK5Seg()
            : base("AK5")
        {

        }

        public AK5Seg(char AckCode)
            : base("AK5")
        {
            AK501_AckCode = AckCode;
        }
        public AK5Seg(char AckCode, string[] errorCodes)
            : base("AK5")
        {
            AK501_AckCode = AckCode;
            for (int pntr = 0; pntr < errorCodes.Length; pntr++)
            {
                switch (pntr)
                {
                    case 0: AK502_SyntaxError = errorCodes[pntr];
                        break;
                    case 1: AK502_SyntaxError = errorCodes[pntr];
                        break;
                    case 2: AK502_SyntaxError = errorCodes[pntr];
                        break;
                    case 3: AK502_SyntaxError = errorCodes[pntr];
                        break;
                    case 4: AK502_SyntaxError = errorCodes[pntr];
                        break;
                    default:
                        pntr = errorCodes.Length;
                        break;
                }
            }
        }

        public char AK501_AckCode { get; set; }
        public string AK502_SyntaxError { get; set; }
        public string AK503_SyntaxError { get; set; }
        public string AK504_SyntaxError { get; set; }
        public string AK505_SyntaxError { get; set; }
        public string AK506_SyntaxError { get; set; }

    }
}