r = 3.5
a = 3.14 * r * r
try:
    file = open('test.txt','r')
    data = file.readlines()
    for a in data:
        a = a.rstrip()   # remove \n
        a = float(a)     # string to float
        v = a * 100.4    # processing
        print(f'volume = {v}')
    file.close()
except:
    print('File IO error')


