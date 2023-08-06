lenghts = [100,120,220,340]
widths  = [120,56,78,220]

areas = [0,0,0,0]

for i in range(len(lenghts)): # 0 - 3
    areas[i] = lenghts[i] * widths[i]


for i in range(len(lenghts)): # for(i=0;i<len(lengths);i++)
    print(f'for Length {lenghts[i]} and for width {widths[i]} then  area is {areas[i]}')




