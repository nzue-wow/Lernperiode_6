# Lern-Periode 6

22.8 bis 19.9.2024

## Grob-Planung
Ich mache ein rudimentäres, text-basiertes RPG. Der Benutzer wählt seine Klasse aus und seine Waffe aus, und trifft auf unterschiedliche Gegner nacheinander.
2. Ich mache es mit den Charakteren von Avater the last Airbender.
3. In meinem RGB Spiel kämpf man gegen die Armee der Firenation, man wählt die Charaktere mit den verschiedenen Kräften aus und kämpft dagegen.

## 22.8

- [x] Arbeitspaket 1: Erstellen Sie ein Projekt im VS und beginnen Sie mir ersten Code-Skizzen. Das ist wichtig, Sie müssen heute bereits schon C#-Code hochladen!
- [ ] Arbeitspaket 2: Schreiben Sie eine Liste, welche Klassen und Objekte es braucht, und wie diese miteinander interagieren. Das Format ist Ihnen freigestellt, aber Sie müssen es auch bereits heute auf github laden. (Dieses AP dauert ausnahmsweise nur 15')
- [ ] Arbeitspaket 3 (Falls Sie den *maker space* besuchen, dann dürfen Sie diesen Punkt löschen. Ansonsten können Sie hier mit dem Coden beginnen, nachdem Sie sich ganz klar überlegt haben, was Ihr erster Schritt ist und den hier als AP festgehalten haben.)

✍️ Heute habe ich... (50-100 Wörter)
Ausgewählt was ich machen will für diese Lernperiode. Ich habe den ersten Vorschlag genommen ein RPG Spiel zu machen. Die Charaktere sind von einem Comic/Serie nämlich von Avatar the last Airbender. Ich habe aucfgeschrieben was für Charaktere es gibt also gut und böse und etwa ihre stärken eingeschätzt. Diese habe ich dann als Objekte in VS reingeschrieben.


☝️ Vergessen Sie nicht, einen ersten Code und Skizze auf github hochzuladen!

## 29.8

- [x] Alle Charaktere ins VS schreiben
- [x] Aufschreiben wer welche Kräfte hat und wie viel Schaden und Leben der hat
- [x] Das Spiel Sinnvoll versuchen aufzuschreiben. - Dann Ueberlegen wie anfangen Coden.

📵 Eines dieser Arbeitspakete ist offline.

✍️ Heute habe ich... (50-100 Wörter)
Heute habe ich die Charaktere in Visual Studio eingetragen und die Liste etwas vereinfacht, indem ich einige Figuren weggelassen habe. So ist das Projekt übersichtlicher und leichter zu starten. Zusätzlich habe ich eine Character-Klasse erstellt, die die Eigenschaften Name, Leben, Angriff und Element enthält. Dazu habe ich Methoden programmiert, mit denen die Charaktere sich gegenseitig angreifen und Schaden nehmen können. Damit ist jetzt ein erster Schritt zu einem funktionierenden Kampfsystem gelegt, das die Basis für den weiteren Spielablauf bildet.
☝️ Vergessen Sie nicht, Ihren Code auf github hochzuladen
## 5.9
- [x] Charakterauswahl einbauen → Spieler soll zu Beginn auswählen, mit welchem Helden er spielen möchte.
- [ ] Wenn ein Charakter 0 Leben hat, soll das Spiel den Gewinner anzeigen.
- [ ] Nach dem ersten Sieg soll automatisch der nächste Gegner aus der Liste kommen.
- [x] en kompletten Spielablauf mit Charakteren, Gegnern, Reihenfolge der Kämpfe und Sonderfähigkeiten.

✍️ Heute habe ich... (50-100 Wörter)
Den einen genauen Spielablaufpaln gemacht wo ich sehe wei die Schleife soll sein, wie die Kämpfe sind und was ich vielleicht noch als nächstes(Sonderfunktionen) hinzufügen möchte. Ausserdem kann ich jetzt im Code entscheiden mit Welchen Helden ich als erstes will Kämpfen. Das funktioniert aber noch nicht ganz blendend denn mann mus die Zahl immer zwei mal eingeben. Dann habe ich eine Klasse fight gemacht und da so ein groben code geschrieben. Er funktioniert noch nicht aber man sieht so mal die basics und die Idee.

## 12.9

- [x] Charakterauswahl verbessern → So das man die zahl nicht mehr 2mal eingeben muss
- [x] fight class richtig programmieren.
- [ ] Diese Funktion richtig einbauen: Nach dem ersten Sieg soll automatisch der nächste Gegner aus der Liste kommen.
- [x] Leben muss abgezogen werden beim Kampf.

✍️ Heute habe ich... (50-100 Wörter)
Heute habe ich die Charakterauswahl verbessert. Jetzt muss man nicht mehr die Zahl zeimal eingeben. Dann habe ich noch die Fight class richtig programmiert, also aus meinem groben code jetzt ein richtigen gemacht. Beim Kampf werden jetzt die Leben der beiden Kämpfen bei jedem Zug angepasst.

# 19.9
- [x] Bis jetzt gewinnt der Böse immer und es gibt nur zwei Attacks bis jemand gewinnt -> Die logik des Spiels verbesser, leben anpassen, Angriff anpassen.
- [x] Es soll ein random gegner als erstes kommen nicht immer der gleiche
- [x] Nachschauen wie dann der nächste Gegner ins Spiel kommt
- [ ] Diese Funktion richtig einbauen: Nach dem ersten Sieg soll automatisch der nächste Gegner aus der Liste kommen.

Heute habe ich...
Es so gemacht das nicht immer der Böse gewinnt. Also ich habe allgemein das Leben bei jedem erhöht und auch bei jedem einen Schutz eingebaut das das Spiel nicht so schnell zue ende ist. Dann habe ich die Gegner randomized so das es nicht immer der gleiche Gegner ist. Jetzt kann auch mal einer der Helden gewinnen. Ebenfalls habe ich nachgeschaut wie die nächsten Gegner ins spiel kommen. Ich muss eine Schleife  über den Gegnern machen und nach jedem Kampf soll kontrolliert werden ob der Held noch lebt.(Man soll auch das ein neuer Held ins Spiel kommt)

# 17.10

- [ ] Diese Funktion richtig einbauen: Nach dem ersten Sieg soll automatisch der nächste Gegner aus der Liste kommen.
- [ ] Diese Funktion richtig einbauen: Nach dem Verlust soll automatisch der nächste Held aus der Liste kommen.
- [ ] Kämpfe in einer Schleife abarbeiten, nicht nur einen einzelnen Kampf.
