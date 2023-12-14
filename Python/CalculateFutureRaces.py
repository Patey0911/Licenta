import firebase_admin
from firebase_admin import db, credentials, firestore
from firebase import firebase

class Circuit:
  def __int__(self,CircuitLength,CircuitName,Date,FirstGP,LapRecord,NoLaps,Place1,Place10,Place11,Place12,Place13,Place14,Place15,Place16,Place17,Place18,Place19,Place2,Place20,
              Place3,Place4,Place5,Place6,Place7,Place8,Place9,RaceDistance,Sprint1,Sprint10,Sprint11,Sprint12,Sprint13,Sprint14,Sprint15,Sprint16,Sprint17,Sprint18,Sprint19
              ,Sprint2,Sprint20,Sprint3,Sprint4,Sprint5,Sprint6,Sprint7,Sprint8,Sprint9,SprintRace):
      self.CircuitLength = CircuitLength
      self.CircuitName = CircuitName
      self.Date = Date
      self.FirstGP = FirstGP
      self.LapRecord = LapRecord
      self.NoLaps = NoLaps
      self.Place1 = Place1
      self.Place10 = Place10
      self.Place11 = Place11
      self.Place12 = Place12
      self.Place13 = Place13
      self.Place14 = Place14
      self.Place15= Place15
      self.Place16 = Place16
      self.Place17 = Place17
      self.Place18 = Place18
      self.Place19 = Place19
      self.Place2 = Place2
      self.Place20 = Place20
      self.Place3 = Place3
      self.Place4 = Place4
      self.Place5 = Place5
      self.Place6 = Place6
      self.Place7 = Place7
      self.Place8 = Place8
      self.Place9 = Place9
      self.RaceDistance = RaceDistance
      self.Sprint1 = Sprint1
      self.Sprint10 = Sprint10
      self.Sprint11 = Sprint11
      self.Sprint12 = Sprint12
      self.Sprint13 = Sprint13
      self.Sprint14 = Sprint14
      self.Sprint15 = Sprint15
      self.Sprint16 = Sprint16
      self.Sprint17 = Sprint17
      self.Sprint18 = Sprint18
      self.Sprint19 = Sprint19
      self.Sprint2 = Sprint2
      self.Sprint20 = Sprint20
      self.Sprint3 = Sprint3
      self.Sprint4 = Sprint4
      self.Sprint5 = Sprint5
      self.Sprint6 = Sprint6
      self.Sprint7 = Sprint7
      self.Sprint8 = Sprint8
      self.Sprint9 = Sprint9
      self.SprintRace = SprintRace
  def __str__(self):
    return '{}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}  '.format(self.CircuitLength, self.CircuitName, self.Date, self.FirstGP, self.LapRecord,  self.NoLaps, self.Place1, self.Place10, self.Place11, self.Place12, self.Place13,
                                   self.Place14, self.Place15, self.Place16, self.Place17, self.Place18, self.Place19, self.Place2, self.Place20, self.Place3, self.Place4, self.Place5, self.Place6, self.Place7, self.Place20
                                  , self.Place8, self.Place9, self.RaceDistance, self.Sprint1, self.Sprint10, self.Sprint11, self.Sprint12, self.Sprint13, self.Sprint14, self.Sprint15, self.Sprint16, self.Sprint17
                                  , self.Sprint18, self.Sprint19, self.Sprint2, self.Sprint20, self.Sprint3, self.Sprint4, self.Sprint5, self.Sprint6, self.Sprint7, self.Sprint8, self.Sprint9, self.SprintRace)
def make_circuit():
  circuit = {}
  circuit['CircuitLength']=CircuitLength
  circuit['CircuitName']=CircuitName
  circuit['Date']=Date
  circuit['FirstGP']=FirstGP
  circuit['LapRecord']=LapRecord
  circuit['NoLaps']=NoLaps
  circuit['Place1']=Place1
  circuit['Place10']=Place10
  circuit['Place11']=Place11
  circuit['Place12']=Place12
  circuit['Place13']=Place13
  circuit['Place14']=Place14
  circuit['Place15']=Place15
  circuit['Place16']=Place16
  circuit['Place17']=Place17
  circuit['Place18']=Place18
  circuit['Place19']=Place19
  circuit['Place2']=Place2
  circuit['Place20']=Place20
  circuit['Place3']=Place3
  circuit['Place4']=Place4
  circuit['Place5']=Place5
  circuit['Place6']=Place6
  circuit['Place7']=Place7
  circuit['Place8']=Place8
  circuit['Place9']=Place9
  circuit['RaceDistance']=RaceDistance
  circuit['Sprint1']=Sprint1
  circuit['Sprint10']=Sprint10
  circuit['Sprint11']=Sprint11
  circuit['Sprint12']=Sprint12
  circuit['Sprint13']=Sprint13
  circuit['Sprint14']=Sprint14
  circuit['Sprint15']=Sprint15
  circuit['Sprint16']=Sprint16
  circuit['Sprint17']=Sprint17
  circuit['Sprint18']=Sprint18
  circuit['Sprint19']=Sprint19
  circuit['Sprint2']=Sprint2
  circuit['Sprint20']=Sprint20
  circuit['Sprint3']=Sprint3
  circuit['Sprint4']=Sprint4
  circuit['Sprint5']=Sprint5
  circuit['Sprint6']=Sprint6
  circuit['Sprint7']=Sprint7
  circuit['Sprint8']=Sprint8
  circuit['Sprint9']=Sprint9
  circuit['SprintRace']=SprintRace
  return circuit

