import os
file_name = 'data1.txt'
if not os.path.exists(file_name):
    print("file not found error, exiting.....")
    exit()
else:
    print("File found")

try:       
    input_file = open(file_name,'r')
    # all_data_in_file = input_file.read()  # READING ALL DATA ATONCE
    data_lines = input_file.readlines()
    i = 0
    for line in data_lines: # 
        i += 1
        income = int(line.strip())
        tax = income * 123
        print(f'{i} {tax}')
    input_file.close()
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