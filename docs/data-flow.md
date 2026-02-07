# Data Flow Documentation
## Smart Workforce Compliance & Automation Portal

---

## 1. Overview
This document describes how data flows through the Smart Workforce Compliance & Automation Portal, from user interaction to automation and reporting.

The data flow ensures that the ASP.NET Core MVC application remains the system of record, while Microsoft Power Platform components enhance workflow efficiency and analytics.

---

## 2. Actors
- Employee
- Supervisor
- Administrator / HR
- Power Automate
- Power Apps
- Power BI

---

## 3. Request Submission Flow

1. An employee logs into the MVC application
2. The employee submits a request (e.g. Leave, Access, Training)
3. The MVC controller validates the request data
4. The request is persisted in the SQL Server database
5. An audit log entry is created

**Result:** Request status is set to `Pending`

---

## 4. Automation Trigger Flow

1. A new request record is created in SQL Server
2. Power Automate flow is triggered
3. Supervisor receives a notification (Email or Teams)
4. Request status remains `Pending` until approval

---

## 5. Approval Flow

1. Supervisor opens the Power Apps Approval App
2. Pending requests are retrieved from SQL Server
3. Supervisor approves or rejects the request
4. Decision is saved to the Approvals table
5. Request status is updated accordingly
6. Audit log is updated with approval action

---

## 6. Notification Flow

1. Power Automate detects status change
2. Employee receives notification of approval or rejection
3. Administrator is optionally notified for record purposes

---

## 7. Reporting & Analytics Flow

1. Power BI connects securely to SQL Server
2. Request and approval data is retrieved
3. Data is transformed for reporting
4. Dashboards are refreshed on schedule
5. Management views insights and trends

---

## 8. Error Handling & Validation Flow

- MVC application performs server-side validation
- Invalid requests are rejected before persistence
- Failed automation flows are logged
- Audit logs support troubleshooting and traceability

---

## 9. Data Governance Principles

- MVC application remains the authoritative source
- Power Platform components operate with least privilege
- Sensitive data is not duplicated unnecessarily
- All critical actions are traceable through audit logs

---

## 10. Summary
The defined data flow ensures reliable, secure, and auditable movement of data across system components while enabling automation and analytics without compromising data integrity.
