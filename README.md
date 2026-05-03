# CampusBuzz – Campus Community Web Application

A full-stack web application built for the University of Pretoria's INF 354 module. CampusBuzz is a campus community platform that allows students to discover and engage with campus events, announcements, and resources.

---

## 🚀 Tech Stack

| Layer | Technology |
|---|---|
| Frontend | Angular 17, TypeScript, HTML, CSS |
| Backend | .NET 8 Web API (C#) |
| Database | Microsoft SQL Server |
| Architecture | RESTful API, MVC pattern |

---

## ✨ Features

- User registration and authentication
- Browse and filter campus events / posts
- Create, edit, and delete content (CRUD)
- Responsive UI across screen sizes
- Data validation and error handling on both frontend and backend

---

## 📁 Project Structure

```
campusbuzz-web-app/
│
├── CampusBuzz.API/          # .NET 8 Web API backend
│   ├── Controllers/         # API route handlers
│   ├── Models/              # Data models & DTOs
│   ├── Data/                # DbContext & migrations
│   └── Program.cs
│
├── campusbuzz-frontend/     # Angular 17 frontend
│   ├── src/
│   │   ├── app/
│   │   │   ├── components/  # Reusable UI components
│   │   │   ├── services/    # HTTP service layer
│   │   │   └── models/      # TypeScript interfaces
│   └── angular.json
│
└── README.md
```

---

## ⚙️ Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/) (v18+)
- [Angular CLI](https://angular.io/cli) (`npm install -g @angular/cli`)
- SQL Server (or SQL Server Express)

### Backend Setup
```bash
cd CampusBuzz.API
# Update connection string in appsettings.json
dotnet ef database update
dotnet run
```
API will run on `https://localhost:7001`

### Frontend Setup
```bash
cd campusbuzz-frontend
npm install
ng serve
```
App will run on `http://localhost:4200`

---

## 🧠 Key Learning Outcomes

- Designed and implemented a RESTful API using .NET 8
- Connected Angular frontend to a backend via HTTP services
- Managed database relationships and migrations with Entity Framework Core
- Resolved real version compatibility challenges across the stack (Node, Angular CLI, NuGet)

---

## 📚 Module Context
Built as part of **INF 354 – Internet Programming** at the University of Pretoria (2025).

---

## 👩🏽‍💻 Author
**Maria Malebo Maleka** — [LinkedIn](https://linkedin.com/in/maria-malebo-maleka-5a405635b)
