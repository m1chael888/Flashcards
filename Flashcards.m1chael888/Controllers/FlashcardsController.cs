using Flashcards.m1chael888.Views;
using Spectre.Console;
using static Flashcards.m1chael888.Views.MainMenuViewEnums;
using static Flashcards.m1chael888.Views.StudyViewEnums;
using static Flashcards.m1chael888.Views.ManageViewEnums;

namespace Flashcards.m1chael888.Controllers
{
    public interface IFlashcardsController
    {
        void HandleMainMenu();
    }
    public class FlashcardsController : IFlashcardsController
    {
        private IMainMenuView _mainMenuView;
        private IStudyView _studyView;
        private IManageView _manageView;
        public FlashcardsController(IMainMenuView mainMenuView, IStudyView studyView, IManageView manageView)
        {
            _mainMenuView = mainMenuView;
            _studyView = studyView;
            _manageView = manageView;
        }

        public void HandleMainMenu()
        {
            Console.Clear();
            var choice = CallMainMenu();

            switch (choice)
            {
                case MainMenuOption.Study:
                    HandleStudyMenu();
                    break;
                case MainMenuOption.Manage:
                    HandleManageMenu();
                    break;
                case MainMenuOption.Exit:
                    Environment.Exit(0);
                    break;
            }
        }

        private void HandleStudyMenu()
        {
            var choice = CallStudyMenu();

            switch (choice)
            {
                case StudyMenuOption.Temp:

                    HandleStudyMenu();
                    break;
                case StudyMenuOption.Back:
                    HandleMainMenu();
                    break;
            }
        }

        private void HandleManageMenu()
        {
            var choice = CallManageMenu();

            switch (choice)
            {
                case ManageMenuOption.Temp:

                    HandleManageMenu();
                    break;
                case ManageMenuOption.Back:
                    HandleMainMenu();
                    break;
            }
        }

        ///

        private StudyMenuOption CallStudyMenu()
        {
            var choice = _studyView.CallMenu();
            return choice;
        }

        private ManageMenuOption CallManageMenu()
        {
            var choice = _manageView.CallMenu();
            return choice;
        }

        private MainMenuOption CallMainMenu()
        {
            var choice = _mainMenuView.Call();
            return choice;
        }

        private void ReturnToMainMenu()
        {
            AnsiConsole.Status()
                .Spinner(Spinner.Known.Point)
                .SpinnerStyle("white")
                .Start("Press any key to return to menu", x =>
                {
                    Console.ReadKey();
                });
            HandleMainMenu();
        }
    }
}
