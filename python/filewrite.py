import os
filename = 'data1.txt'
while os.path.exists(filename):
    print('Error! Same file exists, change file name')
    filename = input('Enter new file name: ')

try:
    file = open(filename,'w')
    file.write("Testing1\n")
    file.write("Testing2\n")
    file.write("Testing3\n")
    file.write("Testing4\n")
    file.close()
except FileNotFoundError:
    print("File not found.")
except PermissionError:
    print("Permission denied to access the file.")
except IOError as e:
    print("An I/O error occurred:", str(e))
except OSError as e:
    print("OS error:", str(e))
except UnicodeDecodeError:
    print("Error decoding the file contents.")
except UnicodeEncodeError:
    print("Error encoding data to be written to the file.")
except ValueError as e:
    print("Value error:", str(e))
except FileExistsError:
    print("File already exists.")
except BlockingIOError:
    print("Blocking I/O operation error.")
except Exception as e:
    print("An unexpected error occurred:", str(e))
