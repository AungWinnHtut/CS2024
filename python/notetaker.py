import tkinter as tk
from tkinter import messagebox

class Note:
    def __init__(self, title, content):
        self.title = title
        self.content = content

class NotebookApp:
    def __init__(self, root):
        self.root = root
        self.root.title("Notebook Database")

        self.notes = []
        self.create_widgets()

    def create_widgets(self):
        self.title_label = tk.Label(self.root, text="Title:")
        self.title_label.pack()

        self.title_entry = tk.Entry(self.root, width=50)
        self.title_entry.pack()

        self.content_label = tk.Label(self.root, text="Content:")
        self.content_label.pack()

        self.content_text = tk.Text(self.root, height=10, wrap=tk.WORD)
        self.content_text.pack()

        self.add_button = tk.Button(self.root, text="Add Note", command=self.add_note)
        self.add_button.pack()

        self.delete_button = tk.Button(self.root, text="Delete Note", command=self.delete_note)
        self.delete_button.pack()

        self.display_button = tk.Button(self.root, text="Display Notes", command=self.display_notes)
        self.display_button.pack()

    def add_note(self):
        title = self.title_entry.get()
        content = self.content_text.get("1.0", tk.END).strip()

        if title and content:
            new_note = Note(title, content)
            self.notes.append(new_note)
            messagebox.showinfo("Note Added", "Note added successfully.")
            self.clear_fields()
        else:
            messagebox.showwarning("Empty Fields", "Title and Content fields cannot be empty.")

    def delete_note(self):
        title = self.title_entry.get()

        for note in self.notes:
            if note.title == title:
                self.notes.remove(note)
                messagebox.showinfo("Note Deleted", f"Note '{title}' deleted.")
                self.clear_fields()
                return

        messagebox.showwarning("Note Not Found", f"Note '{title}' not found.")

    def display_notes(self):
        if not self.notes:
            messagebox.showinfo("No Notes", "No notes found in the database.")
        else:
            notes_info = "\n---- Notes ----\n"
            for note in self.notes:
                notes_info += f"Title: {note.title}\n"
                notes_info += f"Content: {note.content}\n"
                notes_info += "----------------\n"

            messagebox.showinfo("Notes", notes_info)

    def clear_fields(self):
        self.title_entry.delete(0, tk.END)
        self.content_text.delete("1.0", tk.END)

if __name__ == "__main__":
    root = tk.Tk()    
    app = NotebookApp(root)
    root.mainloop()
