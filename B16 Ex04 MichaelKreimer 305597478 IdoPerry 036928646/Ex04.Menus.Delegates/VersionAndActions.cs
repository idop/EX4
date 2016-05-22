//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Ex04.Menus.Delegates
//{
//    class VersionAndActions : MenuItem
//    {
//        public override void Show()
//        {
//            Menu versionAndActionsSubMenu = new Menu("Version and Actions");
//            ActionItem action = new ActionItem("Show Version");
//            action.AddShowVersionListener(this);
//            versionAndActionsSubMenu.AddMenuItem(action);
//            Menu ActionsSubMenu = new Menu("Actions");
//            action = new ActionItem("Chars Count");
//            action.AddCountCharsActionListener(this);
//            ActionsSubMenu.AddMenuItem(action);
//            action = new ActionItem("Count Spaces");
//            action.AddCountSpacesActionListener(this);
//            ActionsSubMenu.AddMenuItem(action);
//            versionAndActionsSubMenu.AddMenuItem(ActionsSubMenu);
//            m_MainMenu.AddMenuItem(versionAndActionsSubMenu);
//        }
//    }
//}
