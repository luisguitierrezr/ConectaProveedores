using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUser_Extended_InternalDepartmentTelcelDirectionRecord
public class JSONRC_e7c96643ac320a01471372d3fdec9c1e : AbstractRESTStructure<RC_e7c96643ac320a01471372d3fdec9c1e> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("User_Extended_Internal")]
[JsonPropertyName("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

[JsonProperty("Department")]
[JsonPropertyName("Department")]
public ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord AttrDepartment;

[JsonProperty("TelcelDirection")]
[JsonPropertyName("TelcelDirection")]
public ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord AttrTelcelDirection;

public JSONRC_e7c96643ac320a01471372d3fdec9c1e() { }

public JSONRC_e7c96643ac320a01471372d3fdec9c1e (RC_e7c96643ac320a01471372d3fdec9c1e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
AttrDepartment = ConvertToRestWithoutDefaults(s.ssENDepartment, new EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.FromStructure, config);
AttrTelcelDirection = ConvertToRestWithoutDefaults(s.ssENTelcelDirection, new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
AttrDepartment = ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.FromStructure(s.ssENDepartment, config);
AttrTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure(s.ssENTelcelDirection, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e7c96643ac320a01471372d3fdec9c1e, RC_e7c96643ac320a01471372d3fdec9c1e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e7c96643ac320a01471372d3fdec9c1e s) => ToStructure(s, config);
}
public static RC_e7c96643ac320a01471372d3fdec9c1e ToStructure(ssConectaProveedores.RestRecords.JSONRC_e7c96643ac320a01471372d3fdec9c1e obj, IBehaviorsConfiguration config) { 
  RC_e7c96643ac320a01471372d3fdec9c1e s = new RC_e7c96643ac320a01471372d3fdec9c1e();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal, config);
  s.ssENDepartment = ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.ToStructure(obj.AttrDepartment, config);
  s.ssENTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.ToStructure(obj.AttrTelcelDirection, config);
  }
  return s;
}

public static Func<RC_e7c96643ac320a01471372d3fdec9c1e, ssConectaProveedores.RestRecords.JSONRC_e7c96643ac320a01471372d3fdec9c1e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e7c96643ac320a01471372d3fdec9c1e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e7c96643ac320a01471372d3fdec9c1e FromStructure(RC_e7c96643ac320a01471372d3fdec9c1e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e7c96643ac320a01471372d3fdec9c1e(s, config);
}

}


