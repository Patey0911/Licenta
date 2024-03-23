import numpy as np
import requests
from bs4 import BeautifulSoup
import numpy
import firebase_admin
from firebase_admin import db, credentials, firestore
from urllib import request, error

PositionSeason = np.zeros(100)
PositionSeasonSprint = np.zeros(100)

AppearanceSeason = np.zeros(100)
AppearanceSeasonSprint = np.zeros(100)

def GetResults2020(index, name):
    url = 'https://www.formula1.com/en/results.html/2020/races/'+index+'/'+name+'/race-result.html'
    response = requests.get(url)
    posDQ = 20
    if response.status_code != 200:
        print("Nu exista")
        exit(0)
    else:
        print(name)
        html_content = response.text

        #Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        #The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'resultsarchive-table'})

        desired_colums = [1, 2]
        poz = -1
        exist = 0
        #Verify if the race has results
        if tabel != None:
            #Go through all rows and columns from table to get data
            for row in tabel.find_all('tr'):
                cells = row.find_all('td')
                poz = poz + 1
                exist = 1
                if len(cells) >= max(desired_colums) + 1:
                    desired_data = [cells[columns].text for columns in desired_colums]
                    if desired_data[0] == 'NC':
                        desired_data[0] = str(poz)
                    if desired_data[0]=='DQ':
                        desired_data[0] = str(posDQ)
                        posDQ = posDQ - 1
                        poz = poz - 1
                    #print(desired_data)
                    ref = db.reference("/")
                    db.reference("/Circuits/2020/"+name+"/"+"Place"+desired_data[0]).set(desired_data[1])
                    db.reference("/Circuits/2020/" + name + "/FutureRace").set("0")
                    ref.get()
        if exist == 0:
            for i in range(1, 21):
                db.reference("/Circuits/2020/" + name + "/" + "Place" + str(i)).set("")
            db.reference("/Circuits/2020/" + name + "/FutureRace").set("0")



    url = 'https://www.formula1.com/en/results.html/2020/races/' + index + '/' + name + '/sprint-results.html'
    response = requests.get(url)
    if name == "azerbaijan" or name == "austria" or name == "belgium" or name == "qatar" or name == "united_States" or name == "brazil" :
        html_content = response.text

        # Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        # The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'resultsarchive-table'})
        db.reference("/Circuits/2020/" + name + "/" + "SprintRace").set(str("1"))
        desired_colums = [1, 2]
        poz = -1
        # Verify if the race has results
        if tabel != None:
            # Go through all rows and columns from table to get data
            for row in tabel.find_all('tr'):
                cells = row.find_all('td')
                poz = poz + 1
                if len(cells) >= max(desired_colums) + 1:
                    desired_data = [cells[columns].text for columns in desired_colums]
                    if desired_data[0] == 'NC':
                        desired_data[0] = str(poz)
                    #print(desired_data)
                    ref = db.reference("/")
                    db.reference("/Circuits/2020/" + name + "/" + "Sprint" + desired_data[0]).set(desired_data[1])
                    ref.get()
    else:
        for i in range (1,21):
            db.reference("/Circuits/2020/" + name + "/" + "Sprint" + str(i)).set("")
        db.reference("/Circuits/2020/" + name + "/" + "SprintRace").set(str("0"))

def GetResults2021(index, name):
    url = 'https://www.formula1.com/en/results.html/2021/races/' + index + '/' + name + '/race-result.html'
    response = requests.get(url)
    posDQ = 20
    if response.status_code != 200:
        print("Nu exista")
        exit(0)
    else:
        print(name)
        html_content = response.text

        # Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        # The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'resultsarchive-table'})

        desired_colums = [1, 2]
        poz = -1
        exist = 0
        # Verify if the race has results
        if tabel != None:
            # Go through all rows and columns from table to get data
            for row in tabel.find_all('tr'):
                cells = row.find_all('td')
                poz = poz + 1
                exist = 1
                if len(cells) >= max(desired_colums) + 1:
                    desired_data = [cells[columns].text for columns in desired_colums]
                    if desired_data[0] == 'NC':
                        desired_data[0] = str(poz)
                    if desired_data[0]=='DQ':
                        desired_data[0] = str(posDQ)
                        posDQ = posDQ - 1
                        poz = poz - 1
                    if(desired_data[0]!='DQ'):
                        # print(desired_data)
                        ref = db.reference("/")
                        db.reference("/Circuits/2021/" + name + "/" + "Place" + desired_data[0]).set(desired_data[1])
                        db.reference("/Circuits/2021/" + name + "/FutureRace").set("0")
                        ref.get()
        if exist == 0:
            for i in range(1, 21):
                db.reference("/Circuits/2021/" + name + "/" + "Place" + str(i)).set("")
                db.reference("/Circuits/2021/" + name + "/FutureRace").set("0")

    url = 'https://www.formula1.com/en/results.html/2021/races/' + index + '/' + name + '/sprint-results.html'
    response = requests.get(url)
    if name == "azerbaijan" or name == "austria" or name == "belgium" or name == "qatar" or name == "united_States" or name == "brazil":
        html_content = response.text

        # Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        # The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'resultsarchive-table'})
        db.reference("/Circuits/2021/" + name + "/" + "SprintRace").set(str("1"))
        desired_colums = [1, 2]
        poz = -1
        # Verify if the race has results
        if tabel != None:
            # Go through all rows and columns from table to get data
            for row in tabel.find_all('tr'):
                cells = row.find_all('td')
                poz = poz + 1
                if len(cells) >= max(desired_colums) + 1:
                    desired_data = [cells[columns].text for columns in desired_colums]
                    if desired_data[0] == 'NC':
                        desired_data[0] = str(poz)
                    # print(desired_data)
                    ref = db.reference("/")
                    db.reference("/Circuits/2021/" + name + "/" + "Sprint" + desired_data[0]).set(desired_data[1])
                    ref.get()
    else:
        for i in range(1, 21):
            db.reference("/Circuits/2021/" + name + "/" + "Sprint" + str(i)).set("")
        db.reference("/Circuits/2021/" + name + "/" + "SprintRace").set(str("0"))

