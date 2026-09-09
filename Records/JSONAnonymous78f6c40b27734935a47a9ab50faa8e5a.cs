using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyUserOrderStatusOrderMainItemOrderMainItemStatusOrderMainOrderDetailOrderApprovalLevelQtdDeliveredQuantityAvailableTotalDeliveryStatusUser_Extended_InternalCompanySupplierRecord
public class JSONRC_aae113dc341165a54f51793c1371eeba : AbstractRESTStructure<RC_aae113dc341165a54f51793c1371eeba> {
[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("OrderStatus")]
[JsonPropertyName("OrderStatus")]
public ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord AttrOrderStatus;

[JsonProperty("OrderMainItem")]
[JsonPropertyName("OrderMainItem")]
public ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

[JsonProperty("OrderMainItemStatus")]
[JsonPropertyName("OrderMainItemStatus")]
public ssConectaProveedores.RestRecords.JSONEN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord AttrOrderMainItemStatus;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderDetail")]
[JsonPropertyName("OrderDetail")]
public ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord AttrOrderDetail;

[JsonProperty("OrderApprovalLevel")]
[JsonPropertyName("OrderApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovalLevel;

[JsonProperty("QtdDelivered")]
[JsonPropertyName("QtdDelivered")]
public ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure AttrQtdDelivered;

[JsonProperty("QuantityAvailable")]
[JsonPropertyName("QuantityAvailable")]
public ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure AttrQuantityAvailable;

[JsonProperty("Total")]
[JsonPropertyName("Total")]
public ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure AttrTotal;

[JsonProperty("DeliveryStatus")]
[JsonPropertyName("DeliveryStatus")]
public ssConectaProveedores.RestRecords.JSONSTTextStructure AttrDeliveryStatus;

[JsonProperty("User_Extended_Internal")]
[JsonPropertyName("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

[JsonProperty("Company")]
[JsonPropertyName("Company")]
public ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

public JSONRC_aae113dc341165a54f51793c1371eeba() { }

public JSONRC_aae113dc341165a54f51793c1371eeba (RC_aae113dc341165a54f51793c1371eeba s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrOrderStatus = ConvertToRestWithoutDefaults(s.ssENOrderStatus, new EN_5eda60810da752f579e01795bb7e0de0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure, config);
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
AttrOrderMainItemStatus = ConvertToRestWithoutDefaults(s.ssENOrderMainItemStatus, new EN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderDetail = ConvertToRestWithoutDefaults(s.ssENOrderDetail, new EN_26f696e758428762fc617e811634d15dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure, config);
AttrOrderApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovalLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
AttrQtdDelivered = ConvertToRestWithoutDefaults(s.ssSTQtdDelivered, new ST_18874ac0b41f9a239dad794ccac4f8d3Structure(), ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure, config);
AttrQuantityAvailable = ConvertToRestWithoutDefaults(s.ssSTQuantityAvailable, new ST_18874ac0b41f9a239dad794ccac4f8d3Structure(), ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure, config);
AttrTotal = ConvertToRestWithoutDefaults(s.ssSTTotal, new ST_18874ac0b41f9a239dad794ccac4f8d3Structure(), ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure, config);
AttrDeliveryStatus = ConvertToRestWithoutDefaults(s.ssSTDeliveryStatus, new STTextStructure(), ssConectaProveedores.RestRecords.JSONSTTextStructure.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrOrderStatus = ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure(s.ssENOrderStatus, config);
AttrOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
AttrOrderMainItemStatus = ssConectaProveedores.RestRecords.JSONEN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord.FromStructure(s.ssENOrderMainItemStatus, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderDetail = ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure(s.ssENOrderDetail, config);
AttrOrderApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovalLevel, config);
AttrQtdDelivered = ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure(s.ssSTQtdDelivered, config);
AttrQuantityAvailable = ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure(s.ssSTQuantityAvailable, config);
AttrTotal = ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure(s.ssSTTotal, config);
AttrDeliveryStatus = ssConectaProveedores.RestRecords.JSONSTTextStructure.FromStructure(s.ssSTDeliveryStatus, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
AttrCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_aae113dc341165a54f51793c1371eeba, RC_aae113dc341165a54f51793c1371eeba> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_aae113dc341165a54f51793c1371eeba s) => ToStructure(s, config);
}
public static RC_aae113dc341165a54f51793c1371eeba ToStructure(ssConectaProveedores.RestRecords.JSONRC_aae113dc341165a54f51793c1371eeba obj, IBehaviorsConfiguration config) { 
  RC_aae113dc341165a54f51793c1371eeba s = new RC_aae113dc341165a54f51793c1371eeba();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency, config);
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENOrderStatus = ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.ToStructure(obj.AttrOrderStatus, config);
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem, config);
  s.ssENOrderMainItemStatus = ssConectaProveedores.RestRecords.JSONEN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord.ToStructure(obj.AttrOrderMainItemStatus, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENOrderDetail = ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.ToStructure(obj.AttrOrderDetail, config);
  s.ssENOrderApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovalLevel, config);
  s.ssSTQtdDelivered = ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.ToStructure(obj.AttrQtdDelivered, config);
  s.ssSTQuantityAvailable = ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.ToStructure(obj.AttrQuantityAvailable, config);
  s.ssSTTotal = ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.ToStructure(obj.AttrTotal, config);
  s.ssSTDeliveryStatus = ssConectaProveedores.RestRecords.JSONSTTextStructure.ToStructure(obj.AttrDeliveryStatus, config);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal, config);
  s.ssENCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  }
  return s;
}

public static Func<RC_aae113dc341165a54f51793c1371eeba, ssConectaProveedores.RestRecords.JSONRC_aae113dc341165a54f51793c1371eeba> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_aae113dc341165a54f51793c1371eeba s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_aae113dc341165a54f51793c1371eeba FromStructure(RC_aae113dc341165a54f51793c1371eeba s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_aae113dc341165a54f51793c1371eeba(s, config);
}

}


