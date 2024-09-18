using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMS_BusinessLogic;
using System.IO;
using Microsoft.Win32;

namespace GMS_Desktop.Global
{
    public class clsGlobal
    {
        public static User currentUser;

        public static bool getStoredCredential(ref string userName,  ref string password)
        {
            try
            {
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                string filePath = currentDirectory + "\\data.txt";

                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line = "";

                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            userName = result[0];
                            password = result[1];
                        }
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
                return false;
            }
        }

        public static bool RememberUserNameAndPassword(string userName, string password)
        {
            try
            {
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                string filePhath = currentDirectory + "\\data.txt";

                if (userName == string.Empty && File.Exists(filePhath))
                {
                    File.Delete(filePhath);
                    return true;
                }

                string dataToSave = userName + "#//#" + password;

                using (StreamWriter writer = new StreamWriter(filePhath))
                {
                    writer.WriteLine(dataToSave);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
                return false;
            }
        }
    }
}
