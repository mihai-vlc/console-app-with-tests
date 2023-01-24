namespace ConsoleApp;

using Terminal.Gui;

internal class Program {
    private static void Main(string[] args) {
        Application.Init();

        TerminalView view = new TerminalView();

        try {
            var running = true;
            while (running) {
                var runToken = Application.Begin(view);
                Application.RunLoop(runToken);
                Application.End(runToken);
            }
        } finally {
            Application.Shutdown();
        }
    }
}
