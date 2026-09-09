using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// StorageRecord
public class RESTRC_b2edf1939202eb7e60eb499349388514 : AbstractRESTStructure<RC_b2edf1939202eb7e60eb499349388514> {
[JsonProperty("Storage")]
public ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

public RESTRC_b2edf1939202eb7e60eb499349388514() { }

public RESTRC_b2edf1939202eb7e60eb499349388514 (RC_b2edf1939202eb7e60eb499349388514 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
  } else {
AttrStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
  }
}

public static RC_b2edf1939202eb7e60eb499349388514 ToStructure(ssConectaProveedores.RestRecords.RESTRC_b2edf1939202eb7e60eb499349388514 obj) { 
  RC_b2edf1939202eb7e60eb499349388514 s = new RC_b2edf1939202eb7e60eb499349388514();
  if(obj != null) {
  s.ssENStorage = ssConectaProveedores.RestRecords.RESTEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage);
  }
  return s;
}

public static Func<RC_b2edf1939202eb7e60eb499349388514, ssConectaProveedores.RestRecords.RESTRC_b2edf1939202eb7e60eb499349388514> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b2edf1939202eb7e60eb499349388514 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b2edf1939202eb7e60eb499349388514 FromStructure(RC_b2edf1939202eb7e60eb499349388514 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b2edf1939202eb7e60eb499349388514(s, config);
}

}


