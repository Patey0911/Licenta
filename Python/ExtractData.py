import requests
from bs4 import BeautifulSoup
import firebase_admin
from firebase_admin import db, credentials
from urllib import request, error

def GetResults(index, name):

    url = 'https://www.formula1.com/en/results.html/2023/races/'+index+'/'+name+'/race-result.html'
    response = requests.get(url)
    if response.status_code != 200:
        print("Nu exista")


    html_content = response.text

    #Parsing the HTML Content
    soup = BeautifulSoup(html_content, 'html.parser')

    #The tabel will be found by class and ID
    tabel = soup.find('table', {'class': 'resultsarchive-table'})

    desired_colums = [1, 2]
    poz = -1

    #Go through all rows and columns from table to get data
    for row in tabel.find_all('tr'):
        cells = row.find_all('td')
        poz = poz + 1
        if len(cells) >= max(desired_colums) + 1:
            desired_data = [cells[columns].text for columns in desired_colums]
            if desired_data[0] == 'NC':
                desired_data[0] = str(poz)
            print(desired_data)
            ref = db.reference("/")
            db.reference("/"+name+"/"+desired_data[0]).set(desired_data[1])
            ref.get()



def GetCircuitData(name):
    #Get data about the circuit
    if "saudi" in name:
        url = 'https://www.formula1.com/en/racing/2023/Saudi_Arabia/Circuit.html'
    elif "great" in name:
        url = 'https://www.formula1.com/en/racing/2023/Great_Britain/Circuit.html'
    elif "united" in name:
        url = 'https://www.formula1.com/en/racing/2023/United_States/Circuit.html'
    elif "las" in name:
        url = 'https://www.formula1.com/en/racing/2023/Las_Vegas/Circuit.html'
    elif "abu" in name:
        url = 'https://www.formula1.com/en/racing/2023/United_Arab_Emirates/Circuit.html'
    else:
        url = 'https://www.formula1.com/en/racing/2023/' + name.capitalize() + '/Circuit.html'
        
    response = requests.get(url)
    html_content = response.text

    print("dupe deschidere")

    print(url)
    #print(html_content)
    soup = BeautifulSoup(html_content, 'html.parser')
    print("Inainte de luare")
    AllData = soup.find_all('p', class_='f1-bold--stat')
    print(AllData)
    FirstGP = AllData[0].get_text(strip=True)
    CircuitLength = AllData[1].get_text(strip=True)
    NoLaps = AllData[2].get_text(strip=True)
    RaceDistance = AllData[3].get_text(strip=True)
    LapRecord = AllData[4].get_text(strip=True)

    print(FirstGP)
    print(CircuitLength)
    print(NoLaps)
    print(RaceDistance)
    print(LapRecord)

    ref = db.reference("/")
    db.reference("/" + name + "/FirstGP").set(FirstGP)
    db.reference("/" + name + "/CircuitLength").set(CircuitLength)
    db.reference("/" + name + "/NoLaps").set(NoLaps)
    db.reference("/" + name + "/RaceDistance").set(RaceDistance)
    db.reference("/" + name + "/LapRecord").set(LapRecord)
    ref.get()

#Initialize the arrays with the variables from link
circuits = ["bahrain", "saudi-arabia", "australia", "azerbaijan", "miami", "monaco", "spain", "canada", "austria", "great_britain", "hungary", "belgium", "netherlands", "italy", "singapore", "japan", "qatar", "united_States", "mexico", "brazil", "las_vegas", "abu_dhabi"]
indexes = ["1141", "1142", "1143", "1207", "1208", "1210", "1211", "1212"]

#Connection with Firebase
cred = credentials.Certificate("credentials.json")
firebase_admin.initialize_app(cred, {"databaseURL": "https://licenta-ed6d3-default-rtdb.europe-west1.firebasedatabase.app/"})

#Go through all results
for pos, element in enumerate(indexes):
   GetResults(indexes[pos], circuits[pos])

#Go through all circuit data
for pos, element in enumerate(circuits):
    GetCircuitData(circuits[pos])





