# AddressManagementSystem

## 🇬🇧 English

### Description
The Address Management System is a simple CRUD application built with C# and MySQL. It allows users to **create, read, update, and delete addresses** stored in a MySQL database. The project follows a layered architecture with separate **Data**, **Models**, and **Services** layers, making it easy to maintain and extend.

### Features
- Add new addresses
- View all addresses
- Update existing addresses
- Delete addresses
- Layered architecture for UI and services
- Safe database operations using parameterized queries

### Technologies
- C# (.NET)
- WinForms (UI)
- MySQL (Database)
- ADO.NET (`MySql.Data` package)

### Project Structure
├── Program.cs # Application entry point
├── Models/ # Data models (Address.cs)
├── Data/ # Database connection and configuration (Database.cs)
├── Services/ # Business logic / CRUD operations (AddressService.cs)
├── UI/ # User interface (Form1.cs)


### Installation
1. Clone the repository.
2. Install **MySQL** and create a database named `address_db`.
3. Update the connection string in `Database.cs` with your MySQL username and password.
4. Install the NuGet package `MySql.Data`.
5. Build and run the project in Visual Studio.

### Usage
- Launch the application.
- Use the form to **add** new addresses.
- View the list of all addresses.
- Edit or delete addresses as needed.

---

## 🇩🇪 Deutsch

### Beschreibung
Das Address Management System ist eine einfache CRUD-Anwendung, erstellt mit C# und MySQL. Es ermöglicht Benutzern, **Adressen zu erstellen, anzuzeigen, zu bearbeiten und zu löschen**, die in einer MySQL-Datenbank gespeichert sind. Das Projekt folgt einer **geschichteten Architektur** mit getrennten Schichten für **Daten**, **Modelle** und **Services**, was die Wartung und Erweiterung erleichtert.

### Funktionen
- Neue Adressen hinzufügen
- Alle Adressen anzeigen
- Bestehende Adressen bearbeiten
- Adressen löschen
- Geschichtete Architektur für UI und Services
- Sichere Datenbankoperationen mit parametrisierten Abfragen

### Technologien
- C# (.NET)
- WinForms (UI)
- MySQL (Datenbank)
- ADO.NET (`MySql.Data` Paket)

### Projektstruktur
├── Program.cs # Einstiegspunkt der Anwendung
├── Models/ # Datenmodelle (Address.cs)
├── Data/ # Datenbankverbindung und Konfiguration (Database.cs)
├── Services/ # Geschäftslogik / CRUD-Operationen (AddressService.cs)
├── UI/ # Benutzeroberfläche (Form1.cs)


### Installation
1. Repository klonen.
2. **MySQL** installieren und eine Datenbank namens `address_db` erstellen.
3. Die Verbindungszeichenfolge in `Database.cs` mit Ihrem MySQL-Benutzernamen und Passwort aktualisieren.
4. NuGet-Paket `MySql.Data` installieren.
5. Projekt in Visual Studio bauen und ausführen.

### Nutzung
- Anwendung starten.
- Formular verwenden, um **neue Adressen hinzuzufügen**.
- Liste aller Adressen anzeigen.
- Adressen bearbeiten oder löschen nach Bedarf.