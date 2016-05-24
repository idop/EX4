using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{


    public class ActionItem : MenuItem
    {
        public ActionItem(string i_Title)
        {
            m_Title = i_Title;
        }

        public override void SelectItem()
        {
            OnSelect(new EventArgs());
        }
    }
}
