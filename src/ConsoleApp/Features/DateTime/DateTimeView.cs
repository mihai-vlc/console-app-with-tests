namespace ConsoleApp.Features.DateTime {
    using System;
    using Terminal.Gui;

    internal class DateTimeView : Label {
        private object? token;

        public DateTimeView() : base() {
            Text = "Loading...";

            Initialized += OnInitialized;
        }

        private void OnInitialized(object? sender, EventArgs e) {
            token = Application.MainLoop.AddTimeout(TimeSpan.FromSeconds(1), OnUpdate);
        }

        private bool OnUpdate(MainLoop arg) {
            Text = DateTime.Now.ToString();

            return true;
        }

        protected override void Dispose(bool disposing) {
            Application.MainLoop.RemoveTimeout(token);

            base.Dispose(disposing);
        }
    }
}
