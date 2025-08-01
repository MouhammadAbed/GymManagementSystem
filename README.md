Features

- Member registration and full profile management
- Subscription management with automatic status tracking (active/expired)
- Trainer assignment and tracking
- Real-time statistics and reports
- Stored procedures for database operations
- Data validation and input checks
- Role-based access for users (admin, staff)
- Automatically deactivates expired subscriptions via scheduled SQL tasks
- The app includes `.bat` and `.sql` files to automate database tasks (e.g., deactivating expired subscriptions) through Windows Task Scheduler. The SQL is triggered twice a day for real-time subscription status updates.

Database
 
- Includes complete SQL Server scripts (tables, views, stored procedures)
- View: `SubscribersFullInfo` to display full member data with proper name formatting
- Procedures: Handle insert/update/delete securely with validation logic

Tech Stack

- Frontend: Windows Forms (C#)
- Backend: C# (.NET Framework), ADO.NET
- Database: SQL Server
- Architecture: 3-Tier (Presentation, Business Logic, Data Access)

Author

Developed by **Mhmad Abed Sater**
