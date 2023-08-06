for n in range(2, 100):
    for x in range(2, n): # not including 2, range(2,2) range(n,n) => no loop
        if n % x == 0:
            print(n, 'equals', x, '*', n//x)
            break
    
    # loop fell through without finding a factor
    else:
        print(n, 'is a prime number')

