if __name__ == "__main__":
    import sys, os


    """No need for a base case, as when this function takes in an empty
       folder, the loop won't even execute."""
    def ListDirRecursively(path: str):
        # For more info on os.walk(), check out 
        # https://docs.python.org/3/library/os.html#os.walk
        for root, dirs, files in os.walk(path):
            for fPath in files:
                print(f'{os.path.join(root, fPath)}')

            for dirPath in dirs:
                ListDirRecursively(dirPath)




    # If path is empty, use the current dir path, otherwise use the specified one.
    path = sys.argv[1] if len(sys.argv) > 1 else os.path.dirname(os.path.realpath(sys.argv[0]))
    
    ListDirRecursively(path=path)
  

    

   
