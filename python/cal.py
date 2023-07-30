import tkinter as tk

root = tk.Tk()

root.geometry("450x390")
root.resizable(0,0)
root.title("My Calculator")

input_value=""
Display_text=tk.StringVar() 


def Click_buttom_action(item):
    global input_value
    input_value= input_value+str(item)
    Display_text.set(input_value)


def Clear_buttom_action():
    global input_value
    input_value=""
    Display_text.set("")


def equal_buttom_action():
    global input_value
    result = str(eval(input_value))
    Display_text.set(result)
    input_value=""


input_frame=tk.Frame(width=100, height=50,highlightbackground="blue",highlightcolor="green",highlightthickness=2)
input_frame.pack(side=tk.TOP)

input_field= tk.Entry(input_frame,font=("pyidaungsu",20, "bold", "italic"),textvariable=Display_text, width=42, bd=5, bg="pink",justify=tk.RIGHT)
input_field.grid(row=0,column=0)
input_field.pack(ipady=5)

btn_frame= tk.Frame(root,width=100, height=300,bg="white")
btn_frame.pack()

btn_clear =tk.Button(btn_frame,text="Clear",fg="green",width=37, height=2,bd=5,bg="white",cursor="hand2",command=lambda: Clear_buttom_action()).grid(row=0,column=0,columnspan=3,ipadx=1,ipady=1)
btn_divind=tk.Button(btn_frame,text="%",fg="green",width=9,height=2,bd=5,bg="white",cursor="hand2",command=lambda: Click_buttom_action("/")).grid(row=0,column=3,ipadx=1,ipady=1)


btn_divind=tk.Button(btn_frame,text="7",fg="green",width=9,height=2,bd=5,bg="white",cursor="hand2",command=lambda: Click_buttom_action("7")).grid(row=1,column=0,ipadx=1,ipady=1)
btn_divind=tk.Button(btn_frame,text="8",fg="green",width=9,height=2,bd=5,bg="white",cursor="hand2",command=lambda: Click_buttom_action("8")).grid(row=1,column=1,ipadx=1,ipady=1)
btn_divind=tk.Button(btn_frame,text="9",fg="green",width=9,height=2,bd=5,bg="white",cursor="hand2",command=lambda: Click_buttom_action("9")).grid(row=1,column=2,ipadx=1,ipady=1)
btn_divind=tk.Button(btn_frame,text="X",fg="green",width=9,height=2,bd=5,bg="white",cursor="hand2",command=lambda: Click_buttom_action("*")).grid(row=1,column=3,ipadx=1,ipady=1)

btn_divind=tk.Button(btn_frame,text="4",fg="green",width=9,height=2,bd=5,bg="white",cursor="hand2",command=lambda: Click_buttom_action("4")).grid(row=2,column=0,ipadx=1,ipady=1)
btn_divind=tk.Button(btn_frame,text="5",fg="green",width=9,height=2,bd=5,bg="white",cursor="hand2",command=lambda: Click_buttom_action("5")).grid(row=2,column=1,ipadx=1,ipady=1)
btn_divind=tk.Button(btn_frame,text="6",fg="green",width=9,height=2,bd=5,bg="white",cursor="hand2",command=lambda: Click_buttom_action("6")).grid(row=2,column=2,ipadx=1,ipady=1)
btn_divind=tk.Button(btn_frame,text="-",fg="green",width=9,height=2,bd=5,bg="white",cursor="hand2",command=lambda: Click_buttom_action("-")).grid(row=2,column=3,ipadx=1,ipady=1)

btn_divind=tk.Button(btn_frame,text="1",fg="green",width=9,height=2,bd=5,bg="white",cursor="hand2",command=lambda: Click_buttom_action("1")).grid(row=3,column=0,ipadx=1,ipady=1)
btn_divind=tk.Button(btn_frame,text="2",fg="green",width=9,height=2,bd=5,bg="white",cursor="hand2",command=lambda: Click_buttom_action("2")).grid(row=3,column=1,ipadx=1,ipady=1)
btn_divind=tk.Button(btn_frame,text="3",fg="green",width=9,height=2,bd=5,bg="white",cursor="hand2",command=lambda: Click_buttom_action("3")).grid(row=3,column=2,ipadx=1,ipady=1)
btn_divind=tk.Button(btn_frame,text="+",fg="green",width=9,height=2,bd=5,bg="white",cursor="hand2",command=lambda: Click_buttom_action("+")).grid(row=3,column=3,ipadx=1,ipady=1)

btn_divind=tk.Button(btn_frame,text="0",fg="green",width=9,height=2,bd=5,bg="white",cursor="hand2",command=lambda: Click_buttom_action("0")).grid(row=4,column=1,ipadx=1,ipady=1)
btn_divind=tk.Button(btn_frame,text=".",fg="green",width=9,height=2,bd=5,bg="white",cursor="hand2",command=lambda: Click_buttom_action(".")).grid(row=4,column=2,ipadx=1,ipady=1)
btn_divind=tk.Button(btn_frame,text="=",fg="green",width=9,height=2,bd=5,bg="white",cursor="hand2",command=lambda: equal_buttom_action()).grid(row=4,column=3,ipadx=1,ipady=1)


root.mainloop()
