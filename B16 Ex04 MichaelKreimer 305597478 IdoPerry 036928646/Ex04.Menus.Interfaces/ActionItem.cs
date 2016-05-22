using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuItem
    {
        private List<KeyValuePair<IActionListener, eMenuAction>> m_ActionListeners;

        public enum eMenuAction
        {
            ShowVersion,
            CountChars,
            CountSpace,
            ShowDate,
            ShowTime
        }

        public void AddActionListener(IActionListener i_Listener, eMenuAction i_MenuAction)
        {
            if (m_ActionListeners == null)
            {
                m_ActionListeners = new List<KeyValuePair<IActionListener, eMenuAction>>();
            }

            m_ActionListeners.Add(new KeyValuePair<IActionListener, eMenuAction>(i_Listener, i_MenuAction));
        }

        public void RemoveActionListener(IActionListener i_Listener, eMenuAction i_MenuAction)
        {
            m_ActionListeners.Remove(new KeyValuePair<IActionListener, eMenuAction>(i_Listener, i_MenuAction));
            if (m_ActionListeners.Count == 0)
            {
                m_ActionListeners = null;
            }
        }

        public void NotifyAllListeners()
        {
            if (m_ActionListeners != null)
            {
                foreach (KeyValuePair<IActionListener, eMenuAction> listener in m_ActionListeners)
                {
                    listener.Key.DoAction(listener.Value);
                }
            }
        }

        public ActionItem(string i_Title)
        {
            m_Title = i_Title;
        }
    }
}