def GetResults2022(index, name):
    url = 'https://www.formula1.com/en/results.html/2022/races/'+index+'/'+name+'/race-result.html'
    response = requests.get(url)
    posDQ = 20
    if response.status_code != 200:
        print("Nu exista")
        exit(0)
    else:
        print(name)
        html_content = response.text

        #Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        #The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'resultsarchive-table'})

        desired_colums = [1, 2]
        poz = -1
        exist = 0
        #Verify if the race has results
        if tabel != None:
            #Go through all rows and columns from table to get data
            for row in tabel.find_all('tr'):
                cells = row.find_all('td')
                poz = poz + 1
                exist = 1
                if len(cells) >= max(desired_colums) + 1:
                    desired_data = [cells[columns].text for columns in desired_colums]
                    if desired_data[0] == 'NC':
                        desired_data[0] = str(poz)
                    if desired_data[0] == 'DQ':
                        desired_data[0] = str(posDQ)
                        posDQ = posDQ - 1
                        poz = poz - 1
                    #print(desired_data)
                    ref = db.reference("/")
                    db.reference("/Circuits/2022/"+name+"/"+"Place"+desired_data[0]).set(desired_data[1])
                    db.reference("/Circuits/2022/" + name + "/FutureRace").set("0")
                    ref.get()
        if exist == 0:
            for i in range(1, 21):
                db.reference("/Circuits/2022/" + name + "/" + "Place" + str(i)).set("")
            db.reference("/Circuits/2022/" + name + "/FutureRace").set("0")



    url = 'https://www.formula1.com/en/results.html/2022/races/' + index + '/' + name + '/sprint-results.html'
    response = requests.get(url)
    if name == "azerbaijan" or name == "austria" or name == "belgium" or name == "qatar" or name == "united_States" or name == "brazil" :
        html_content = response.text

        # Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        # The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'resultsarchive-table'})
        db.reference("/Circuits/2022/" + name + "/" + "SprintRace").set(str("1"))
        desired_colums = [1, 2]
        poz = -1
        # Verify if the race has results
        if tabel != None:
            # Go through all rows and columns from table to get data
            for row in tabel.find_all('tr'):
                cells = row.find_all('td')
                poz = poz + 1
                if len(cells) >= max(desired_colums) + 1:
                    desired_data = [cells[columns].text for columns in desired_colums]
                    if desired_data[0] == 'NC':
                        desired_data[0] = str(poz)
                    #print(desired_data)
                    ref = db.reference("/")
                    db.reference("/Circuits/2022/" + name + "/" + "Sprint" + desired_data[0]).set(desired_data[1])
                    ref.get()
    else:
        for i in range (1,21):
            db.reference("/Circuits/2022/" + name + "/" + "Sprint" + str(i)).set("")
        db.reference("/Circuits/2022/" + name + "/" + "SprintRace").set(str("0"))
