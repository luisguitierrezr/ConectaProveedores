using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUser_Extended_InternalRegionRecord
public class RESTRC_185879ac9d2186c1424cb37de7de8668 : AbstractRESTStructure<RC_185879ac9d2186c1424cb37de7de8668> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_185879ac9d2186c1424cb37de7de8668() { }

public RESTRC_185879ac9d2186c1424cb37de7de8668 (RC_185879ac9d2186c1424cb37de7de8668 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_185879ac9d2186c1424cb37de7de8668 ToStructure(ssConectaProveedores.RestRecords.RESTRC_185879ac9d2186c1424cb37de7de8668 obj) { 
  RC_185879ac9d2186c1424cb37de7de8668 s = new RC_185879ac9d2186c1424cb37de7de8668();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_185879ac9d2186c1424cb37de7de8668, ssConectaProveedores.RestRecords.RESTRC_185879ac9d2186c1424cb37de7de8668> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_185879ac9d2186c1424cb37de7de8668 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_185879ac9d2186c1424cb37de7de8668 FromStructure(RC_185879ac9d2186c1424cb37de7de8668 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_185879ac9d2186c1424cb37de7de8668(s, config);
}

}


