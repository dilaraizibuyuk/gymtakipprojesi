﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymtakipprojesi
{
    class ComboBoxItem
    {
        public string Text
        {
            get;set;
        }
        public object value
        {
            get;set;
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
