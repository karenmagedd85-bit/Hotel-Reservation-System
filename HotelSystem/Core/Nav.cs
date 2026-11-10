namespace HotelSystem
{
    /// <summary>Opens pages, links the sidebar buttons of every form, and enforces permissions.</summary>
    public static class Nav
    {
        public static ApplicationContext Context { get; } = new ApplicationContext();

        // Sidebar button text (lower-case) -> page
        private static readonly Dictionary<string, AppPage> Labels = new Dictionary<string, AppPage>
        {
            ["dashboard"] = AppPage.Dashboard,

            ["room management"] = AppPage.Rooms,
            ["rooms"] = AppPage.Rooms,

            ["customer management"] = AppPage.Customers,
            ["customer"] = AppPage.Customers,
            ["customers"] = AppPage.Customers,

            ["reservation management"] = AppPage.Reservations,
            ["reservation"] = AppPage.Reservations,
            ["reservations"] = AppPage.Reservations,

            ["payment"] = AppPage.Payments,
            ["payments"] = AppPage.Payments,

            ["reports and statistics"] = AppPage.Reports,
            ["report and statistics"] = AppPage.Reports,
            ["reports and analytics"] = AppPage.Reports,
        };

        private static Form Create(AppPage page)
        {
            switch (page)
            {
                case AppPage.Login:        return new LoginForm();
                case AppPage.Dashboard:    return new DashboardForm();
                case AppPage.Rooms:        return new RoomsForm();
                case AppPage.Customers:    return new CustomersForm();
                case AppPage.Reservations: return new ReservationForm();
                case AppPage.Payments:     return new PaymentForm();
                case AppPage.Reports:      return new ReportsForm();
                default: throw new ArgumentOutOfRangeException(nameof(page));
            }
        }

        public static void Start()
        {
            Session.End();
            Form login = Create(AppPage.Login);
            Context.MainForm = login;
            login.Show();
        }

        /// <summary>Open a page and close the current one (blocked if the role is not allowed).</summary>
        public static void Go(AppPage target, Form? from)
        {
            if (!Session.CanAccess(target))
            {
                MessageBox.Show("You do not have permission to open this page.", "Access denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form next = Create(target);

            if (from != null)
            {
                next.StartPosition = FormStartPosition.Manual;
                next.Location = from.Location;
                if (from.WindowState == FormWindowState.Maximized)
                    next.WindowState = FormWindowState.Maximized;
            }

            Context.MainForm = next;   // switch first so closing the old form does not end the app
            next.Show();
            from?.Close();
        }

        public static void Logout(Form from)
        {
            Session.End();
            Go(AppPage.Login, from);
        }

        /// <summary>
        /// Called once in every form's constructor.
        /// Links the sidebar buttons to their pages and the logout controls to Logout.
        /// Pages the current role cannot open are greyed out (and blocked in Go() anyway).
        /// </summary>
        public static void Wire(Form form)
        {
            foreach (Control c in AllControls(form))
            {
                if (c.Name.IndexOf("logout", StringComparison.OrdinalIgnoreCase) >= 0
                    && (c is Button || c is PictureBox || c is Label))
                {
                    c.Cursor = Cursors.Hand;
                    c.Click += (s, e) => Logout(form);
                    continue;
                }

                // Sidebar items are Buttons in most forms, and Labels named btn.../lab... in the Customers form
                // (page titles such as lblTitle are Labels too, so they are skipped on purpose)
                bool isSidebarItem = c is Button
                    || (c is Label && (c.Name.StartsWith("btn", StringComparison.OrdinalIgnoreCase)
                                    || c.Name.StartsWith("lab", StringComparison.OrdinalIgnoreCase)));

                if (isSidebarItem
                    && Labels.TryGetValue(c.Text.Trim().ToLowerInvariant(), out AppPage page))
                {
                    if (!Session.CanAccess(page))
                    {
                        c.Enabled = false;
                        continue;
                    }

                    AppPage target = page;
                    c.Cursor = Cursors.Hand;
                    c.Click += (s, e) => Go(target, form);
                }
            }
        }

        private static IEnumerable<Control> AllControls(Control root)
        {
            foreach (Control child in root.Controls)
            {
                yield return child;
                foreach (Control grandChild in AllControls(child))
                    yield return grandChild;
            }
        }
    }
}
