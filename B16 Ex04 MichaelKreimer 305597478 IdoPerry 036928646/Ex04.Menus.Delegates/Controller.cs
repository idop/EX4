using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class Controller
    {
        private const bool v_IsMainMenu = true;
        public readonly List<MenuItem> m_Employees = new List<MenuItem>();
        private Menu m_MainMenu;

        public void Init()
        {
            m_MainMenu = new Menu("Welcome the the main menu implemented with delegates", v_IsMainMenu);
            addVersionAndActionsSubMenu();
            addShowDateTimeSubMenu();
            m_MainMenu.Show();
        }

        private void addVersionAndActionsSubMenu()
        {
            Menu versionAndActionsSubMenu = new Menu("Version and Actions");
            ActionItem action = new ActionItem("Show Version");
            action.m_ShowAction += this.ShowVersion;
            versionAndActionsSubMenu.AddMenuItem(action);
            Menu ActionsSubMenu = new Menu("Actions");
            action = new ActionItem("Chars Count");
            action.m_ShowAction += this.CountChars;
            ActionsSubMenu.AddMenuItem(action);
            action = new ActionItem("Count Spaces");
            action.m_ShowAction += this.CountSpaces;
            ActionsSubMenu.AddMenuItem(action);
            versionAndActionsSubMenu.AddMenuItem(ActionsSubMenu);
            m_MainMenu.AddMenuItem(versionAndActionsSubMenu);
        }

        private void addShowDateTimeSubMenu()
        {
            Menu ShowDateTimeSubMenu = new Menu("Show Date/Time");
            ActionItem action = new ActionItem("Show Time");
            action.m_ShowAction += this.ShowTime;
            ShowDateTimeSubMenu.AddMenuItem(action);
            action = new ActionItem("Show Date");
            action.m_ShowAction += this.ShowDate;
            ShowDateTimeSubMenu.AddMenuItem(action);
            m_MainMenu.AddMenuItem(ShowDateTimeSubMenu);
        }

        public void CountChars()
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

        public void CountSpaces()
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

        public void ShowDate()
        {
            Console.Clear();
            Console.WriteLine("Today's date is: {0:d}", Actions.GetCurrentDateTime());
            waitForAnyKey();
        }

        public void ShowTime()
        {
            Console.Clear();
            Console.WriteLine("Current Time is: {0:T}", Actions.GetCurrentDateTime());
            waitForAnyKey();
        }

        public void ShowVersion()
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
