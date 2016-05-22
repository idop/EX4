using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class ActionItem
    {
        public event Action<string> m_DoAction;
        public string m_InputStr;
        public ActionItem(string i_InputStr, Action<string> i_Action)
        {
            m_DoAction = i_Action;
            m_InputStr = i_InputStr;
        }
        private void notifyListeners()
        {
            m_DoAction.Invoke(m_InputStr);
        }
    }
}
