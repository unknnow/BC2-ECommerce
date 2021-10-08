# PROJET - FindAll - BC2 - EFFICOM
## Faux site web de vente en ligne

Projet crée et développer lors du cours de BC2 à EFFICOM. Nous devions crée un site avec thème libre mais obligatoirement utilsé une API .Net core en lien avec une Base de données MySQL ainsi que développé le front du site sous Blazor.

## Structure du projet

- Front : Blazor
- Back : API .Net core
- Base de données : MySQL

## Fichiers / Dossier

- API : Contient le projet API .net core
- Blazor : Contient le projet Blazor webassembly
- bc2projet-data-final: fichier MYSQL d'import de la base de données (Données d'exemple inclus)

## Installation de la BDD

Créer la base de données "bc2projet" puis importer le fichier avec l'aide de PHPMyAdmin par exmple.

## Lancement de Blazor & API

Commande à excuter dans le dossier API et Blazor :

```
dotnet watch run
```

Mise à jour de la BDD :

```
dotnet ef migrations add "Nom de la migration"
dotnet ef database update
```