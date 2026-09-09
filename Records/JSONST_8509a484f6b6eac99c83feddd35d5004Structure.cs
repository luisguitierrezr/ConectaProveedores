using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// APIOutput2
public class JSONST_8509a484f6b6eac99c83feddd35d5004Structure : AbstractRESTStructure<ST_8509a484f6b6eac99c83feddd35d5004Structure> {
[JsonProperty("success")]
[JsonPropertyName("success")]
public bool? Attrsuccess;

[JsonProperty("errors")]
[JsonPropertyName("errors")]
public string Attrerrors;

[JsonProperty("data")]
[JsonPropertyName("data")]
public ssConectaProveedores.RestRecords.JSONST_91300ad987a75a51816ab4149ce29870Structure Attrdata;

public JSONST_8509a484f6b6eac99c83feddd35d5004Structure() { }

public JSONST_8509a484f6b6eac99c83feddd35d5004Structure (ST_8509a484f6b6eac99c83feddd35d5004Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrsuccess = ConvertToRestWithoutDefaults(s.sssuccess, false);
Attrerrors = ConvertToRestWithoutDefaults(s.sserrors, "");
Attrdata = ConvertToRestWithoutDefaults(s.ssdata, new ST_91300ad987a75a51816ab4149ce29870Structure(), ssConectaProveedores.RestRecords.JSONST_91300ad987a75a51816ab4149ce29870Structure.FromStructure, config);
  } else {
Attrsuccess = (bool?) s.sssuccess;
Attrerrors = s.sserrors;
Attrdata = ssConectaProveedores.RestRecords.JSONST_91300ad987a75a51816ab4149ce29870Structure.FromStructure(s.ssdata, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_8509a484f6b6eac99c83feddd35d5004Structure, ST_8509a484f6b6eac99c83feddd35d5004Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_8509a484f6b6eac99c83feddd35d5004Structure s) => ToStructure(s, config);
}
public static ST_8509a484f6b6eac99c83feddd35d5004Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_8509a484f6b6eac99c83feddd35d5004Structure obj, IBehaviorsConfiguration config) { 
  ST_8509a484f6b6eac99c83feddd35d5004Structure s = new ST_8509a484f6b6eac99c83feddd35d5004Structure();
  if(obj != null) {
  s.sssuccess = obj.Attrsuccess == null ? false : obj.Attrsuccess.Value;
  s.sserrors = obj.Attrerrors == null ? "" : obj.Attrerrors;
  s.ssdata = ssConectaProveedores.RestRecords.JSONST_91300ad987a75a51816ab4149ce29870Structure.ToStructure(obj.Attrdata, config);
  }
  return s;
}

public static Func<ST_8509a484f6b6eac99c83feddd35d5004Structure, ssConectaProveedores.RestRecords.JSONST_8509a484f6b6eac99c83feddd35d5004Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_8509a484f6b6eac99c83feddd35d5004Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_8509a484f6b6eac99c83feddd35d5004Structure FromStructure(ST_8509a484f6b6eac99c83feddd35d5004Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_8509a484f6b6eac99c83feddd35d5004Structure(s, config);
}

}


