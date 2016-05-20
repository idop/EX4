using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem 
    {
        protected string m_Title;
        protected List<MenuItem> m_MenuItems;

        public string Title
        {
            get
            {
                return m_Title;
            }
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            if(m_MenuItems == null)
            {
                m_MenuItems = new List<MenuItem>();
            }

            m_MenuItems.Add(i_MenuItem);
        }

        public void RemoveMenuItem(MenuItem i_MenuItem)
        {
            m_MenuItems.Remove(i_MenuItem);
            if (m_MenuItems.Count == 0)
            {
                m_MenuItems = null;
            }
        }

        public IList<MenuItem> GetMenuItems()
        {
            return m_MenuItems.AsReadOnly();
        }
    }
}
