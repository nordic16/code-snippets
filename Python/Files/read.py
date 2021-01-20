if __name__ == '__main__':

    path = 'path/to/file'
    
    with open(path, 'r') as file:
        lines = file.readlines()
        print('\n'.join(lines))
      
