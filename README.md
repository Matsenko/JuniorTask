# Project Setup

This project requires a connection to a SQL Server database. Follow the instructions below to set up the project:

## Database Connection

1. Open the `appsettings.json` file located in the project root directory.

2. Locate the `ConnectionStrings` section in the file.

3. Modify the `DefaultConnection` value with your SQL Server connection string. Example:

   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Data Source=YOUR_SERVER_NAME;Initial Catalog=YOUR_DATABASE_NAME;User ID=YOUR_USERNAME;Password=YOUR_PASSWORD;"
   }
