import mysql.connector
import json

mydb = mysql.connector.connect(
    host = #AWS endpoint,
    user = #Master Username,
    passwd = #Password,
    database = #Database,
    port = #Port Number
)
#This Code will not function without the proper host, user, passwd, database, and port inputted properly
#Missing data for security reasons

mycursor = mydb.cursor()
#mycursor.execute("SHOW DATABASES")
#for x in mycursor:
#       print(x)

#mycursor.execute("SHOW TABLES")
#for x in mycursor:
#       print(x)

#mycursor.execute("SELECT * FROM Events")
#for y in mycursor:
#       print(y)

from flask import Flask
app = Flask(__name__)
#dbCon = None
@app.route("/")
def hello():
        return "Hello, World!"

@app.route("/events")
def events():
        testing = []
        events = []
        mycursor.execute("SELECT * FROM Events")
        for x in mycursor:
                print(x)
                items = []
                for item in x:
                        print(item)
                        items.append(item)
                events.append(items)
        return json.dumps(events)

@app.route("/test")
def test():
        test = {}
        test["foo"] = 1
        test["bar"] = "Hello World"
#       test[{"User_ID":zip(*events)[0]}] = 5
        return json.dumps(test)

@app.route("/jsfile")
def jsfile():
        empList = []
        mycursor.execute("SELECT * FROM Events")
        for x in mycursor:
                print(x)
                empDict = {}
                items = []
                for item in x:
                        print(item)
                        items.append(str(item))
                empDict = {
                'Event ID':items[0],
                'User ID':items[1],
                'Event Title':items[2],
                'Event Game':items[3],
                'Event Date':items[4],
                'Start Time':items[5],
                'End Time':items[6],
                'Number Of Players': items[7],
                'Platform':items[8]}
                #'Public':items[9],
                #'Notes':items[10],
                #'Recurring Status':items[11]}
                empList.append(empDict)
        return json.dumps(empList)

if __name__ == "__main__":
        #dbCon = mysql.connector...
        app.run(debug=True, host = '<ip address>', port = #Port Number)
        #A real ip address has to be inputted at <ip address>
