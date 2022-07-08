/*
  'req' variable has:
    'Headers' - object with request headers
    'Payload' - object with request body data
    'Env' - object with environment variables

  'res' variable has:
    'Send(text, status)' - function to return text response. Status code defaults to 200
    'Json(obj, status)' - function to return JSON response. Status code defaults to 200
  
  If an error is thrown, a response with code 500 will be returned.
*/

using System.Threading.Tasks;
using Newtonsoft.Json;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

public async Task<RuntimeResponse> Main(RuntimeRequest req, RuntimeResponse res)
{
    var randomWordURL = "https://random-word-api.herokuapp.com/word?number=3";
    var httpClient = new HttpClient();
    var randomWordResponse = await httpClient.GetAsync(randomWordURL);
    var randomWordResponseString = await randomWordResponse.Content.ReadAsStringAsync();
    var randomWordList = JsonConvert.DeserializeObject<List<string>>(randomWordResponseString);

    var randomWord = randomWordList[0];

    var dictionaryURL = "https://api.dictionaryapi.dev/api/v2/entries/en/" + randomWord;
    var dictionaryResponse = await httpClient.GetAsync(dictionaryURL);
    var dictionaryResponseString = await dictionaryResponse.Content.ReadAsStringAsync();
    var dictionaryList = JsonConvert.DeserializeObject<List<DictionaryAPIResponse>>(dictionaryResponseString);

    var meaning = dictionaryList[0].Meanings[0].Definitions[0].Definition;

    //Console.WriteLine(randomWordList[0] + " means " + meaning);

    TwilioClient.Init(req.Env["TwilioAccountSID"], req.Env["TwilioAuthToken"]);

    var message = MessageResource.Create(
        to: new Twilio.Types.PhoneNumber("+918439056262"),
        from: new Twilio.Types.PhoneNumber(req.Env["TwilioPhoneNumber"]),
        body: "Random Word Of The Day: \n" + randomWordList[0] + " means " + meaning
    );

    return res.Json(new () 
    {
      { "randomWord", randomWord },
      { "meaning", meaning },
      { "twilioResponse", message }
    });
}