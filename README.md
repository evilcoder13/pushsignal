# pushsignal
Push notification for android using one signal and xamarin

# Programming Language: C#
There're 2 projects in this package as per described below

# Xamarin-PushSignal:
This project is Android app built in Xamarin, which allow you register for the onesignal notification. It would works headless, however, I'd prefer something I can control so I made it as single view Xamarin project.

# DotnetCore-API-PushSignal:
This project is dotnet core project, which allow you to quickly send message to the Android phone (all registered) by request to http://localhost:5000/SendAlarm?msg=whatever you want to send

# Setup:
All this project setup is followed guide at https://documentation.onesignal.com/docs/xamarin-sdk-setup

Zero, you should register your OneSignal app at https://onesignal.com/.

First, for Xamarin one, you should open file at pushsignal\Xamarin-PushSignal\PushSignal\MainActivity.cs, then replace the string inside StartInit by the app-id of your One Signal.

Sencond, for API one, you should open file at pushsignal\DotnetCore-API-PushSignal\Controllers\SendAlarm.cs, then replace the string in authorization with your onesignal API key, app_id with your onesignal App ID.

# Deploy:
You can deploy API on Linux, Windows, Mac, Docker or Wherever you want as long as it supports dotnetcore.

Xamarin Droid is to deployed to Android phone, for sure.

# Term of use:
As you wish :)

# Contribute:
Any contribution is welcome. Just drop me few line, I'll check & merge when possible.

# Donation:
If you're happy, you can always make me happier by contribute above or by some beers at: http://paypal.me/evilcoder13