using Terminal.Gui;

namespace ConsoleApp;

internal class TerminalView : Window {
    public TerminalView() : base() {
        this.Title = "";
        this.ColorScheme = Colors.TopLevel;
        this.Border.BorderStyle = BorderStyle.None;
        this.Border.Effect3D = false;

        Add(
            new Label("My application") {
                X = Pos.Center(),
                Y = Pos.Top(this),
                Height = 1,
            }
        );

        Add(
            new Label("Username") {
                X = Pos.Center(),
                Y = Pos.Top(this) + 2,
                Height = 1,
            }
        );


        Add(
            new TextField("") {
                X = Pos.Center(),
                Y = Pos.Top(this) + 3,
                Width = Dim.Percent(80),
                Height = 1,
            }
        );

        Add(
            new ColorPicker("Favorite color") {
                X = Pos.Center(),
                Y = Pos.Top(this) + 6,
            }
        );
    }
}
