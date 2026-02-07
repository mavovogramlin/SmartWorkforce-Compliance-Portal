# Power Automate Flow: Request Approval Notification

## Overview
This flow automates notifications and approvals for employee requests submitted via the MVC application. It ensures timely communication between employees and supervisors.

## Trigger
- When a new row is added or modified in `Requests` table (Status = Pending)

## Actions
1. Get request details from SQL Server
2. Notify supervisor via Email / Teams
3. Wait for supervisor approval (Approve / Reject)
4. Update request status in SQL Server
5. Notify employee of decision

## Optional Enhancements
- Escalation for pending approvals
- Logging to `AuditLogs` table
- Mobile approval via Teams or Power Apps
