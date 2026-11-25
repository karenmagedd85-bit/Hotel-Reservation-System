namespace HotelSystem
{
    /// <summary>All pages of the system.</summary>
    public enum AppPage
    {
        Login,
        Dashboard,
        Rooms,
        Customers,
        Reservations,
        Payments,
        Reports
    }

    /// <summary>Who is logged in right now + what they are allowed to open.</summary>
    public static class Session
    {
        public const string AdminRole = "Admin";
        public const string ReceptionistRole = "Receptionist";

        public static string? Username { get; private set; }
        public static string? Role { get; private set; }

        public static bool IsLoggedIn => Role != null;
        public static bool IsAdmin => Role == AdminRole;
        public static bool IsReceptionist => Role == ReceptionistRole;

        public static void Start(string username, string role)
        {
            Username = username;
            Role = role;
        }

        public static void End()
        {
            Username = null;
            Role = null;
        }

        /// <summary>
        /// THE place that decides permissions.
        /// Admin        -> every page.
        /// Receptionist -> Dashboard, Customers, Reservations, Payments only.
        /// Change the list below if you want a different split.
        /// </summary>
        public static bool CanAccess(AppPage page)
        {
            if (page == AppPage.Login) return true;
            if (!IsLoggedIn) return false;
            if (IsAdmin) return true;

            if (IsReceptionist)
            {
                return page == AppPage.Dashboard
                    || page == AppPage.Customers
                    || page == AppPage.Reservations
                    || page == AppPage.Payments;
            }

            return false;
        }
    }
}
