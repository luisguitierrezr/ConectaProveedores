using OutSystems.Application.RestConsume;
using OutSystems.Application.RestConsume.Definitions;

namespace ssConectaProveedores;

// This class is meant to be used solely by the New Rest Consume implementation
// and its purpose is to provide the datatypes that should be involved in serializing and deserializing
// Rest Consume requests and response payloads.
// Methods ToStructure and FromStructure are used to convert between these intermediate types
// and the actual Structure runtime types (C# structs).
public partial class RestConsumeStructure_users2_06cbd1286b150e2e79c91e9d1ed3d811 {
// This class fields can be omitted whenever this type is not involved in serializing or deserializing.
// That's the case when a single array attribute is used, which causes the upper layer to use the array directly
// without the need for this class. When that happens, the class is never instantiated and methods ToStructure
// and FromStructure enabled an easy conversion to and from the underlying type.

    [JsonProperty("liststring")]
public string ssliststring;
[JsonProperty("categoryclass")]
public string sscategoryclass;

        
    public RestConsumeStructure_users2_06cbd1286b150e2e79c91e9d1ed3d811() { }

    public RestConsumeStructure_users2_06cbd1286b150e2e79c91e9d1ed3d811(ST_06cbd1286b150e2e79c91e9d1ed3d811Structure structure) {
        this.ssliststring = 
structure.ssliststring == "" ? null : (string)structure.ssliststring;
this.sscategoryclass = 
(string)structure.sscategoryclass;

    }


    public static ST_06cbd1286b150e2e79c91e9d1ed3d811Structure ToStructure(RestConsumeStructure_users2_06cbd1286b150e2e79c91e9d1ed3d811 structure) {
        var result = new ST_06cbd1286b150e2e79c91e9d1ed3d811Structure ();

        if (structure is null) {
           return result;
        }

        result.ssliststring = 
structure.ssliststring == null ? "" : (string)structure.ssliststring;
result.sscategoryclass = 
structure.sscategoryclass == null ? "" : (string)structure.sscategoryclass;


        return result;
    }

    public static RestConsumeStructure_users2_06cbd1286b150e2e79c91e9d1ed3d811 FromStructure(ST_06cbd1286b150e2e79c91e9d1ed3d811Structure structure) {
        return new RestConsumeStructure_users2_06cbd1286b150e2e79c91e9d1ed3d811(structure);

    } 
}
