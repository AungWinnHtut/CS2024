import tkinter as tk
from tkinter import messagebox

def on_checkbox_toggle():
    pass

def on_submit():
    pass


# from id label and entry             to id label and entry       checkbox encrypt
# data label
# data entry (whole screen)
# right most button SEND
window = tk.Tk()
window.title('Green Hackers Secret Msg System')
header_frame = tk.Frame(window)
header_frame.pack(pady=10)
from_id_label= tk.Label(header_frame,text='From(ID): ')
from_id_label.grid(row=0, column=0,padx=10, pady=10)
from_id_entry = tk.Entry(header_frame)
from_id_entry.grid(row=0, column=1,padx=10, pady=10)
to_id_label= tk.Label(header_frame,text='To(ID): ')
to_id_label.grid(row=0, column=3,padx=10, pady=10)
to_id_entry = tk.Entry(header_frame)
to_id_entry.grid(row=0, column=4,padx=10, pady=10)
# Create a Tkinter variable to hold the state of the checkbox
checkbox_var = tk.BooleanVar()
# Create the Checkbutton widget
checkbox = tk.Checkbutton(header_frame, text="Encrypt", variable=checkbox_var, command=on_checkbox_toggle)
# Pack the Checkbutton into the window
checkbox.grid(row=0, column=5,padx=10, pady=10)

data_frame = tk.Frame(window)
data_frame.pack()
# Create a Text widget for data entry
text_input = tk.Text(data_frame)# width=40, height=10)
text_input.grid(row=0,column=0,rowspan=4,columnspan=6,padx=10, pady=10)

# Create a button to submit the data
submit_button = tk.Button(data_frame, text="          Submit        ", command=on_submit)
submit_button.grid(row=5,column=4,columnspan=4,padx=10, pady=10)

window.mainloop()