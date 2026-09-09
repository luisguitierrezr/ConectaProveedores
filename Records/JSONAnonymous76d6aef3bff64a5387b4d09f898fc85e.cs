using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LogsAccountingSubjectRecord
public class JSONRC_780ecab424bd911724518df74dd2298a : AbstractRESTStructure<RC_780ecab424bd911724518df74dd2298a> {
[JsonProperty("LogsAccountingSubject")]
[JsonPropertyName("LogsAccountingSubject")]
public ssConectaProveedores.RestRecords.JSONEN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord AttrLogsAccountingSubject;

public JSONRC_780ecab424bd911724518df74dd2298a() { }

public JSONRC_780ecab424bd911724518df74dd2298a (RC_780ecab424bd911724518df74dd2298a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLogsAccountingSubject = ConvertToRestWithoutDefaults(s.ssENLogsAccountingSubject, new EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord.FromStructure, config);
  } else {
AttrLogsAccountingSubject = ssConectaProveedores.RestRecords.JSONEN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord.FromStructure(s.ssENLogsAccountingSubject, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_780ecab424bd911724518df74dd2298a, RC_780ecab424bd911724518df74dd2298a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_780ecab424bd911724518df74dd2298a s) => ToStructure(s, config);
}
public static RC_780ecab424bd911724518df74dd2298a ToStructure(ssConectaProveedores.RestRecords.JSONRC_780ecab424bd911724518df74dd2298a obj, IBehaviorsConfiguration config) { 
  RC_780ecab424bd911724518df74dd2298a s = new RC_780ecab424bd911724518df74dd2298a();
  if(obj != null) {
  s.ssENLogsAccountingSubject = ssConectaProveedores.RestRecords.JSONEN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord.ToStructure(obj.AttrLogsAccountingSubject, config);
  }
  return s;
}

public static Func<RC_780ecab424bd911724518df74dd2298a, ssConectaProveedores.RestRecords.JSONRC_780ecab424bd911724518df74dd2298a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_780ecab424bd911724518df74dd2298a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_780ecab424bd911724518df74dd2298a FromStructure(RC_780ecab424bd911724518df74dd2298a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_780ecab424bd911724518df74dd2298a(s, config);
}

}


