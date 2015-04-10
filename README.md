
#Introduction
App360ID SDK helps you build engaging social apps and get more installs

#Getting started with Demo project

Firstly, clone or download this repository to your machine.

 - `git clone https://github.com/app360/app360id-wp-sdk.git`
 - or, download from https://github.com/app360/app360id-wp-sdk

>The App360IDSDK supports Windows Phone 8 and 8.1 silverlight project.

#Add App360 SDK to your project
There are two ways to add App360SDK to your project.
##Using [Nuget](https://www.nuget.org/packages/App360SDK) (recommendation)
Go to Tools -> Nuget Package Manager -> Package Manager Console

`Install-Package Install-Package App360IDSDK -Pre`

##Manual

1. Download project demo from https://github.com/app360/app360id-wp-sdk
2. Add  App360IDSDK.dll file (RightClick to your project -> Add -> Reference)
	   from [/release](https://github.com/app360/app360-wp-sdk/tree/master/Release) 
	
3. Add a new file app360.xml into your project with content below:
	```xml
	<?xml version="1.0" encoding="utf-8" ?>
	<config>
	  <redirect_uri>http://example.com</redirect_uri>
	</config>
	```
# Intergrate your app with App360SDK for windows phone


## Initialize
The first of all, call Initialize with Application ID:
```
Login.InitializeWithAppId("<application_id>");
```

##Login

`App360IDSDK.Login.LoginWithScope("<scope>",<shouldDisplayUI>);`

  Login with specify scope. This method will login silently if there's valid access token. If not, it will display form for user to login if `shouldDisplayUI` = true
  
- scope: Scope (permission) want to access
- shouldDisplayUI: Should SDK show form for user login.

### Getting Result
```
public MainPage()
{
	InitializeComponent();
	Login.InitializeWithAppId("<application_id>");
	\\ register event
	Login.OnLogin += Login_OnLogin;
}

void Login_OnLogin(UserInfo sender, LoginEventArgs args)
{
	if (args.IsSucess)
	{
		MessageBox.Show(sender.DisplayName);
	}
	else
	{
		MessageBox.Show(args.Error);
	}

}
```

##Logout
To logout user:

 `Login.LogOut();`

#Release Notes

##Version 1.0.0-alpha
**Release Date:** 9 April 2015

- Initial version
 

# Knows issues
There's no known issues for now
# FAQ
**What is a application id and client key?**

They are a pair of key, used to authorize your app (game) with SDK's server.

**How can i get my application id and client key?**

 - Goto https://developers.app360.vn
 - Login if you already have an account or register a new one
 - Open your application in App360 dashboard, select Information tab
 - All key you need will be there
 
 
# Support
Please contact [us](mailto:support@app360.vn) for general inquiries.
#For a technical issue
In case you have a technical issue, you can reach our technical support team. Please provide the following information when you reach out, it'll allow us to help you much more quickly.

 - The steps to reproduce the problem. 
 - If possible, some pieces of code, or even a project.
>For more information, please go to https://developers.app360.vn.