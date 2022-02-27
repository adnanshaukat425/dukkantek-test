# Inventory management system

This project consists of 3 API as below.<br>
1. [/Product/GetCount?statusId=1](https://github.com/adnanshaukat425/dukkantek-test)
2. [/Product/ChangeStatus?productId=1&statusId=1](https://github.com/adnanshaukat425/dukkantek-test)
3. [/Product/Sell?productId=1](https://github.com/adnanshaukat425/dukkantek-test)

# Seting up the project, follow the steps to setup the project.

1. Setup the connection string from the appsettings.json file.
2. Run the migration command 'update-database' in package manager console, this will create the database in SQL Server.
3. From the appsettings.json file, setup the seed data, status and catagories. You can also set default products if you want to.
4. If you want to run the seed data set the 'Seed' to true and run the project. And again set it to false to avoid running seed data everytime.
5. Run the project.
