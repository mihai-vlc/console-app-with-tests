using ConsoleApp.Features.DateTime;
using Terminal.Gui;

namespace ConsoleApp;

internal class TerminalTopLevel : Toplevel {
    private Pos currentRow;
    public TerminalTopLevel() : base() {
        this.LayoutStyle = LayoutStyle.Computed;
        this.currentRow = Pos.Top(this);

        var title = new View() {
            X = Pos.Center(),
            Width = Dim.Fill(),
            AutoSize = true,
            Height = 2,
        };

        title.Add(
            new Label("My application") {
                X = Pos.Left(title) + 2
            }
        );

        title.Add(
            new DateTimeView() {
                X = Pos.AnchorEnd(25)
            }
        );

        AddElement(title);

        AddElement(new LineView(), 2);

        AddElement(
            new Label("Username") {
                X = Pos.Center()
            }
        );

        AddElement(
            new TextField("") {
                X = Pos.Center(),
                Width = Dim.Percent(80),
            },
            1
        );

        AddElement(
            new ColorPicker("Favorite color") {
                X = Pos.Center()
            },
            1
        );

        AddElement(
            new Button("Save") {
                X = Pos.Center()
            }
        );

    }

    private void AddElement(View view, int marginBottom = 0) {
        view.Y = this.currentRow;

        Add(view);

        this.currentRow = Pos.Bottom(view) + marginBottom;
    }

}
