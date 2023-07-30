import tkinter as tk
from tkinter import messagebox

def on_checkbox_toggle():
    pass

def on_submit():
    pass

window = tk.Tk()
window.title('Green Hackers Secret Msg System')
window.geometry("500x400")  # Set the initial window size

# Frame for the 'From' section
from_frame = tk.Frame(window)
from_frame.pack(pady=10)

from_id_label = tk.Label(from_frame, text='From(ID):')
from_id_label.grid(row=0, column=0, padx=5)
from_id_entry = tk.Entry(from_frame)
from_id_entry.grid(row=0, column=1, padx=5)

# Frame for the 'To' section
to_frame = tk.Frame(window)
to_frame.pack(pady=10)

to_id_label = tk.Label(to_frame, text='To(ID):')
to_id_label.grid(row=0, column=0, padx=5)
to_id_entry = tk.Entry(to_frame)
to_id_entry.grid(row=0, column=1, padx=5)

# Create a Tkinter variable to hold the state of the checkbox
checkbox_var = tk.BooleanVar()

# Frame for the 'Encrypt' checkbox
encrypt_frame = tk.Frame(window)
encrypt_frame.pack(pady=10)

checkbox = tk.Checkbutton(encrypt_frame, text="Encrypt", variable=checkbox_var, command=on_checkbox_toggle)
checkbox.pack()

# Frame for the 'Data' section
data_frame = tk.Frame(window)
data_frame.pack(pady=10)

data_label = tk.Label(data_frame, text='Data:')
data_label.pack()

# Create a Text widget for data entry
text_input = tk.Text(data_frame, width=40, height=10)
text_input.pack(padx=5, pady=5)

# Frame for the 'Send' button
button_frame = tk.Frame(window)
button_frame.pack(pady=10)

# Create a button to submit the data
submit_button = tk.Button(button_frame, text="Send", command=on_submit)
submit_button.pack()

window.mainloop()
