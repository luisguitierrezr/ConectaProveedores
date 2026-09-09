using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyContractFileTypeOrderRequestFileOrderContractFileOrderMainOrderDetailOrderFileRecord
public class JSONRC_ede323d374bfaaf1250e4715618dd7eb : AbstractRESTStructure<RC_ede323d374bfaaf1250e4715618dd7eb> {
[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

[JsonProperty("ContractFileType")]
[JsonPropertyName("ContractFileType")]
public ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord AttrContractFileType;

[JsonProperty("OrderRequestFile")]
[JsonPropertyName("OrderRequestFile")]
public ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord AttrOrderRequestFile;

[JsonProperty("OrderContractFile")]
[JsonPropertyName("OrderContractFile")]
public ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord AttrOrderContractFile;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderDetail")]
[JsonPropertyName("OrderDetail")]
public ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord AttrOrderDetail;

[JsonProperty("OrderFile")]
[JsonPropertyName("OrderFile")]
public ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord AttrOrderFile;

public JSONRC_ede323d374bfaaf1250e4715618dd7eb() { }

public JSONRC_ede323d374bfaaf1250e4715618dd7eb (RC_ede323d374bfaaf1250e4715618dd7eb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrContractFileType = ConvertToRestWithoutDefaults(s.ssENContractFileType, new EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord.FromStructure, config);
AttrOrderRequestFile = ConvertToRestWithoutDefaults(s.ssENOrderRequestFile, new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure, config);
AttrOrderContractFile = ConvertToRestWithoutDefaults(s.ssENOrderContractFile, new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderDetail = ConvertToRestWithoutDefaults(s.ssENOrderDetail, new EN_26f696e758428762fc617e811634d15dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure, config);
AttrOrderFile = ConvertToRestWithoutDefaults(s.ssENOrderFile, new EN_096339be3ef098b3762e8897e3a1c095EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
AttrContractFileType = ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord.FromStructure(s.ssENContractFileType, config);
AttrOrderRequestFile = ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure(s.ssENOrderRequestFile, config);
AttrOrderContractFile = ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure(s.ssENOrderContractFile, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderDetail = ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure(s.ssENOrderDetail, config);
AttrOrderFile = ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure(s.ssENOrderFile, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ede323d374bfaaf1250e4715618dd7eb, RC_ede323d374bfaaf1250e4715618dd7eb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ede323d374bfaaf1250e4715618dd7eb s) => ToStructure(s, config);
}
public static RC_ede323d374bfaaf1250e4715618dd7eb ToStructure(ssConectaProveedores.RestRecords.JSONRC_ede323d374bfaaf1250e4715618dd7eb obj, IBehaviorsConfiguration config) { 
  RC_ede323d374bfaaf1250e4715618dd7eb s = new RC_ede323d374bfaaf1250e4715618dd7eb();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency, config);
  s.ssENContractFileType = ssConectaProveedores.RestRecords.JSONEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord.ToStructure(obj.AttrContractFileType, config);
  s.ssENOrderRequestFile = ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.ToStructure(obj.AttrOrderRequestFile, config);
  s.ssENOrderContractFile = ssConectaProveedores.RestRecords.JSONEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.ToStructure(obj.AttrOrderContractFile, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENOrderDetail = ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.ToStructure(obj.AttrOrderDetail, config);
  s.ssENOrderFile = ssConectaProveedores.RestRecords.JSONEN_096339be3ef098b3762e8897e3a1c095EntityRecord.ToStructure(obj.AttrOrderFile, config);
  }
  return s;
}

public static Func<RC_ede323d374bfaaf1250e4715618dd7eb, ssConectaProveedores.RestRecords.JSONRC_ede323d374bfaaf1250e4715618dd7eb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ede323d374bfaaf1250e4715618dd7eb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ede323d374bfaaf1250e4715618dd7eb FromStructure(RC_ede323d374bfaaf1250e4715618dd7eb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ede323d374bfaaf1250e4715618dd7eb(s, config);
}

}


