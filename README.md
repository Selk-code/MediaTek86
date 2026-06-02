# Application MediaTek86
Application C# écrite sous Visual Studio et exploitant une BDD MySQL.

## Présentation de l'application

### But de l'application
Le responsable souhaite disposer d'un outil de gestion de son personnel et de leurs absences.

Elle permet à un responsable, après authentification, de gérer les personnels de la 
médiathèque ainsi que leurs absences.

### Structure de la BDD
Voici la structure de la BDD qui est au format MySQL :

<img width="1224" height="609" alt="image" src="https://github.com/user-attachments/assets/ab4efbf9-1bac-4e45-9d2a-13ffc34f2bdd" />


## Interface et fonctionnalités

Voici à quoi ressemble la fenêtre principale de l'application :

<img width="625" height="450" alt="image" src="https://github.com/user-attachments/assets/b41db58e-fb10-4a70-ba2a-c29dc258edb6" />


L'application doit permettre de :
- présenter la liste du personnel (nom, prénom, tel, mail, service) ;
- permettre d'ajouter un personnel ;
- permettre de modifier ou supprimer un personnel ;
- accéder à la gestion des absences d'un personnel sélectionné, permettant de :
  - afficher la liste de ses absences (date de début, date de fin, motif) ;
  - ajouter une absence ;
  - modifier une absence ;
  - supprimer une absence.
