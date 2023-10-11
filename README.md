# IMR

Pentru tema 1:

- M-am folosit de un template de proiect AR Core;
- Am adaugat doua personaje - cactusul si o pisica
- Pisica va avea o pozitie fixa
- Cactusul va aparea positie dinamica, in functie de unde apasa userul (functionalitate oferita de scriptul TapToPlace)
- In momentul in care cactusul se apropie de pisica (distanta fiind calculata in metoda Upload a cactusului), se va schimba o variabila booleana *attacking* care face ca animatia cactusului sa se schimbe -> fie in Idle (false), fie in Attack (true); pentru asta am folosit un Animator 
