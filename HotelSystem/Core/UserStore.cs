namespace HotelSystem
{
    /// <summary>
    /// Temporary user list (no database in the project yet).
    /// Later you can replace Validate() with a database query that returns the Role column.
    /// </summary>
    internal static class UserStore
    {
        private static readonly (string User, string Pass, string Role)[] Users =
        {
            ("admin",     "admin123",     Session.AdminRole),
            ("reception", "reception123", Session.ReceptionistRole),
        };

        /// <summary>Returns the role if the username/password are right, otherwise null.</summary>
        public static string? Validate(string username, string password)
        {
            foreach (var u in Users)
            {
                if (string.Equals(u.User, username, StringComparison.OrdinalIgnoreCase) && u.Pass == password)
                    return u.Role;
            }
            return null;
        }
    }
}
