# 🎮 Game List Manager

**Description:**
This is my **first personal project** using **WPF (Windows Presentation Foundation)** and **PostgreSQL**. The application allows users to manage a list of video games — including adding, updating, deleting, and sorting games through a clean user interface.

---

## 📚 Technologies Used

- **C# (.NET)** – Core language for logic implementation.
- **WPF** – For building the graphical user interface.
- **PostgreSQL** – Relational database for storing game records.
- **Npgsql** – .NET library for working with PostgreSQL.
- **XAML** – Used for UI layout and styling.
- **MV-like structure** – The project is loosely based on the MVVM pattern with clear separation between UI and logic.

---

## 🔧 Features

- ✅ Display all games in a `DataGrid`.
- ➕ Add new games using a form.
- ✏️ Update selected game entries.
- ❌ Delete selected games with confirmation.
- 🔤 Sort games alphabetically by title.
- 🧩 Modular design with reusable `UserControls`.

---

## 📁 Project Structure (simplified)

```
GameList/
├── Classes/              # Data models like Game.cs
├── Database/             # Database logic, e.g., DataBaseHelper.cs
├── View/
│   ├── UserControl/      # Insert, Update, Delete buttons as UserControls
│   ├── Windows/          # MainWindow and other windows
├── appsettings.json      # Contains the database connection string
```

---

## 🧪 How to Run the Project

1. Make sure you have a running **PostgreSQL** server.
2. Create a `games` table using the SQL provided below.
3. Open the project in **Visual Studio**.
4. In `appsettings.json`, replace the connection string with your own.
5. Run the application!

---

## 🗄️ PostgreSQL Table Schema

```sql
CREATE TABLE games (
    id SERIAL PRIMARY KEY,
    title VARCHAR(100) NOT NULL,
    genre VARCHAR(100),
    platform VARCHAR(100),
    releasedate TIMESTAMP,
    completed BOOLEAN,
    rating INT
);
```

---

## 🧠 About Me

This is my first full WPF desktop application project. I built it to:

- Learn how to build UI with XAML.
- Understand how to connect C# applications to PostgreSQL.
- Practice working with CRUD (Create, Read, Update, Delete) operations.
- Learn how to structure a real-world project.

---

## 🔮 Possible Improvements

- ✅ Add form validation.
- 🔍 Implement search and filter options.
- 🖱 Add keyboard shortcuts or context menus.
- 🧹 Refactor towards full MVVM pattern.

---

## 📄 License

This project is created for learning purposes only and is not intended for commercial use.
