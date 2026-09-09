using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserRecord
public class RESTRC_ced013358a82a813f1d9a5108f17ce79 : AbstractRESTStructure<RC_ced013358a82a813f1d9a5108f17ce79> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

public RESTRC_ced013358a82a813f1d9a5108f17ce79() { }

public RESTRC_ced013358a82a813f1d9a5108f17ce79 (RC_ced013358a82a813f1d9a5108f17ce79 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
  }
}

public static RC_ced013358a82a813f1d9a5108f17ce79 ToStructure(ssConectaProveedores.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79 obj) { 
  RC_ced013358a82a813f1d9a5108f17ce79 s = new RC_ced013358a82a813f1d9a5108f17ce79();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  }
  return s;
}

public static Func<RC_ced013358a82a813f1d9a5108f17ce79, ssConectaProveedores.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ced013358a82a813f1d9a5108f17ce79 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79 FromStructure(RC_ced013358a82a813f1d9a5108f17ce79 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ced013358a82a813f1d9a5108f17ce79(s, config);
}

}


