using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LogsAccountingRecord
public class JSONRC_404aa878a81887880a35de683904d643 : AbstractRESTStructure<RC_404aa878a81887880a35de683904d643> {
[JsonProperty("LogsAccounting")]
[JsonPropertyName("LogsAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord AttrLogsAccounting;

public JSONRC_404aa878a81887880a35de683904d643() { }

public JSONRC_404aa878a81887880a35de683904d643 (RC_404aa878a81887880a35de683904d643 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLogsAccounting = ConvertToRestWithoutDefaults(s.ssENLogsAccounting, new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord.FromStructure, config);
  } else {
AttrLogsAccounting = ssConectaProveedores.RestRecords.JSONEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord.FromStructure(s.ssENLogsAccounting, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_404aa878a81887880a35de683904d643, RC_404aa878a81887880a35de683904d643> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_404aa878a81887880a35de683904d643 s) => ToStructure(s, config);
}
public static RC_404aa878a81887880a35de683904d643 ToStructure(ssConectaProveedores.RestRecords.JSONRC_404aa878a81887880a35de683904d643 obj, IBehaviorsConfiguration config) { 
  RC_404aa878a81887880a35de683904d643 s = new RC_404aa878a81887880a35de683904d643();
  if(obj != null) {
  s.ssENLogsAccounting = ssConectaProveedores.RestRecords.JSONEN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord.ToStructure(obj.AttrLogsAccounting, config);
  }
  return s;
}

public static Func<RC_404aa878a81887880a35de683904d643, ssConectaProveedores.RestRecords.JSONRC_404aa878a81887880a35de683904d643> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_404aa878a81887880a35de683904d643 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_404aa878a81887880a35de683904d643 FromStructure(RC_404aa878a81887880a35de683904d643 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_404aa878a81887880a35de683904d643(s, config);
}

}


