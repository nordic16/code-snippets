public static class DeleteFilesRecursively 
{	
    static void Main(string[] args) 
    {
        string path = args[0];

        DelFilesRecursively(path);
    }
	
	/// <summary>
  /// Deletes everything within path recursively.
  /// </summary>
  /// <param name="path">The parent folder. This folder won't be deleted.</param>
    private static void DelFilesRecursively(string path)
    {
        //If the folder is not empty.
        if (Directory.GetFileSystemEntries(path).Length > 0)
        {
            // Loops through everything within path.
            foreach (string fPath in Directory.GetFileSystemEntries(path))
            {
                // It's a folder: recurse through its content and then delete it.
                if (Directory.Exists(fPath))
                {
                    // Delete everything within fPath.
                    DeleteFilesRecursively(fPath);
                    Directory.Delete(fPath); // Folder is deleted after all children have been deleted.
                
                } else //It's a file.
                {
                    File.Delete(fPath);
                }
            }
        
        // If the folder is empty, no need to recurse through its content, so go back and recurse through the parent folder.
        } else 
        {
            return;
        }
    }
}
