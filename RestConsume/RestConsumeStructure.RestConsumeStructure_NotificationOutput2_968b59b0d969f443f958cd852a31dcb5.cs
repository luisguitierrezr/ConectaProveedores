using OutSystems.Application.RestConsume;
using OutSystems.Application.RestConsume.Definitions;

namespace ssConectaProveedores;

// This class is meant to be used solely by the New Rest Consume implementation
// and its purpose is to provide the datatypes that should be involved in serializing and deserializing
// Rest Consume requests and response payloads.
// Methods ToStructure and FromStructure are used to convert between these intermediate types
// and the actual Structure runtime types (C# structs).
public partial class RestConsumeStructure_NotificationOutput2_968b59b0d969f443f958cd852a31dcb5 {
// This class fields can be omitted whenever this type is not involved in serializing or deserializing.
// That's the case when a single array attribute is used, which causes the upper layer to use the array directly
// without the need for this class. When that happens, the class is never instantiated and methods ToStructure
// and FromStructure enabled an easy conversion to and from the underlying type.

    [JsonProperty("id")]
public long? ssid;
[JsonProperty("title")]
public string sstitle;
[JsonProperty("content")]
public string sscontent;
[JsonProperty("isread")]
public bool? ssisread;
[JsonProperty("createdat")]
public DateTime? sscreatedat;
[JsonProperty("categoryclass")]
public string sscategoryclass;

        
    public RestConsumeStructure_NotificationOutput2_968b59b0d969f443f958cd852a31dcb5() { }

    public RestConsumeStructure_NotificationOutput2_968b59b0d969f443f958cd852a31dcb5(ST_968b59b0d969f443f958cd852a31dcb5Structure structure) {
        this.ssid = 
(long)structure.ssid;
this.sstitle = 
structure.sstitle == "" ? null : (string)structure.sstitle;
this.sscontent = 
structure.sscontent == "" ? null : (string)structure.sscontent;
this.ssisread = 
structure.ssisread == false ? null : (bool)structure.ssisread;
this.sscreatedat = 
(DateTime)RestConsumeStructureAttributeUtils.DateTimeToUniversal(structure.sscreatedat);
this.sscategoryclass = 
structure.sscategoryclass == "" ? null : (string)structure.sscategoryclass;

    }


    public static ST_968b59b0d969f443f958cd852a31dcb5Structure ToStructure(RestConsumeStructure_NotificationOutput2_968b59b0d969f443f958cd852a31dcb5 structure) {
        var result = new ST_968b59b0d969f443f958cd852a31dcb5Structure ();

        if (structure is null) {
           return result;
        }

        result.ssid = 
structure.ssid == null ? 0L : (long)structure.ssid;
result.sstitle = 
structure.sstitle == null ? "" : (string)structure.sstitle;
result.sscontent = 
structure.sscontent == null ? "" : (string)structure.sscontent;
result.ssisread = 
structure.ssisread == null ? false : (bool)structure.ssisread;
result.sscreatedat = 
structure.sscreatedat == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : (DateTime)RestConsumeStructureAttributeUtils.DateTimeToUniversal((DateTime)structure.sscreatedat);
result.sscategoryclass = 
structure.sscategoryclass == null ? "" : (string)structure.sscategoryclass;


        return result;
    }

    public static RestConsumeStructure_NotificationOutput2_968b59b0d969f443f958cd852a31dcb5 FromStructure(ST_968b59b0d969f443f958cd852a31dcb5Structure structure) {
        return new RestConsumeStructure_NotificationOutput2_968b59b0d969f443f958cd852a31dcb5(structure);

    } 
}
