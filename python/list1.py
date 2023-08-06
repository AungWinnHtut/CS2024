a = 10
print(a)

data = [1,3,5,6,2,4,8]
del data[2] # [1,3,6,2,4,8]
print('after deletion  ')
print(data)
data[2]=12.3 # [1,3,12.3,2,4,8]
print('after updating  ')
print(data)
data1 = data[2:5]
print('after slicing')
print(data1)

list1 = ['physics', 'chemistry', 'maths','C#']
list1.insert(2,'Bio') # p,c,b,m,c
list1.sort()
# list1.reverse()
print(list1)
print ('Index of chemistry', list1.index('chemistry'))
print ('Index of C#', list1.index('C#'))

