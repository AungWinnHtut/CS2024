import os
import random
import msvcrt

def advanture_game():
    x_min = 0
    x_max = 10
    y_min = 0
    y_max = 10
    player_x = 5
    player_y = 5

    # q = quit
    while 1:
        key = msvcrt.getch().decode()
        if key == 'a':
            player_x = player_x - 1
            if player_x < x_min:
                player_x = x_min
        
        if key == 'd':
            player_x = player_x + 1
            if player_x > x_max:
                player_x = x_max
        
        if key == 'w':
            player_y = player_y - 1
            if player_y < y_min:
                player_y = y_min
        
        if key == 's':
            player_y = player_y + 1
            if player_y > y_max:
                player_y = y_max
        
        if key == 'q':
            print('Exiting advanture game')
            start()
        
        print(f'Player location is x={player_x},y={player_y}')
        for i in range(0,player_y):
            print()
        avater = ''
        for i in range(0,player_x):
            avater = avater + '  '
        avater = avater + '*'
        print(avater)
        


    

def lucky_test():
    os.system('cls')
    day = eval(input('please enter the day: '))
    month = eval(input('please enter the month: '))
    year = eval(input('please enter the year: '))
    num =  day + (month*12) + (year * 365)
    ans = num % 3
   
    if ans == 0:
        print("Bad Luck")
    elif ans == 1:
        print("Normal")
    else:
        print("Lucky")
    os.system('pause')

def dice_game():
    os.system('cls')    
    player = random.randint(1,6)
    computer = random.randint(1,6)
    print('Press any key to roll the dice')
    os.system('pause')
    print(f'player: {player}')
    print('Press any key to roll the dice for computer')
    os.system('pause')
    print(f'computer: {computer}')
    if player > computer:
        print('You win!')
    elif computer > player:
        print('You lose!')
    else:
        print('Draw')
    os.system('pause')

    


def start():
    os.system('cls')
    print('0-exit')
    print('1-baydin app')
    print('2-dice game')
    print('3-advanture game')
    
    choice = input('what is your choice? ')
    if choice == '0':
        print('exiting...')
        os.system('cls')
        exit()        
    elif choice == '1':
        lucky_test()
        
    elif choice == '2':
        dice_game()
    elif choice == '3':
        advanture_game()
    start()
        
   

   
# Start here
start()