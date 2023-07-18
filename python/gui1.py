import tkinter as tk
from tkinter import messagebox

def Area():
    R = Radius_entry.get()
    R = float(R)
    A = 3.14*R*R
    A = "{:.2f}".format(A)
    
    Area_entry.insert(0,A)
    #Area_label.config(text=f'Area = {.2fA}')

window = tk.Tk()
window.title('Green Hackers')
# Add widgets and configure their properties
Radius_label= tk.Label(window,text='Radius: ')
Radius_label.grid(row=0, column=0)
Radius_entry = tk.Entry(window)
Radius_entry.grid(row=0, column=1)


Area_label = tk.Label(window,text='Area')
Area_label.grid(row=1, column=0)
Area_entry = tk.Entry(window)
Area_entry.grid(row=1, column=1)


Login_button = tk.Button(window,text='Calculate Area',command=Area)
Login_button.grid(row=2, column=1)

# Start the main event loop
window.mainloop()