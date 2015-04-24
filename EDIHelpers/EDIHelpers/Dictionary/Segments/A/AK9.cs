namespace EDIHelpers.Dictionary.Segments
{
    public class AK9Seg : SegmentBase
    {
        public AK9Seg()
            : base("AK9")
        {

        }
        public AK9Seg(char AckCode, int AK2count, int stCount, int AcceptedCount)
            : base("AK9")
        {
            AK901_GroupAck = AckCode;
            AK902_TransactionCount = AK2count;
            AK903_TransactionsIncluded = stCount;
            AK904_AcceptedTransactions = AcceptedCount;
        }
        public AK9Seg(char AckCode, int AK2count, int stCount, int AcceptedCount, string[] errorCodes)
            : base("AK9")
        {

            AK901_GroupAck = AckCode;
            AK902_TransactionCount = AK2count;
            AK903_TransactionsIncluded = stCount;
            AK904_AcceptedTransactions = AcceptedCount;


            for (int pntr = 0; pntr < errorCodes.Length; pntr++)
            {
                switch (pntr)
                {
                    case 0: AK905_SyntaxError = errorCodes[pntr];
                        break;
                    case 1: AK906_SyntaxError = errorCodes[pntr];
                        break;
                    case 2: AK907_SyntaxError = errorCodes[pntr];
                        break;
                    case 3: AK908_SyntaxError = errorCodes[pntr];
                        break;
                    case 4: AK909_SyntaxError = errorCodes[pntr];
                        break;
                    default:
                        pntr = errorCodes.Length;
                        break;
                }
            }
        }
        public char AK901_GroupAck { get; set; }
        public int? AK902_TransactionCount { get; set; }
        public int? AK903_TransactionsIncluded { get; set; }
        public int? AK904_AcceptedTransactions { get; set; }
        public string AK905_SyntaxError { get; set; }
        public string AK906_SyntaxError { get; set; }
        public string AK907_SyntaxError { get; set; }
        public string AK908_SyntaxError { get; set; }
        public string AK909_SyntaxError { get; set; }

    }
}