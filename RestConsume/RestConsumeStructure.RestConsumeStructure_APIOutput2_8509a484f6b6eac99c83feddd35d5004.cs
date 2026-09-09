using OutSystems.Application.RestConsume;
using OutSystems.Application.RestConsume.Definitions;

namespace ssConectaProveedores;

// This class is meant to be used solely by the New Rest Consume implementation
// and its purpose is to provide the datatypes that should be involved in serializing and deserializing
// Rest Consume requests and response payloads.
// Methods ToStructure and FromStructure are used to convert between these intermediate types
// and the actual Structure runtime types (C# structs).
public partial class RestConsumeStructure_APIOutput2_8509a484f6b6eac99c83feddd35d5004 {
// This class fields can be omitted whenever this type is not involved in serializing or deserializing.
// That's the case when a single array attribute is used, which causes the upper layer to use the array directly
// without the need for this class. When that happens, the class is never instantiated and methods ToStructure
// and FromStructure enabled an easy conversion to and from the underlying type.

    [JsonProperty("success")]
public bool? sssuccess;
[JsonProperty("errors")]
public string sserrors;
[JsonProperty("data")]
public RestConsumeStructure_dataoutput2_91300ad987a75a51816ab4149ce29870 ssdata;

        
    public RestConsumeStructure_APIOutput2_8509a484f6b6eac99c83feddd35d5004() { }

    public RestConsumeStructure_APIOutput2_8509a484f6b6eac99c83feddd35d5004(ST_8509a484f6b6eac99c83feddd35d5004Structure structure) {
        this.sssuccess = 
structure.sssuccess == false ? null : (bool)structure.sssuccess;
this.sserrors = 
structure.sserrors == "" ? null : (string)structure.sserrors;
this.ssdata = 
new ST_91300ad987a75a51816ab4149ce29870Structure().Equals((ST_91300ad987a75a51816ab4149ce29870Structure)structure.ssdata) ? null : RestConsumeStructure_dataoutput2_91300ad987a75a51816ab4149ce29870.FromStructure(structure.ssdata);
    }


    public static ST_8509a484f6b6eac99c83feddd35d5004Structure ToStructure(RestConsumeStructure_APIOutput2_8509a484f6b6eac99c83feddd35d5004 structure) {
        var result = new ST_8509a484f6b6eac99c83feddd35d5004Structure ();

        if (structure is null) {
           return result;
        }

        result.sssuccess = 
structure.sssuccess == null ? false : (bool)structure.sssuccess;
result.sserrors = 
structure.sserrors == null ? "" : (string)structure.sserrors;
result.ssdata = 
RestConsumeStructure_dataoutput2_91300ad987a75a51816ab4149ce29870.ToStructure(structure.ssdata);

        return result;
    }

    public static RestConsumeStructure_APIOutput2_8509a484f6b6eac99c83feddd35d5004 FromStructure(ST_8509a484f6b6eac99c83feddd35d5004Structure structure) {
        return new RestConsumeStructure_APIOutput2_8509a484f6b6eac99c83feddd35d5004(structure);

    } 
}
