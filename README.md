# System_Gestion_Fin

## Description
Cette application simplifiée permet d'enregistrer et de gérer des transactions financières (crédit et débit) pour une entreprise. Chaque transaction est soumise à des règles de validation personnalisées. L'application peut évoluer pour accepter des règles supplémentaires sans nécessiter de modification du code existant.

## Fonctionnalités
- Enregistrement de transactions (crédit/débit) avec une date, un montant et une description.
- Validation des transactions selon des règles métier :
  - Le montant d'un crédit ne peut pas dépasser 10 000.
  - Le solde ne peut pas descendre en dessous de -5 000 après un débit.
- Support pour l'ajout dynamique de nouvelles règles de validation.

## Prérequis
- .NET SDK 5.0 ou plus récent installé sur votre machine.

- ## Installation
- 1. **Cloner le dépôt** :
   git clone https://github.com/EnergieNVidia77/gestion-transactions-financieres.git

- 2. **Ouvrir Visual Studio** :
   Lancer la solution .sln

## Choix Techniques

### 1. Séparation des types de transaction
- Les transactions sont modélisées par deux classes distinctes : `TransactionCredit` et `TransactionDebit`, dérivées d'une classe de base `Transaction`. Cela permet de gérer les différentes logiques métier pour chaque type de transaction (crédit/débit).
- Chaque type est donc une entité séparée pour simplifier la gestion des règles propres à chaque type de transaction.

### 2. Service de transactions
- La classe `TransactionService` est responsable de la gestion des transactions et du solde du compte. Elle encapsule la logique de validation et l'ajout de nouvelles transactions.
- Elle fournit une méthode simple pour ajouter des transactions et vérifie leur validité avant de les appliquer.

### 3. Gestion des erreurs
- Si une transaction viole une règle de validation (par exemple, si un débit fait passer le solde en dessous de -5000), une exception est levée (ici seulement une sortie std sur console) et la transaction n'est pas effectuée.
- Ce mécanisme garantit l'intégrité des données et empêche des opérations invalides.

### 4. Utilisation d'une interface pour les validateurs
- L'interface `IValidator` est utilisée pour garantir que chaque validateur de transaction respecte un contrat commun.
- Chaque règle de validation est implémentée sous forme de classe distincte qui implémente l'interface `IValidator`. Cette interface impose une méthode commune, `IsValid(Transaction transaction, decimal _solde)`, qui vérifie si une transaction est conforme aux règles définies.
- Ce système facilite l'ajout de nouvelles règles de validation sans modifier les classes existantes. Il suffit de créer une nouvelle classe qui implémente `IValidator` et de l'ajouter à la chaîne de validateurs.
