using OutSystems.Application.RestConsume;
using OutSystems.Application.RestConsume.Definitions;

namespace ssConectaProveedores;

// This class is meant to be used solely by the New Rest Consume implementation
// and its purpose is to provide the datatypes that should be involved in serializing and deserializing
// Rest Consume requests and response payloads.
// Methods ToStructure and FromStructure are used to convert between these intermediate types
// and the actual Structure runtime types (C# structs).
public partial class RestConsumeStructure_Configuration2_ba6d268a2af779386f4c1aef812147c5 {
// This class fields can be omitted whenever this type is not involved in serializing or deserializing.
// That's the case when a single array attribute is used, which causes the upper layer to use the array directly
// without the need for this class. When that happens, the class is never instantiated and methods ToStructure
// and FromStructure enabled an easy conversion to and from the underlying type.

    [JsonProperty("userid")]
public string ssuserid;
[JsonProperty("categoryid")]
public string sscategoryid;
[JsonProperty("isenabled")]
public bool? ssisenabled;
[JsonProperty("notifybyemail")]
public bool? ssnotifybyemail;
[JsonProperty("notifyinapp")]
public bool? ssnotifyinapp;
[JsonProperty("categorydescription")]
public string sscategorydescription;

        
    public RestConsumeStructure_Configuration2_ba6d268a2af779386f4c1aef812147c5() { }

    public RestConsumeStructure_Configuration2_ba6d268a2af779386f4c1aef812147c5(ST_ba6d268a2af779386f4c1aef812147c5Structure structure) {
        this.ssuserid = 
(string)structure.ssuserid;
this.sscategoryid = 
(string)structure.sscategoryid;
this.ssisenabled = 
structure.ssisenabled == false ? null : (bool)structure.ssisenabled;
this.ssnotifybyemail = 
structure.ssnotifybyemail == false ? null : (bool)structure.ssnotifybyemail;
this.ssnotifyinapp = 
structure.ssnotifyinapp == false ? null : (bool)structure.ssnotifyinapp;
this.sscategorydescription = 
structure.sscategorydescription == "" ? null : (string)structure.sscategorydescription;

    }


    public static ST_ba6d268a2af779386f4c1aef812147c5Structure ToStructure(RestConsumeStructure_Configuration2_ba6d268a2af779386f4c1aef812147c5 structure) {
        var result = new ST_ba6d268a2af779386f4c1aef812147c5Structure ();

        if (structure is null) {
           return result;
        }

        result.ssuserid = 
structure.ssuserid == null ? "" : (string)structure.ssuserid;
result.sscategoryid = 
structure.sscategoryid == null ? "" : (string)structure.sscategoryid;
result.ssisenabled = 
structure.ssisenabled == null ? false : (bool)structure.ssisenabled;
result.ssnotifybyemail = 
structure.ssnotifybyemail == null ? false : (bool)structure.ssnotifybyemail;
result.ssnotifyinapp = 
structure.ssnotifyinapp == null ? false : (bool)structure.ssnotifyinapp;
result.sscategorydescription = 
structure.sscategorydescription == null ? "" : (string)structure.sscategorydescription;


        return result;
    }

    public static RestConsumeStructure_Configuration2_ba6d268a2af779386f4c1aef812147c5 FromStructure(ST_ba6d268a2af779386f4c1aef812147c5Structure structure) {
        return new RestConsumeStructure_Configuration2_ba6d268a2af779386f4c1aef812147c5(structure);

    } 
}
