namespace Quan_Ly_Phong_Kham_Dong_Y
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string maNV;

            using (frmLogin formLogin = new frmLogin())
            {
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    maNV = formLogin.maNV;
                }
                else { 
                    return;
                }
            }
            Application.Run(new frmMain(maNV));
        }
    }
}