import sqlite3

class Database:
    def __init__(self, db_name):
        try:
            self.conn = sqlite3.connect(db_name)
            self.cursor = self.conn.cursor()
            print(f"Connected to the database: {db_name}")
        except sqlite3.Error as e:
            print(f"Error connecting to the database: {e}")

    def create_table(self, table_name, columns):
        try:
            query = f"CREATE TABLE IF NOT EXISTS {table_name} ({columns})"
            self.cursor.execute(query)
            self.conn.commit()
            print(f"Table '{table_name}' created successfully.")
        except sqlite3.Error as e:
            print(f"Error creating table: {e}")

    def insert_data(self, table_name, data):
        try:
            columns = ", ".join(data.keys()) # id, name, age
            print(f'kyes are {data.keys()}')
            print(f'values are {data.values()}')
            print(f'columns are {columns}')
            values = ", ".join([f"'{value}'" for value in data.values()])
            print(f'values become {values}')
            query = f"INSERT INTO {table_name} ({columns}) VALUES ({values})"
            print(query)
            self.cursor.execute(query)
            self.conn.commit()
            print("Data inserted successfully.")
        except sqlite3.Error as e:
            print(f"Error inserting data: {e}")

    def fetch_data(self, table_name, condition=None):
        try:
            query = f"SELECT * FROM {table_name}"
            if condition:
                query += f" WHERE {condition}"
            self.cursor.execute(query)
            data = self.cursor.fetchall()
            return data
        except sqlite3.Error as e:
            print(f"Error fetching data: {e}")

    def update_data(self, table_name, data, condition=None):
        try:
            set_values = ", ".join([f"{key}='{value}'" for key, value in data.items()])
            query = f"UPDATE {table_name} SET {set_values}"
            if condition:
                query += f" WHERE {condition}"
            self.cursor.execute(query)
            self.conn.commit()
            print("Data updated successfully.")
        except sqlite3.Error as e:
            print(f"Error updating data: {e}")

    def delete_data(self, table_name, condition=None):
        try:
            query = f"DELETE FROM {table_name}"
            if condition:
                query += f" WHERE {condition}"
            self.cursor.execute(query)
            self.conn.commit()
            print("Data deleted successfully.")
        except sqlite3.Error as e:
            print(f"Error deleting data: {e}")

    def close_connection(self):
        try:
            self.cursor.close()
            self.conn.close()
            print("Connection closed.")
        except sqlite3.Error as e:
            print(f"Error closing connection: {e}")


# Example usage:
db = Database("mydatabase.db")

# Create a table
db.create_table("employees", "id INTEGER PRIMARY KEY, name TEXT, age INTEGER")

# Insert data into the table
data = {
    "id": 1,
    "name": "John Doe",
    "age": 30
}
data1 = {
    "id": 2,
    "name": "Green Hackers",
    "age": 40
}
db.insert_data("employees", data)
db.insert_data("employees", data1)

# Fetch all data from the table
all_data = db.fetch_data("employees")
print(all_data)

# Update data in the table
new_data = {
    "name": "Jane Smith",
    "age": 32
}
db.update_data("employees", new_data, "id = 1")

# Fetch updated data
updated_data = db.fetch_data("employees", "id = 1")
print(updated_data)

# Delete data from the table
# db.delete_data("employees", "id = 1")

# Close the database connection
db.close_connection()
