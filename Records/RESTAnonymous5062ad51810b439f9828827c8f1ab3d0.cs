using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_CreatedUser_UpdatedOrderMainRecord
public class RESTRC_af9a716157092fb65ec15387ef146a90 : AbstractRESTStructure<RC_af9a716157092fb65ec15387ef146a90> {
[JsonProperty("User_Created")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser_Created;

[JsonProperty("User_Updated")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser_Updated;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public RESTRC_af9a716157092fb65ec15387ef146a90() { }

public RESTRC_af9a716157092fb65ec15387ef146a90 (RC_af9a716157092fb65ec15387ef146a90 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_Created = ConvertToRestWithoutDefaults(s.ssENUser_Created, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUser_Updated = ConvertToRestWithoutDefaults(s.ssENUser_Updated, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrUser_Created = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser_Created, config);
AttrUser_Updated = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser_Updated, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static RC_af9a716157092fb65ec15387ef146a90 ToStructure(ssConectaProveedores.RestRecords.RESTRC_af9a716157092fb65ec15387ef146a90 obj) { 
  RC_af9a716157092fb65ec15387ef146a90 s = new RC_af9a716157092fb65ec15387ef146a90();
  if(obj != null) {
  s.ssENUser_Created = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser_Created);
  s.ssENUser_Updated = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser_Updated);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  }
  return s;
}

public static Func<RC_af9a716157092fb65ec15387ef146a90, ssConectaProveedores.RestRecords.RESTRC_af9a716157092fb65ec15387ef146a90> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_af9a716157092fb65ec15387ef146a90 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_af9a716157092fb65ec15387ef146a90 FromStructure(RC_af9a716157092fb65ec15387ef146a90 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_af9a716157092fb65ec15387ef146a90(s, config);
}

}