def GetResults2023(index, name):
    #Result
    url = 'https://www.formula1.com/en/results.html/2023/races/'+index+'/'+name+'/race-result.html'
    response = requests.get(url)
    posDQ = 20
    if response.status_code != 200:
        print("Nu exista")
        exit(0)
    else:
        print(name + "Race")
        html_content = response.text

        #Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        #The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'resultsarchive-table'})
        Text = "RACE"

        desired_colums = [1, 2]
        poz = -1
        exist = 0
        #Verify if the race has results
        if tabel != None:
            Valid = soup.find_all('h1', class_='ResultsArchiveTitle')
            print(str(Valid).find(Text))
            print(Text in str(Valid))
            if(Text in str(Valid)):
                #Go through all rows and columns from table to get data
                for row in tabel.find_all('tr'):
                    cells = row.find_all('td')
                    poz = poz + 1
                    exist = 1
                    if len(cells) >= max(desired_colums) + 1:
                        desired_data = [cells[columns].text for columns in desired_colums]
                        if desired_data[0]=='DQ' or desired_data[0] == 'NC':
                            desired_data[0] = str(posDQ)
                            posDQ = posDQ - 1
                            poz = poz -1
                        #print(desired_data)
                        ref = db.reference("/")
                        db.reference("/Circuits/2023/"+name+"/"+"Place"+desired_data[0]).set(desired_data[1])
                        PositionSeason[int(desired_data[1])] += int(desired_data[0])
                        AppearanceSeason[int(desired_data[1])] += 1
                        db.reference("/Circuits/2023/" + name + "/FutureRace").set("0")
                        ref.get()
        if exist == 0:
            for i in range(1, 21):
                db.reference("/Circuits/2023/" + name + "/" + "Place" + str(i)).set("")
                db.reference("/Circuits/2023/" + name + "/FutureRace").set("1")

    #Fastest Lap
    url = 'https://www.formula1.com/en/results.html/2023/races/' + index + '/' + name + '/fastest-laps.html'
    response = requests.get(url)
    posDQ = 20
    if response.status_code != 200:
        print("Nu exista")
        exit(0)
    else:
        print(name + "FastestLap")
        html_content = response.text

        # Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        # The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'resultsarchive-table'})
        Text = "FASTEST"

        desired_colums = [1, 2]
        poz = -1
        exist = 0
        # Verify if the race has results
        if tabel != None:
            Valid = soup.find_all('h1', class_='ResultsArchiveTitle')
            print(str(Valid).find(Text))
            print(Text in str(Valid))
            if (Text in str(Valid)):
                # Go through all rows and columns from table to get data
                for row in tabel.find_all('tr'):
                    cells = row.find_all('td')
                    poz = poz + 1
                    exist = 1
                    if len(cells) >= max(desired_colums) + 1:
                        desired_data = [cells[columns].text for columns in desired_colums]
                        ref = db.reference("/")
                        db.reference("/Circuits/2023/" + name + "/" + "FastestLap").set(desired_data[1])
                        ref.get()
                        break
        if exist == 0:
            for i in range(1, 21):
                db.reference("/Circuits/2023/" + name + "/" + "FastestLap").set("")

    #Qualifying
    url = 'https://www.formula1.com/en/results.html/2023/races/' + index + '/' + name + '/qualifying.html'
    response = requests.get(url)
    posDQ = 20
    if response.status_code != 200:
        print("Nu exista")
        exit(0)
    else:
        print(name + "Qualifying")
        html_content = response.text

        # Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        # The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'resultsarchive-table'})
        Text = "QUALIFYING"

        desired_colums = [1, 2]
        poz = -1
        exist = 0
        # Verify if the race has results
        if tabel != None:
            # Go through all rows and columns from table to get data
            Valid = soup.find_all('h1', class_='ResultsArchiveTitle')
            print(str(Valid).find(Text))
            print(Text in str(Valid))
            if(Text in str(Valid)):
                for row in tabel.find_all('tr'):
                    cells = row.find_all('td')
                    poz = poz + 1
                    exist = 1
                    if len(cells) >= max(desired_colums) + 1:
                        desired_data = [cells[columns].text for columns in desired_colums]
                        if desired_data[0] == 'DQ' or desired_data[0] == 'NC':
                            desired_data[0] = str(posDQ)
                            posDQ = posDQ - 1
                            poz = poz - 1
                        # print(desired_data)
                        ref = db.reference("/")
                        db.reference("/Circuits/2023/" + name + "/" + "Qualifying" + desired_data[0]).set(desired_data[1])
                        ref.get()
        if exist == 0:
            for i in range(1, 21):
                db.reference("/Circuits/2023/" + name + "/" + "Qualifying" + str(i)).set("")


    #Sprint
    url = 'https://www.formula1.com/en/results.html/2023/races/' + index + '/' + name + '/sprint-results.html'
    response = requests.get(url)
    if name == "azerbaijan" or name == "austria" or name == "belgium" or name == "qatar" or name == "united_States" or name == "brazil" :
        html_content = response.text
        print(name + "Sprint")
        posDQ = 20;

        # Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        # The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'resultsarchive-table'})
        db.reference("/Circuits/2023/" + name + "/" + "SprintRace").set(str("1"))
        desired_colums = [1, 2]
        poz = -1
        exist = 0
        Text = "SPRINT"
        # Verify if the race has results
        if tabel != None:
            # Go through all rows and columns from table to get data
            Valid = soup.find_all('h1', class_='ResultsArchiveTitle')
            print(str(Valid).find(Text))
            print(Text in str(Valid))
            if(Text in str(Valid)):
                for row in tabel.find_all('tr'):
                    cells = row.find_all('td')
                    poz = poz + 1
                    if len(cells) >= max(desired_colums) + 1:
                        desired_data = [cells[columns].text for columns in desired_colums]
                        exist = 1
                        if desired_data[0] == 'DQ' or desired_data[0] == 'NC':
                            desired_data[0] = str(posDQ)
                            posDQ = posDQ - 1
                            poz = poz - 1
                        #print(desired_data)
                        ref = db.reference("/")
                        db.reference("/Circuits/2023/" + name + "/" + "Sprint" + desired_data[0]).set(desired_data[1])
                        PositionSeasonSprint[int(desired_data[1])] += int(desired_data[0])
                        AppearanceSeasonSprint[int(desired_data[1])] += 1
                        ref.get()
        if exist == 0:
            for i in range(1, 21):
                db.reference("/Circuits/2023/" + name + "/" + "Sprint" + str(i)).set("")
    else:
        for i in range (1,21):
            db.reference("/Circuits/2023/" + name + "/" + "Sprint" + str(i)).set("")
        db.reference("/Circuits/2023/" + name + "/" + "SprintRace").set(str("0"))

    #Sprint Shootout
    url = 'https://www.formula1.com/en/results.html/2023/races/' + index + '/' + name + '/sprint-shootout.html'
    response = requests.get(url)
    if name == "azerbaijan" or name == "austria" or name == "belgium" or name == "qatar" or name == "united_States" or name == "brazil":
        html_content = response.text
        print(name + "Sprint Shootout")
        posDQ = 20

        # Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        # The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'resultsarchive-table'})
        db.reference("/Circuits/2023/" + name + "/" + "SprintRace").set(str("1"))
        desired_colums = [1, 2]
        poz = -1
        exist = 0

        Text = "SPRINT SHOOTOUT"
        # Verify if the race has results
        if tabel != None:
            # Go through all rows and columns from table to get data
            Valid = soup.find_all('h1', class_='ResultsArchiveTitle')
            print(str(Valid).find(Text))
            print(Text in str(Valid))
            if (Text in str(Valid)):
                for row in tabel.find_all('tr'):
                    cells = row.find_all('td')
                    poz = poz + 1
                    exist = 1
                    if len(cells) >= max(desired_colums) + 1:
                        desired_data = [cells[columns].text for columns in desired_colums]
                        if desired_data[0] == 'DQ' or desired_data[0] == 'NC':
                            desired_data[0] = str(posDQ)
                            posDQ = posDQ - 1
                            poz = poz - 1
                        # print(desired_data)
                        ref = db.reference("/")
                        db.reference("/Circuits/2023/" + name + "/" + "SprintQualifying" + desired_data[0]).set(desired_data[1])
                        ref.get()
            if exist == 0:
                for i in range(1, 21):
                    db.reference("/Circuits/2023/" + name + "/" + "SprintQualifying" + str(i)).set("")
    else:
        for i in range(1, 21):
            db.reference("/Circuits/2023/" + name + "/" + "SprintQualifying" + str(i)).set("")

