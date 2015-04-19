# AzureAD-WebAPI-SPOnline

In this sample, a Windows console Application calls a Web API secured by Azure AD and the API calls SharePoint Online on behalf the logged in user. This scenario is useful for situations where you need a protected API Proxy to interact with SharePoint Online using User's credentials.
The application uses the Active Directory Authentication Library (ADAL) to get a token from Azure AD using the OAuth 2.0 client credential flow, where the client credential is a password.

For more information about how the protocols work in this scenario and other scenarios, see [Authentication Scenarios for Azure AD.](http://go.microsoft.com/fwlink/?LinkId=394414)

## Console Application

### NuGet Packages
To create a solution from scratch, Open Visual Studio and create a new Windows Console Application Solution.

Then click on **Tools** menu, **NuGet Package Manager** and in **Package Manager Console** item.

Install bellow packages:

Install-Package Microsoft.Net.Http
Install-Package Microsoft.IdentityModel.Clients.ActiveDirectory -Version 2.15.204151539

![Install Nuget Packages](https://cloud.githubusercontent.com/assets/12012898/7217636/cb27b382-e60f-11e4-90ad-b3c6338d3b1d.png)



## Web API

To create this project, Create a New ASP.NET Web Application and then choose Empty Template. We're going to create everything from the ground.

[New Project](https://cloud.githubusercontent.com/assets/12012898/7217678/a7caa63a-e612-11e4-9729-8d3b7c4e9f32.png)

[Choose Template](https://cloud.githubusercontent.com/assets/12012898/7217677/a7c60b16-e612-11e4-8603-b5cfaf261fea.png)

### NuGet Packages
To create a solution from scratch, Open Visual Studio and create a new Windows Console Application Solution.

Then click on **Tools** menu, **NuGet Package Manager** and in **Package Manager Console** item.

Install bellow packages:

Install-Package Microsoft.AspNet.WebApi
Install-Package Microsoft.AspNet.WebApi.Owin
Install-Package Microsoft.Owin.Host.SystemWeb
Install-Package Microsoft.Owin.Security.ActiveDirectory
Install-Package Microsoft.IdentityModel.Clients.ActiveDirectory -Version 2.15.204151539

![Install Nuget Packages](https://cloud.githubusercontent.com/assets/12012898/7217682/1323c2c2-e613-11e4-9b83-fec0f80fdad9.png)


## How to run this sample

To run this sample you will need:
- Visual Studio 2013
- An Internet connection
- An Azure subscription (a free trial is sufficient)

Every Azure subscription has an associated Azure Active Directory tenant.  If you don't already have an Azure subscription, you can get a free subscription by signing up at [http://wwww.windowsazure.com](http://www.windowsazure.com).  All of the Azure AD features used by this sample are available free of charge.

### Step 1:  Clone or download this repository

From your shell or command line:

`git clone https://github.com/RARomano/AzureAD-WebAPI-SPOnline.git`