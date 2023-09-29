Certainly! Here's a more detailed `README.md` in English:

---

# AwesomeCrud

Welcome to the AwesomeCrud repository! This project, built with ASP.NET Core, is designed to serve as a comprehensive course platform. Whether you're a developer looking to understand its structure or someone interested in using it, this guide will help you get started.

## Table of Contents

- [Project Overview](#project-overview)
- [Features](#features)
- [Getting Started](#getting-started)
    - [Prerequisites](#prerequisites)
    - [Installation](#installation)
    - [Running the Application](#running-the-application)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Project Overview

The project is structured into several main directories, each serving a specific purpose:

- **Areas**: Contains specific functionalities of the project.
    - **Identity**: Handles authentication and user management.
- **Data**: Contains classes and configurations related to the database.
- **Models**: Houses model classes representing the entities of the project.
- **Pages**: Consists of Razor pages that make up the user interface.
    - **Premiums**: Pages related to the "Premium" feature.
    - **Students**: Pages dedicated to student functionalities.
- **wwwroot**: Stores static files and libraries.

## Features

- **User Authentication**: Secure sign-up and login functionality.
- **Course Management**: Add, edit, and delete courses.
- **Student Profiles**: Manage student information and track progress.
- **Premium Features**: Special features or courses available for premium users.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/).

### Installation

1. Clone the repository to your local machine:
   ```bash
   git clone https://github.com/marcinhojazz/AwesomeCrud.git
   ```

2. Navigate to the project directory:
   ```bash
   cd AwesomeCrud
   ```

3. Restore the required packages:
   ```bash
   dotnet restore
   ```

### Running the Application

1. To run the application, use the following command:
   ```bash
   dotnet run
   ```

2. Once the application starts, open your browser and navigate to `http://localhost:5000` to access the platform.

## Contributing

Contributions are always welcome! If you wish to contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Open a pull request.

## License

This project is open-source. Feel free to use, modify, and distribute it as you see fit.

## Contact

If you have any questions, issues, or feedback, please open an issue in this repository or contact the repository owner.

---

I hope this provides a more comprehensive overview of your project! Let me know if you'd like any further adjustments or additions.