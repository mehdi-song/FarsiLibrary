﻿using FarsiLibrary.Win.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarsiLibrary.Win.Helpers
{
    class EnglishCalendarScroller : ICalendarScroller
    {
        public EnglishCalendarScroller(FADatePicker picker)
        {

        }

        bool ICalendarScroller.CanScroll { get { return false; } }

        void ICalendarScroller.SetDate(int delta)
        {
        }

        void ICalendarScroller.SetSelection(int selectionStart)
        {

        }
    }
}
