using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MFU_ErrorRecord
public class RESTRC_b87fa9e4edd3dd8574880501160c11fc : AbstractRESTStructure<RC_b87fa9e4edd3dd8574880501160c11fc> {
[JsonProperty("MFU_Error")]
public ssConectaProveedores.RestRecords.RESTST_f9f8b40f5330871047e55e068d129447Structure AttrMFU_Error;

public RESTRC_b87fa9e4edd3dd8574880501160c11fc() { }

public RESTRC_b87fa9e4edd3dd8574880501160c11fc (RC_b87fa9e4edd3dd8574880501160c11fc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMFU_Error = ConvertToRestWithoutDefaults(s.ssSTMFU_Error, new ST_f9f8b40f5330871047e55e068d129447Structure(), ssConectaProveedores.RestRecords.RESTST_f9f8b40f5330871047e55e068d129447Structure.FromStructure, config);
  } else {
AttrMFU_Error = ssConectaProveedores.RestRecords.RESTST_f9f8b40f5330871047e55e068d129447Structure.FromStructure(s.ssSTMFU_Error, config);
  }
}

public static RC_b87fa9e4edd3dd8574880501160c11fc ToStructure(ssConectaProveedores.RestRecords.RESTRC_b87fa9e4edd3dd8574880501160c11fc obj) { 
  RC_b87fa9e4edd3dd8574880501160c11fc s = new RC_b87fa9e4edd3dd8574880501160c11fc();
  if(obj != null) {
  s.ssSTMFU_Error = ssConectaProveedores.RestRecords.RESTST_f9f8b40f5330871047e55e068d129447Structure.ToStructure(obj.AttrMFU_Error);
  }
  return s;
}

public static Func<RC_b87fa9e4edd3dd8574880501160c11fc, ssConectaProveedores.RestRecords.RESTRC_b87fa9e4edd3dd8574880501160c11fc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b87fa9e4edd3dd8574880501160c11fc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b87fa9e4edd3dd8574880501160c11fc FromStructure(RC_b87fa9e4edd3dd8574880501160c11fc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b87fa9e4edd3dd8574880501160c11fc(s, config);
}

}