def GetResults2024(index, name):
    #Result
    if(name == "emiliaRomgna"):
        name = "italy"
    url = 'https://www.formula1.com/en/results.html/2024/races/'+index+'/'+name+'/race-result.html'
    print(url)
    response = requests.get(url)
    posDQ = 20
    if response.status_code != 200:
        print("Nu exista")
        exit(0)
    else:
        print(name + "Race")
        html_content = response.text

        #Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        #The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'resultsarchive-table'})
        Text = "RACE"

        desired_colums = [1, 2]
        poz = -1
        exist = 0
        #Verify if the race has results
        if tabel != None:
            Valid = soup.find_all('h1', class_='ResultsArchiveTitle')
            print(str(Valid).find(Text))
            print(Text in str(Valid))
            if(Text in str(Valid)):
                #Go through all rows and columns from table to get data
                for row in tabel.find_all('tr'):
                    cells = row.find_all('td')
                    poz = poz + 1
                    exist = 1
                    if len(cells) >= max(desired_colums) + 1:
                        desired_data = [cells[columns].text for columns in desired_colums]
                        if desired_data[0]=='DQ' or desired_data[0] == 'NC':
                            desired_data[0] = str(posDQ)
                            posDQ = posDQ - 1
                            poz = poz -1
                        #print(desired_data)
                        ref = db.reference("/")
                        db.reference("/Circuits/2024/"+name+"/"+"Place"+desired_data[0]).set(desired_data[1])
                        PositionSeason[int(desired_data[1])] += int(desired_data[0])
                        AppearanceSeason[int(desired_data[1])] += 1
                        db.reference("/Circuits/2024/" + name + "/FutureRace").set("0")
                        ref.get()
        if exist == 0:
            for i in range(1, 21):
                db.reference("/Circuits/2024/" + name + "/" + "Place" + str(i)).set("")
                db.reference("/Circuits/2024/" + name + "/FutureRace").set("1")

    #Fastest Lap
    url = 'https://www.formula1.com/en/results.html/2024/races/' + index + '/' + name + '/fastest-laps.html'
    response = requests.get(url)
    posDQ = 20
    if response.status_code != 200:
        print("Nu exista")
        exit(0)
    else:
        print(name + "FastestLap")
        html_content = response.text

        # Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        # The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'resultsarchive-table'})
        Text = "FASTEST"

        desired_colums = [1, 2]
        poz = -1
        exist = 0
        # Verify if the race has results
        if tabel != None:
            Valid = soup.find_all('h1', class_='ResultsArchiveTitle')
            print(str(Valid).find(Text))
            print(Text in str(Valid))
            if (Text in str(Valid)):
                # Go through all rows and columns from table to get data
                for row in tabel.find_all('tr'):
                    cells = row.find_all('td')
                    poz = poz + 1
                    exist = 1
                    if len(cells) >= max(desired_colums) + 1:
                        desired_data = [cells[columns].text for columns in desired_colums]
                        ref = db.reference("/")
                        db.reference("/Circuits/2024/" + name + "/" + "FastestLap").set(desired_data[1])
                        ref.get()
                        break
        if exist == 0:
            for i in range(1, 21):
                db.reference("/Circuits/2024/" + name + "/" + "FastestLap").set("")

    #Qualifying
    url = 'https://www.formula1.com/en/results.html/2024/races/' + index + '/' + name + '/qualifying.html'
    response = requests.get(url)
    posDQ = 20
    if response.status_code != 200:
        print("Nu exista")
        exit(0)
    else:
        print(name + "Qualifying")
        html_content = response.text

        # Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        # The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'resultsarchive-table'})
        Text = "QUALIFYING"

        desired_colums = [1, 2]
        poz = -1
        exist = 0
        # Verify if the race has results
        if tabel != None:
            # Go through all rows and columns from table to get data
            Valid = soup.find_all('h1', class_='ResultsArchiveTitle')
            print(str(Valid).find(Text))
            print(Text in str(Valid))
            if(Text in str(Valid)):
                for row in tabel.find_all('tr'):
                    cells = row.find_all('td')
                    poz = poz + 1
                    exist = 1
                    if len(cells) >= max(desired_colums) + 1:
                        desired_data = [cells[columns].text for columns in desired_colums]
                        if desired_data[0] == 'DQ' or desired_data[0] == 'NC':
                            desired_data[0] = str(posDQ)
                            posDQ = posDQ - 1
                            poz = poz - 1
                        # print(desired_data)
                        ref = db.reference("/")
                        db.reference("/Circuits/2024/" + name + "/" + "Qualifying" + desired_data[0]).set(desired_data[1])
                        ref.get()
        if exist == 0:
            for i in range(1, 21):
                db.reference("/Circuits/2024/" + name + "/" + "Qualifying" + str(i)).set("")


    #Sprint
    url = 'https://www.formula1.com/en/results.html/2024/races/' + index + '/' + name + '/sprint-results.html'
    response = requests.get(url)
    if name == "china" or name == "miami" or name == "austria" or name == "united_States" or name == "brazil" or name == "qatar" :
        html_content = response.text
        print(name + "Sprint")
        posDQ = 20;

        # Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        # The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'resultsarchive-table'})
        db.reference("/Circuits/2024/" + name + "/" + "SprintRace").set(str("1"))
        desired_colums = [1, 2]
        poz = -1
        exist = 0
        Text = "SPRINT"
        # Verify if the race has results
        if tabel != None:
            # Go through all rows and columns from table to get data
            Valid = soup.find_all('h1', class_='ResultsArchiveTitle')
            print(str(Valid).find(Text))
            print(Text in str(Valid))
            if(Text in str(Valid)):
                for row in tabel.find_all('tr'):
                    cells = row.find_all('td')
                    poz = poz + 1
                    if len(cells) >= max(desired_colums) + 1:
                        desired_data = [cells[columns].text for columns in desired_colums]
                        exist = 1
                        if desired_data[0] == 'DQ' or desired_data[0] == 'NC':
                            desired_data[0] = str(posDQ)
                            posDQ = posDQ - 1
                            poz = poz - 1
                        #print(desired_data)
                        ref = db.reference("/")
                        db.reference("/Circuits/2024/" + name + "/" + "Sprint" + desired_data[0]).set(desired_data[1])
                        PositionSeasonSprint[int(desired_data[1])] += int(desired_data[0])
                        AppearanceSeasonSprint[int(desired_data[1])] += 1
                        ref.get()
        if exist == 0:
            for i in range(1, 21):
                db.reference("/Circuits/2024/" + name + "/" + "Sprint" + str(i)).set("")
    else:
        for i in range (1,21):
            db.reference("/Circuits/2024/" + name + "/" + "Sprint" + str(i)).set("")
        db.reference("/Circuits/2024/" + name + "/" + "SprintRace").set(str("0"))

    #Sprint Shootout
    url = 'https://www.formula1.com/en/results.html/2024/races/' + index + '/' + name + '/sprint-shootout.html'
    response = requests.get(url)
    if name == "china" or name == "miami" or name == "austria" or name == "united_States" or name == "brazil" or name == "qatar" :
        html_content = response.text
        print(name + "Sprint Shootout")
        posDQ = 20

        # Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        # The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'resultsarchive-table'})
        db.reference("/Circuits/2024/" + name + "/" + "SprintRace").set(str("1"))
        desired_colums = [1, 2]
        poz = -1
        exist = 0

        Text = "SPRINT SHOOTOUT"
        # Verify if the race has results
        if tabel != None:
            # Go through all rows and columns from table to get data
            Valid = soup.find_all('h1', class_='ResultsArchiveTitle')
            print(str(Valid).find(Text))
            print(Text in str(Valid))
            if (Text in str(Valid)):
                for row in tabel.find_all('tr'):
                    cells = row.find_all('td')
                    poz = poz + 1
                    exist = 1
                    if len(cells) >= max(desired_colums) + 1:
                        desired_data = [cells[columns].text for columns in desired_colums]
                        if desired_data[0] == 'DQ' or desired_data[0] == 'NC':
                            desired_data[0] = str(posDQ)
                            posDQ = posDQ - 1
                            poz = poz - 1
                        # print(desired_data)
                        ref = db.reference("/")
                        db.reference("/Circuits/2024/" + name + "/" + "SprintQualifying" + desired_data[0]).set(desired_data[1])
                        ref.get()
        if exist == 0:
            for i in range(1, 21):
                db.reference("/Circuits/2024/" + name + "/" + "SprintQualifying" + str(i)).set("")
    else:
        for i in range(1, 21):
            db.reference("/Circuits/2024/" + name + "/" + "SprintQualifying" + str(i)).set("")

