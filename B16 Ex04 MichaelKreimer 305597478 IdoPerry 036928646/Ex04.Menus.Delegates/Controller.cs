﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class Controller
    {
        private const bool v_IsMainMenu = true;
        private Menu m_MainMenu;

        public void Init()
        {
            m_MainMenu = new Menu("Welcome the the main menu implemented with delegates", v_IsMainMenu);
            addVersionAndActionsSubMenu();
            addShowDateTimeSubMenu();
            m_MainMenu.SelectItem();
        }

        private void addVersionAndActionsSubMenu()
        {
            Menu versionAndActionsSubMenu = new Menu("Version and Actions");
            ActionItem action = new ActionItem("Show Version");
            action.Select += this.showVersionItem_Select;
            versionAndActionsSubMenu.AddMenuItem(action);
            Menu ActionsSubMenu = new Menu("Actions");
            action = new ActionItem("Chars Count");
            action.Select += this.countCharsItem_Select;
            ActionsSubMenu.AddMenuItem(action);
            action = new ActionItem("Count Spaces");
            action.Select += this.countSpacesItem_Select;
            ActionsSubMenu.AddMenuItem(action);
            versionAndActionsSubMenu.AddMenuItem(ActionsSubMenu);
            m_MainMenu.AddMenuItem(versionAndActionsSubMenu);
        }

        private void addShowDateTimeSubMenu()
        {
            Menu ShowDateTimeSubMenu = new Menu("Show Date/Time");
            ActionItem action = new ActionItem("Show Time");
            action.Select += this.showTimeItem_Select;
            ShowDateTimeSubMenu.AddMenuItem(action);
            action = new ActionItem("Show Date");
            action.Select += this.showDateItem_Select;
            ShowDateTimeSubMenu.AddMenuItem(action);
            m_MainMenu.AddMenuItem(ShowDateTimeSubMenu);
        }

        private void countCharsItem_Select(object sender, EventArgs eventArgs)
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

        private void countSpacesItem_Select(object sender, EventArgs eventArgs)
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

        private void showDateItem_Select(object sender, EventArgs eventArgs)
        {
            Console.Clear();
            Console.WriteLine("Today's date is: {0:d}", Actions.GetCurrentDateTime());
            waitForAnyKey();
        }

        private void showTimeItem_Select(object sender, EventArgs eventArgs)
        {
            Console.Clear();
            Console.WriteLine("Current Time is: {0:T}", Actions.GetCurrentDateTime());
            waitForAnyKey();
        }

        private void showVersionItem_Select(object sender, EventArgs eventArgs)
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
