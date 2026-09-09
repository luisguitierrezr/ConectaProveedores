using OutSystems.Application.RestConsume;
using OutSystems.Application.RestConsume.Definitions;

namespace ssConectaProveedores;

// This class is meant to be used solely by the New Rest Consume implementation
// and its purpose is to provide the datatypes that should be involved in serializing and deserializing
// Rest Consume requests and response payloads.
// Methods ToStructure and FromStructure are used to convert between these intermediate types
// and the actual Structure runtime types (C# structs).
public partial class RestConsumeStructure_NewNotification2_f2b86c6e9a171aacffc6ca49bb5b5aaf {
// This class fields can be omitted whenever this type is not involved in serializing or deserializing.
// That's the case when a single array attribute is used, which causes the upper layer to use the array directly
// without the need for this class. When that happens, the class is never instantiated and methods ToStructure
// and FromStructure enabled an easy conversion to and from the underlying type.

    [JsonProperty("userids")]
public string[] ssuserids;
[JsonProperty("title")]
public string sstitle;
[JsonProperty("content")]
public string sscontent;
[JsonProperty("categoryclass")]
public string sscategoryclass;

        
    public RestConsumeStructure_NewNotification2_f2b86c6e9a171aacffc6ca49bb5b5aaf() { }

    public RestConsumeStructure_NewNotification2_f2b86c6e9a171aacffc6ca49bb5b5aaf(ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure structure) {
        this.ssuserids = 
structure.ssuserids.Length == 0 ? null : structure.ssuserids.ToArray();
this.sstitle = 
structure.sstitle == "" ? null : (string)structure.sstitle;
this.sscontent = 
structure.sscontent == "" ? null : (string)structure.sscontent;
this.sscategoryclass = 
structure.sscategoryclass == "" ? null : (string)structure.sscategoryclass;

    }


    public static ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure ToStructure(RestConsumeStructure_NewNotification2_f2b86c6e9a171aacffc6ca49bb5b5aaf structure) {
        var result = new ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure ();

        if (structure is null) {
           return result;
        }

        result.ssuserids = 
BasicTypeList<string>.ToList(structure.ssuserids);
result.sstitle = 
structure.sstitle == null ? "" : (string)structure.sstitle;
result.sscontent = 
structure.sscontent == null ? "" : (string)structure.sscontent;
result.sscategoryclass = 
structure.sscategoryclass == null ? "" : (string)structure.sscategoryclass;


        return result;
    }

    public static RestConsumeStructure_NewNotification2_f2b86c6e9a171aacffc6ca49bb5b5aaf FromStructure(ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure structure) {
        return new RestConsumeStructure_NewNotification2_f2b86c6e9a171aacffc6ca49bb5b5aaf(structure);

    } 
}
