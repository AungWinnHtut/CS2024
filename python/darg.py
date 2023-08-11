def fun(n,L=None):
    if L is None:
            L = []
    L.append(n)
    return L

def funCar(model,yer,price):
      print('normal car')
      print(model)
      print(yer)
      print(price)


def funCar1(*myCar):
      print('tuple car')
      for spec in myCar:
            print(spec)


def foo(model1,**myCar):
      return 'color' in myCar


def bar(i):
      """
          This is Lambda function

          This function demonstrates how to use Lambda function
      """
      return lambda x:x+i

myCar ={
      'year':2020,
      'price':10000,
      'color':'red',
      'model':2021
}



