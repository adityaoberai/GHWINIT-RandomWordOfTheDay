# Random Word Of TheDay

Welcome to the documentation of this function 👋 We strongly recommend keeping this file in sync with your function's logic to make sure anyone can easily understand your function in the future. If you don't need documentation, you can remove this file.

## 🤖 Documentation

Sends an SMS to a person with a random word and its meaning

<!-- Update with your description, for example 'Create Stripe payment and return payment URL' -->

_Example input:_

This function expects no input

<!-- If input is expected, add example -->

_Example output:_

<!-- Update with your expected output -->

```json
{
	"randomWord": "perambulating",
	"meaning": "To walk about, roam or stroll.",
	"twilioResponse": {
		"Body": "Random Word Of The Day: \nperambulating means To walk about, roam or stroll.",
		"NumSegments": "1",
		"Direction": {},
		"From": {},
		"To": "\u002B919876543210",
		"DateUpdated": "2022-07-08T07:59:31+00:00",
		"Price": null,
		"ErrorMessage": null,
		"Uri": "/2010-04-01/Accounts/ACe29c144db149972dbf5427bbdd0c16dd/Messages/SM4cc2cf763c1e48668598bd0797093b40.json",
		"AccountSid": "ACe29c144db149972dbf5427bbdd0c16dd",
		"NumMedia": "0",
		"Status": {},
		"MessagingServiceSid": null,
		"Sid": "SM4cc2cf763c1e48668598bd0797093b40",
		"DateSent": null,
		"DateCreated": "2022-07-08T07:59:31+00:00",
		"ErrorCode": null,
		"PriceUnit": "USD",
		"ApiVersion": "2010-04-01",
		"SubresourceUris": {
			"media": "/2010-04-01/Accounts/ACe29c144db149972dbf5427bbdd0c16dd/Messages/SM4cc2cf763c1e48668598bd0797093b40/Media.json"
		}
	}
}
```

## 📝 Environment Variables

Go to Settings tab of your Cloud Function and add the following environment variables:

- `TwilioAccountSID`: Twilio Account SID
- `TwilioAuthToken`: Twilio Auth Token
- `TwilioPhoneNumber`: Twilio Phone Number to send the SMS from
- `ToPhoneNumber`: Phone Number to send the SMS to

> ℹ️ _The Twilio Account SID and Auth Token can be obtained from your Twilio console. You can purchase a Twilio phone number using [this guide](https://support.twilio.com/hc/en-us/articles/223135247-How-to-Search-for-and-Buy-a-Twilio-Phone-Number-from-Console)._

## 🚀 Deployment

There are two ways of deploying the Appwrite function, both having the same results, but each using a different process. We highly recommend using CLI deployment to achieve the best experience.

### Using CLI

Make sure you have [Appwrite CLI](https://appwrite.io/docs/command-line#installation) installed, and you have successfully logged into your Appwrite server. To make sure Appwrite CLI is ready, you can use the command `appwrite client --debug` and it should respond with green text `✓ Success`.

Make sure you are in the same folder as your `appwrite.json` file and run `appwrite deploy function` to deploy your function. You will be prompted to select which functions you want to deploy.

### Manual using tar.gz

Manual deployment has no requirements and uses Appwrite Console to deploy the tag. First, enter the folder of your function. Then, create a tarball of the whole folder and gzip it. After creating `.tar.gz` file, visit Appwrite Console, click on the `Deploy Tag` button and switch to the `Manual` tab. There, set the `entrypoint` to `src/Index.cs`, and upload the file we just generated.
