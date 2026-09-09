using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyCurrency_2ContractFileTypeOrderRequestFileOrderContractFileOrderMainOrderDetailOrderFileRecord
public class RESTRC_47b8b3c05056f6c3d5b8f5b05dd1c032 : AbstractRESTStructure<RC_47b8b3c05056f6c3d5b8f5b05dd1c032> {
[JsonProperty("Currency")]
public ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

[JsonProperty("Currency_2")]
public ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency_2;

[JsonProperty("ContractFileType")]
public ssConectaProveedores.RestRecords.RESTEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord AttrContractFileType;

[JsonProperty("OrderRequestFile")]
public ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord AttrOrderRequestFile;

[JsonProperty("OrderContractFile")]
public ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord AttrOrderContractFile;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderDetail")]
public ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord AttrOrderDetail;

[JsonProperty("OrderFile")]
public ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord AttrOrderFile;

public RESTRC_47b8b3c05056f6c3d5b8f5b05dd1c032() { }

public RESTRC_47b8b3c05056f6c3d5b8f5b05dd1c032 (RC_47b8b3c05056f6c3d5b8f5b05dd1c032 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrCurrency_2 = ConvertToRestWithoutDefaults(s.ssENCurrency_2, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrContractFileType = ConvertToRestWithoutDefaults(s.ssENContractFileType, new EN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord.FromStructure, config);
AttrOrderRequestFile = ConvertToRestWithoutDefaults(s.ssENOrderRequestFile, new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure, config);
AttrOrderContractFile = ConvertToRestWithoutDefaults(s.ssENOrderContractFile, new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderDetail = ConvertToRestWithoutDefaults(s.ssENOrderDetail, new EN_26f696e758428762fc617e811634d15dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure, config);
AttrOrderFile = ConvertToRestWithoutDefaults(s.ssENOrderFile, new EN_096339be3ef098b3762e8897e3a1c095EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
AttrCurrency_2 = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency_2, config);
AttrContractFileType = ssConectaProveedores.RestRecords.RESTEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord.FromStructure(s.ssENContractFileType, config);
AttrOrderRequestFile = ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure(s.ssENOrderRequestFile, config);
AttrOrderContractFile = ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.FromStructure(s.ssENOrderContractFile, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderDetail = ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure(s.ssENOrderDetail, config);
AttrOrderFile = ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.FromStructure(s.ssENOrderFile, config);
  }
}

public static RC_47b8b3c05056f6c3d5b8f5b05dd1c032 ToStructure(ssConectaProveedores.RestRecords.RESTRC_47b8b3c05056f6c3d5b8f5b05dd1c032 obj) { 
  RC_47b8b3c05056f6c3d5b8f5b05dd1c032 s = new RC_47b8b3c05056f6c3d5b8f5b05dd1c032();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency);
  s.ssENCurrency_2 = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency_2);
  s.ssENContractFileType = ssConectaProveedores.RestRecords.RESTEN_0cf2dde92298188c5430f5df84c9b7f8EntityRecord.ToStructure(obj.AttrContractFileType);
  s.ssENOrderRequestFile = ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.ToStructure(obj.AttrOrderRequestFile);
  s.ssENOrderContractFile = ssConectaProveedores.RestRecords.RESTEN_17538b35348920159ed0ee43b3fb2b50EntityRecord.ToStructure(obj.AttrOrderContractFile);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENOrderDetail = ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.ToStructure(obj.AttrOrderDetail);
  s.ssENOrderFile = ssConectaProveedores.RestRecords.RESTEN_096339be3ef098b3762e8897e3a1c095EntityRecord.ToStructure(obj.AttrOrderFile);
  }
  return s;
}

public static Func<RC_47b8b3c05056f6c3d5b8f5b05dd1c032, ssConectaProveedores.RestRecords.RESTRC_47b8b3c05056f6c3d5b8f5b05dd1c032> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_47b8b3c05056f6c3d5b8f5b05dd1c032 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_47b8b3c05056f6c3d5b8f5b05dd1c032 FromStructure(RC_47b8b3c05056f6c3d5b8f5b05dd1c032 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_47b8b3c05056f6c3d5b8f5b05dd1c032(s, config);
}

}


