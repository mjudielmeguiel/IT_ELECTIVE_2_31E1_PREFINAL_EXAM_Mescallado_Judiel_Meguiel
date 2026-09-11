# IT Elective 2 — Prefinal Examination

**Name:** Judiel Meguiel Mescallado
**Section:** 31E1
**Date Submitted:** September 12, 2026
**Academic Year:** 2026-2027
**Semester:** 1st Semester, AY 2026-2027

---

## General Instructions

- Read each question carefully before selecting your answer.
- Choose the best answer from the given options (A, B, C, or D).
- Do not leave any item blank. If unsure, make your best guess.

---

## Examination Answers

### 1. What is the main problem solved by using a database instead of an in-memory collection?
**Answer: C** — It allows data to persist after the application stops

### 2. Which approach is being used when an existing database is used to generate EF Core entity classes?
**Answer: B** — Database-First

### 3. What is the primary purpose of Entity Framework Core?
**Answer: C** — To map objects in code to relational database data

### 4. Which EF Core component is primarily responsible for communicating with the database?
**Answer: A** — DbContext

### 5. What does the following command primarily do? dotnet ef dbcontext scaffold ...
**Answer: C** — Generates EF Core models and a DbContext from an existing database

### 6. Where is a database connection string commonly stored in an ASP.NET Core MVC application?
**Answer: B** — appsettings.json

### 7. A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?
**Answer: B** — One-to-Many

### 8. In the following example, what is SectionId? public int SectionId { get; set; }
**Answer: B** — Foreign key referencing Section

### 9. What is the purpose of a navigation property such as public Section Section { get; set; }?
**Answer: B** — It represents a relationship to another entity

### 10. What does .Include() generally allow EF Core to do?
**Answer: B** — Load related Section data together with Students

### 11. Why might a ViewModel be used when displaying Student and Section information?
**Answer: B** — To combine or shape the data specifically needed by the view

### 12. Consider this query: var students = _context.Students.Include(s => s.Section).ToList(); Main benefit of Include()?
**Answer: A** — It loads the related Section navigation property

### 13. Which type of validation occurs in the browser before a request is sent to the server?
**Answer: B** — Client-side validation

### 14. Why is server-side validation still necessary if client-side validation exists?
**Answer: A** — Client-side validation can be bypassed

### 15. A school requires every student to have a unique Student Number. Which rule best represents this requirement?
**Answer: B** — Student Number should be unique

### 16. Which is the best reason for having a database-level unique constraint on StudentNumber?
**Answer: A** — It protects data integrity even if application-level validation is bypassed

### 17. What is the purpose of a try...catch block in a controller?
**Answer: B** — To catch and handle exceptions that may occur during execution

### 18. Which middleware is commonly used in ASP.NET Core for centralized exception handling?
**Answer: B** — UseExceptionHandler()

### 19. A user requests /Student/999, but Student 999 does not exist. What would be the most appropriate response?
**Answer: B** — Display a Not Found (404) response/page

### 20. A student already belongs to Section A for a particular subject. The application attempts to assign the same student to Section A again. What is the primary concern?
**Answer: A** — Data integrity

---

## Table of Specification Alignment

| Topic | Items |
|---|---|
| Relational Data Modeling, Tables, Keys, Constraints, Model Binding | 1–5 |
| Entity-Relationship Diagrams, Razor Syntax and Dynamic Rendering | 6–10 |
| Data Normalization, Validation, and ModelState | 11–15 |
| SQL, In-Memory Storage, CRUD Operations, and Data Persistence | 16–20 |

---

## Project Details

- **Framework:** ASP.NET Core MVC
- **Database:** None (Hardcoded data only)
- **Total Commits:** 20
- **Submitted by:** Judiel Meguiel Mescallado
- **Evaluated by:** Nino Francisco Alamo (Faculty)
