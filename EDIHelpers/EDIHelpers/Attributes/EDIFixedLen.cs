using System;

namespace EDIHelpers.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class EDIFixedLen : System.Attribute
    {
        private int _length;
        private char _filler;

        public EDIFixedLen(int len, char filler = ' ')
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