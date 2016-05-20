using System;
using Ex04.Menus.Interfaces.Logic;


namespace Ex04.Menus.Interfaces
{
    public class Controler : ICountCharsActionListener, ICountSpacesActionListener, IShowDateActionListener, IShowTimeActionListener, IShowVersionListener
    {
        private const bool  v_IsMainMenu = true;
        private Menu m_MainMenu;
       

        public void Init()
        {
            m_MainMenu = new Menu("Welcome the the main menu implemented with interfaces",v_IsMainMenu);
            addVersionAndActionsSubMenu();
            addShowDateTimeSubMenu();
            m_MainMenu.Show();
        }

        private void addShowDateTimeSubMenu()
        {
            Menu ShowDateTimeSubMenu = new Menu("Show Date/Time");
            ActionItem action = new ActionItem("Show Time");
            action.AddShowTimeActionListener(this);
            ShowDateTimeSubMenu.AddMenuItem(action);
            action = new ActionItem("Show Date");
            action.AddShowDateActionListener(this);
            ShowDateTimeSubMenu.AddMenuItem(action);
            m_MainMenu.AddMenuItem(ShowDateTimeSubMenu);
        }

        private void addVersionAndActionsSubMenu()
        {
            Menu versionAndActionsSubMenu = new Menu("Version and Actions");
            ActionItem action = new ActionItem("Show Version");
            action.AddShowVersionListener(this);
            versionAndActionsSubMenu.AddMenuItem(action);
            Menu ActionsSubMenu = new Menu("Actions");
            action = new ActionItem("Chars Count");
            action.AddCountCharsActionListener(this);
            ActionsSubMenu.AddMenuItem(action);
            action = new ActionItem("Count Spaces");
            action.AddCountSpacesActionListener(this);
            ActionsSubMenu.AddMenuItem(action);
            versionAndActionsSubMenu.AddMenuItem(ActionsSubMenu);
            m_MainMenu.AddMenuItem(versionAndActionsSubMenu);
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
