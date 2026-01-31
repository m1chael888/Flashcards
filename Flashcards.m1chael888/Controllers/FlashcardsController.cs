using Flashcards.m1chael888.Views;
using Spectre.Console;
using static Flashcards.m1chael888.Views.MainMenuViewEnums;

namespace Flashcards.m1chael888.Controllers
{
    public interface IFlashcardsController
    {
        void HandleMainMenuOption();
    }
    public class FlashcardsController : IFlashcardsController
    {
        private IMainMenuView _mainMenuView;
        public FlashcardsController(IMainMenuView mainMenuView)
        {
            _mainMenuView = mainMenuView;
        }

        public void HandleMainMenuOption()
        {
            var choice = CallMainMenu();

            switch (choice)
            {
                case MainMenuOption.Temp:
                    Console.WriteLine("under construction");
                    Console.ReadKey();
                    break;
                case MainMenuOption.Exit:
                    Environment.Exit(0);
                    break;
            }
        }

        private MainMenuOption CallMainMenu()
        {
            var choice = _mainMenuView.Call();
            return choice;
        }


    }
}
