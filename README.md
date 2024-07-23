# Welcome to Abby

## Your Task

As the new .NET Expert, we need your expertise to upgrade our Legacy Application to a modern .NET 8 Application.

We have an idea that we would like a .NET MVC app. We hear that Blazor is the latest and greatest and that it would be the better path forward.

# Part 1 - Legacy Code Review and Credential Updates

Either way, review our [Legacy](./Legacy/) Codebase and provide estimate for the development process you'll be undertaking.

Here's our QuickStart Dev Guide to help examine the codebase before beginning your new development:

- Database Connection String

- SendGrid Credentials

    SecretKey

    Abby.Utility - EmailSender.cs

- Update Admin credentials in Abby.DataAccess/DbInitializer class

- Facebook API

    AppId
    
    Update Sender Email Account in AppSecret in AbbyWeb/Program.cs


# Part 2a Migrate to Blazor (Recommended)

`dotnet new blazor -n Abby --use-program-main --auth Individual -uld`

Help for setting up a Blazor with API Controllers - https://stackoverflow.com/questions/70583469/host-web-api-in-blazor-server-application

# Part 2b Migrate to MVC

`dotnet new mvc -n Abby --use-program-main --auth Individual -uld`

# Part 3 Abby Library Migration

Add the Library Projects Abby.Utility, Abby.Models, and Abby.DataAccess to your new Project's codebase and update your .csproj files to net8.0

# Part 4 Facelift

Add some custom branding to our Homepage. As an internal business tool, we haven't worried much about our presentation.

Show us something cool, yet professional.

# Part 5 Email API

https://app.sendgrid.com/guide/integrate/

# Testing

Test the app locally, ensure that all existing routes and pages are accessible. 

Login as an Admin, create Categories, FoodTypes, MenuItems

Login as a Customer, create Orders

Login as an Admin, view and process Orders

# Deployment

Modify the Server in your Connection String to "" and Deploy to Azure


# Stretch Goal 

## In Addition to the Stripe API, Enable Bitcoin Payments

We've set up a Bitcoin Wallet. As a proof of concept, generate QR Codes at checkout for customers to pay their totals to.
Orders should be saved in the database
Our bitcoin address is ""

