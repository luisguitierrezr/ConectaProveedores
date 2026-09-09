using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ContractFileTypeOrderContractFileOrderFileRecord
public class JSONRC_f6cad939346a2d641ae33c13dbcb8a70 : AbstractRESTStructure<RC_f6cad939346a2d641ae33c13dbcb8a70> {
[JsonProperty("ContractFileType")]
[JsonPropertyName("ContractFileType")]
public ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord AttrContractFileType;

[JsonProperty("OrderContractFile")]
[JsonPropertyName("OrderContractFile")]
public ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord AttrOrderContractFile;

[JsonProperty("OrderFile")]
[JsonPropertyName("OrderFile")]
public ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord AttrOrderFile;

public JSONRC_f6cad939346a2d641ae33c13dbcb8a70() { }

public JSONRC_f6cad939346a2d641ae33c13dbcb8a70 (RC_f6cad939346a2d641ae33c13dbcb8a70 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrContractFileType = ConvertToRestWithoutDefaults(s.ssENContractFileType, new EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord.FromStructure, config);
AttrOrderContractFile = ConvertToRestWithoutDefaults(s.ssENOrderContractFile, new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure, config);
AttrOrderFile = ConvertToRestWithoutDefaults(s.ssENOrderFile, new EN_096339be3ef098b3762e8897e3a1c095EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure, config);
  } else {
AttrContractFileType = ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord.FromStructure(s.ssENContractFileType, config);
AttrOrderContractFile = ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure(s.ssENOrderContractFile, config);
AttrOrderFile = ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure(s.ssENOrderFile, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f6cad939346a2d641ae33c13dbcb8a70, RC_f6cad939346a2d641ae33c13dbcb8a70> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f6cad939346a2d641ae33c13dbcb8a70 s) => ToStructure(s, config);
}
public static RC_f6cad939346a2d641ae33c13dbcb8a70 ToStructure(ssConectaProveedores.RestRecords.JSONRC_f6cad939346a2d641ae33c13dbcb8a70 obj, IBehaviorsConfiguration config) { 
  RC_f6cad939346a2d641ae33c13dbcb8a70 s = new RC_f6cad939346a2d641ae33c13dbcb8a70();
  if(obj != null) {
  s.ssENContractFileType = ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord.ToStructure(obj.AttrContractFileType, config);
  s.ssENOrderContractFile = ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.ToStructure(obj.AttrOrderContractFile, config);
  s.ssENOrderFile = ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.ToStructure(obj.AttrOrderFile, config);
  }
  return s;
}

public static Func<RC_f6cad939346a2d641ae33c13dbcb8a70, ssConectaProveedores.RestRecords.JSONRC_f6cad939346a2d641ae33c13dbcb8a70> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f6cad939346a2d641ae33c13dbcb8a70 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f6cad939346a2d641ae33c13dbcb8a70 FromStructure(RC_f6cad939346a2d641ae33c13dbcb8a70 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f6cad939346a2d641ae33c13dbcb8a70(s, config);
}

}


