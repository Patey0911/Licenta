import requests
from bs4 import BeautifulSoup
import firebase_admin
from firebase_admin import credentials
from firebase_admin import firestore
def GetData(index, name):
    url = 'https://www.formula1.com/en/results.html/2023/races/'+index+'/'+name+'/race-result.html'
    response = requests.get(url)
    html_content = response.text

    # Utilizați BeautifulSoup pentru a parsa conținutul HTML
    soup = BeautifulSoup(html_content, 'html.parser')

    # Găsiți tabelul dorit pe baza claselor, id-ului sau altor criterii
    tabel = soup.find('table', {'class': 'resultsarchive-table'})

    desired_colums = [1, 2]
    poz = -1

    # Parcurgeți rândurile și coloanele tabelului pentru a prelua datele
    for row in tabel.find_all('tr'):
        cells = row.find_all('td')
        poz = poz + 1
        if len(cells) >= max(desired_colums) + 1:
            date_dorite = [cells[coloana].text for coloana in desired_colums]
            if date_dorite[0] == 'NC':
                date_dorite[0] = str(poz)
            print(date_dorite)

GetData('1142','saudi-arabia')



# Inițializați Firebase Admin SDK
cred = credentials.Certificate('C:\Users\mihal\Desktop\Licenta\Python\licenta-ed6d3-firebase-adminsdk-rirxw-748e3c91ca.json')
firebase_admin.initialize_app(cred)

# Obțineți o referință la baza de date Firestore
db = firestore.client()

# Definiți datele pe care doriți să le adăugați
data = {
    "nume": "John Doe",
    "varsta": 25,
    "email": "johndoe@example.com"
}

# Adăugați datele într-o colecție
doc_ref = db.collection("utilizatori").document()
doc_ref.set(data)