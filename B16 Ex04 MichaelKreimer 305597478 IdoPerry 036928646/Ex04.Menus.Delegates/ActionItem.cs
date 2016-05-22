using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void Action();
    public class ActionItem: MenuItem
    {
        public event Action m_ShowAction;
        public string m_InputStr;
        public ActionItem(string i_InputStr)
        {
        }
        private void notifyListeners()
        {
            m_ShowAction.Invoke();
        }
    }
}
