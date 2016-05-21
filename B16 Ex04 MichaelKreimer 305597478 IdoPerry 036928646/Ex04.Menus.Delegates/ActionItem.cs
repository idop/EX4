using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    class ActionItem
    {
        public event Action<string> m_DoAction;
        public ActionItem(Action<string>i_Action)
        {
            this.m_DoAction = i_Action;
        }
    }
}