def GetCircuitData2020(name):
    #Get data about the circuits
    if "saudi" in name:
        url = 'https://www.formula1.com/en/racing/2020/Saudi_Arabia/Circuit.html'
    elif "great" in name:
        url = 'https://www.formula1.com/en/racing/2020/Great_Britain/Circuit.html'
    elif "united" in name:
        url = 'https://www.formula1.com/en/racing/2020/United_States/Circuit.html'
    elif "las" in name:
        url = 'https://www.formula1.com/en/racing/2020/Las_Vegas/Circuit.html'
    elif "abu" in name:
        url = 'https://www.formula1.com/en/racing/2020/United_Arab_Emirates/Circuit.html'
    else:
        url = 'https://www.formula1.com/en/racing/2020/' + name.capitalize() + '/Circuit.html'

    response = requests.get(url)
    html_content = response.text

    soup = BeautifulSoup(html_content, 'html.parser')

    AllData = soup.find_all('p', class_='f1-bold--stat')
    #print(AllData)

    FirstGP = AllData[0].get_text(strip=True)
    NoLaps = AllData[1].get_text(strip=True)
    CircuitLength = AllData[2].get_text(strip=True)
    RaceDistance = AllData[3].get_text(strip=True)
    LapRecord = AllData[4].get_text(strip=True)

    #print(FirstGP)
    #print(CircuitLength)
    #print(NoLaps)
    #print(RaceDistance)
    #print(LapRecord)

    ref = db.reference("/")
    db.reference("/Circuits/2020/" + name + "/CircuitName").set(name)
    db.reference("/Circuits/2020/" + name + "/FirstGP").set(FirstGP)
    db.reference("/Circuits/2020/" + name + "/CircuitLength").set(CircuitLength)
    db.reference("/Circuits/2020/" + name + "/NoLaps").set(NoLaps)
    db.reference("/Circuits/2020/" + name + "/RaceDistance").set(RaceDistance)
    db.reference("/Circuits/2020/" + name + "/LapRecord").set(LapRecord)

    #Take DateF
    if "saudi" in name:
        url = 'https://www.formula1.com/en/racing/2020/Saudi_Arabia.html'
    elif "great" in name:
        url = 'https://www.formula1.com/en/racing/2020/Great_Britain.html'
    elif "united" in name:
        url = 'https://www.formula1.com/en/racing/2020/United_States.html'
    elif "las" in name:
        url = 'https://www.formula1.com/en/racing/2020/Las_Vegas.html'
    elif "abu" in name:
        url = 'https://www.formula1.com/en/racing/2020/United_Arab_Emirates.html'
    else:
        url = 'https://www.formula1.com/en/racing/2020/' + name.capitalize()+'.html'

    url = 'https://www.autosport.com/f1/schedule/2020/'
    response = requests.get(url)
    html_content = response.text

    soup = BeautifulSoup(html_content, 'html.parser')

    Date = soup.find_all('span', class_='ms-schedule-table-date__value text-md font-semi uppercase')
    DateGood = Date[2*pos].get_text(strip=True)

    db.reference("/Circuits/2020/" + name + "/Date").set(DateGood)
    print(name)
    print(pos)
    print(DateGood)

    ref.get()

def GetCircuitData2021(name):
    #Get data about the circuits
    if "saudi" in name:
        url = 'https://www.formula1.com/en/racing/2021/Saudi_Arabia/Circuit.html'
    elif "great" in name:
        url = 'https://www.formula1.com/en/racing/2021/Great_Britain/Circuit.html'
    elif "united" in name:
        url = 'https://www.formula1.com/en/racing/2021/United_States/Circuit.html'
    elif "las" in name:
        url = 'https://www.formula1.com/en/racing/2021/Las_Vegas/Circuit.html'
    elif "abu" in name:
        url = 'https://www.formula1.com/en/racing/2021/United_Arab_Emirates/Circuit.html'
    else:
        url = 'https://www.formula1.com/en/racing/2021/' + name.capitalize() + '/Circuit.html'

    response = requests.get(url)
    html_content = response.text

    soup = BeautifulSoup(html_content, 'html.parser')

    AllData = soup.find_all('p', class_='f1-bold--stat')
    #print(AllData)

    FirstGP = AllData[0].get_text(strip=True)
    NoLaps = AllData[1].get_text(strip=True)
    CircuitLength = AllData[2].get_text(strip=True)
    RaceDistance = AllData[3].get_text(strip=True)
    LapRecord = AllData[4].get_text(strip=True)

    #print(FirstGP)
    #print(CircuitLength)
    #print(NoLaps)
    #print(RaceDistance)
    #print(LapRecord)

    ref = db.reference("/")
    db.reference("/Circuits/2021/" + name + "/CircuitName").set(name)
    db.reference("/Circuits/2021/" + name + "/FirstGP").set(FirstGP)
    db.reference("/Circuits/2021/" + name + "/CircuitLength").set(CircuitLength)
    db.reference("/Circuits/2021/" + name + "/NoLaps").set(NoLaps)
    db.reference("/Circuits/2021/" + name + "/RaceDistance").set(RaceDistance)
    db.reference("/Circuits/2021/" + name + "/LapRecord").set(LapRecord)

    #Take DateF
    if "saudi" in name:
        url = 'https://www.formula1.com/en/racing/2021/Saudi_Arabia.html'
    elif "great" in name:
        url = 'https://www.formula1.com/en/racing/2021/Great_Britain.html'
    elif "united" in name:
        url = 'https://www.formula1.com/en/racing/2021/United_States.html'
    elif "las" in name:
        url = 'https://www.formula1.com/en/racing/2021/Las_Vegas.html'
    elif "abu" in name:
        url = 'https://www.formula1.com/en/racing/2021/United_Arab_Emirates.html'
    else:
        url = 'https://www.formula1.com/en/racing/2021/' + name.capitalize()+'.html'

    url = 'https://www.autosport.com/f1/schedule/2021/'
    response = requests.get(url)
    html_content = response.text

    soup = BeautifulSoup(html_content, 'html.parser')

    Date = soup.find_all('span', class_='ms-schedule-table-date__value text-md font-semi uppercase')
    DateGood = Date[2*pos].get_text(strip=True)

    db.reference("/Circuits/2021/" + name + "/Date").set(DateGood)
    print(name)
    print(pos)
    print(DateGood)

    ref.get()

