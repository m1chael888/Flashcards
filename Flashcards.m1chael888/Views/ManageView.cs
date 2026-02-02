using Spectre.Console;
using static Flashcards.m1chael888.Views.ManageViewEnums;

namespace Flashcards.m1chael888.Views
{
    public interface IManageView
    {
        ManageMenuOption CallMenu();
    }
    public class ManageView : IManageView
    {
        public ManageMenuOption CallMenu()
        {
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<ManageMenuOption>()
                    .Title("[lime]Manage Menu::[/]")
                    .AddChoices(Enum.GetValues<ManageMenuOption>())
                    .HighlightStyle("lime")
                    .WrapAround()
                    );
            return choice;
        }
    }
}
