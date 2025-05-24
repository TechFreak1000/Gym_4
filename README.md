# 🏋️‍♂️ Gym Management and Personalized Exercise Recommendation System

A full-stack web application built using **ASP.NET Core 6** to help gym trainers manage clients, monitor fitness progress, provide personalized exercise recommendations, and sell gym merchandise online.

---

## 🚀 Features

- 👤 **Trainer Dashboard** — Monitor client performance and updates.
- 🧠 **Personalised Exercise Recommendations** — Tailored programs for each client.
- 🛒 **Merchandise Store** — Advertise and sell gym-branded products.
- 📊 **Progress Tracking** — Record and review fitness achievements.
- 🔐 **Role-Based Access** — Separate views and controls for trainers and clients.

---

## 🛠 Tech Stack

| Layer       | Technology                      |
|-------------|----------------------------------|
| Backend     | ASP.NET Core 6, C#               |
| Frontend    | Razor Pages, Bootstrap, JavaScript |
| Database    | Microsoft SQL Server             |
| ORM         | Entity Framework Core            |
| Tools       | Visual Studio, LINQ, EF Migrations |

---

## 📁 Project Structure

```
Gym_4-master/
├── Controllers/          # Route and business logic
├── Models/               # Entity and View models
├── Views/                # Razor UI templates
├── Data/                 # DbContext and configuration
├── Migrations/           # EF Core schema migrations
├── wwwroot/              # Static web assets (CSS, JS, images)
├── appsettings.json      # Project configuration
├── Program.cs            # Application entry point
```

---

## ⚙️ Setup Instructions

### ✅ Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or later

### ▶️ Run Locally

1. **Clone the repository**
```bash
git clone https://github.com/TechFreak1000/Gym_4.git
cd gym-management-system
```

2. **Open in Visual Studio**

   Open the `Gym.sln` file in Visual Studio.

3. **Run EF Core Migrations**

   Open the Package Manager Console and run:
   ```powershell
   Update-Database
   ```

4. **Start the Application**
   - Press `F5` or click "Start" to run the project.

---

## 📸 Screenshots (Optional)

> _Add screenshots here showing the dashboard, merchandise section, and recommendation interface._

---

## 👨‍💻 Author

**Rudrang Darade**  
📧 your.rudrang04@gmail.com  
🔗 [GitHub Profile](https://github.com/TechFreak1000)

---

## 📜 License

This project is licensed under the **MIT License**. See the [LICENSE](./LICENSE) file for details.
