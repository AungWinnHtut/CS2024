import mysql.connector

class CRUDApp:
    def __init__(self, host, username, password, database):
        self.host = host
        self.username = username
        self.password = password
        self.database = database
        self.connection = None

    def connect(self):
        self.connection = mysql.connector.connect(
            host=self.host,
            user=self.username,
            password=self.password,
            database=self.database
        )

    def disconnect(self):
        if self.connection:
            self.connection.close()

    def execute_query(self, query, values=None):
        cursor = self.connection.cursor()
        if values:
            cursor.execute(query, values)
        else:
            cursor.execute(query)
        self.connection.commit()
        return cursor

    def create_user(self, name, email):
        query = "INSERT INTO users (name, email) VALUES (%s, %s)"
        values = (name, email)
        self.execute_query(query, values)

    def read_users(self):
        query = "SELECT id, name, email FROM users"
        result = self.execute_query(query)
        users = []
        for row in result:
            user = User(*row)
            users.append(user)
        return users

    def update_user(self, user_id, name, email):
        query = "UPDATE users SET name = %s, email = %s WHERE id = %s"
        values = (name, email, user_id)
        self.execute_query(query, values)

    def delete_user(self, user_id):
        query = "DELETE FROM users WHERE id = %s"
        values = (user_id,)
        self.execute_query(query, values)

class User:
    def __init__(self, id, name, email):
        self.id = id
        self.name = name
        self.email = email

if __name__ == "__main__":
    app = CRUDApp("localhost", "your_username", "your_password", "your_database_name")
    app.connect()

    # Create a user
    app.create_user("John Doe", "john.doe@example.com")

    # Read users
    users = app.read_users()
    for user in users:
        print(f"ID: {user.id}, Name: {user.name}, Email: {user.email}")

    # Update a user
    user_id_to_update = 1
    app.update_user(user_id_to_update, "Jane Smith", "jane.smith@example.com")

    # Delete a user
    user_id_to_delete = 2
    app.delete_user(user_id_to_delete)

    app.disconnect()
