# Projet 6 : Modélisez et créez une base de données pour une application .NET

Ce projet est la création d'une **base de données** alimentée à l'aide de **tickets fictifs**. 
L'objectif était de se mettre à l'aise avec les **bases de données** et le langage **LINQ**

---
## Outils et technologies utilisés

- **Visual Studio 2022**
- **C# / ASP.NET Core**
- **SQL Server Management Studio**
- **Entity Framework**
- **LINQPad 8**
  
---
## Le modèle entité-association

<p align="center">
<img width="335" height="419" alt="image" src="https://github.com/user-attachments/assets/0589f3eb-a240-4ade-9eeb-fc4c90a7f749" />
</p>

---
## Le back-end

- **Base de données** : SQL Server via EF Core (approche Code-First)
- **Injection dans la base de données** : Grâce aux DataSeed qui permettent d'ajouter dans la BDD, si elle est vide, les tickets fictifs au moment du lancement de l'application

---
## Installation  

1. `git clone https://github.com/khiastos/Projet-6-OC.git`  
2. Ouvrir la solution dans Visual Studio  
3. Modifier la chaîne de connexion dans `appsettings.json` en mettant celle de votre base en local et le nom de votre choix
4. Lancer `Update-Database` dans la Console du Gestionnaire de Package
5. Exécuter le projet

Si besoin, vous pouvez supprimer les migrations déjà existantes pour éviter les potentiels conflits, il faudra cependant exécuter `Add-Migration (+ Nom de votre choix)` pour créer une nouvelle migration, puis effectuer `Update-Database`.

---
## Lancement

Il vous suffit simplement de lancer l'application afin que la BDD se remplisse grâce aux DataSeed, ainsi vous pourrez consulter les tickets via l'Explorateur d'objet SQL Server

