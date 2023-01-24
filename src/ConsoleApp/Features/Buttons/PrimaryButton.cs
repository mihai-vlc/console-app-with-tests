namespace ConsoleApp.Features.Buttons;

using NStack;
using Terminal.Gui;

internal class PrimaryButton : Button {
    public PrimaryButton(ustring text, bool is_default = false) : base(text, is_default) {
        this.ColorScheme = new ColorScheme {
            Normal = new(Color.White, Color.BrightBlue),
            HotNormal = new(Color.White, Color.BrightBlue),
            Focus = new(Color.White, Color.Cyan),
            HotFocus = new(Color.White, Color.Cyan),
            Disabled = new(Color.White, Color.Gray)
        };

    }

    protected override void UpdateTextFormatterText() {
        TextFormatter.Text = " " + Text + " ";
    }
}
