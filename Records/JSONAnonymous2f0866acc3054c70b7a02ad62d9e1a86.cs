using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ContractFileTypeRecord
public class JSONRC_6d6e93fa5edbd2aad29e8f15b3f71aeb : AbstractRESTStructure<RC_6d6e93fa5edbd2aad29e8f15b3f71aeb> {
[JsonProperty("ContractFileType")]
[JsonPropertyName("ContractFileType")]
public ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord AttrContractFileType;

public JSONRC_6d6e93fa5edbd2aad29e8f15b3f71aeb() { }

public JSONRC_6d6e93fa5edbd2aad29e8f15b3f71aeb (RC_6d6e93fa5edbd2aad29e8f15b3f71aeb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrContractFileType = ConvertToRestWithoutDefaults(s.ssENContractFileType, new EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord.FromStructure, config);
  } else {
AttrContractFileType = ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord.FromStructure(s.ssENContractFileType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_6d6e93fa5edbd2aad29e8f15b3f71aeb, RC_6d6e93fa5edbd2aad29e8f15b3f71aeb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_6d6e93fa5edbd2aad29e8f15b3f71aeb s) => ToStructure(s, config);
}
public static RC_6d6e93fa5edbd2aad29e8f15b3f71aeb ToStructure(ssConectaProveedores.RestRecords.JSONRC_6d6e93fa5edbd2aad29e8f15b3f71aeb obj, IBehaviorsConfiguration config) { 
  RC_6d6e93fa5edbd2aad29e8f15b3f71aeb s = new RC_6d6e93fa5edbd2aad29e8f15b3f71aeb();
  if(obj != null) {
  s.ssENContractFileType = ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord.ToStructure(obj.AttrContractFileType, config);
  }
  return s;
}

public static Func<RC_6d6e93fa5edbd2aad29e8f15b3f71aeb, ssConectaProveedores.RestRecords.JSONRC_6d6e93fa5edbd2aad29e8f15b3f71aeb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6d6e93fa5edbd2aad29e8f15b3f71aeb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_6d6e93fa5edbd2aad29e8f15b3f71aeb FromStructure(RC_6d6e93fa5edbd2aad29e8f15b3f71aeb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_6d6e93fa5edbd2aad29e8f15b3f71aeb(s, config);
}

}


