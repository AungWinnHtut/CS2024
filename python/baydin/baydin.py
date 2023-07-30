import os
print('***Baydin Program***')
day = eval(input('Pls enter day of your bithdate: '))

day = (day % 5) + 1

filename = str(day)+'.data' # str(day) => 1 -> '1', '1'+'.data' => '1.data'
if not os.path.exists(filename):
    print('file not found')
    exit()


try:
    file = open(filename,'r')
    data = file.read()
    print(data)
    file.close()
except:
    print("file io error")


os.system('notepad '+filename)