using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IdNameRecord
public class RESTRC_8129c2d9846bc83a20ef6f3e7b60c809 : AbstractRESTStructure<RC_8129c2d9846bc83a20ef6f3e7b60c809> {
[JsonProperty("Id")]
public string AttrId;

[JsonProperty("Name")]
public string AttrName;

public RESTRC_8129c2d9846bc83a20ef6f3e7b60c809() { }

public RESTRC_8129c2d9846bc83a20ef6f3e7b60c809 (RC_8129c2d9846bc83a20ef6f3e7b60c809 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = ConvertToRestWithoutDefaults(s.ssId, "");
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
  } else {
AttrId = s.ssId;
AttrName = s.ssName;
  }
}

public static RC_8129c2d9846bc83a20ef6f3e7b60c809 ToStructure(ssConectaProveedores.RestRecords.RESTRC_8129c2d9846bc83a20ef6f3e7b60c809 obj) { 
  RC_8129c2d9846bc83a20ef6f3e7b60c809 s = new RC_8129c2d9846bc83a20ef6f3e7b60c809();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<RC_8129c2d9846bc83a20ef6f3e7b60c809, ssConectaProveedores.RestRecords.RESTRC_8129c2d9846bc83a20ef6f3e7b60c809> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8129c2d9846bc83a20ef6f3e7b60c809 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8129c2d9846bc83a20ef6f3e7b60c809 FromStructure(RC_8129c2d9846bc83a20ef6f3e7b60c809 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8129c2d9846bc83a20ef6f3e7b60c809(s, config);
}

}


