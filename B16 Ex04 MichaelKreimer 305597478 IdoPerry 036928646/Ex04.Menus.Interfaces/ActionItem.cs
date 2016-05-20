using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuItem
    {
        private List<ICountCharsActionListener> m_CountCharActionListeners;
        private List<ICountSpacesActionListener> m_CountSpacesActionListeners;
        private List<IShowDateActionListener> m_ShowDateActionListeners;
        private List<IShowTimeActionListener> m_ShowTimeActionListeners;
        private List<IShowVersionListener> m_ShowVersionListeners;

        public void AddCountCharsActionListener(ICountCharsActionListener i_Listener)
        {
            if (m_CountCharActionListeners == null)
            {
                m_CountCharActionListeners = new List<ICountCharsActionListener>();
            }

            m_CountCharActionListeners.Add(i_Listener);
        }

        public void RemoveCountCharsActionListener(ICountCharsActionListener i_Listener)
        {
            m_CountCharActionListeners.Remove(i_Listener);
            if (m_CountCharActionListeners.Count == 0)
            {
                m_CountCharActionListeners = null;
            }
        }

        private void notifyAllCountCharActionListeners()
        {
            if (m_CountCharActionListeners != null)
            {
                foreach (ICountCharsActionListener listener in m_CountCharActionListeners)
                {
                    listener.CountChars();
                }
            }
        }

        public void AddCountSpacesActionListener(ICountSpacesActionListener i_Listener)
        {
            if (m_CountSpacesActionListeners == null)
            {
                m_CountSpacesActionListeners = new List<ICountSpacesActionListener>();
            }

            m_CountSpacesActionListeners.Add(i_Listener);
        }

        public void RemoveCountSpacesActionListener(ICountSpacesActionListener i_Listener)
        {
            m_CountSpacesActionListeners.Remove(i_Listener);
            if (m_CountSpacesActionListeners.Count == 0)
            {
                m_CountSpacesActionListeners = null;
            }
        }

        private void notifyAllCountSpacesActionListeners()
        {
            if (m_CountSpacesActionListeners != null)
            {
                foreach (ICountSpacesActionListener listener in m_CountSpacesActionListeners)
                {
                    listener.CountSpaces();
                }
            }
        }

        public void AddShowDateActionListener(IShowDateActionListener i_Listener)
        {
            if (m_ShowDateActionListeners == null)
            {
                m_ShowDateActionListeners = new List<IShowDateActionListener>();
            }

            m_ShowDateActionListeners.Add(i_Listener);
        }

        public void RemoveShowDateActionListener(IShowDateActionListener i_Listener)
        {
            m_ShowDateActionListeners.Remove(i_Listener);
            if (m_ShowDateActionListeners.Count == 0)
            {
                m_ShowDateActionListeners = null;
            }
        }

        private void notifyAllShowDateActionListener()
        {
            if (m_ShowDateActionListeners != null)
            {
                foreach (IShowDateActionListener listener in m_ShowDateActionListeners)
                {
                    listener.ShowDate();
                }
            }
        }

        public void AddShowTimeActionListener(IShowTimeActionListener i_Listener)
        {
            if (m_ShowTimeActionListeners == null)
            {
                m_ShowTimeActionListeners = new List<IShowTimeActionListener>();
            }

            m_ShowTimeActionListeners.Add(i_Listener);
        }

        public void RemoveShowTimeActionListener(IShowTimeActionListener i_Listener)
        {
            m_ShowTimeActionListeners.Remove(i_Listener);
            if (m_ShowTimeActionListeners.Count == 0) 
            {
                m_ShowTimeActionListeners = null;
            }
        }

        private void notifyAllShowTimeActionListener()
        {
            if (m_ShowTimeActionListeners != null)
            {
                foreach (IShowTimeActionListener listener in m_ShowTimeActionListeners)
                {
                    listener.ShowTime();
                }
            }
        }

        public void AddShowVersionListener(IShowVersionListener i_Listener)
        {
            if (m_ShowVersionListeners == null)
            {
                m_ShowVersionListeners = new List<IShowVersionListener>();
            }

            m_ShowVersionListeners.Add(i_Listener);
        }

        public void RemoveShowVersionListener(IShowVersionListener i_Listener)
        {
            m_ShowVersionListeners.Remove(i_Listener);
            if (m_ShowVersionListeners.Count == 0)
            {
                m_ShowVersionListeners = null;
            }
        }

        private void notifyAllShowVersionListener()
        {
            if (m_ShowVersionListeners != null)
            {
                foreach (IShowVersionListener listener in m_ShowVersionListeners)
                {
                    listener.ShowVersion();
                }
            }
        }

        public void NotifayAllListeners()
        {
            if (m_CountCharActionListeners != null)
            {
                notifyAllCountCharActionListeners();
            }

            if (m_CountSpacesActionListeners != null)
            {
                notifyAllCountSpacesActionListeners();
            }

            if (m_ShowDateActionListeners != null)
            {
                notifyAllShowDateActionListener();
            }

            if (m_ShowTimeActionListeners != null)
            {
                notifyAllShowTimeActionListener();
            }

            if (m_ShowVersionListeners != null)
            {
                notifyAllShowVersionListener();
            }
        }

        public ActionItem(string i_Title)
        {
            m_Title = i_Title;
        }
    }
}
