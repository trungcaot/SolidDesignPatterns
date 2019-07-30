using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SRP
{
    /// <summary>
    /// Reponsible for saving a file
    /// </summary>
    public class FileSaver
    {
        // Original: stay in the WorkReport class. 
        // moved.
        // we added a new feature saving to file or even more features in this class.
        // load or upload to cloud
        public void SaveToFile(string directoryPath, string fileName, WorkReport report)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
        }
    }
}
