using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUser_Extended_InternalDepartmentRegionRecord
public class RESTRC_21a885f0bb9cdabb4dd12f34282bebba : AbstractRESTStructure<RC_21a885f0bb9cdabb4dd12f34282bebba> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

[JsonProperty("Department")]
public ssConectaProveedores.RestRecords.RESTEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord AttrDepartment;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_21a885f0bb9cdabb4dd12f34282bebba() { }

public RESTRC_21a885f0bb9cdabb4dd12f34282bebba (RC_21a885f0bb9cdabb4dd12f34282bebba s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
AttrDepartment = ConvertToRestWithoutDefaults(s.ssENDepartment, new EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
AttrDepartment = ssConectaProveedores.RestRecords.RESTEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.FromStructure(s.ssENDepartment, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_21a885f0bb9cdabb4dd12f34282bebba ToStructure(ssConectaProveedores.RestRecords.RESTRC_21a885f0bb9cdabb4dd12f34282bebba obj) { 
  RC_21a885f0bb9cdabb4dd12f34282bebba s = new RC_21a885f0bb9cdabb4dd12f34282bebba();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal);
  s.ssENDepartment = ssConectaProveedores.RestRecords.RESTEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.ToStructure(obj.AttrDepartment);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_21a885f0bb9cdabb4dd12f34282bebba, ssConectaProveedores.RestRecords.RESTRC_21a885f0bb9cdabb4dd12f34282bebba> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_21a885f0bb9cdabb4dd12f34282bebba s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_21a885f0bb9cdabb4dd12f34282bebba FromStructure(RC_21a885f0bb9cdabb4dd12f34282bebba s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_21a885f0bb9cdabb4dd12f34282bebba(s, config);
}

}


