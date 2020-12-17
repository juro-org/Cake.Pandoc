using System;
using System.Collections.Generic;
using System.Text;

namespace Cake.Pandoc.Enums
{
    public class EnumBaseType
    {
        private string value;

        public EnumBaseType(string value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return this.value;
        }
    }
}
