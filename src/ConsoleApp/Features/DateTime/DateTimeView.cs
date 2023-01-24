namespace ConsoleApp.Features.DateTime {
    using System;
    using Terminal.Gui;

    internal class DateTimeView : View {
        private Label content;
        private object? token;

        public DateTimeView() : base() {
            content = new Label();

            Initialized += OnInitialized;
            Add(this.content);
        }

        private void OnInitialized(object? sender, EventArgs e) {
            token = Application.MainLoop.AddTimeout(TimeSpan.FromSeconds(1), OnUpdate);
        }

        private bool OnUpdate(MainLoop arg) {
            content.Text = DateTime.Now.ToString();

            return true;
        }

        protected override void Dispose(bool disposing) {
            Application.MainLoop.RemoveTimeout(token);

            base.Dispose(disposing);
        }
    }
}
