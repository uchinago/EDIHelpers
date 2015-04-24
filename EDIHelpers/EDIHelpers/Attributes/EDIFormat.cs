using System;

namespace EDIHelpers.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class EDIFormat: System.Attribute
    {
        private string formatType;
        public EDIFormat(string frmt)
        {
            this.formatType = frmt;
        }
        public string GetFormat()
        {
            return formatType;
        }
        public void SetFormat(string frmt)
        {
            formatType = frmt;
        }
      
    }
}