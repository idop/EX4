using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuItem
    {
        private List<KeyValuePair<IActionListener, MenuItemUtils.eMenuAction>> m_ActionListeners;

        public void AddActionListener(IActionListener i_Listener, MenuItemUtils.eMenuAction i_MenuAction)
        {
            if (m_ActionListeners == null)
            {
                m_ActionListeners = new List<KeyValuePair<IActionListener, MenuItemUtils.eMenuAction>>();
            }

            m_ActionListeners.Add(new KeyValuePair<IActionListener, MenuItemUtils.eMenuAction>(i_Listener, i_MenuAction));
        }

        public void RemoveActionListener(IActionListener i_Listener, MenuItemUtils.eMenuAction i_MenuAction)
        {
            m_ActionListeners.Remove(new KeyValuePair<IActionListener, MenuItemUtils.eMenuAction>(i_Listener, i_MenuAction));
            if (m_ActionListeners.Count == 0)
            {
                m_ActionListeners = null;
            }
        }

        public void NotifyAllListeners()
        {
            if (m_ActionListeners != null)
            {
                foreach (KeyValuePair<IActionListener, MenuItemUtils.eMenuAction> listener in m_ActionListeners)
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
