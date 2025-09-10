```markdown
# 🌦️ Weather CLI App

A simple **C# console application** that fetches real-time weather information for any city using the [wttr.in](https://wttr.in) API.

---

## 🚀 Features
- Fetches current weather by city name  
- Uses the free [wttr.in](https://wttr.in) weather service  
- Minimal output in short format (e.g., `London: 🌧️ +18°C`)  
- Handles network errors gracefully  

---

## 📂 Project Structure
```

weatherApi/
│── Program.cs   # Main application code
│── README.md    # Project documentation

````

---

## 🛠️ Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (6.0 or later recommended)  
- Internet connection (to fetch weather data)

Check if you have .NET installed:
```bash
dotnet --version
````

---

## ▶️ Running the App

1. Clone the repo:

   ```bash
   git clone https://github.com/michelleaijo/weatherApi.git
   cd weatherApi
   ```

2. Build the project:

   ```bash
   dotnet build
   ```

3. Run the app:

   ```bash
   dotnet run
   ```

4. Enter a city name when prompted, e.g.:

   ```
   Enter a city: Paris
   Weather Info:
   Paris: 🌤️ +22°C
   ```

---

## 📌 Example

```
Enter a city: New York
Weather Info:
New York: 🌦️ +25°C
```

---

## ⚠️ Notes

* This app uses the public `wttr.in` service which may have request limits.
* Weather data may vary depending on location and time of day.

---

## 📜 License

This project is licensed under the **MIT License** – feel free to use, modify, and share.

```
