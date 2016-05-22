using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuItem
    {
        private List<IActionListener> m_ActionListeners;
        private eMenuAction m_MenuAction;

        public enum eMenuAction
        {
            ShowVersion,
            CountChars,
            CountSpace,
            ShowDate,
            ShowTime
        }

        public void AddActionListener(IActionListener i_Listener)
        {
            if (m_ActionListeners == null)
            {
                m_ActionListeners = new List<IActionListener>();
            }

            m_ActionListeners.Add(i_Listener);
        }

        public void RemoveActionListener(IActionListener i_Listener)
        {
            m_ActionListeners.Remove(i_Listener);
            if (m_ActionListeners.Count == 0)
            {
                m_ActionListeners = null;
            }
        }

        public void NotifyAllListeners()
        {
            if (m_ActionListeners != null)
            {
                foreach (IActionListener listener in m_ActionListeners)
                {
                    listener.DoAction(m_MenuAction);
                }
            }
        }

        public ActionItem(string i_Title, eMenuAction i_MenuAction)
        {
            m_Title = i_Title;
            m_MenuAction = i_MenuAction;
        }
    }
}
