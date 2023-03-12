namespace ConsoleApp;

using Terminal.Gui;

internal class Program {
    private static void Main(string[] args) {
        Application.Init();

        TerminalTopLevel view = new TerminalTopLevel();

        try {
            var running = true;

            while (running) {
                var runToken = Application.Begin(view);
                Application.RunLoop(runToken);
                Application.End(runToken);
                running = view.Running;
            }
        } finally {
            Application.Shutdown();
        }
    }
}
