public static class ListDirectoryRecursively 
{	
	static void Main(string[] args) 
	{
        string path = args[0];

        ListRecursively(path);
    }


    /// <summary>
    /// This function lists all files and subdirectories of a folder recursively.
    /// </summary>
    /// <param name="path">The path for the parent folder.</param>
    private static void ListRecursively(string path)
    {
        try
        {
            // If the folder is not empty, check out its content.
            if (Directory.GetFileSystemEntries(path).Length > 0)
            {
                // Lists all files and directories in a folder.
                for (int i = 0; i < Directory.GetFileSystemEntries(path).Length; i++)
                {
                    string fPath = Directory.GetFileSystemEntries(path)[i];

                    // If the currently selected element is a folder, perform the same steps on it. 
                    if (Directory.Exists(fPath)) 
                    {
                        ListRecursively(fPath);

                    }
                    // If the currently selected element is a file, just print its path.
                    else
                    {
                        Console.WriteLine(fPath);
                    }
                }
            }
            // If the folder is empty, go back to its parent.
            else
            {
                return;
            }
			
        } catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Cannot access directory");
        }
    }
}
