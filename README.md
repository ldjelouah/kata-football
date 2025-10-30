# Classement de matchs (Premier League) ⚽

## But
Implémenter `RankingService.BuildTable(IEnumerable<RawMatch>)` pour produire un **classement** d’équipes.

## Règles
- Points : victoire **3**, nul **1**, défaite **0**
- Tri : **Points desc** → **Différence de buts (DG) desc** → **Buts marqués (GF) desc** → **Nom asc**

## Entrée
- `List<RawMatch>` (déjà désérialisée depuis `data/matches.json`)
- Modèle : `RawMatch(string HomeTeam, string AwayTeam, int HomeGoals, int AwayGoals)`

## Sortie
- `IEnumerable<Standing>` (remplir `Played/Won/Drawn/Lost`, `GoalsFor/GoalsAgainst`, `Points`, `GoalDifference` calculé)

## Contraintes
- C# / **.NET 8**, tout **en mémoire**
- Gérer **les 2 équipes** par match
- Dictionnaire **insensible à la casse** recommandé (`StringComparer.OrdinalIgnoreCase`)
- Code **simple**, lisible, petites méthodes

## Attendus
- Logique correcte + tri exact
- Noms clairs
- Si l’entrée est vide → retourner une **liste vide**

## Exécuter
```bash
dotnet run --project League.App
```


## Tests unitaires
 - Le test fourni `RankingTests.Should_Order_By_Points_Then_GD_Then_GF` doit être VERT.
 - Ajoutez 1 test unitaire supplémentaire :
	
	Créez des matchs pour que deux équipes soient à égalité de points.
Vérifiez que le classement les départage d’abord par la Différence de Buts (DG) ;
si la DG est égale, par les Buts marqués (GF) ;
si GF est aussi égal, par l’ordre alphabétique du nom d’équipe.
