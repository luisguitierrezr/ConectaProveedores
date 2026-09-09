using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NameTextIdRecord
public class JSONRC_d2eb0d0bdf3678ac335e4faafec1c741 : AbstractRESTStructure<RC_d2eb0d0bdf3678ac335e4faafec1c741> {
[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Text")]
[JsonPropertyName("Text")]
public string AttrText;

[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

public JSONRC_d2eb0d0bdf3678ac335e4faafec1c741() { }

public JSONRC_d2eb0d0bdf3678ac335e4faafec1c741 (RC_d2eb0d0bdf3678ac335e4faafec1c741 s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONRC_d2eb0d0bdf3678ac335e4faafec1c741, RC_d2eb0d0bdf3678ac335e4faafec1c741> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_d2eb0d0bdf3678ac335e4faafec1c741 s) => ToStructure(s, config);
}
public static RC_d2eb0d0bdf3678ac335e4faafec1c741 ToStructure(ssConectaProveedores.RestRecords.JSONRC_d2eb0d0bdf3678ac335e4faafec1c741 obj, IBehaviorsConfiguration config) { 
  RC_d2eb0d0bdf3678ac335e4faafec1c741 s = new RC_d2eb0d0bdf3678ac335e4faafec1c741();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssText = obj.AttrText == null ? "" : obj.AttrText;
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  }
  return s;
}

public static Func<RC_d2eb0d0bdf3678ac335e4faafec1c741, ssConectaProveedores.RestRecords.JSONRC_d2eb0d0bdf3678ac335e4faafec1c741> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d2eb0d0bdf3678ac335e4faafec1c741 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_d2eb0d0bdf3678ac335e4faafec1c741 FromStructure(RC_d2eb0d0bdf3678ac335e4faafec1c741 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_d2eb0d0bdf3678ac335e4faafec1c741(s, config);
}

}


