# 👻 BudgetBoo 👻
A cross-platform financial budget tracking app built with C#, .NET 8, and .NET MAUI! ♥


## ♥ Table of Contents 

- [Overview](#-overview)
- [Features](#-features)
- [Screenshots](#-screenshots)
- [Getting Started](#-getting-started)
- [Project Structure](#-project-structure)
- [Technologies Used](#t-echnologies-used)
- [Build & Run](#-build--run)
- [Contact](#-get-in-touch)

## ♥ Overview

BudgetBoo helps you track your expenses and manage your budget across multiple platforms (Windows, Android, iOS, MacCatalyst, Tizen).  
The app uses a modular architecture with separate projects for core logic, data access, and UI.

## ♥ Features

- Add, view, and categorize transactions
- Responsive and modern UI
- Cross-platform support
- Local SQLite database storage

*More features coming soon!*

## ♥ Screenshots

<!-- Add screenshots here -->

## ♥ Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) with .NET MAUI workload

### Setup

1. Clone the repository:
    ```sh
    git clone https://github.com/NahdaaJ/budgetboo.git
    cd budgetboo/BudgetBoo
    ```

2. Open `BudgetBoo.sln` in Visual Studio.

3. Restore NuGet packages.


## ♥ Project Structure

```
BudgetBoo/
├── BudgetBoo.sln                # Solution file
├── BudgetBoo.Core/              # Core models and business logic
│   ├── Models/                  # Domain models and enums
│   └── BudgetBoo.Core.csproj
├── BudgetBoo.Data/              # Data access and database initialization
│   ├── Entities/                # Database entities
│   ├── Database/                # Database initialization logic
│   └── BudgetBoo.Data.csproj
├── BudgetBoo.UI/                # .NET MAUI cross-platform UI
│   ├── App.xaml, App.xaml.cs    # Application entry and resources
│   ├── AppShell.xaml, AppShell.xaml.cs # (Optional) Shell navigation
│   ├── MainLayout.xaml, MainLayout.xaml.cs # Main layout and navigation
│   ├── ContentPages/            # UI pages (e.g., TransactionPage)
│   ├── Helpers/                 # UI helper classes (e.g., EnumExtensions)
│   ├── Resources/               # Styles, fonts, images, and raw assets
│   ├── ViewModels/              # View models for UI binding
│   ├── Platforms/               # Platform-specific code (Android, iOS, Windows, etc.)
│   └── BudgetBoo.UI.csproj
└── README.md                    # Project documentation
```

## ♥ Technologies Used

- [.NET 8](https://dotnet.microsoft.com/)
- [.NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/)
- [SQLite-net-pcl](https://github.com/praeclarum/sqlite-net)
- [Dapper](https://github.com/DapperLib/Dapper)
- C#
- XAML

## ♥ Build & Run

1. Select the target platform (Windows, Android, iOS, MacCatalyst, Tizen) in Visual Studio.
2. Press **F5** to build and run the app.

## ♥ Get in touch!
If you have come across this repo, I'd love to hear from you! Whether you have feedback, suggestions, or just want to say hi, don't hesitate to reach out! ♡

<div align=center>
      <a href="https://www.linkedin.com/in/nahdaa-jawed/" target="_blank">
         <img src="/ReadMePics/linkedin.png" alt="LinkedIn" style="height:50px;border-radius:11px" >
      </a>
      <a href="https://github.com/NahdaaJ" target="_blank">
         <img src="/ReadMePics/github.png" alt="GitHub" style="height:50px;border-radius:11px" >
      </a>
      <a href="mailto:nahdaajawed@gmail.com?subject=%F0%9F%90%B0%20Reaching%20Out%20From%20Your%20BudgetBoo%20Repo&body=Just%20hopping%20by%20to%20say%20hi%20and%20get%20in%20touch!">
         <img src="/ReadMePics/email.png" alt="Email" style="height:50px;border-radius:11px" >
      </a>
   </div>