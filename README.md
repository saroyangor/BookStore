# BookStore Application

Приложение **BookStore** с бэкендом на .NET Core, фронтендом на Next.js и базой данных PostgreSQL, запускаемое через Docker Compose.

## Требования

- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/)

## Структура Docker Compose

- **backend** — .NET Core API (`BookStore.API`)  
- **frontend** — Next.js (`bookstore.client`)  
- **postgres** — база данных PostgreSQL  

## Запуск всего стека

1. Клонируем проект:

```bash
git clone https://github.com/saroyangor/BookStore.git --recurse-submodules
```

2. Запуск через Docker Compose:
```bash
cd BookStore
docker-compose up --build -d
```

3. Проверка работы сервисов:
 - API (backend): http://localhost:5297
 - Frontend: http://localhost:3000
 - PostgreSQL: порт 5432 (для локального подключения)

