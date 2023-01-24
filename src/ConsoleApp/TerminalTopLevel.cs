using Terminal.Gui;

namespace ConsoleApp;

internal class TerminalTopLevel : Toplevel {
    private Pos currentRow;
    public TerminalTopLevel() : base() {
        this.LayoutStyle = LayoutStyle.Computed;
        this.currentRow = Pos.Top(this);

        AddElement(
            new Label("My application") {
                X = Pos.Center()
            },
            2
        );

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


        /*
        Add(
            new Label("Username") {
                X = Pos.Center(),
                Y = Pos.Top(this) + 2,
                Height = 1,
            }
        );




        Add(
            new ColorPicker("Favorite color") {
                X = Pos.Center(),
                Y = Pos.Top(this) + 6,
            }
        );

        Add(
            new Button() {
                X = Pos.Center(),
                Y = Pos.Top(this) + 16
            }
        );
        */
    }

    private void AddElement(View view, int marginBottom = 0) {
        view.Y = this.currentRow;

        Add(view);

        this.currentRow = Pos.Bottom(view) + marginBottom;
    }

}
