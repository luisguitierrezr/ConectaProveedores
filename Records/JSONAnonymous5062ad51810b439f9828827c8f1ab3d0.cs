using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_CreatedUser_UpdatedOrderMainRecord
public class JSONRC_af9a716157092fb65ec15387ef146a90 : AbstractRESTStructure<RC_af9a716157092fb65ec15387ef146a90> {
[JsonProperty("User_Created")]
[JsonPropertyName("User_Created")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_Created;

[JsonProperty("User_Updated")]
[JsonPropertyName("User_Updated")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_Updated;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public JSONRC_af9a716157092fb65ec15387ef146a90() { }

public JSONRC_af9a716157092fb65ec15387ef146a90 (RC_af9a716157092fb65ec15387ef146a90 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_Created = ConvertToRestWithoutDefaults(s.ssENUser_Created, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUser_Updated = ConvertToRestWithoutDefaults(s.ssENUser_Updated, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrUser_Created = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_Created, config);
AttrUser_Updated = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_Updated, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_af9a716157092fb65ec15387ef146a90, RC_af9a716157092fb65ec15387ef146a90> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_af9a716157092fb65ec15387ef146a90 s) => ToStructure(s, config);
}
public static RC_af9a716157092fb65ec15387ef146a90 ToStructure(ssConectaProveedores.RestRecords.JSONRC_af9a716157092fb65ec15387ef146a90 obj, IBehaviorsConfiguration config) { 
  RC_af9a716157092fb65ec15387ef146a90 s = new RC_af9a716157092fb65ec15387ef146a90();
  if(obj != null) {
  s.ssENUser_Created = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_Created, config);
  s.ssENUser_Updated = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_Updated, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  }
  return s;
}

public static Func<RC_af9a716157092fb65ec15387ef146a90, ssConectaProveedores.RestRecords.JSONRC_af9a716157092fb65ec15387ef146a90> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_af9a716157092fb65ec15387ef146a90 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_af9a716157092fb65ec15387ef146a90 FromStructure(RC_af9a716157092fb65ec15387ef146a90 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_af9a716157092fb65ec15387ef146a90(s, config);
}

}


