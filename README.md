Smart Printing House Management System 🖨️
An advanced, event-driven desktop application tailored for printing businesses. Built with C# (.NET) using a 3-Tier Architecture, this system automates the entire lifecycle of printing orders—from reception to delivery—integrated with WhatsApp for real-time notifications.

🚀 Key Features
1. Smart Workflow & Task Management
Automated Task Queue: Upon login, an interactive dashboard instantly populates with "Incomplete Orders," prioritizing tasks based on deadlines.

Time Tracking: Real-time calculation of remaining time for each order, helping operators manage priorities efficiently.

Order Status Lifecycle: Full tracking from "Pending" -> "In Progress" -> "Completed," with strict validation rules.

2. WhatsApp Integration & Notifications 📲
Customer Updates: The system automatically triggers WhatsApp messages to clients when:

An order starts processing ("Work in Progress").

An order is finished ("Completed").

Admin Alerts: Critical alerts (e.g., Low Stock, Overdue Debts) are sent directly to the manager's WhatsApp.

3. Advanced Digital Invoicing (Text-to-Image) 🧾
Dynamic Generation: Utilizes System.Drawing to convert invoice data (text) into a secure image format instantly.

Smart Delivery: The generated invoice image (containing details + QR code for Instagram) is automatically saved to the local desktop and sent to the client via WhatsApp via a single click.

4. Inventory & Logic-Based Stock Control 📦
Auto-Deduction Logic: Every print job automatically deducts raw materials from the inventory based on configured formulas.

Low Stock Warnings: Proactive popup alerts + Admin WhatsApp messages when materials hit a specific threshold (e.g., "Paper stock critical").

5. Financial & Debt Management
Debt Tracker: Dedicated module for tracking client debts with monthly due-date reminders.

Error Logging: Integrated with Windows Event Viewer to log runtime errors and bugs for simpler debugging and maintenance.

🛠️ Technical Architecture & Stack
I designed this project to simulate enterprise-level software standards:

Architecture: 3-Tier Architecture (Presentation Layer, Business Logic Layer, Data Access Layer) ensuring separation of concerns.

Design Patterns: Applied Event-Driven Programming and Singleton Pattern for resource management.

Database: SQL Server (Currently upgrading to T-SQL Stored Procedures for performance).

Persistence: User settings (Themes/Colors) are serialized and saved locally via Windows Registry/Settings.

File Handling: Automated local file management for archiving invoices.

Language: C# (WinForms).

📸 Project Screenshots
1. Main Dashboard & Navigation
The central hub for managing modules, featuring a clear sidebar and quick access icons.

2. Order Management Grid
A comprehensive view of all orders with filtering options and quick-action buttons.

3. Workflow Context Menu
Right-click functionality to execute orders, send WhatsApp updates, or cancel requests instantly.

4. Smart Digital Invoice
Auto-generated, high-quality invoice image with embedded QR code, ready for WhatsApp sharing.

5. Automated Local Archiving
System automatically creates and organizes invoice image files in a dedicated local folder for offline record-keeping.

6. Inventory & Stock Alerts
Intelligent logic that warns the user (and Admin via WhatsApp) when material stock hits zero.

7. Time Estimation Logic
System calculates and displays precise remaining time for order completion.

8. Security & Access Logs
Detailed audit logs tracking user logins, permissions, and access times for security.

🔮 Future Roadmap
[ ] Migrating raw SQL queries to T-SQL Stored Procedures.

[ ] Adding Localization support (Dynamic Arabic/English UI switching).
