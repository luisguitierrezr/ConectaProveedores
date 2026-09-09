using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUser_Extended_InternalRegionRecord
public class JSONRC_185879ac9d2186c1424cb37de7de8668 : AbstractRESTStructure<RC_185879ac9d2186c1424cb37de7de8668> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("User_Extended_Internal")]
[JsonPropertyName("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_185879ac9d2186c1424cb37de7de8668() { }

public JSONRC_185879ac9d2186c1424cb37de7de8668 (RC_185879ac9d2186c1424cb37de7de8668 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_185879ac9d2186c1424cb37de7de8668, RC_185879ac9d2186c1424cb37de7de8668> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_185879ac9d2186c1424cb37de7de8668 s) => ToStructure(s, config);
}
public static RC_185879ac9d2186c1424cb37de7de8668 ToStructure(ssConectaProveedores.RestRecords.JSONRC_185879ac9d2186c1424cb37de7de8668 obj, IBehaviorsConfiguration config) { 
  RC_185879ac9d2186c1424cb37de7de8668 s = new RC_185879ac9d2186c1424cb37de7de8668();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_185879ac9d2186c1424cb37de7de8668, ssConectaProveedores.RestRecords.JSONRC_185879ac9d2186c1424cb37de7de8668> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_185879ac9d2186c1424cb37de7de8668 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_185879ac9d2186c1424cb37de7de8668 FromStructure(RC_185879ac9d2186c1424cb37de7de8668 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_185879ac9d2186c1424cb37de7de8668(s, config);
}

}


