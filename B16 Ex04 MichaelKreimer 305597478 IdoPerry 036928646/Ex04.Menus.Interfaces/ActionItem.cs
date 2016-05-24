using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuItem
    {
        private List<IActionListener> m_ActionListeners;
        private int m_Id;

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

        public override void SelectItem()
        {
            if (m_ActionListeners != null)
            {
                foreach (IActionListener listener in m_ActionListeners)
                {
                    listener.OnSelect(m_Id);
                }
            }
        }

        public ActionItem(string i_Title , int i_Id)
        {
            m_Title = i_Title;
            m_Id = i_Id;
        }
    }
}
