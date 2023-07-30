def greeting(name):
    print('မဂင်္လာပါ '+name)


def area():
    l = 19
    w = 22.5
    a = l * w
    print(a)


# Start Here
greeting('aung aung')

fi = open('data.txt','r')
data = fi.readlines()

for line in data:
    line = line.rstrip()
    print(line)




fi.close()