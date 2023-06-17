# Simple-Notes-Application
 
This is a Simple Note application to store your ideias in the fatest way possible. It was made using C# and WindowsForms integrated with a Sql Server database. The scripts to create the table in the database and run the app are in this [folder](https://github.com/AaronCrvl/Simple-Notes-Application/tree/main/WindowsFormsApp2/Data/SQL).

# !__Attention 
You need to create and configure the app.settings inside de console app and windows form app to get it working, for example:

```html
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.6.1" />
    </startup>
  <connectionStrings>
    <add name="<NAME>" connectionString="connection timeout=600;Persist Security Info=True;Initial Catalog=<DATABASE>;Data Source=(LocalDb)\<NAME>" />
      (or)
    <add name="<NAME>" connectionString="connection timeout=600;Persist Security Info=True;Initial Catalog=<DATABASE>;Data Source=<NAME>" />
  </connectionStrings>
</configuration>

```

# Prints
![Tela 1](https://github.com/AaronCrvl/Simple-Notes-Application/blob/main/WindowsFormsApp2/img/App.jpg?raw=true)

## Autor
- [@AaronCrvl](https://www.github.com/AaronCrvl)
