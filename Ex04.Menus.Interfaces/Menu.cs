using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class Menu
    {
        string m_Title;
        List<MenuItem> m_MenuItems;
        string m_MenuType;

        public Menu(string i_MenuTitle)
        {
            m_Title = i_MenuTitle;
        }

        public string Title
        {
            get 
            {
                return m_Title;
            }
            set
            {
                m_Title = value;
            }
        }

        public void AddMenuItem(MenuItem i_MenuItemToAdd)
        {
            m_MenuItems.Add(i_MenuItemToAdd);
        }

        public void SelectedOptino()
        {
            int userChoice;

            while (true)
            {
                Console.Clear();
                displayMenu();
                userChoice = getUserChoice();
            }

        }

        public StringBuilder GetSubMenuName()
        {
            int itemLocation = 0;
            StringBuilder subMenu = new StringBuilder();
            foreach(MenuItem item in m_MenuItems){
                subMenu.Append(itemLocation);
                subMenu.Append(". ");
                subMenu.Append(item.MenuItemName);
                itemLocation++;
            }

            return subMenu;
        }

        public int getUserChoice()
        {
            string msg;
            int userChoice;

            msg = string.Format("Please enter your choice (1-{0} or 0 to exit):", m_MenuItems.Count + 1);
            Console.WriteLine(msg);
            userChoice = int.Parse(Console.ReadLine());

            return userChoice;

        }

        public void displayMenu()
        {
            Console.WriteLine(
            @"{0}
            ==============
            {1}
            ",
            Title,
            GetSubMenuName());
        }
    }
}

