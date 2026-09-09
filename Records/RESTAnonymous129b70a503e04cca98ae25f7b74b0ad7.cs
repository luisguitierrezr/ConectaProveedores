using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_CreatedUser_UpdatedRequisitionRecord
public class RESTRC_b993edfaac62fcf2f3babee6c7847316 : AbstractRESTStructure<RC_b993edfaac62fcf2f3babee6c7847316> {
[JsonProperty("User_Created")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser_Created;

[JsonProperty("User_Updated")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser_Updated;

[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

public RESTRC_b993edfaac62fcf2f3babee6c7847316() { }

public RESTRC_b993edfaac62fcf2f3babee6c7847316 (RC_b993edfaac62fcf2f3babee6c7847316 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_Created = ConvertToRestWithoutDefaults(s.ssENUser_Created, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUser_Updated = ConvertToRestWithoutDefaults(s.ssENUser_Updated, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
  } else {
AttrUser_Created = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser_Created, config);
AttrUser_Updated = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser_Updated, config);
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
  }
}

public static RC_b993edfaac62fcf2f3babee6c7847316 ToStructure(ssConectaProveedores.RestRecords.RESTRC_b993edfaac62fcf2f3babee6c7847316 obj) { 
  RC_b993edfaac62fcf2f3babee6c7847316 s = new RC_b993edfaac62fcf2f3babee6c7847316();
  if(obj != null) {
  s.ssENUser_Created = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser_Created);
  s.ssENUser_Updated = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser_Updated);
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  }
  return s;
}

public static Func<RC_b993edfaac62fcf2f3babee6c7847316, ssConectaProveedores.RestRecords.RESTRC_b993edfaac62fcf2f3babee6c7847316> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b993edfaac62fcf2f3babee6c7847316 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b993edfaac62fcf2f3babee6c7847316 FromStructure(RC_b993edfaac62fcf2f3babee6c7847316 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b993edfaac62fcf2f3babee6c7847316(s, config);
}

}


