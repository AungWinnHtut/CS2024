mat = [
    [1,2,3,4],
    [5,6,7,8],
    [9,10,11,12]    
]

matT = []

for col in range(4):
    matT_row = []
    for row in mat:
        matT_row.append(row[col])
    matT.append(matT_row)
