using System;

namespace EDIHelpers.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class EDILength : System.Attribute
    {
        private int _length;
        private char _filler;

        public EDILength(int len, char filler = ' ')
        {
            this._length = len;
            this._filler = filler;
        }
        public int GetFormat()
        {
            return _length;
        }
        public char GetFiller()
        {
            return _filler;
        }

    }
}