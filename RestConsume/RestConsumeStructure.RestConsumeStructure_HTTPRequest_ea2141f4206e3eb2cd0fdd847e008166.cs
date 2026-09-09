using OutSystems.Application.RestConsume;
using OutSystems.Application.RestConsume.Definitions;

namespace ssConectaProveedores;

// This class is meant to be used solely by the New Rest Consume implementation
// and its purpose is to provide the datatypes that should be involved in serializing and deserializing
// Rest Consume requests and response payloads.
// Methods ToStructure and FromStructure are used to convert between these intermediate types
// and the actual Structure runtime types (C# structs).
public partial class RestConsumeStructure_HTTPRequest_ea2141f4206e3eb2cd0fdd847e008166 {
// This class fields can be omitted whenever this type is not involved in serializing or deserializing.
// That's the case when a single array attribute is used, which causes the upper layer to use the array directly
// without the need for this class. When that happens, the class is never instantiated and methods ToStructure
// and FromStructure enabled an easy conversion to and from the underlying type.

    [JsonProperty("BaseURL")]
public string ssBaseURL;
[JsonProperty("URLPath")]
public string ssURLPath;
[JsonProperty("URLQueryParameters")]
public RestConsumeStructure_URLQueryParameter_f9be77c0ae9485d53ded05b1557548f9[] ssURLQueryParameters;
[JsonProperty("HTTPMethod")]
public string ssHTTPMethod;
[JsonProperty("Headers")]
public RestConsumeStructure_HTTPHeader_3cf3b984041595af1703070620d6367b[] ssHeaders;
[JsonProperty("RequestText")]
public string ssRequestText;
[JsonProperty("RequestBinary")]
public byte[] ssRequestBinary;

        
    public RestConsumeStructure_HTTPRequest_ea2141f4206e3eb2cd0fdd847e008166() { }

    public RestConsumeStructure_HTTPRequest_ea2141f4206e3eb2cd0fdd847e008166(ST_ea2141f4206e3eb2cd0fdd847e008166Structure structure) {
        this.ssBaseURL = 
structure.ssBaseURL == "" ? null : (string)structure.ssBaseURL;
this.ssURLPath = 
structure.ssURLPath == "" ? null : (string)structure.ssURLPath;
this.ssURLQueryParameters = 
structure.ssURLQueryParameters.Length == 0 ? null : structure.ssURLQueryParameters.ToArray(RestConsumeStructure_URLQueryParameter_f9be77c0ae9485d53ded05b1557548f9.FromStructure);
this.ssHTTPMethod = 
structure.ssHTTPMethod == "" ? null : (string)structure.ssHTTPMethod;
this.ssHeaders = 
structure.ssHeaders.Length == 0 ? null : structure.ssHeaders.ToArray(RestConsumeStructure_HTTPHeader_3cf3b984041595af1703070620d6367b.FromStructure);
this.ssRequestText = 
structure.ssRequestText == "" ? null : (string)structure.ssRequestText;
this.ssRequestBinary = 
structure.ssRequestBinary.Length == 0 ? null : structure.ssRequestBinary;

    }


    public static ST_ea2141f4206e3eb2cd0fdd847e008166Structure ToStructure(RestConsumeStructure_HTTPRequest_ea2141f4206e3eb2cd0fdd847e008166 structure) {
        var result = new ST_ea2141f4206e3eb2cd0fdd847e008166Structure ();

        if (structure is null) {
           return result;
        }

        result.ssBaseURL = 
structure.ssBaseURL == null ? "" : (string)structure.ssBaseURL;
result.ssURLPath = 
structure.ssURLPath == null ? "" : (string)structure.ssURLPath;
result.ssURLQueryParameters = 
RL_09d38ca4875adba9fe0bf71f298f1c3d.ToList(structure.ssURLQueryParameters, RestConsumeStructure_URLQueryParameter_f9be77c0ae9485d53ded05b1557548f9.ToStructure);
result.ssHTTPMethod = 
structure.ssHTTPMethod == null ? "" : (string)structure.ssHTTPMethod;
result.ssHeaders = 
RL_c06bca3d168b84039f4414ae52f271eb.ToList(structure.ssHeaders, RestConsumeStructure_HTTPHeader_3cf3b984041595af1703070620d6367b.ToStructure);
result.ssRequestText = 
structure.ssRequestText == null ? "" : (string)structure.ssRequestText;
result.ssRequestBinary = 
structure.ssRequestBinary == null ? new byte[] {} : structure.ssRequestBinary;


        return result;
    }

    public static RestConsumeStructure_HTTPRequest_ea2141f4206e3eb2cd0fdd847e008166 FromStructure(ST_ea2141f4206e3eb2cd0fdd847e008166Structure structure) {
        return new RestConsumeStructure_HTTPRequest_ea2141f4206e3eb2cd0fdd847e008166(structure);

    } 
}
