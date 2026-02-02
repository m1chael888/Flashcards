using Spectre.Console;
using static Flashcards.m1chael888.Views.MainMenuViewEnums;

namespace Flashcards.m1chael888.Views
{
    public interface IMainMenuView
    {
        MainMenuOption ShowMenu();
    }
    public class MainMenuView : IMainMenuView
    {
        public MainMenuOption ShowMenu()
        {
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<MainMenuOption>()
                    .Title("[lime]Main Menu::[/]")
                    .AddChoices(Enum.GetValues<MainMenuOption>())
                    .HighlightStyle("lime")
                    .WrapAround()
                    );
            return choice;
        }
    }
}
