import os
print('***Baydin Program***')
day = eval(input('Pls enter day of your bithdate: '))

day = (day % 5) + 1

filename = ''
if day==1:
    filename='1.data'
elif day==2:
    filename='2.data'
elif day==3:
    filename='3.data'
elif day==4:
    filename='4.data'
elif day==5:
    filename='5.data'
else:
    print('Wrond day!')
    exit()

file = open(filename,'r')
data = file.read()
print(data)
file.close()


os.system('notepad '+filename)