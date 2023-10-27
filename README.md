# IMR

## Pentru tema 1:

- M-am folosit de un template de proiect AR Core;
- Am adaugat doua personaje - cactusul si o pisica
- Pisica va avea o pozitie fixa
- Cactusul va aparea positie dinamica, in functie de unde apasa userul (functionalitate oferita de scriptul TapToPlace)
- In momentul in care cactusul se apropie de pisica (distanta fiind calculata in metoda Upload a cactusului), se va schimba o variabila booleana *attacking* care face ca animatia cactusului sa se schimbe -> fie in Idle (false), fie in Attack (true); pentru asta am folosit un Animator 
- Video de demo -> HW_1/CatCactuGame/Demo Video

## Pentru tema 2:
- Am folosit XRInteraction Toolkit cu Mock HMD pentru a face un simulator VR
- Am adaugat doua obiecte gasite pe Unity assets store pentru Left si Right Controller
- Am adaugat o sfera 3D care are proprietarea de interactable si poate interactiona cu controllerele mentionate la punctul anterior
- Am adaugat un cilindru 3D pe post de board si sferele pot fi aruncate de interactori catre ea si astfel se mareste scorul
- Am adaugat un TextMesh pentru vizualizarea scorului pus langa board

- Interactorul mai intai trebuie sa dea grab la sfera (prin tasta G) si daca a apasat tasta F (am ales aceasta tasta pentru throw event), cand va da ungrab (=onSelectExited) sfera va fi aruncata; daca y-axis a sferei e sub -50, ea revine pe plan si poate fi din nou grabbed si thrown
- In scriptul `ThrowObject.cs` asociat sferei am referinte catre sfera pentru a-i vedea proprietatile, catre text box-ul de score pentru a-l actualiza cand e cazul (cand sfera atinge board), dar si catre board pentru a calcula distanta intre aceasta si sfera
- In scriptul HDMInfoManager am facut setupul pentru Mock (dupa tutorialul din suportul de laborator)
- In scriptul GrabbedSphere am setat proprietati pentru sfera - cand e grabbed, cand e thrown, cand se reintoarce pe plan

## Pentru tema 3:
- Am facut 2 metode dupa 2 tutoriale diferite de a modela mana, pornind de la un cub si am modelat marginile, am extins si scalat pana a iesit ok
- Am *incercat* sa fac si unwrap
- Am adaugat in Unity in setupul din tema 2 modelul pentru ambele maini, am pus o textura gasita intr-un pachet din care am luat modelele de pe assets store folosite la tema trecuta
- Poze de demo in HW_3/demo_pictures pentru model si pentru cum arata in unity
