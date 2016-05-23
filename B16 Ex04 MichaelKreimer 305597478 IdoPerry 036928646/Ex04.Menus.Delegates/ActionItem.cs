using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void Action();
    public class ActionItem: MenuItem
    {
        public ActionItem(string i_Title)
        {
            m_Title = i_Title;
        }
        public event Action m_ShowAction;
        public string m_InputStr;
        public override void Show()
        {
            m_ShowAction.Invoke();
        }
    }
}
