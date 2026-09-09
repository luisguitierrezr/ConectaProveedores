using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_CreatedUser_UpdatedRequisitionRecord
public class JSONRC_b993edfaac62fcf2f3babee6c7847316 : AbstractRESTStructure<RC_b993edfaac62fcf2f3babee6c7847316> {
[JsonProperty("User_Created")]
[JsonPropertyName("User_Created")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_Created;

[JsonProperty("User_Updated")]
[JsonPropertyName("User_Updated")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_Updated;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

public JSONRC_b993edfaac62fcf2f3babee6c7847316() { }

public JSONRC_b993edfaac62fcf2f3babee6c7847316 (RC_b993edfaac62fcf2f3babee6c7847316 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_Created = ConvertToRestWithoutDefaults(s.ssENUser_Created, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUser_Updated = ConvertToRestWithoutDefaults(s.ssENUser_Updated, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
  } else {
AttrUser_Created = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_Created, config);
AttrUser_Updated = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_Updated, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b993edfaac62fcf2f3babee6c7847316, RC_b993edfaac62fcf2f3babee6c7847316> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b993edfaac62fcf2f3babee6c7847316 s) => ToStructure(s, config);
}
public static RC_b993edfaac62fcf2f3babee6c7847316 ToStructure(ssConectaProveedores.RestRecords.JSONRC_b993edfaac62fcf2f3babee6c7847316 obj, IBehaviorsConfiguration config) { 
  RC_b993edfaac62fcf2f3babee6c7847316 s = new RC_b993edfaac62fcf2f3babee6c7847316();
  if(obj != null) {
  s.ssENUser_Created = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_Created, config);
  s.ssENUser_Updated = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_Updated, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  }
  return s;
}

public static Func<RC_b993edfaac62fcf2f3babee6c7847316, ssConectaProveedores.RestRecords.JSONRC_b993edfaac62fcf2f3babee6c7847316> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b993edfaac62fcf2f3babee6c7847316 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b993edfaac62fcf2f3babee6c7847316 FromStructure(RC_b993edfaac62fcf2f3babee6c7847316 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b993edfaac62fcf2f3babee6c7847316(s, config);
}

}


