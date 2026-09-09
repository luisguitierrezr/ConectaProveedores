using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// StorageRecord
public class JSONRC_b2edf1939202eb7e60eb499349388514 : AbstractRESTStructure<RC_b2edf1939202eb7e60eb499349388514> {
[JsonProperty("Storage")]
[JsonPropertyName("Storage")]
public ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

public JSONRC_b2edf1939202eb7e60eb499349388514() { }

public JSONRC_b2edf1939202eb7e60eb499349388514 (RC_b2edf1939202eb7e60eb499349388514 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
  } else {
AttrStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b2edf1939202eb7e60eb499349388514, RC_b2edf1939202eb7e60eb499349388514> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b2edf1939202eb7e60eb499349388514 s) => ToStructure(s, config);
}
public static RC_b2edf1939202eb7e60eb499349388514 ToStructure(ssConectaProveedores.RestRecords.JSONRC_b2edf1939202eb7e60eb499349388514 obj, IBehaviorsConfiguration config) { 
  RC_b2edf1939202eb7e60eb499349388514 s = new RC_b2edf1939202eb7e60eb499349388514();
  if(obj != null) {
  s.ssENStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage, config);
  }
  return s;
}

public static Func<RC_b2edf1939202eb7e60eb499349388514, ssConectaProveedores.RestRecords.JSONRC_b2edf1939202eb7e60eb499349388514> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b2edf1939202eb7e60eb499349388514 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b2edf1939202eb7e60eb499349388514 FromStructure(RC_b2edf1939202eb7e60eb499349388514 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b2edf1939202eb7e60eb499349388514(s, config);
}

}


