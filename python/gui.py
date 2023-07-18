import tkinter as tk
from tkinter import messagebox

def Login():
    uname = Uname_entry.get()
    password = Password_entry.get() 
    if uname == 'admin' and password == '1234':        
        messagebox.showinfo('Login','Login successfully')
        Status_label.config(text=f'Login OK with username {uname} and password {password}')
    else:
        messagebox.showinfo('Login','Login fail, try again!')

# Create the main window
window = tk.Tk()
window.title('Green Hackers')
# Add widgets and configure their properties
Uname_label= tk.Label(window,text='Username: ')
Uname_label.pack()
Uname_entry = tk.Entry(window)
Uname_entry.pack()

Password_label = tk.Label(window,text='Password: ')
Password_label.pack()
Password_entry = tk.Entry(window)
Password_entry.pack()

Status_label = tk.Label(window,text='')
Status_label.pack()

Login_button = tk.Button(window,text='Login',command=Login)
Login_button.pack()

# Start the main event loop
window.mainloop()