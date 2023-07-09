class Length:
    def __init__(self,feet,inches):
        self.feet = feet
        if inches < 12:            
            self.inches = inches
        else:
            print('inches value must less then 12')
            ins = int(input('please reenter inches value: '))
            while(ins>=12):
                ins = int(input('please reenter inches value: '))
            self.inches=ins

    def showLength(self):
        print(f'Length is {self.feet} feet {self.inches} inches long')


    def updateLength(self,feet,inches):
        self.feet = feet
        self.inches = inches

    def convertInches(self):
        self.totalinches = self.inches + (12 * self.feet)
        print(self.totalinches)

    def convertFeet(self):
        self.totalfeet = (self.inches/12) + self.feet
        self.totalfeet = format(self.totalfeet,'.2f')
        print('total feet = ',self.totalfeet)



class Point:
    def __init__(self,x,y):
        self.x = x
        self.y = y

    def showPoint(self):
        print(f'X = {self.x} and Y = {self.y}')


    def updatePoint(self,x,y):
        self.x = x
        self.y = y


class Student:
    stuCount = 0 #class varible 

    def __init__(self,name,age):
        Student.stuCount += 1
        self.name = name
        self.age = age
    
    def showStudentCount(self):
        print(f'The total student objects are {Student.stuCount}')
    
    def showName(self):   # getter
        print(self.name)
    
    def showAge(self):    # getter
        print(self.age)

    def updateName(self,newName): #setter
        self.name = newName
    
    def updateAge(self,newAge):   #setter
        self.age = newAge
    



# Start Here
L1 = Length(2,11)
L1.showLength()
L1.convertInches()
L1.convertFeet()


