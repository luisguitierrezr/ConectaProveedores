using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NameTextIdRecord
public class RESTRC_d2eb0d0bdf3678ac335e4faafec1c741 : AbstractRESTStructure<RC_d2eb0d0bdf3678ac335e4faafec1c741> {
[JsonProperty("Name")]
public string AttrName;

[JsonProperty("Text")]
public string AttrText;

[JsonProperty("Id")]
public long? AttrId;

public RESTRC_d2eb0d0bdf3678ac335e4faafec1c741() { }

public RESTRC_d2eb0d0bdf3678ac335e4faafec1c741 (RC_d2eb0d0bdf3678ac335e4faafec1c741 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrText = ConvertToRestWithoutDefaults(s.ssText, "");
AttrId = ConvertToRestWithoutDefaults(s.ssId, 0L);
  } else {
AttrName = s.ssName;
AttrText = s.ssText;
AttrId = (long?) s.ssId;
  }
}

public static RC_d2eb0d0bdf3678ac335e4faafec1c741 ToStructure(ssConectaProveedores.RestRecords.RESTRC_d2eb0d0bdf3678ac335e4faafec1c741 obj) { 
  RC_d2eb0d0bdf3678ac335e4faafec1c741 s = new RC_d2eb0d0bdf3678ac335e4faafec1c741();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssText = obj.AttrText == null ? "" : obj.AttrText;
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  }
  return s;
}

public static Func<RC_d2eb0d0bdf3678ac335e4faafec1c741, ssConectaProveedores.RestRecords.RESTRC_d2eb0d0bdf3678ac335e4faafec1c741> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d2eb0d0bdf3678ac335e4faafec1c741 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d2eb0d0bdf3678ac335e4faafec1c741 FromStructure(RC_d2eb0d0bdf3678ac335e4faafec1c741 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d2eb0d0bdf3678ac335e4faafec1c741(s, config);
}

}


