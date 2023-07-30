# Open the file in read mode
file = open('data.txt', 'r') 
# Read the first line
line = file.readline()

# Loop through the file until the end is reached (empty line indicates end of file)
while line:
    # Process the line (e.g., print it)
    print(line.strip())

    # Read the next line
    line = file.readline()

if line == '':
    print('Line is NULL')

file.close()

