using System;
using Ex04.Menus.Interfaces.Logic;

namespace Ex04.Menus.Interfaces
{
    public class Controller : IActionListener
    {
        private const bool v_IsMainMenu = true;
        private Menu m_MainMenu;

        public void Init()
        {
            m_MainMenu = new Menu("Welcome the the main menu implemented with interfaces", v_IsMainMenu);
            addVersionAndActionsSubMenu();
            addShowDateTimeSubMenu();
            m_MainMenu.SelectItem();
        }

        private void addShowDateTimeSubMenu()
        {
            Menu ShowDateTimeSubMenu = new Menu("Show Date/Time");
            ActionItem action = new ActionItem("Show Time",(int)MenuItemUtils.eMenuAction.ShowTime);
            action.AddActionListener(this);
            ShowDateTimeSubMenu.AddMenuItem(action);
            action = new ActionItem("Show Date",(int)MenuItemUtils.eMenuAction.ShowDate);
            action.AddActionListener(this);
            ShowDateTimeSubMenu.AddMenuItem(action);
            m_MainMenu.AddMenuItem(ShowDateTimeSubMenu);
        }

        private void addVersionAndActionsSubMenu()
        {
            Menu versionAndActionsSubMenu = new Menu("Version and Actions");
            ActionItem action = new ActionItem("Show Version", (int)MenuItemUtils.eMenuAction.ShowVersion);
            action.AddActionListener(this);
            versionAndActionsSubMenu.AddMenuItem(action);
            Menu ActionsSubMenu = new Menu("Actions");
            action = new ActionItem("Chars Count", (int)MenuItemUtils.eMenuAction.CountChars);
            action.AddActionListener(this);
            ActionsSubMenu.AddMenuItem(action);
            action = new ActionItem("Count Spaces", (int)MenuItemUtils.eMenuAction.CountSpace);
            action.AddActionListener(this);
            ActionsSubMenu.AddMenuItem(action);
            versionAndActionsSubMenu.AddMenuItem(ActionsSubMenu);
            m_MainMenu.AddMenuItem(versionAndActionsSubMenu);
        }

        public void OnSelect(int i_Id)
        {
            switch ((MenuItemUtils.eMenuAction) i_Id)
            {
                case MenuItemUtils.eMenuAction.ShowVersion:
                    showVersion();
                    break;
                case MenuItemUtils.eMenuAction.CountChars:
                    countChars();
                    break;
                case MenuItemUtils.eMenuAction.CountSpace:
                    countSpaces();
                    break;
                case MenuItemUtils.eMenuAction.ShowDate:
                    showDate();
                    break;
                case MenuItemUtils.eMenuAction.ShowTime:
                    showTime();
                    break;
                default:
                    break;
            }
        }

        private void countChars()
        {
            int numberOfCharacter;
            string input;
            Console.Clear();
            Console.WriteLine("Please enter a string you want to count the number of characters in");
            input = Console.ReadLine();
            numberOfCharacter = Actions.CountChars(input);
            Console.WriteLine("There are {0} characters in: {1}", numberOfCharacter, input);
            waitForAnyKey(); 
        }

        private void countSpaces()
        {
            int numberOfSpaces;
            string input;
            Console.Clear();
            Console.WriteLine("Please enter a string you want to count the number of spaces in");
            input = Console.ReadLine();
            numberOfSpaces = Actions.CountSpaces(input);
            Console.WriteLine("There are {0} Spaces in: {1}", numberOfSpaces, input);
            waitForAnyKey();
        }

        private void showDate()
        {
            Console.Clear();
            Console.WriteLine("Today's date is: {0:d}", Actions.GetCurrentDateTime());
            waitForAnyKey();
        }

        private void showTime()
        {
            Console.Clear();
            Console.WriteLine("Current Time is: {0:T}", Actions.GetCurrentDateTime());
            waitForAnyKey();
        }

        private void showVersion()
        {
            Console.Clear();
            Console.WriteLine("Version: 16.2.4.0");
            waitForAnyKey();
        }

        private void waitForAnyKey()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
