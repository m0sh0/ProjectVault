# 🌤️ WeatherInfoConsoleApp

> My very first C# project that uses an API to fetch and display weather information in the console.

---

## 📌 What does this project do?

- Asks the user for a city name
- Uses the [OpenWeatherMap API](https://openweathermap.org/api) to fetch weather data
- Displays:
  - Current temperature
  - Feels-like temperature
  - Min and max temperatures
  - Wind speed
  - The country the city is located in

---

## 🛠️ Technologies & Concepts Used

- **C# (.NET)** – Main programming language
- **HttpClient** – To send requests to the API
- **System.Text.Json** – To parse JSON responses
- **async/await** – Asynchronous programming
- **App Configuration** – Reads settings from a `.json` file
- **Clean Project Structure**:
  - `/Models` – Defines JSON data structure
  - `/Services` – Service logic for API requests
  - `/Config` – Loading settings
- **.gitignore** – Protecting sensitive files (like actual API keys)

---

## 🚀 Getting Started

### ✅ Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/) installed
- An **OpenWeatherMap** API key

### 🗝️ Setup
1. Clone this repository:
    ```bash
    git clone https://github.com/<your-username>/WeatherInfoConsoleApp.git
    ```
2. Copy the `example.json` file and rename it to:
    ```
    Connections.json
    ```
3. Edit `Connections.json` and replace `YOUR_API_KEY` with your actual OpenWeatherMap API key:
    ```json
    {
      "GetTemp": "https://api.openweathermap.org/data/2.5/weather?q=cityName&appid=YOUR_API_KEY&units=metric"
    }
    ```

### 🏃‍♂️ Run
```bash
dotnet run
