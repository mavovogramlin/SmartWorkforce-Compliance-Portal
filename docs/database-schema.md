# Database Schema
## Smart Workforce Compliance & Automation Portal

---

## 1. Overview
This document defines the SQL Server database schema for the Smart Workforce Compliance & Automation Portal. It outlines the tables, fields, relationships, and primary business rules.

The schema is designed for:

- Security and role-based access
- Tracking employee requests and approvals
- Maintaining compliance documents
- Supporting analytics and reporting

---

## 2. Tables

### 2.1 Users
Stores employee, supervisor, and admin information.

| Column Name | Type | Description |
|-------------|------|-------------|
| UserId | NVARCHAR(450) PK | Unique identifier from ASP.NET Identity |
| FullName | NVARCHAR(100) | Employee full name |
| Email | NVARCHAR(100) | Employee email |
| Role | NVARCHAR(50) | Employee, Supervisor, Admin |
| Department | NVARCHAR(50) | Department name |
| IsActive | BIT | Account status |

---

### 2.2 Requests
Tracks all requests submitted by employees.

| Column Name | Type | Description |
|-------------|------|-------------|
| RequestId | INT PK IDENTITY | Unique request identifier |
| UserId | NVARCHAR(450) FK | Employee who submitted request |
| RequestType | NVARCHAR(50) | Leave, Access, Training, Equipment |
| Description | NVARCHAR(MAX) | Additional details |
| Status | NVARCHAR(20) | Pending, Approved, Rejected |
| CreatedDate | DATETIME | Timestamp of submission |

---

### 2.3 Approvals
Tracks supervisor decisions for requests.

| Column Name | Type | Description |
|-------------|------|-------------|
| ApprovalId | INT PK IDENTITY | Unique approval identifier |
| RequestId | INT FK | Related request |
| ApproverId | NVARCHAR(450) FK | Supervisor who approved/rejected |
| Decision | NVARCHAR(20) | Approved or Rejected |
| Comments | NVARCHAR(MAX) | Optional supervisor comments |
| DecisionDate | DATETIME | Timestamp of approval action |

---

### 2.4 Documents
Stores uploaded compliance documents.

| Column Name | Type | Description |
|-------------|------|-------------|
| DocumentId | INT PK IDENTITY | Unique document identifier |
| UserId | NVARCHAR(450) FK | Employee associated with document |
| DocumentType | NVARCHAR(50) | ID, Safety, Certificate |
| FilePath | NVARCHAR(MAX) | Path to stored file |
| ExpiryDate | DATETIME | Expiration date for compliance tracking |

---

### 2.5 AuditLogs
Tracks all important actions for accountability.

| Column Name | Type | Description |
|-------------|------|-------------|
| AuditId | INT PK IDENTITY | Unique audit entry |
| UserId | NVARCHAR(450) FK | Who performed the action |
| Action | NVARCHAR(100) | Description of action |
| Timestamp | DATETIME | When action occurred |

---

## 3. Relationships

- `Users` → `Requests` (1-to-many)
- `Users` → `Documents` (1-to-many)
- `Requests` → `Approvals` (1-to-many)
- `Users` → `AuditLogs` (1-to-many)

---

## 4. Notes

- All foreign keys enforce referential integrity.
- Status fields (`Requests.Status`, `Approvals.Decision`) are ENUM-like (restricted values).
- Database designed to support **Power BI** analytics and **Power Automate** triggers.
- Extensible for future modules (e.g., notifications, escalations).

---

## 5. Summary
This schema supports secure, structured, and auditable management of employee requests and approvals. It provides a solid foundation for both custom MVC development and Power Platform automation and reporting.
