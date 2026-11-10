# Exercice 09 : TDD avec Vitest (D3A)

- Lancer le projet

```bash
docker compose -f docker-compose.yml up -d --build
```

- Ouvrir un `DevContainer` sur le conteneur `frontend`, puis le dossier `/usr/src/app`
- Lancer les tests

```bash
npm run test
```

- Attention : au démarrage, le conteneur fait `npm install`, et cela peut être long. Regardez les logs (`docker compose logs -f frontend`) avant de lancer les tests.
