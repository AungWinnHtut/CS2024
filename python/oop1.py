class Length:
    def __init__(self,feet,inches):
        self.feet = feet
        self.inches = inches
        self.total_inches = (self.feet*12)+self.inches


    def __add__(self,other):
        self.inches += other.inches
        if (self.inches>12):
            self.feet += 1
            self.inches -= 12
        self.feet += other.feet
        return Length(self.feet,self.inches)
    
    def __mul__(self,other):
        self.sq_inches = self.total_inches * other.total_inches
        self.sq_feet = self.sq_inches / 144
        return self.sq_feet



L = Length(3,7)   
W = Length(5,7)

total_length = L + W
print(total_length.feet)
print(total_length.inches)

area = L * W
print(area)