using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ContractFileTypeOrderContractFileOrderFileRecord
public class RESTRC_f6cad939346a2d641ae33c13dbcb8a70 : AbstractRESTStructure<RC_f6cad939346a2d641ae33c13dbcb8a70> {
[JsonProperty("ContractFileType")]
public ssConectaProveedores.RestRecords.RESTEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord AttrContractFileType;

[JsonProperty("OrderContractFile")]
public ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord AttrOrderContractFile;

[JsonProperty("OrderFile")]
public ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord AttrOrderFile;

public RESTRC_f6cad939346a2d641ae33c13dbcb8a70() { }

public RESTRC_f6cad939346a2d641ae33c13dbcb8a70 (RC_f6cad939346a2d641ae33c13dbcb8a70 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrContractFileType = ConvertToRestWithoutDefaults(s.ssENContractFileType, new EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord.FromStructure, config);
AttrOrderContractFile = ConvertToRestWithoutDefaults(s.ssENOrderContractFile, new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure, config);
AttrOrderFile = ConvertToRestWithoutDefaults(s.ssENOrderFile, new EN_096339be3ef098b3762e8897e3a1c095EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure, config);
  } else {
AttrContractFileType = ssConectaProveedores.RestRecords.RESTEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord.FromStructure(s.ssENContractFileType, config);
AttrOrderContractFile = ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure(s.ssENOrderContractFile, config);
AttrOrderFile = ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure(s.ssENOrderFile, config);
  }
}

public static RC_f6cad939346a2d641ae33c13dbcb8a70 ToStructure(ssConectaProveedores.RestRecords.RESTRC_f6cad939346a2d641ae33c13dbcb8a70 obj) { 
  RC_f6cad939346a2d641ae33c13dbcb8a70 s = new RC_f6cad939346a2d641ae33c13dbcb8a70();
  if(obj != null) {
  s.ssENContractFileType = ssConectaProveedores.RestRecords.RESTEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord.ToStructure(obj.AttrContractFileType);
  s.ssENOrderContractFile = ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.ToStructure(obj.AttrOrderContractFile);
  s.ssENOrderFile = ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.ToStructure(obj.AttrOrderFile);
  }
  return s;
}

public static Func<RC_f6cad939346a2d641ae33c13dbcb8a70, ssConectaProveedores.RestRecords.RESTRC_f6cad939346a2d641ae33c13dbcb8a70> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f6cad939346a2d641ae33c13dbcb8a70 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f6cad939346a2d641ae33c13dbcb8a70 FromStructure(RC_f6cad939346a2d641ae33c13dbcb8a70 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f6cad939346a2d641ae33c13dbcb8a70(s, config);
}

}


