namespace VersionAttribute
{
    using System;

    //Apply the version attribute to a sample class and display its version at runtime.

    [Version("2.11")]
    public class Startup{
        public static void Main()
        {
            Type type = typeof(Startup);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("Version {0}",attr.Version);
            }
        }
    }
}
