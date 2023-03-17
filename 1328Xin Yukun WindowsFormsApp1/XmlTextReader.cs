using System;
using System.Xml;

namespace _1328Xin_Yukun_WindowsFormsApp1
{
    internal class XmlTextReader
    {
        private string v;

        public XmlTextReader(string v)
        {
            this.v = v;
        }

        public XmlNodeType NodeType { get; internal set; }
        public bool HasAttributes { get; internal set; }
        public string Value { get; internal set; }
        public string Name { get; internal set; }

        internal void MoveToAttribute(string v)
        {
            throw new NotImplementedException();
        }

        internal void MoveToElement()
        {
            throw new NotImplementedException();
        }

        internal void MoveToFirstAttribute()
        {
            throw new NotImplementedException();
        }

        internal void MoveToNextAttribute(string v)
        {
            throw new NotImplementedException();
        }

        internal void MoveToNextAttribute()
        {
            throw new NotImplementedException();
        }

        internal bool Read()
        {
            throw new NotImplementedException();
        }

        internal void ReadString()
        {
            throw new NotImplementedException();
        }
    }
}