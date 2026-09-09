using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUser_Extended_InternalDepartmentRegionRecord
public class JSONRC_21a885f0bb9cdabb4dd12f34282bebba : AbstractRESTStructure<RC_21a885f0bb9cdabb4dd12f34282bebba> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("User_Extended_Internal")]
[JsonPropertyName("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

[JsonProperty("Department")]
[JsonPropertyName("Department")]
public ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord AttrDepartment;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_21a885f0bb9cdabb4dd12f34282bebba() { }

public JSONRC_21a885f0bb9cdabb4dd12f34282bebba (RC_21a885f0bb9cdabb4dd12f34282bebba s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
AttrDepartment = ConvertToRestWithoutDefaults(s.ssENDepartment, new EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
AttrDepartment = ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.FromStructure(s.ssENDepartment, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_21a885f0bb9cdabb4dd12f34282bebba, RC_21a885f0bb9cdabb4dd12f34282bebba> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_21a885f0bb9cdabb4dd12f34282bebba s) => ToStructure(s, config);
}
public static RC_21a885f0bb9cdabb4dd12f34282bebba ToStructure(ssConectaProveedores.RestRecords.JSONRC_21a885f0bb9cdabb4dd12f34282bebba obj, IBehaviorsConfiguration config) { 
  RC_21a885f0bb9cdabb4dd12f34282bebba s = new RC_21a885f0bb9cdabb4dd12f34282bebba();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal, config);
  s.ssENDepartment = ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.ToStructure(obj.AttrDepartment, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_21a885f0bb9cdabb4dd12f34282bebba, ssConectaProveedores.RestRecords.JSONRC_21a885f0bb9cdabb4dd12f34282bebba> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_21a885f0bb9cdabb4dd12f34282bebba s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_21a885f0bb9cdabb4dd12f34282bebba FromStructure(RC_21a885f0bb9cdabb4dd12f34282bebba s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_21a885f0bb9cdabb4dd12f34282bebba(s, config);
}

}


