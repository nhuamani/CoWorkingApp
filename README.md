# Console App .Net Core

## Create App

```bash
# Root directory
mkdir CoWorkingApp
cd

# Interface (Main) directory
mkdir CoWorkingApp.App
cd CoWorkingApp.App

# Create .Net Console App
dotnet new console

# Compile App
dotnet build

# Run App
dotnet run

# Back to Root directory
cd ..

# Create Data Directory
mkdir CoWorkingApp.Data
cd CoWorkingApp.Data

# Create Library Class for Data Persistence
dotnet new classlib

# Back to Root directory
cd ..

# Create Model Directory
mkdir CoWorkingApp.Model
cd CoWorkingApp.Model

# Create Library Class for Model
dotnet new classlib

# Back to Root directory
cd ..

# Add reference between projects
cd CoWorkingApp.App
dotnet add reference ../CoWorkingApp.Model/CoWorkingApp.Model.csproj ../CoWorkingApp.Data/CoWorkingApp.Data.csproj

cd ..
cd CoWorkingApp.Data
dotnet add reference ../CoWorkingApp.Model/CoWorkingApp.Model.csproj
# Add 

```
