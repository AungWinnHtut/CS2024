import mysql.connector

def create_connection(host, username, password, database):
    connection = mysql.connector.connect(
        host=host,
        user=username,
        password=password,
        database=database
    )
    return connection

def close_connection(connection):
    if connection:
        connection.close()

def execute_query(connection, query, values=None):
    cursor = connection.cursor()
    if values:
        cursor.execute(query, values)
    else:
        cursor.execute(query)
    connection.commit()
    return cursor

def create_user(connection, name, email):
    query = "INSERT INTO users (name, email) VALUES (%s, %s)"
    values = (name, email)
    execute_query(connection, query, values)

def read_users(connection):
    query = "SELECT id, name, email FROM users"
    result = execute_query(connection, query)
    users = []
    for row in result:
        user = (row[0], row[1], row[2])
        users.append(user)
    return users

def update_user(connection, user_id, name, email):
    query = "UPDATE users SET name = %s, email = %s WHERE id = %s"
    values = (name, email, user_id)
    execute_query(connection, query, values)

def delete_user(connection, user_id):
    query = "DELETE FROM users WHERE id = %s"
    values = (user_id,)
    execute_query(connection, query, values)

if __name__ == "__main__":
    host = "localhost"
    username = "your_username"
    password = "your_password"
    database = "your_database_name"

    connection = create_connection(host, username, password, database)

    # Create a user
    create_user(connection, "John Doe", "john.doe@example.com")

    # Read users
    users = read_users(connection)
    for user in users:
        print(f"ID: {user[0]}, Name: {user[1]}, Email: {user[2]}")

    # Update a user
    user_id_to_update = 1
    update_user(connection, user_id_to_update, "Jane Smith", "jane.smith@example.com")

    # Delete a user
    user_id_to_delete = 2
    delete_user(connection, user_id_to_delete)

    close_connection(connection)