def GetCircuitData2022(name):
    #Get data about the circuits
    if "saudi" in name:
        url = 'https://www.formula1.com/en/racing/2022/Saudi_Arabia/Circuit.html'
    elif "great" in name:
        url = 'https://www.formula1.com/en/racing/2022/Great_Britain/Circuit.html'
    elif "united" in name:
        url = 'https://www.formula1.com/en/racing/2022/United_States/Circuit.html'
    elif "las" in name:
        url = 'https://www.formula1.com/en/racing/2022/Las_Vegas/Circuit.html'
    elif "abu" in name:
        url = 'https://www.formula1.com/en/racing/2022/United_Arab_Emirates/Circuit.html'
    else:
        url = 'https://www.formula1.com/en/racing/2022/' + name.capitalize() + '/Circuit.html'

    response = requests.get(url)
    html_content = response.text

    soup = BeautifulSoup(html_content, 'html.parser')

    AllData = soup.find_all('p', class_='f1-bold--stat')
    #print(AllData)

    FirstGP = AllData[0].get_text(strip=True)
    NoLaps = AllData[1].get_text(strip=True)
    CircuitLength = AllData[2].get_text(strip=True)
    RaceDistance = AllData[3].get_text(strip=True)
    LapRecord = AllData[4].get_text(strip=True)

    #print(FirstGP)
    #print(CircuitLength)
    #print(NoLaps)
    #print(RaceDistance)
    #print(LapRecord)

    ref = db.reference("/")
    db.reference("/Circuits/2022/" + name + "/CircuitName").set(name)
    db.reference("/Circuits/2022/" + name + "/FirstGP").set(FirstGP)
    db.reference("/Circuits/2022/" + name + "/CircuitLength").set(CircuitLength)
    db.reference("/Circuits/2022/" + name + "/NoLaps").set(NoLaps)
    db.reference("/Circuits/2022/" + name + "/RaceDistance").set(RaceDistance)
    db.reference("/Circuits/2022/" + name + "/LapRecord").set(LapRecord)

    #Take DateF
    if "saudi" in name:
        url = 'https://www.formula1.com/en/racing/2022/Saudi_Arabia.html'
    elif "great" in name:
        url = 'https://www.formula1.com/en/racing/2022/Great_Britain.html'
    elif "united" in name:
        url = 'https://www.formula1.com/en/racing/2022/United_States.html'
    elif "las" in name:
        url = 'https://www.formula1.com/en/racing/2022/Las_Vegas.html'
    elif "abu" in name:
        url = 'https://www.formula1.com/en/racing/2022/United_Arab_Emirates.html'
    else:
        url = 'https://www.formula1.com/en/racing/2022/' + name.capitalize()+'.html'

    url = 'https://www.autosport.com/f1/schedule/2022/'
    response = requests.get(url)
    html_content = response.text

    soup = BeautifulSoup(html_content, 'html.parser')

    Date = soup.find_all('span', class_='ms-schedule-table-date__value text-md font-semi uppercase')
    DateGood = Date[2*pos].get_text(strip=True)

    db.reference("/Circuits/2022/" + name + "/Date").set(DateGood)
    print(name)
    print(pos)
    print(DateGood)

    ref.get()

def GetCircuitData2023(name):
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

    soup = BeautifulSoup(html_content, 'html.parser')

    AllData = soup.find_all('p', class_='f1-bold--stat')
    #print(AllData)

    FirstGP = AllData[0].get_text(strip=True)
    NoLaps = AllData[1].get_text(strip=True)
    CircuitLength = AllData[2].get_text(strip=True)
    RaceDistance = AllData[3].get_text(strip=True)
    LapRecord = AllData[4].get_text(strip=True)

    #print(FirstGP)
    #print(CircuitLength)
    #print(NoLaps)
    #print(RaceDistance)
    #print(LapRecord)

    ref = db.reference("/")
    db.reference("/Circuits/2023/" + name + "/CircuitName").set(name)
    db.reference("/Circuits/2023/" + name + "/FirstGP").set(FirstGP)
    db.reference("/Circuits/2023/" + name + "/CircuitLength").set(CircuitLength)
    db.reference("/Circuits/2023/" + name + "/NoLaps").set(NoLaps)
    db.reference("/Circuits/2023/" + name + "/RaceDistance").set(RaceDistance)
    db.reference("/Circuits/2023/" + name + "/LapRecord").set(LapRecord)

    #Take DateF
    if "saudi" in name:
        url = 'https://www.formula1.com/en/racing/2023/Saudi_Arabia.html'
    elif "great" in name:
        url = 'https://www.formula1.com/en/racing/2023/Great_Britain.html'
    elif "united" in name:
        url = 'https://www.formula1.com/en/racing/2023/United_States.html'
    elif "las" in name:
        url = 'https://www.formula1.com/en/racing/2023/Las_Vegas.html'
    elif "abu" in name:
        url = 'https://www.formula1.com/en/racing/2023/United_Arab_Emirates.html'
    else:
        url = 'https://www.formula1.com/en/racing/2023/' + name.capitalize()+'.html'

    url = 'https://www.autosport.com/f1/schedule/2023/'
    response = requests.get(url)
    html_content = response.text

    soup = BeautifulSoup(html_content, 'html.parser')

    Date = soup.find_all('span', class_='ms-schedule-table-date__value text-md font-semi uppercase')
    DateGood = Date[2*pos].get_text(strip=True)

    db.reference("/Circuits/2023/" + name + "/Date").set(DateGood)
    print(name)
    print(pos)
    print(DateGood)

    ref.get()

