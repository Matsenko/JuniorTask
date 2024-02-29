Project Setup
This project requires a connection to a SQL Server database. Follow the instructions below to set up the project:

Database Connection
Open the appsettings.json file located in the project root directory.

Locate the ConnectionStrings section in the file.

Modify the DefaultConnection value with your SQL Server connection string. Example:
"ConnectionStrings": {
    "DefaultConnection": "Data Source=YOUR_SERVER_NAME;Initial Catalog=YOUR_DATABASE_NAME;User ID=YOUR_USERNAME;Password=YOUR_PASSWORD;"
}
Replace YOUR_SERVER_NAME, YOUR_DATABASE_NAME, YOUR_USERNAME, and YOUR_PASSWORD with your actual database server name, database name, username, and password respectively.
