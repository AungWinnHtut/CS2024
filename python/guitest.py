import tkinter as tk
from tkinter import messagebox


def Login():
    uname = entry_Uname.get()
    password = entry_Password.get()
    if uname == 'aung' and password == '1234':
        messagebox.showinfo('Green Hackers','Correct!')
    else:
        messagebox.showinfo('Green Hackers','Wrong')

windows = tk.Tk()

lblUname = tk.Label(windows,text='Username:')
lblUname.pack()
entry_Uname = tk.Entry(windows)
entry_Uname.pack()
lblPass = tk.Label(windows,text='Password:')
lblPass.pack()
entry_Password = tk.Entry(windows)
entry_Password.pack()
btn_Login = tk.Button(windows,text='Login',command=Login)
btn_Login.pack()
windows.mainloop()