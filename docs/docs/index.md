# ✅ ToDo-App

## 📌 Übersicht
Diese ToDo-Listen-Anwendung ist eine einfache Konsolenanwendung in **C#**, die es ermöglicht:
- 📝 Aufgaben hinzuzufügen
- 👀 Aufgaben anzuzeigen
- ❌ Aufgaben zu löschen
- 💾 Aufgaben in einer CSV-Datei zu speichern

Das Projekt dient als Beispiel für den **Einsatz von Git und DevOps-Praktiken**.

---

## 🚀 Installation
### Voraussetzungen
- 🛠 **.NET SDK** installiert ([Download hier](https://dotnet.microsoft.com/en-us/download))
- 🔗 **Git** installiert ([Download hier](https://git-scm.com/))
- 🖥 **Visual Studio Code** oder eine andere IDE

### 📂 Projekt klonen
```sh
git clone https://github.com/ajnurademi/M324-ToDo-App
cd todo-app
```

### ▶ Anwendung starten
```sh
dotnet run
```

---

## 🎯 Nutzung
Beim Starten der Anwendung erscheint ein Menü:
```
ToDo-Liste:
1. Aufgabe hinzufügen
2. Aufgabe entfernen
3. Aufgaben anzeigen
4. Aufgaben speichern
5. Beenden
Auswahl:
```

- 🔹 **1** → Neue Aufgabe hinzufügen
- 🔹 **2** → Aufgabe per Index löschen
- 🔹 **3** → Liste der Aufgaben anzeigen
- 🔹 **4** → Aufgaben in `todo_list.csv` speichern
- 🔹 **5** → Anwendung beenden (speichert automatisch)

---

## 🔄 Git & DevOps-Praktiken
Dieses Projekt nutzt **Git** für die Versionskontrolle und folgt dem **Conventional Commits**-Standard:
- ✨ `feat(ui): add task removal feature`
- 🐛 `fix(storage): correct CSV file save issue`
- 📖 `docs(readme): update usage instructions`

Wir setzen **Branches & Tagging** ein, um Entwicklungsphasen zu organisieren.

### 🌱 Branch-Strategie
- `🚀 main` → Stabile Version
- `🛠 develop` → Aktuelle Entwicklung
- `🆕 feature/*` → Neue Features
- `🔥 hotfix/*` → Kritische Fehlerbehebungen

### 🔢 Semantische Versionierung
Wir nutzen **Semantic Versioning (SemVer)**:
- `MAJOR.MINOR.PATCH` (z. B. `1.0.0` → Erste stabile Version)
- **MINOR** für neue Features 🆕
- **PATCH** für Bugfixes 🐞

---

## ✍ Autor
🔗 [Ajnur Ademi](https://github.com/ajnurademi)
🔗 [Aron Herbel](https://github.com/aronherbel)