def GetCircuitData2024(name):
    #Get data about the circuits
    if "saudi" in name:
        url = 'https://www.formula1.com/en/racing/2024/Saudi_Arabia/Circuit.html'
    elif "great" in name:
        url = 'https://www.formula1.com/en/racing/2024/Great_Britain/Circuit.html'
    elif "united" in name:
        url = 'https://www.formula1.com/en/racing/2024/United_States/Circuit.html'
    elif "las" in name:
        url = 'https://www.formula1.com/en/racing/2024/Las_Vegas/Circuit.html'
    elif "abu" in name:
        url = 'https://www.formula1.com/en/racing/2024/United_Arab_Emirates/Circuit.html'
    elif "emilia" in name:
        url = 'https://www.formula1.com/en/racing/2024/EmiliaRomagna/Circuit.html'
    else:
        url = 'https://www.formula1.com/en/racing/2024/' + name.capitalize() + '/Circuit.html'
    print(url)

    response = requests.get(url)
    html_content = response.text

    soup = BeautifulSoup(html_content, 'html.parser')

    AllData = soup.find_all('p', class_='f1-bold--stat')
    #print(AllData)

    FirstGP = AllData[0].get_text(strip=True)
    NoLaps = AllData[1].get_text(strip=True)
    CircuitLength = AllData[2].get_text(strip=True)
    RaceDistance = AllData[3].get_text(strip=True)
    LapRecord = AllData[4].get_text(strip=True)

    #print(FirstGP)
    #print(CircuitLength)
    #print(NoLaps)
    #print(RaceDistance)
    #print(LapRecord)

    ref = db.reference("/")
    db.reference("/Circuits/2024/" + name + "/CircuitName").set(name)
    db.reference("/Circuits/2024/" + name + "/FirstGP").set(FirstGP)
    db.reference("/Circuits/2024/" + name + "/CircuitLength").set(CircuitLength)
    db.reference("/Circuits/2024/" + name + "/NoLaps").set(NoLaps)
    db.reference("/Circuits/2024/" + name + "/RaceDistance").set(RaceDistance)
    db.reference("/Circuits/2024/" + name + "/LapRecord").set(LapRecord)

    #Take DateF
    if "saudi" in name:
        url = 'https://www.formula1.com/en/racing/2024/Saudi_Arabia.html'
    elif "great" in name:
        url = 'https://www.formula1.com/en/racing/2024/Great_Britain.html'
    elif "united" in name:
        url = 'https://www.formula1.com/en/racing/2024/United_States.html'
    elif "las" in name:
        url = 'https://www.formula1.com/en/racing/2024/Las_Vegas.html'
    elif "abu" in name:
        url = 'https://www.formula1.com/en/racing/2024/United_Arab_Emirates.html'
    elif "emilia" in name:
        url = 'https://www.formula1.com/en/racing/2024/EmiliaRomagna.html'
    else:
        url = 'https://www.formula1.com/en/racing/2024/' + name.capitalize()+'.html'

    url = 'https://www.autosport.com/f1/schedule/2024/'
    response = requests.get(url)
    html_content = response.text

    soup = BeautifulSoup(html_content, 'html.parser')

    Date = soup.find_all('span', class_='ms-schedule-table-date__value text-body font-bold uppercase')
    print(Date)
    DateGood = Date[2*pos].get_text(strip=True)

    db.reference("/Circuits/2024/" + name + "/Date").set(DateGood)
    print(name)
    print(pos)
    print(DateGood)

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
        #Uncomment after the first race
        print(Points[i].get_text(strip=True))
        print(DriversLastNames[i].get_text(strip=True))
        print(DriversFirstNames[i].get_text(strip=True))
        db.reference("/Drivers/" + DriversLastNames[i].get_text(strip=True) + "/PointsSeason").set(Points[i].get_text(strip=True))
        db.reference("/Drivers/" + DriversLastNames[i].get_text(strip=True) + "/FirstName").set(DriversFirstNames[i].get_text(strip=True))
        db.reference("/Drivers/" + DriversLastNames[i].get_text(strip=True) + "/LastName").set(DriversLastNames[i].get_text(strip=True))
        if(DriversLastNames[i] != "Bearmen"):
            ref = db.reference("/Drivers/" + DriversLastNames[i].get_text(strip=True) + "/No")
            number = ref.get()
        db.reference("/Drivers/" + DriversLastNames[i].get_text(strip=True) + "/AccumulatedPos").set(str(PositionSeason[int(number)]))
        db.reference("/Drivers/" + DriversLastNames[i].get_text(strip=True) + "/AccumulatedPosSprint").set(str(PositionSeasonSprint[int(number)]))
        db.reference("/Drivers/" + DriversLastNames[i].get_text(strip=True) + "/Position").set(str(i+1))
        db.reference("/Drivers/" + DriversLastNames[i].get_text(strip=True) + "/NoApp").set(str(AppearanceSeason[int(number)]))
        db.reference("/Drivers/" + DriversLastNames[i].get_text(strip=True) + "/NoAppSprint").set(str(AppearanceSeasonSprint[int(number)]))
        print(PositionSeason[int(number)])

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
                    db.reference("/Drivers/" + DriversLastNames[i].get_text(strip=True) + "/" + DataName).set(str("0"))
                else:
                    db.reference("/Drivers/" + DriversLastNames[i].get_text(strip=True) + "/"+DataName).set(cells[0].get_text(strip=True))
                poz = poz+1

