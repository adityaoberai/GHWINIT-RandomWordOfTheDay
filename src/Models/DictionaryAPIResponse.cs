using Newtonsoft.Json;

public class WordDefinition
{
    [JsonProperty("definition")]
    public string Definition;

    [JsonProperty("example")]
    public string Example;

    [JsonProperty("synonyms")]
    public List<string> Synonyms;

    [JsonProperty("antonyms")]
    public List<string> Antonyms;
}

public class Meaning
{
    [JsonProperty("partOfSpeech")]
    public string PartOfSpeech;

    [JsonProperty("definitions")]
    public List<WordDefinition> Definitions;
}

public class Phonetic
{
    [JsonProperty("text")]
    public string Text;

    [JsonProperty("audio")]
    public string Audio;
}

public class DictionaryAPIResponse
{
    [JsonProperty("word")]
    public string Word;

    [JsonProperty("phonetic")]
    public string Phonetic;

    [JsonProperty("phonetics")]
    public List<Phonetic> Phonetics;

    [JsonProperty("origin")]
    public string Origin;

    [JsonProperty("meanings")]
    public List<Meaning> Meanings;
}