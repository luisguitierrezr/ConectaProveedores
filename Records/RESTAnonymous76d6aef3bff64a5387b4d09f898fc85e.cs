using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LogsAccountingSubjectRecord
public class RESTRC_780ecab424bd911724518df74dd2298a : AbstractRESTStructure<RC_780ecab424bd911724518df74dd2298a> {
[JsonProperty("LogsAccountingSubject")]
public ssConectaProveedores.RestRecords.RESTEN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord AttrLogsAccountingSubject;

public RESTRC_780ecab424bd911724518df74dd2298a() { }

public RESTRC_780ecab424bd911724518df74dd2298a (RC_780ecab424bd911724518df74dd2298a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLogsAccountingSubject = ConvertToRestWithoutDefaults(s.ssENLogsAccountingSubject, new EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord.FromStructure, config);
  } else {
AttrLogsAccountingSubject = ssConectaProveedores.RestRecords.RESTEN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord.FromStructure(s.ssENLogsAccountingSubject, config);
  }
}

public static RC_780ecab424bd911724518df74dd2298a ToStructure(ssConectaProveedores.RestRecords.RESTRC_780ecab424bd911724518df74dd2298a obj) { 
  RC_780ecab424bd911724518df74dd2298a s = new RC_780ecab424bd911724518df74dd2298a();
  if(obj != null) {
  s.ssENLogsAccountingSubject = ssConectaProveedores.RestRecords.RESTEN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord.ToStructure(obj.AttrLogsAccountingSubject);
  }
  return s;
}

public static Func<RC_780ecab424bd911724518df74dd2298a, ssConectaProveedores.RestRecords.RESTRC_780ecab424bd911724518df74dd2298a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_780ecab424bd911724518df74dd2298a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_780ecab424bd911724518df74dd2298a FromStructure(RC_780ecab424bd911724518df74dd2298a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_780ecab424bd911724518df74dd2298a(s, config);
}

}


