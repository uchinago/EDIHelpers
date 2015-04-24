using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Composites
{
    public class C052_StatusCodes: CompositeBase
    {
        public C052_StatusCodes()
        {
            
        }
       
        /// <summary>
        /// A = Medicare Part A
        /// B = Medicare Part B
        /// C = Medicare Part A and B
        /// D = Medicare
        /// E = No Medicare
        /// </summary>
        private char C05201_PlanCode;
        /// <summary>
        /// 0 = Age
        /// 1 = Disability
        /// 2 = End STage Renal Disease (ESRD)
        /// </summary>
        private char C05202_ReasonCode;
        /// <summary>
        /// 0 = Age
        /// 1 = Disability
        /// 2 = End STage Renal Disease (ESRD)
        /// </summary>
        private char C05203_ReasonCode;
        /// <summary>
        /// 0 = Age
        /// 1 = Disability
        /// 2 = End STage Renal Disease (ESRD)
        /// </summary>
        private char C05204_ReasonCode;


        /// <summary>
        /// A = Medicare Part A
        /// B = Medicare Part B
        /// C = Medicare Part A and B
        /// D = Medicare
        /// E = No Medicare
        /// </summary>
        public char C05201PlanCode
        {
            get { return C05201_PlanCode; }
            set { C05201_PlanCode = value; }
        }

        /// <summary>
        /// 0 = Age
        /// 1 = Disability
        /// 2 = End STage Renal Disease (ESRD)
        /// </summary>
        public char C05202ReasonCode
        {
            get { return C05202_ReasonCode; }
            set { C05202_ReasonCode = value; }
        }

        /// <summary>
        /// 0 = Age
        /// 1 = Disability
        /// 2 = End STage Renal Disease (ESRD)
        /// </summary>
        public char C05203ReasonCode
        {
            get { return C05203_ReasonCode; }
            set { C05203_ReasonCode = value; }
        }

        /// <summary>
        /// 0 = Age
        /// 1 = Disability
        /// 2 = End STage Renal Disease (ESRD)
        /// </summary>
        public char C05204ReasonCode
        {
            get { return C05204_ReasonCode; }
            set { C05204_ReasonCode = value; }
        }
    }
}