def TeamsDetails():
    #Get actual teams points
    url = 'https://www.formula1.com/en/teams.html'

    response = requests.get(url)
    html_content = response.text

    soup = BeautifulSoup(html_content, 'html.parser')

    Points = soup.find_all('div', class_='f1-wide--s')
    TeamsNames = soup.find_all('span', class_='f1-color--black')
    DriversNames = soup.find_all('span', class_='last-name f1-uppercase f1-bold--xs d-block d-lg-inline')

    for i in range(0,10):
        #Uncomment after the first race
        print(Points[i].get_text(strip=True))
        print(TeamsNames[i].get_text(strip=True))
        print(DriversNames[2*i].get_text(strip=True))
        print(DriversNames[2*i+1].get_text(strip=True))
        db.reference("/Teams/" + TeamsNames[i].get_text(strip=True)+ "/Points").set(Points[i].get_text(strip=True))
        db.reference("/Teams/" + TeamsNames[i].get_text(strip=True) + "/Driver1").set(DriversNames[2*i].get_text(strip=True))
        db.reference("/Teams/" + TeamsNames[i].get_text(strip=True) + "/Driver2").set(DriversNames[2*i+1].get_text(strip=True))
        db.reference("/Teams/" + TeamsNames[i].get_text(strip=True) + "/Team").set(TeamsNames[i].get_text(strip=True))

        TeamName = TeamsNames[i].get_text(strip=True)
        TeamName = TeamName.replace(" ","-")
        url = urlteams+TeamName+".html"

        response = requests.get(url)
        html_content = response.text

        # Parsing the HTML Content
        soup = BeautifulSoup(html_content, 'html.parser')

        # The tabel will be found by class and ID
        tabel = soup.find('table', {'class': 'stat-list'})
        poz = 0
        print(url)
        for row in tabel.find_all('tr'):
            cells = row.find_all('td')
            print(cells[0].get_text(strip=True))
            if poz == 0:
                DataName = 'FullName'
            elif poz == 1:
                DataName = 'Base'
            elif poz == 2:
                DataName = 'TeamChief'
            elif poz == 3:
                DataName = 'TechnicalChief'
            elif poz == 4:
                DataName = 'Chassis'
            elif poz == 5:
                DataName = 'PowerUnit'
            elif poz == 6:
                DataName = 'FirstTeamEntry'
            elif poz == 7:
                DataName = 'WorldChampionships'
            elif poz == 8:
                DataName = 'HighestRaceFinish'
            elif poz == 9:
                DataName = 'PolePositions'
            elif poz == 10:
                DataName = 'FastestLaps'
            if (cells[0].get_text(strip=True) == 'N/A'):
                db.reference("/Teams/" + TeamsNames[i].get_text(strip=True) + "/" + DataName).set(str("0"))
            elif poz != 0:
                db.reference("/Teams/" + TeamsNames[i].get_text(strip=True) + "/" + DataName).set(cells[0].get_text(strip=True))
            poz = poz + 1


#Initialize the arrays with the variables from link
circuits2020 = ["austria", "hungary", "great-britain", "spain", "belgium", "italy", "russia", "germany", "portugal", "turkey", "bahrain", "abu-dhabi"]
indexes2020 = ["1045", "1047", "1048", "1050", "1051", "1052", "1054", "1055", "1056", "1058", "1059", "1061"]
circuits2021 = ["bahrain", "italy", "portugal", "spain", "monaco", "azerbaijan", "france", "austria", "great_britain", "hungary", "belgium", "netherlands", "russia", "turkey", "united-states", "mexico", "brazil", "qatar", "saudi-arabia", "abu-dhabi"]
indexes2021 = ["1064", "1065", "1066", "1086", "1067", "1068", "1070", "1092", "1072", "1073", "1074", "1075", "1077", "1078", "1102", "1103", "1104", "1105", "1106", "1107"]
circuits2022 = ["bahrain", "saudi-arabia", "australia", "miami", "spain", "monaco","azerbaijan", "canada", "great_britain", "austria", "france", "hungary", "belgium", "netherlands", "italy", "singapore", "japan", "united_States", "mexico", "brazil", "abu_dhabi"]
indexes2022 = ["1124", "1125", "1108", "1110", "1111", "1112", "1126", "1113", "1114", "1115", "1116", "1117", "1118", "1119", "1120", "1133", "1134", "1135", "1136", "1137", "1138"]
circuits2023 = ["bahrain", "saudi-arabia", "australia", "azerbaijan", "miami", "monaco", "spain", "canada", "austria", "great_britain", "hungary", "belgium", "netherlands", "italy", "singapore", "japan", "qatar", "united_States", "mexico", "brazil", "las_vegas", "abu_dhabi"]
indexes2023 = ["1141", "1142", "1143", "1207", "1208", "1210", "1211", "1212", "1213", "1214", "1215", "1216", "1217", "1218", "1219", "1220", "1221", "1222", "1223", "1224", "1225", "1226"]
circuits2024 = ["bahrain", "saudi-arabia", "australia", "japan", "china", "miami", "emiliaRomagna", "monaco", "canada", "spain", "austria", "great_britain", "hungary", "belgium", "netherlands", "italy", "azerbaijan", "singapore", "united_States", "mexico", "brazil", "las_vegas", "qatar", "abu_dhabi"]
indexes2024 = ["1229", "1230", "1231", "1232", "1233", "1234", "1235", "1236", "1237", "1238", "1239", "1240", "1241", "1242", "1243", "1244", "1245", "1246", "1247", "1248", "1249", "1250", "1251", "1252"]

#Url for teams details
urlteams = "https://www.formula1.com/en/teams/"

#Connection with Firebase
cred = credentials.Certificate("credentials.json")
firebase_admin.initialize_app(cred, {"databaseURL": "https://licenta-ed6d3-default-rtdb.europe-west1.firebasedatabase.app/"})

#Go through all circuit data
#for pos, element in enumerate(circuits2020):
#    GetCircuitData2020(circuits2020[pos])
#for pos, element in enumerate(circuits2021):
#    GetCircuitData2021(circuits2021[pos])
#for pos, element in enumerate(circuits2022):
#    GetCircuitData2022(circuits2022[pos])
#for pos, element in enumerate(circuits2023):
#    GetCircuitData2023(circuits2023[pos])
#for pos, element in enumerate(circuits2024):
#    GetCircuitData2024(circuits2024[pos])

#Go through all results
#for pos, element in enumerate(indexes2020):
#    GetResults2020(indexes2020[pos], circuits2020[pos])
#for pos, element in enumerate(indexes2021):
#    GetResults2021(indexes2021[pos], circuits2021[pos])
#for pos, element in enumerate(indexes2022):
#    GetResults2022(indexes2022[pos], circuits2022[pos])
#for pos, element in enumerate(indexes2023):
#    GetResults2023(indexes2023[pos], circuits2023[pos])
for pos, element in enumerate(indexes2024):
    GetResults2024(indexes2024[pos], circuits2024[pos])


#Everytime run this 2 with GetResults2024
DriversDetails()


TeamsDetails()


