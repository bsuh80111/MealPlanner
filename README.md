# Meal Planner

## Running the App

```
dotnet run --launch-profile https
```

## Docs

API docs are viewable by navigating to _localhost:<port>/swagger_

## Database

### Add New Migration

```
dotnet ef migrations add nameOfMigration
```

### Remove the Last Migration

```
dotnet ef migrations remove
```

### Update Database

```
dotnet ef database update
```

### Drop Database

```
dotnet ef database drop --force
```
