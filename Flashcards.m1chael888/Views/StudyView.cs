using Spectre.Console;
using static Flashcards.m1chael888.Views.StudyViewEnums;

namespace Flashcards.m1chael888.Views
{
    public interface IStudyView
    {
        StudyMenuOption ShowMenu();
    }
    public class StudyView : IStudyView
    {
        public StudyMenuOption ShowMenu()
        {
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<StudyMenuOption>()
                    .Title("[lime]Study Menu::[/]")
                    .AddChoices(Enum.GetValues<StudyMenuOption>())
                    .HighlightStyle("lime")
                    .WrapAround()
                    );
            return choice;
        }
    }
}
