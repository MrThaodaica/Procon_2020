import requests
import json
import datetime
import time

#header
token = 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJkYXRhIjoibmhhbiIsImlhdCI6MTU3NTA5Nzk1OSwiZXhwIjoxNTc1MTg0MzU5fQ.dKYTMhfoIq1jGGzVQ0UjR18Kl6NBie5306i9onPhVP8';
headers = { 'Authorization' : token }

#init Room
resp = requests.get("http://sv-procon.uet.vnu.edu.vn:8009/matches/", headers = headers , verify = False);
infoRoom = json.loads(resp.text)
infoRoom = dict(infoRoom[0])
#init matches
url = "http://sv-procon.uet.vnu.edu.vn:8009/matches/" + str(infoRoom["id"])
resp = requests.get(url, headers = headers , verify = False);
global infoMatches
# infoMatches = json.loads(resp.text)
infoMatches = dict(json.loads(resp.text))

#lay so turn cua tran dau
turnGoc = infoRoom["turns"]
turn = 0
# info Room


def getTimeStarted():
    #info matches
    global token
    global resp
    global headers
    global infoRoom
    global url
    #lay request
    resp = requests.get(url, headers = headers , verify = False);

    #luu vao bien
    global infoMatches
    infoMatches = dict(json.loads(resp.text))
    global turn
    turn = float(infoMatches["turn"]) #lay turn hien tai
    return float(infoMatches["startedAtUnixTime"])

timeToRefresh = float(infoRoom["turnMillis"])/1000 + float(infoRoom["intervalMillis"])/1000

timeInit = 0
if turn == 0 and timeInit == 0 :
    timeInit = getTimeStarted()
dd1 = str(datetime.datetime.fromtimestamp((timeInit)/1000).strftime("%H:%M:%S.%f"))
d1 = datetime.datetime.strptime(dd1,"%H:%M:%S.%f")
d2 = datetime.datetime.strptime(str(time.time().strftime("%H:%M:%S.%f")),"%H:%M:%S.%f")
#d2 = datetime.datetime.now().strftime("%H:%M:%S.%f")

dt1 = datetime.timedelta(minutes=d1.minute, seconds=d1.second, microseconds=d1.microsecond)
dt2 = datetime.timedelta(minutes=d2.minute, seconds=d2.second, microseconds=d2.microsecond)
fin = dt2 - dt1

dem = 0
tOld = time.time().strftime("%H:%M:%S.%f")

dem = 0
while True:
    time.sleep(1);
    dem += 1
    print("time : " + str(dem))
    # if dem > float(infoRoom["turnMillis"])/1000:
    #     dem = 0
    # tOld = datetime.datetime.now().second

    # newTime = getTimeStarted()

    #end
    # if turn == turnGoc :
    #         break
        
    
def lamTron(a):
    return False if a < 0 else a if a*10%10 == 0 else a + 1 - a*10%10/10 if a > 10 else a - a*10%10/10
