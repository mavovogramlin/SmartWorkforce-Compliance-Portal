# Power BI Dashboards: Smart Workforce Compliance & Automation Portal

## 1. Overview
The Power BI dashboards provide **real-time insights** into employee requests, approvals, and compliance status. They complement the MVC application and Power Automate flows, enabling management to **monitor trends, bottlenecks, and performance**.

These dashboards showcase:

- Request volumes by department and employee
- Average approval turnaround time
- Compliance risk indicators
- Status of pending, approved, and rejected requests

---

## 2. Data Sources
- **SQL Server** database (Requests, Approvals, Users, AuditLogs)
- Optional: Exported Excel from Power Automate for historical snapshots

---

## 3. Key Metrics / Visuals

| Metric | Visual Type | Description |
|--------|------------|-------------|
| Total Requests by Department | Bar chart | Shows how many requests each department submitted |
| Requests by Status | Donut / Pie chart | Displays Pending, Approved, Rejected counts |
| Approval Time Analysis | Line chart | Tracks average approval time over days/weeks |
| Supervisor Workload | Table / Matrix | Lists supervisors with number of pending requests |
| Compliance Documents Expiring | Clustered Bar | Highlights employees with documents nearing expiry |

---

## 4. Dashboard Layout Recommendation
1. **Top row:** Total Requests (Card), Requests by Status (Donut)  
2. **Middle row:** Approval Time Trends (Line chart), Supervisor Workload (Matrix)  
3. **Bottom row:** Compliance Expiry Overview (Bar chart)  

> Layout keeps **critical info at a glance** for managers.

---

## 5. Filters and Slicers
- Department  
- Request Type (Leave, Access, Training, Equipment)  
- Date Range (CreatedDate)  
- Supervisor  

> Slicers make dashboards **interactive and drillable**.

---

## 6. Refresh & Integration
- Connect directly to **SQL Server** for live updates  
- Schedule refresh (e.g., daily) for automated reporting  
- Can embed dashboard in **Teams** or **Power Apps** for mobile-friendly access  

---

## 7. Benefits
- Improves decision-making speed and accuracy  
- Identifies bottlenecks in approval workflows  
- Tracks compliance document expiry to prevent violations  
- Demonstrates **PL-300 skills**: data analysis, visualization, and reporting  
- Completes the full stack of **MVC → Power Automate → Power BI**  

---

## 8. Optional Enhancements
- Conditional formatting to highlight overdue requests  
- Drillthrough to employee request details  
- KPI cards for approval rates  
- Alerts via Power Automate for thresholds (e.g., >5 pending requests per supervisor)
