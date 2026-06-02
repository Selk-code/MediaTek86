# Application Contexte MediaTek86
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


L'application est structurée dans le respect du pattern MVC.
<img width="1623" height="841" alt="image" src="https://github.com/user-attachments/assets/c2ed7897-0f2b-4be0-90e0-83bb893e9ece" />


Explications sur les couches supplémentaires
L'application contient 2 paquetages supplémentaires par rapport au MVC classique :
. 'bddmanager' : contient la classe qui permet d'accéder à la base de données MySQL et d'exécuter les requêtes (classe indépendante et réutilisable).
. 'dal' (Data Access Layer) : répond aux demandes du paquetage 'controller' et exploite 'bddmanager' en lui demandant d'exécuter des requêtes.
L'avantage de cette architecture est l'isolement de la connexion (bddmanager) par rapport au reste de l'application. Le controleur ne sait pas d'où viennent les données (cela pourrait être un autre SGBDR, voire un autre type de fichier, comme XML). Le paquetage 'dal' fait l'intermédiaire en préparant des requêtes SQL. Donc on sait dans les classes de ce paquetage, qu'il est question d'une base de données relationnelle, mais ne sait pas non plus quel est le SGBDR utilisé.
Changer de SGBDR reviendrait à juste changer la classe BddManager (son contenu), donc ne travailler que sur le paquetage 'bddmanager'.
Changer de type de fichier reviendrait à changer aussi les classes du paquetage 'dal', sans toucher au reste de l'application.

Présentation du cheminement
L'application démarre sur une vue : c'est la structure classique des applications C# de bureau, mais il serait aussi possible de démarrer sur un contrôleur principal.
La vue crée une instance du contrôleur qui lui est dédié (chaque vue a son propre contrôleur). Quand elle a besoin d'accéder aux données (affichage ou demande de modifications), elle fait appel à son contrôleur.
Le contrôleur fait appel aux classes de la couche 'dal' pour exécuter les demandes de la vue.
Les classes de la couche 'dal' contiennent les requêtes qui doivent être exécutées et sollicitent la couche 'bddmanager' pour exécuter les requêtes.
Chaque classe de la couche 'dal' est liée à une classe métier contenu dans 'model'. Ces classes correspondent aux tables de la base de données (avec une approche objet, donc pas de clés étrangères mais des références d'objets) et ne contiennent que la structure des données (propriétés, getters, setters). Excepté 'bddmanager' qui est indépendant de l'application (réutilisable dans n'importe quelle application), toutes les couches exploitent le 'model' (pour le formatage des données).
