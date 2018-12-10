import mysql.connector
import json

mydb = mysql.connector.connect(
    host = 'AWS endpoint',
    user = 'MasterUsername',
    passwd = 'Password123',
   database = 'ADatabase',
    port = '3306'
)
#This Code will not function without the proper host, user, passwd, database, and port inputted properly

mycursor = mydb.cursor()

from flask import Flask
app = Flask(__name__)
#dbCon = None
@app.route("/")
def hello():
        return "Welcome to the Guild"

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

@app.route("/events/get")
def getEvents():
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
        app.run(debug=True, host = '0.0.0.0', port = 3306)
        #Port number used here is not used for Guild
