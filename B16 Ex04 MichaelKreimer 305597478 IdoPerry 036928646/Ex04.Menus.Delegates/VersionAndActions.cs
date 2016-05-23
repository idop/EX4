using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    class VersionAndActions : MenuItem
    {
        public VersionAndActions()
        {
            init();
        }
        public override void Show()
        {
            throw new NotImplementedException();
        }
        private void init()
        {
            addShowVersion();
        }

        private void addShowVersion()
        {
            throw new NotImplementedException();
        }
    }
}