ListofCircuits =[]
circuits = ["bahrain"]
cred = credentials.Certificate("credentials.json")
firebase_admin.initialize_app(cred, {"databaseURL": "https://licenta-ed6d3-default-rtdb.europe-west1.firebasedatabase.app/"})
#firebase = firebase.FirebaseApplication("https://licenta-ed6d3-default-rtdb.europe-west1.firebasedatabase.app/Circuits", None)
for pos, element in enumerate(circuits):
  ref = db.reference('Circuits/'+circuits[pos]+'/',None)
  CircuitLength = ref.child('CircuitLength').get()
  CircuitName = ref.child('CircuitName').get()
  Date = ref.child('Date').get()
  FirstGP = ref.child('FirstGP').get()
  LapRecord = ref.child('LapRecord').get()
  NoLaps = ref.child('NoLaps').get()
  Place1 = ref.child('Place1').get()
  Place10 = ref.child('Place10').get()
  Place11 = ref.child('Place11').get()
  Place12 = ref.child('Place12').get()
  Place13 = ref.child('Place13').get()
  Place14 = ref.child('Place14').get()
  Place15 = ref.child('Place15').get()
  Place16 = ref.child('Place16').get()
  Place17 = ref.child('Place17').get()
  Place18 = ref.child('Place18').get()
  Place19 = ref.child('Place19').get()
  Place2 = ref.child('Place2').get()
  Place20 = ref.child('Place20').get()
  Place3 = ref.child('Place3').get()
  Place4 = ref.child('Place4').get()
  Place5= ref.child('Place5').get()
  Place6 = ref.child('Place6').get()
  Place7 = ref.child('Place7').get()
  Place8 = ref.child('Place8').get()
  Place9 = ref.child('Place9').get()
  RaceDistance = ref.child('RaceDistance').get()
  Sprint1 = ref.child('Sprint1').get()
  Sprint10 = ref.child('Sprint10').get()
  Sprint11 = ref.child('Sprint11').get()
  Sprint12 = ref.child('Sprint12').get()
  Sprint13 = ref.child('Sprint13').get()
  Sprint14 = ref.child('Sprint14').get()
  Sprint15 = ref.child('Sprint15').get()
  Sprint16 = ref.child('Sprint16').get()
  Sprint17 = ref.child('Sprint17').get()
  Sprint18 = ref.child('Sprint18').get()
  Sprint19 = ref.child('Sprint19').get()
  Sprint2 = ref.child('Sprint2').get()
  Sprint20 = ref.child('Sprint20').get()
  Sprint3 = ref.child('Sprint3').get()
  Sprint4 = ref.child('Sprint4').get()
  Sprint5 = ref.child('Sprint5').get()
  Sprint6 = ref.child('Sprint6').get()
  Sprint7 = ref.child('Sprint7').get()
  Sprint8 = ref.child('Sprint8').get()
  Sprint9 = ref.child('Sprint9').get()
  SprintRace = ref.child('SprintRace').get()
  print(circuits[pos])
  actualcircuit=Circuit.__str__(CircuitLength,CircuitName,Date,FirstGP,LapRecord,NoLaps,Place1,Place10,Place11,Place12,Place13,Place14,Place15,Place16,Place17,Place18,Place19,Place2,Place20,
              Place3,Place4,Place5,Place6,Place7,Place8,Place9,RaceDistance,Sprint1,Sprint10,Sprint11,Sprint12,Sprint13,Sprint14,Sprint15,Sprint16,Sprint17,Sprint18,Sprint19
              ,Sprint2,Sprint20,Sprint3,Sprint4,Sprint5,Sprint6,Sprint7,Sprint8,Sprint9,SprintRace)
  print(actualcircuit)
  print(hasattr(actualcircuit, 'FirstGP'))
  ListofCircuits.append(actualcircuit)


