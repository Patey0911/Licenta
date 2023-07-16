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
        exit(0)
    else:

        html_content = response.text

        #Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        #The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'resultsarchive-table'})

        desired_colums = [1, 2]
        poz = -1
        #Verify if the race has results
        if tabel != None:
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
                    db.reference("/Circuits/"+name+"/"+desired_data[0]).set(desired_data[1])
                    ref.get()



def GetCircuitData(name):
    #Get data about the circuits
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

    #print(url)

    soup = BeautifulSoup(html_content, 'html.parser')

    AllData = soup.find_all('p', class_='f1-bold--stat')
    print(AllData)

    FirstGP = AllData[0].get_text(strip=True)
    NoLaps = AllData[1].get_text(strip=True)
    CircuitLength = AllData[2].get_text(strip=True)
    RaceDistance = AllData[3].get_text(strip=True)
    LapRecord = AllData[4].get_text(strip=True)

    print(FirstGP)
    print(CircuitLength)
    print(NoLaps)
    print(RaceDistance)
    print(LapRecord)

    ref = db.reference("/")
    db.reference("/Circuits/" + name + "/FirstGP").set(FirstGP)
    db.reference("/Circuits/" + name + "/CircuitLength").set(CircuitLength)
    db.reference("/Circuits/" + name + "/NoLaps").set(NoLaps)
    db.reference("/Circuits/" + name + "/RaceDistance").set(RaceDistance)
    db.reference("/Circuits/" + name + "/LapRecord").set(LapRecord)
    ref.get()

def DriversDetails():
    #Get actual drivers names and points
    url = 'https://www.formula1.com/en/drivers.html'

    response = requests.get(url)
    html_content = response.text

    soup = BeautifulSoup(html_content, 'html.parser')

    Points = soup.find_all('div', class_='f1-wide--s')
    DriversLastNames = soup.find_all('span', class_='d-block f1-bold--s f1-color--carbonBlack')
    DriversFirstNames = soup.find_all('span', class_='d-block f1--xxs f1-color--carbonBlack')

    for i in range(0,20):
        print(Points[i].get_text(strip=True))
        print(DriversLastNames[i].get_text(strip=True))
        print(DriversFirstNames[i].get_text(strip=True))
        db.reference("/Drivers/" + DriversLastNames[i].get_text(strip=True) + "/Points").set(Points[i].get_text(strip=True))
        db.reference("/Drivers/" + DriversLastNames[i].get_text(strip=True) + "/FirstName").set(DriversFirstNames[i].get_text(strip=True))
        db.reference("/Drivers/" + DriversLastNames[i].get_text(strip=True) + "/LastName").set(DriversLastNames[i].get_text(strip=True))

    #To obtain more information about every driver we need to visit their f1 pages
    for i in range(0, 20):
        url = 'https://www.formula1.com/en/drivers/'+DriversFirstNames[i].get_text(strip=True).lower()+'-'+DriversLastNames[i].get_text(strip=True).lower()+'.html'

        if(DriversLastNames[i].get_text(strip=True)=="De Vries"):
            url = 'https://www.formula1.com/en/drivers/nyck-de-vries.html'

        response = requests.get(url)
        html_content = response.text

        # Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        # The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'stat-list'})

        desired_colums = [1, 2]
        poz = 0
        #print(tabel)
        # Verify if the table about the driver exist
        if tabel != None:
            # Go through all rows and columns from table to get data
            for row in tabel.find_all('tr'):
                cells = row.find_all('td')
                print(cells[0].get_text(strip=True))
                if poz == 0:
                    DataName = 'Team'
                elif poz == 1:
                    DataName = 'Country'
                elif poz == 2:
                    DataName = 'Podiums'
                elif poz == 3:
                    DataName = 'Points'
                elif poz == 4:
                    DataName = 'GrandsPrixEntered'
                elif poz == 5:
                    DataName = 'WorldChampionships'
                elif poz == 6:
                    DataName = 'HighestRaceFinish'
                elif poz == 7:
                    DataName = 'HighestGridPosition'
                elif poz == 8:
                    DataName = 'DateOfBirth'
                elif poz == 9:
                    DataName = 'PlaceOfBirth'
                if(cells[0].get_text(strip=True) == 'N/A'):
                    db.reference("/Drivers/" + DriversLastNames[i].get_text(strip=True) + "/" + DataName).set(0)
                else:
                    db.reference("/Drivers/" + DriversLastNames[i].get_text(strip=True) + "/"+DataName).set(cells[0].get_text(strip=True))
                poz = poz+1

def TeamsPoints():
    #Get actual teams points
    url = 'https://www.formula1.com/en/teams.html'

    response = requests.get(url)
    html_content = response.text

    soup = BeautifulSoup(html_content, 'html.parser')

    Points = soup.find_all('div', class_='f1-wide--s')
    TeamsNames = soup.find_all('span', class_='f1-color--black')
    DriversNames = soup.find_all('span', class_='last-name f1-uppercase f1-bold--xs d-block d-lg-inline')

    for i in range(0,10):
        print(Points[i].get_text(strip=True))
        print(TeamsNames[i].get_text(strip=True))
        print(DriversNames[2*i].get_text(strip=True))
        print(DriversNames[2*i+1].get_text(strip=True))
        db.reference("/Teams/" + TeamsNames[i].get_text(strip=True)+ "/Points").set(Points[i].get_text(strip=True))
        db.reference("/Teams/" + TeamsNames[i].get_text(strip=True) + "/Driver1").set(DriversNames[2*i].get_text(strip=True))
        db.reference("/Teams/" + TeamsNames[i].get_text(strip=True) + "/Driver2").set(DriversNames[2*i+1].get_text(strip=True))
        db.reference("/Teams/" + TeamsNames[i].get_text(strip=True) + "/Team").set(TeamsNames[i].get_text(strip=True))

#Initialize the arrays with the variables from link
circuits = ["bahrain", "saudi-arabia", "australia", "azerbaijan", "miami", "monaco", "spain", "canada", "austria", "great_britain", "hungary", "belgium", "netherlands", "italy", "singapore", "japan", "qatar", "united_States", "mexico", "brazil", "las_vegas", "abu_dhabi"]
indexes = ["1141", "1142", "1143", "1207", "1208", "1210", "1211", "1212", "1213", "1214", "1215", "1216", "1217", "1218", "1219", "1220", "1221", "1222", "1223", "1224", "1225", "1226"]

#Connection with Firebase
cred = credentials.Certificate("credentials.json")
firebase_admin.initialize_app(cred, {"databaseURL": "https://licenta-ed6d3-default-rtdb.europe-west1.firebasedatabase.app/"})

#Go through all results
for pos, element in enumerate(indexes):
    GetResults(indexes[pos], circuits[pos])

#Go through all circuit data
for pos, element in enumerate(circuits):
    GetCircuitData(circuits[pos])

DriversDetails()

TeamsPoints()
