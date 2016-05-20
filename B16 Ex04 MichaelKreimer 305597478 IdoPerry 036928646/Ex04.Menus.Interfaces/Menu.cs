using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class Menu : MenuItem
    {
        private const string k_ChooseMenuItemMessage = "Please Choose one of the following options:";
        private const string k_BackChoiseMessage = "Press 0 to go back to previous menu.";
        private const string k_ExitChoiseMessage = "Press 0 to exit.";
        private const string k_InvalidInputMessage = "Invalid Choise please try again.";
        private const int k_ExitOrBackOptionValue = 0;
        private bool m_IsMainMenu = false;

        public Menu(string i_Title)
        {
            m_Title = i_Title;
        }

        public Menu(string i_Title, bool i_IsMainMenu)
        {
            m_Title = i_Title;
            m_IsMainMenu = i_IsMainMenu;
        }

        public void Show()
        {
            bool userWantsToGoBack = false;
            while (!userWantsToGoBack)
            {
                Console.Clear();
                Console.WriteLine(m_Title);
                displayMenuItems();
                Console.WriteLine(m_IsMainMenu ? k_ExitChoiseMessage : k_BackChoiseMessage);
                userWantsToGoBack = chooseMenuItem();
            }
        }

        private bool chooseMenuItem()
        {
            bool invalidInput = true;
            bool userWantsToGoBack = false;
            int userChoise = 0;
            while (invalidInput)
            {
                try
                {

                    userChoise = int.Parse(Console.ReadLine());
                    if (isUserChoiseValid(userChoise))
                    {
                        if (userChoise == k_ExitOrBackOptionValue)
                        {
                            userWantsToGoBack = true;
                        }
                        else
                        {
                            activateMenuItem(userChoise - 1);
                        }

                        invalidInput = false;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (FormatException)
                {

                    Console.WriteLine(k_InvalidInputMessage);
                }
                catch (ArgumentOutOfRangeException)
                {

                    Console.WriteLine(k_InvalidInputMessage);
                }
            }

            return userWantsToGoBack;
        }

        private void activateMenuItem(int i_UserChoise)
        {
            MenuItem menuItemToActivate = m_MenuItems[i_UserChoise];
            if(menuItemToActivate is Menu)
            {
                ((Menu)menuItemToActivate).Show();
            }
            else if(menuItemToActivate is ActionItem)
            {
                ((ActionItem)menuItemToActivate).NotifayAllListeners();
            }
        }

        private bool isUserChoiseValid(int userChoise)
        {
            return userChoise >= k_ExitOrBackOptionValue && userChoise <= m_MenuItems.Count;
        }

        private void displayMenuItems()
        {
            int itemNumber = 1;

            foreach (MenuItem menuItem in m_MenuItems)
            {
                Console.WriteLine("Enter {0} for {1}.", itemNumber, menuItem.Title);
                ++itemNumber;
            }
        }
    }
}
