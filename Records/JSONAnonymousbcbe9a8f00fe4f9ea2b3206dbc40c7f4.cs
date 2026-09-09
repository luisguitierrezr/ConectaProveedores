using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MFU_ErrorRecord
public class JSONRC_b87fa9e4edd3dd8574880501160c11fc : AbstractRESTStructure<RC_b87fa9e4edd3dd8574880501160c11fc> {
[JsonProperty("MFU_Error")]
[JsonPropertyName("MFU_Error")]
public ssConectaProveedores.RestRecords.JSONST_f9f8b40f5330871047e55e068d129447Structure AttrMFU_Error;

public JSONRC_b87fa9e4edd3dd8574880501160c11fc() { }

public JSONRC_b87fa9e4edd3dd8574880501160c11fc (RC_b87fa9e4edd3dd8574880501160c11fc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMFU_Error = ConvertToRestWithoutDefaults(s.ssSTMFU_Error, new ST_f9f8b40f5330871047e55e068d129447Structure(), ssConectaProveedores.RestRecords.JSONST_f9f8b40f5330871047e55e068d129447Structure.FromStructure, config);
  } else {
AttrMFU_Error = ssConectaProveedores.RestRecords.JSONST_f9f8b40f5330871047e55e068d129447Structure.FromStructure(s.ssSTMFU_Error, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b87fa9e4edd3dd8574880501160c11fc, RC_b87fa9e4edd3dd8574880501160c11fc> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b87fa9e4edd3dd8574880501160c11fc s) => ToStructure(s, config);
}
public static RC_b87fa9e4edd3dd8574880501160c11fc ToStructure(ssConectaProveedores.RestRecords.JSONRC_b87fa9e4edd3dd8574880501160c11fc obj, IBehaviorsConfiguration config) { 
  RC_b87fa9e4edd3dd8574880501160c11fc s = new RC_b87fa9e4edd3dd8574880501160c11fc();
  if(obj != null) {
  s.ssSTMFU_Error = ssConectaProveedores.RestRecords.JSONST_f9f8b40f5330871047e55e068d129447Structure.ToStructure(obj.AttrMFU_Error, config);
  }
  return s;
}

public static Func<RC_b87fa9e4edd3dd8574880501160c11fc, ssConectaProveedores.RestRecords.JSONRC_b87fa9e4edd3dd8574880501160c11fc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b87fa9e4edd3dd8574880501160c11fc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b87fa9e4edd3dd8574880501160c11fc FromStructure(RC_b87fa9e4edd3dd8574880501160c11fc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b87fa9e4edd3dd8574880501160c11fc(s, config);
}

}


