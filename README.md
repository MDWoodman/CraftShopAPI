CraftShopAPI
============

CraftShopAPI to projekt demonstracyjny ASP.NET Core Web API,
którego celem jest praktyczne ćwiczenie zasad SOLID,
architektury warstwowej oraz wybranych wzorców projektowych
w kontekście aplikacji backendowej.

Projekt ma charakter edukacyjny i jest rozwijany iteracyjnie.

------------------------------------------------------------
1. TECHNOLOGIE
------------------------------------------------------------

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- Dependency Injection (wbudowany kontener .NET)
- Fluent API (częściowo)

------------------------------------------------------------
2. STRUKTURA PROJEKTU
------------------------------------------------------------

Projekt jest podzielony logicznie na warstwy:

CraftShopAPI
├── Application
│   ├── Builders
│   ├── DTO
│   ├── Factories
│   ├── Prototypes
│   ├── Services
│   └── Repositories (interfejsy)
│
├── Domain
│   ├── Entities
│   └── Enum
│
├── Infrastructure
│   ├── Repositories (implementacje)
│   └── CraftShopDbContext
│
├── Migrations
└── Program.cs

Architektura jest warstwowa, z wyraźnym rozdzieleniem:
- logiki domenowej
- logiki aplikacyjnej
- persystencji danych
- warstwy API

------------------------------------------------------------
3. SOLID
------------------------------------------------------------

Projekt realizuje podstawowe założenia SOLID:

S — Single Responsibility Principle  
- Encje odpowiadają za swój stan
- Repozytoria za dostęp do danych
- Serwisy aplikacyjne za orkiestrację

O — Open / Closed Principle  
- Logika tworzenia obiektów oddzielona od ich użycia
- Wzorce Builder / Prototype ograniczają modyfikacje istniejącego kodu

L — Liskov Substitution Principle  
- Repozytoria i serwisy używane przez interfejsy

I — Interface Segregation Principle  
- Osobne interfejsy dla odczytu i zapisu (Read / Write)

D — Dependency Inversion Principle  
- Warstwy wyższe zależą od interfejsów
- Implementacje wstrzykiwane przez Dependency Injection

------------------------------------------------------------
4. DOMAIN
------------------------------------------------------------

Warstwa Domain zawiera:
- Encje biznesowe (Lamp, Chair, CrystalDecor, Order, OrderItem)
- Enumy opisujące stany i typy
- Podstawową strukturę modelu domenowego

Encje:
- nie zależą od EF Core
- nie zawierają kodu infrastrukturalnego
- reprezentują model biznesowy

------------------------------------------------------------
5. ZASTOSOWANE WZORCE PROJEKTOWE
------------------------------------------------------------

Builder  
- Używany do tworzenia złożonych obiektów (np. Lamp, Chair)
- Oddziela proces budowy od logiki aplikacyjnej

Prototype  
- Umożliwia klonowanie obiektów (np. prototyp Lampy)
- Klonowanie realizowane w warstwie Application

Factory  
- Wykorzystywana do tworzenia obiektów w zależności od typu
- Uproszczona forma fabryki (bez centralnego switcha w kontrolerach)

Repository  
- Oddzielenie logiki persystencji od logiki biznesowej
- Interfejsy w Application, implementacje w Infrastructure

------------------------------------------------------------
6. ENTITY FRAMEWORK CORE
------------------------------------------------------------

- SQLite jako baza danych
- Code First + migracje
- DbContext umieszczony w Infrastructure
- Osobne DbSet dla encji (np. Order, OrderItem)
- Relacje 1-N (Order → OrderItem)

------------------------------------------------------------
7. DEPENDENCY INJECTION
------------------------------------------------------------

- Wbudowany kontener DI ASP.NET Core
- Rejestracja zależności w Program.cs
- Wstrzykiwanie przez konstruktor
- Scoped lifetime dla:
  - DbContext
  - Repozytoriów
  - Serwisów

------------------------------------------------------------
8. API
------------------------------------------------------------

API pełni rolę cienkiej warstwy:

- Kontrolery nie zawierają logiki biznesowej
- Odpowiadają za obsługę HTTP
- Delegują pracę do serwisów aplikacyjnych

Przykładowe endpointy:
- POST /api/lamp
- GET /api/lamp
- POST /api/order

------------------------------------------------------------
9. STAN PROJEKTU
------------------------------------------------------------

Projekt jest w trakcie rozwoju.
Część rozwiązań (np. pełny State Pattern, Mediator, Observer)
jest przygotowywana iteracyjnie.

Kod koncentruje się na:
- poprawnej architekturze
- świadomym użyciu wzorców
- czytelności i możliwości rozbudowy

------------------------------------------------------------
10. CEL EDUKACYJNY
------------------------------------------------------------

Celem projektu jest:
- nauka czystej architektury
- praktyczne zastosowanie SOLID
- zrozumienie wzorców projektowych
- rozwój umiejętności backendowych w .NET

Projekt nie jest produkcyjnym systemem,
lecz świadomie zaprojektowanym poligonem architektonicznym.

