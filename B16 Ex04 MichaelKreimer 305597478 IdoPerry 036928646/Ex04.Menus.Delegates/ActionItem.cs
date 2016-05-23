using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void ActionDelegate();

    public class ActionItem : MenuItem
    {
        public ActionItem(string i_Title)
        {
            m_Title = i_Title;
        }

        public event ActionDelegate m_ShowAction;

        public override void Show()
        {
            m_ShowAction.Invoke();
        }
    }
}
