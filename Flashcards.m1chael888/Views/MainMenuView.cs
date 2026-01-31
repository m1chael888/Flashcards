using Spectre.Console;
using static Flashcards.m1chael888.Views.MainMenuViewEnums;

namespace Flashcards.m1chael888.Views
{
    public interface IMainMenuView
    {
        MainMenuOption Call();
    }
    public class MainMenuView : IMainMenuView
    {
        public MainMenuOption Call()
        {
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<MainMenuOption>()
                    .Title("[green]Main Menu::[/]")
                    .AddChoices(Enum.GetValues<MainMenuOption>())
                    .HighlightStyle("green")
                    .WrapAround()
                    );
            return choice;
        }
    }
}
