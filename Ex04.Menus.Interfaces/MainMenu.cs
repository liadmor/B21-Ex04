using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        List<MenuItem> m_MenuItems;
        string m_MenuTitle;

        public MainMenu(string i_menuTitle)
        {
            m_MenuTitle = i_menuTitle;
        }

        public void AddMenuItem(MenuItem i_MenuItemToAdd)
        {
            m_MenuItems.Add(i_MenuItemToAdd);
        }

        public void print 


    }
}
