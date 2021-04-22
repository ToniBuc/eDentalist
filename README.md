# eDentalist
eDentalist is an ASP.NET Core desktop &amp; mobile application for operating a private dental office. 
It includes a .NET Core API, Windows Forms app meant for administrative purposes and a Xamarin Forms mobile app that can be used by both staff and patients, with certain functionalities differing based on user type.

## Installation & Use

1. docker-compose build
2. docker-compose up
3. Within the project itself, use WinUI, UWP or both as startup projects to use the app

## Login Credentials

### Administrator:
* Username: admin
* Password: Password1

### Dentist:
* Username: dentist
* Password: Password1

### Patient (mobile only):
* Username: patient
* Password: Password1

## Stripe

Patients have the ability to pay for their bills through the mobile app. Stripe was used to implement this functionality, which offers cards meant for testing. They can be found at the following link: https://stripe.com/docs/testing
