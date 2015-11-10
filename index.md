---
layout: home
title: Bill McRoberts
home: true
---

## Slack Sandbox

Xamarin Forms &bull; Custom Rendering &bull; Xamarin.Auth &bull; Refit

Beginning sandbox repository for building out a Xamarin Forms implementation for Slack. 

<img src="images/slack.png" width="20%">

My work includes 4 years development on the GroupMe (http://groupme.com) group chat app from Microsoft. Hence, I've always been interested in taking a closer look at Slack (http://slack.com), a team-based communication app with extension capabilities. We can divide the building blocks for a Slack app into the following categories - mapped to the Xamarin component/technology mainly responsible:

| OAuth Authenticaion | Xamarin.Auth ([https://components.xamarin.com/view/xamarin.auth](https://components.xamarin.com/view/xamarin.auth "Xamarin.Auth")) |
| Web API | Refit ([http://paulcbetts.github.io/refit/](http://paulcbetts.github.io/refit/ "Refit")) |
| Real Time Messaging API | Realtime.Messaging.Xamarin ([https://github.com/NVentimiglia/Realtime.Messaging.Xamarin](https://github.com/NVentimiglia/Realtime.Messaging.Xamarin "Realtime.Messaging.Xamarin")) | 
| UI | Xamarin.Forms ([https://xamarin.com/forms](https://xamarin.com/forms "Xamarin.Forms")) |

### Setup
1. Go to [http://slack.com](http://slack.com "Slack") and create your Slack account.
1. Go to [https://api.slack.com/](https://api.slack.com/ "Slack API") and:
  * Register as a Developer
  * Create a Slack app
1. In Visual Studio, start with a new Blank App (Xamarin.Forms.Portable), and remove the Windows Phone platform project.

### OAuth Authentication
We'll use Xamarin.Auth for our OAuth authentication needs. Because we need platform specific UI flows for authentication, we'll create a custom page renderer for our needs.

Start with the class OAuthSettings to hold our OAuth credentials.


```csharp
    public class OAuthSettings
    {
        public OAuthSettings(
            string clientId,
            string clientSecret,
            string scope,
            string authorizeUrl,
            string redirectUrl,
            string accessTokenUrl)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            Scope = scope;
            AuthorizeUrl = authorizeUrl;
            RedirectUrl = redirectUrl;
            AccessTokenUrl = accessTokenUrl;
        }

        public string ClientId { get; private set; }
        public string ClientSecret { get; private set; }
        public string Scope { get; private set; }
        public string AuthorizeUrl { get; private set; }
        public string RedirectUrl { get; private set; }
        public string AccessTokenUrl { get; private set; }
    }
```


### Web API

### Real Time Messaging API

### UI










