# RecordShop Frontend (Blazor)

This project provides a minimal frontend for the [RecordShop backend web API project](https://github.com/rsdc2/cs-record-shop) using the [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor) framework.

## Before running the frontend project...

You need to have the backend project host running. Follow the instructions at   [RecordShop backend web API project](https://github.com/rsdc2/cs-record-shop) to do this.

## Run and test in Visual Studio (2022)

Load `RecordShop.sln` in Visual Studio, from where the project can be run and tested using Visual Studio's user interface.

## Running from the commandline

1. Clone or download the repository.
2. `cd` into the repo folder:

```
cd cs-record-shop-frontend
```

3. `cd` into the `RecordShop` project.

```
cd RecordShop_FE/RecordShop_FE
```

4. Run the project:

```
dotnet run
```

This will build and run the project. Among the messages that appear in the console will be one providing the address on which the server is listening, e.g.:

```
info:   Microsoft.Hosting.Lifetime[14]
        Now listening on: http://localhost:<PORT> 

```

where `<PORT>` stands for a four digit port number, that will be needed for subsequent steps.

### Accessing in a browser 

5. In a browser, navigate to:

```
http://localhost:<PORT>/Albums
```

## Acknowledgements

### Context

The project was written as a learning exercise as part of the [Northcoders](https://northcoders.com/) software development bootcamp.

### Dependencies and licenses

The project has no third-party dependencies beyond those required for Blazor.