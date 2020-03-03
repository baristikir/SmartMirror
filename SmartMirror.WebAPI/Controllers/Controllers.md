# Controllers
* ValuesController
* WebController
* GUIController
## Values Controller
for testing

## WebController
provides methods for the Web-Interface
### API - Methods
* api/Web/users [GET]
> gibt eine Liste von "User" zur�ck
> input: null
> return string[]
* api/Web/users/(id) [GET]
> gibt den durch die id bestimmten Username aus der Datenbank zur�ck
> return User
* api/Web/users [POST]
> f�gt einen neuen Benutzer mit �bergebenen Benutzernamen hinzu
> input: {id:3,name:"peter",email:"test"}
> return int (Userid)
* api/Web/users/(id) [DELETE]
> l�scht den User mit der �bergebenen id
* api/Web/users/(id) [PUT]
> aktualisiert Daten vom Benutzer
> input

* api/Web/Widget [GET]
> gibt die Liste aller insgsamt verf�gbaren Namen der externen API's wieder
> retun string[]
* api/Web/Widget/(id) [GET]
> gibt den Namen der externen API wieder mit der �bergebenen id
> return string
* api/Web/Widget [POST]
> gibt folgendes bei unterschiedlichen input zur�ck:
> * username: alle Namen von angemeldeten widgets 
> * widgetName: alle benutzer die dieses widget angemeldeten haben
> * username,widgetName: gibt den Token f�r zur�ck


## GUIController
provides methods for GUI
### API - Methods
* api/GUI/widgets/(Userid) [GET]
> return a Datamodell Object with data for all widgets of a specified by Client and beeing activated. 
> Client is specified by ClientID
* api/GUI/wigets [POST]
> 
> 


## Notizen
* Objekte k�nnen direkt zur�ckgegeben werden. Diese werden dann ins Json format ebracht. Aus diesem Format kann dann anschlie�end der Client (Web-angular bzw. GUI) das Object wieder parsen.
* Objecte k�nnen �ber [POST] in JSON-Format gesndetet werden, bsp. f�r User = {id:3,name:"peter",email:"test"}