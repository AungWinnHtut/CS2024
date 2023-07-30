import mysql.connector
mydb = mysql.connector.connect(
    host="localhost",
    user="root",
    passwd=""
)
#1 print(mydb)

mycursor = mydb.cursor()

# 2 mycursor.execute("CREATE DATABASE pydb")
mycursor.execute("USE pydb")
print(f'mycursor is {mycursor}')

#databases = mycursor.fetchall() # the results is a list
#print(f'databases is {databases}')

for db in mycursor:
    print(db)

mycursor.execute("SHOW TABLES")
#print(f'mycursor is {mycursor}')



mycursor.close()
mydb.close()