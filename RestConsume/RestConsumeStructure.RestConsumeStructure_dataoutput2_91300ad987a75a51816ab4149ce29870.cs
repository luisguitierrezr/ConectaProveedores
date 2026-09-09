using OutSystems.Application.RestConsume;
using OutSystems.Application.RestConsume.Definitions;

namespace ssConectaProveedores;

// This class is meant to be used solely by the New Rest Consume implementation
// and its purpose is to provide the datatypes that should be involved in serializing and deserializing
// Rest Consume requests and response payloads.
// Methods ToStructure and FromStructure are used to convert between these intermediate types
// and the actual Structure runtime types (C# structs).
public partial class RestConsumeStructure_dataoutput2_91300ad987a75a51816ab4149ce29870 {
// This class fields can be omitted whenever this type is not involved in serializing or deserializing.
// That's the case when a single array attribute is used, which causes the upper layer to use the array directly
// without the need for this class. When that happens, the class is never instantiated and methods ToStructure
// and FromStructure enabled an easy conversion to and from the underlying type.

    [JsonProperty("notificationlist")]
public RestConsumeStructure_NotificationOutput2_968b59b0d969f443f958cd852a31dcb5[] ssnotificationlist;
[JsonProperty("configurationlist")]
public RestConsumeStructure_Configuration2_ba6d268a2af779386f4c1aef812147c5[] ssconfigurationlist;
[JsonProperty("checkedusers")]
public RestConsumeStructure_users2_06cbd1286b150e2e79c91e9d1ed3d811 sscheckedusers;

        
    public RestConsumeStructure_dataoutput2_91300ad987a75a51816ab4149ce29870() { }

    public RestConsumeStructure_dataoutput2_91300ad987a75a51816ab4149ce29870(ST_91300ad987a75a51816ab4149ce29870Structure structure) {
        this.ssnotificationlist = 
structure.ssnotificationlist.Length == 0 ? null : structure.ssnotificationlist.ToArray(RestConsumeStructure_NotificationOutput2_968b59b0d969f443f958cd852a31dcb5.FromStructure);
this.ssconfigurationlist = 
structure.ssconfigurationlist.Length == 0 ? null : structure.ssconfigurationlist.ToArray(RestConsumeStructure_Configuration2_ba6d268a2af779386f4c1aef812147c5.FromStructure);
this.sscheckedusers = 
new ST_06cbd1286b150e2e79c91e9d1ed3d811Structure().Equals((ST_06cbd1286b150e2e79c91e9d1ed3d811Structure)structure.sscheckedusers) ? null : RestConsumeStructure_users2_06cbd1286b150e2e79c91e9d1ed3d811.FromStructure(structure.sscheckedusers);
    }


    public static ST_91300ad987a75a51816ab4149ce29870Structure ToStructure(RestConsumeStructure_dataoutput2_91300ad987a75a51816ab4149ce29870 structure) {
        var result = new ST_91300ad987a75a51816ab4149ce29870Structure ();

        if (structure is null) {
           return result;
        }

        result.ssnotificationlist = 
RL_02b33a244546a7f09e6ac2e1170aaea2.ToList(structure.ssnotificationlist, RestConsumeStructure_NotificationOutput2_968b59b0d969f443f958cd852a31dcb5.ToStructure);
result.ssconfigurationlist = 
RL_3ff9916e5a2a5558f61f2a757294606e.ToList(structure.ssconfigurationlist, RestConsumeStructure_Configuration2_ba6d268a2af779386f4c1aef812147c5.ToStructure);
result.sscheckedusers = 
RestConsumeStructure_users2_06cbd1286b150e2e79c91e9d1ed3d811.ToStructure(structure.sscheckedusers);

        return result;
    }

    public static RestConsumeStructure_dataoutput2_91300ad987a75a51816ab4149ce29870 FromStructure(ST_91300ad987a75a51816ab4149ce29870Structure structure) {
        return new RestConsumeStructure_dataoutput2_91300ad987a75a51816ab4149ce29870(structure);

    } 
}
