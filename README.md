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

Créer la base de données "bc2projet" puis importer le fichier avec l'aide de PHPMyAdmin par exemple.
Ligne de connexion à la BDD dispo dans le fichier API/Startup.cs - ligne 42.

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

## Authentification Auth0

L'authentification à temporairement était arréter dû à un bug mais manque de temps pour le corriger. (L'authentification fonctionne mais pas pour tous le monde).

Cependant le code est toujours visible en commentaire dans le Code.

Pour activer le code de l'authentification Auth0 commenter les lignes suivantes :
- Blazor - App.razor : ligne 1 à 10

Décommenter les lignes suivantes :
- Blazor - App.razor : ligne 12 à 31
- Blazor - Program.cs : ligne 23 à 27
- Blazor - MainLayout.razor : lignes 9, 13, 27, 39 et 45
- Blazor - Index.razor : ligne 35 et 37
