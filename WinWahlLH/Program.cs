namespace WinWahlLFH
{
    internal static class Program
    {

        public static List<Wahl>? Wahlen;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]        

        static void Main()
        {
            Wahlen = new List<Wahl>();
            Wahlen.Add(new Wahl("Bundestagswahl 2025", 4, new DateTime(2025, 3, 13), 1));
            Wahlen.Add(new Wahl("Sachsen-Anhalt 2025", 4, new DateTime(2025, 9, 25), 2));
            Wahlen.Add(new Wahl("Timbuktu 2025", 4, new DateTime(2025, 10, 25), 3));
            Wahlen.Add(new Wahl("Hessen 2026", 4, new DateTime(2026, 4, 14), 4));


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());

            //Wahlen = new List<Wahl>();
            //DateTime Termin = new DateTime(2024, 11, 25);
            //Wahl myWahl = new Wahl("Bundestagswahl 2024", 4);
        }
    }
}