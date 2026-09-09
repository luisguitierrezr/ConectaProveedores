using OutSystems.Application.RestConsume;
using OutSystems.Application.RestConsume.Definitions;

namespace ssConectaProveedores;

// This class is meant to be used solely by the New Rest Consume implementation
// and its purpose is to provide the datatypes that should be involved in serializing and deserializing
// Rest Consume requests and response payloads.
// Methods ToStructure and FromStructure are used to convert between these intermediate types
// and the actual Structure runtime types (C# structs).
public partial class RestConsumeStructure_HTTPHeader_3cf3b984041595af1703070620d6367b {
// This class fields can be omitted whenever this type is not involved in serializing or deserializing.
// That's the case when a single array attribute is used, which causes the upper layer to use the array directly
// without the need for this class. When that happens, the class is never instantiated and methods ToStructure
// and FromStructure enabled an easy conversion to and from the underlying type.

    [JsonProperty("Name")]
public string ssName;
[JsonProperty("Value")]
public string ssValue;

        
    public RestConsumeStructure_HTTPHeader_3cf3b984041595af1703070620d6367b() { }

    public RestConsumeStructure_HTTPHeader_3cf3b984041595af1703070620d6367b(ST_3cf3b984041595af1703070620d6367bStructure structure) {
        this.ssName = 
structure.ssName == "" ? null : (string)structure.ssName;
this.ssValue = 
structure.ssValue == "" ? null : (string)structure.ssValue;

    }


    public static ST_3cf3b984041595af1703070620d6367bStructure ToStructure(RestConsumeStructure_HTTPHeader_3cf3b984041595af1703070620d6367b structure) {
        var result = new ST_3cf3b984041595af1703070620d6367bStructure ();

        if (structure is null) {
           return result;
        }

        result.ssName = 
structure.ssName == null ? "" : (string)structure.ssName;
result.ssValue = 
structure.ssValue == null ? "" : (string)structure.ssValue;


        return result;
    }

    public static RestConsumeStructure_HTTPHeader_3cf3b984041595af1703070620d6367b FromStructure(ST_3cf3b984041595af1703070620d6367bStructure structure) {
        return new RestConsumeStructure_HTTPHeader_3cf3b984041595af1703070620d6367b(structure);

    } 
}
