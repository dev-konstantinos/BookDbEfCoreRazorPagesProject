# BookDbEFCoreRazorPagesProject

This is a demo application built using Entity Framework Core (Code First) with MySQL and without authentification.
The project follows basic Razor Pages architecture for a simple book management system.

## Overview
- The application includes CRUD (Create, Read, Update, Delete) operations for managing books.
- The database connection string is stored in `appsettings.json` for simplicity (set DB configuration before use).

## Project Structure
- **Pages/Books**: Contains Razor Pages for book management.
- **Models/Book.cs**: Defines the Book model.
- **Data/Migrations**: Handles database migrations.
- **Program.cs**: Main application entry point.
