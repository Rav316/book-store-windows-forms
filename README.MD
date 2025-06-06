# Курсовой проект: **Магазин книг**

## 🚀 Запуск проекта

1. Распакуйте архив __Philosopher.zip__ и установите все шрифты из архива.
2. Настройте подключение к базе данных в классе [`AppDbContext`](book-store/context/AppDbContext.cs).
3. Выполните [скрипт](book-store/Resources/Sql/schema.sql) для создания схемы базы данных.
4. Выполните [скрипт](book-store/Resources/Sql/init.sql) для добавления тестовых данных.
5. Перенесите изображения из [папки](book-store/Resources/Init/Books) `Resources/Init/Books` в [папку](book-store/Resources/Books) `Resources/Books`.

---

## 🧰 Стек технологий

| Технология             | Описание                         |
|------------------------|----------------------------------|
| ![dotnet](https://img.shields.io/badge/.NET-8.0-blueviolet?logo=dotnet)           | Платформа .NET 8.0 |
| ![WinForms](https://img.shields.io/badge/Windows%20Forms-UI-lightgrey?logo=windows) | UI с использованием Windows Forms |
| ![EF Core](https://img.shields.io/badge/Entity%20Framework-ORM-green?logo=entity-framework) | ORM Entity Framework |
| ![PostgreSQL](https://img.shields.io/badge/PostgreSQL-16-blue?logo=postgresql)    | СУБД PostgreSQL 16 |

---

## 📁 Структура проекта

```
book-store/
├── context/                // Контекст приложения, содержит AppDbContext, SecurityContext
├── database/
│   ├── entity/            // Классы-сущности таблиц, используемые EF для маппинга с базой данных
│   └── repository/        // Слой доступа к данным. Методы для выполнения запросов к БД
├── dto/                   // Data Transfer Object'ы. Классы для передачи данных между слоями
├── form/                  // Реализация UI-форм приложения. Взаимодействие с пользователем
├── mapper/                // Классы для преобразования сущностей в DTO и обратно
├── Resources/             // Ресурсы приложения (изображения книг, SQL-скрипты и т.д.)
├── service/               // Бизнес-логика приложения. Взаимодействие между слоями и обработка сценариев
├── util/                  // Утилитные и вспомогательные классы
└── validation/            // Классы для валидации пользовательского ввода в формах
```
