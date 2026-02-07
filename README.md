# Smart Workforce Compliance & Automation Portal

## Overview
The Smart Workforce Compliance & Automation Portal is a hybrid enterprise solution that automates **employee requests, approvals, compliance tracking, and reporting**.  

This project combines **ASP.NET Core MVC**, **SQL Server**, and the **Microsoft Power Platform** (Power Automate, Power Apps, Power BI) to deliver a scalable, secure, and highly automated workflow solution.

It demonstrates competencies across multiple Microsoft certifications:
- **PL-900:** Power Platform fundamentals
- **PL-200:** Business process automation
- **PL-300:** Data analysis & visualization
- **PL-400:** Power Platform development & integration
- **PL-500:** Workflow automation & RPA
- **PL-600:** Solution architecture & governance

---
## Technology Stack
- ASP.NET Core MVC (C#)
- SQL Server
- Entity Framework Core
- Power Automate
- Power Apps
- Power BI


---

## 📌 Features

### Employee Module
- Submit requests for leave, training, equipment, or access
- View own requests and statuses
- Role-based access via ASP.NET Identity

### Supervisor Module
- View pending requests
- Approve or reject requests
- Add comments
- Audit trail for accountability

### Automation Module (Power Automate)
- Notifies supervisors when new requests are submitted
- Waits for approval and updates request status
- Sends outcome notifications to employees
- Optional: Escalation and reminders

### Reporting Module (Power BI)
- Dashboard showing request volumes by department
- Requests by status (Pending, Approved, Rejected)
- Approval turnaround times
- Supervisor workload and compliance tracking

---

## 📈 Architecture & Flow

- **MVC Application** → System of record for requests and approvals  
- **SQL Server** → Stores structured data (Requests, Approvals, Users, AuditLogs)  
- **Power Automate** → Handles workflows, notifications, and approval automation  
- **Power Apps** → Mobile-friendly approval interface for supervisors  
- **Power BI** → Provides management insights and compliance dashboards  

> See [solution-architecture.md](docs/solution-architecture.md) and [data-flow.md](docs/data-flow.md) for full diagrams and explanations.

---

## 📌 Certificate Alignment

| Module | Microsoft Certification |
|--------|------------------------|
| Power Platform Fundamentals | PL-900 |
| Business Process Automation | PL-200 |
| Power BI Dashboards & Analytics | PL-300 |
| Power Platform Development & MVC Integration | PL-400 |
| Workflow Automation & RPA | PL-500 |
| End-to-End Solution Architecture | PL-600 |

---

## 📌 How to Use / Run

1. Clone repository  
2. Restore NuGet packages for MVC project  
3. Configure `appsettings.json` for SQL Server connection  
4. Apply EF Core migrations to create database  
5. Run the MVC application  
6. Power Automate flows and Power BI dashboards should be **linked to SQL Server**  

> Note: Power Automate flows and Power BI dashboards are **documented and linked**; see `/docs` folder.

---

## 📌 Documentation Links

- [Solution Architecture](docs/solution-architecture.md)  
- [Data Flow](docs/data-flow.md)  
- [Database Schema](docs/database-schema.md)  
- [Power Automate Flow](docs/power-automate-flow.md)  
- [Power BI Dashboards](docs/power-bi-dashboards.md)

---

## 👨‍💻 Why This Project is Valuable

- Full **end-to-end workflow automation**  
- Professional **MVC + Power Platform + Analytics** integration  
- Demonstrates **enterprise-grade development skills**  
- Shows **knowledge of Microsoft ecosystem** and **certifications alignment**  
- Ready for **Deviare or similar Microsoft-focused employers**  
