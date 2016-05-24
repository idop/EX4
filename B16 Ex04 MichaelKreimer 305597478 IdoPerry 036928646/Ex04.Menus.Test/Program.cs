using Ex04.Menus;

namespace Ex04.Menus.Test
{
    public static class Program
    {
    public static void Main()
        {
            Interfaces.Controller iController = new Interfaces.Controller();
            iController.Init();
            Delegates.Controller dController = new Delegates.Controller();
            dController.Init();
        }
    }
}
