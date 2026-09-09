using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyOrderStatusOrderApprovalOrderMainOrderApprovalLevelIsSelectedDaysInAssigmentCompanySupplierRegionRecord
public class JSONRC_0a41c52434474d75060edec9b8b557c0 : AbstractRESTStructure<RC_0a41c52434474d75060edec9b8b557c0> {
[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

[JsonProperty("OrderStatus")]
[JsonPropertyName("OrderStatus")]
public ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord AttrOrderStatus;

[JsonProperty("OrderApproval")]
[JsonPropertyName("OrderApproval")]
public ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord AttrOrderApproval;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderApprovalLevel")]
[JsonPropertyName("OrderApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovalLevel;

[JsonProperty("IsSelected")]
[JsonPropertyName("IsSelected")]
public bool? AttrIsSelected;

[JsonProperty("DaysInAssigment")]
[JsonPropertyName("DaysInAssigment")]
public int? AttrDaysInAssigment;

[JsonProperty("Company")]
[JsonPropertyName("Company")]
public ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_0a41c52434474d75060edec9b8b557c0() { }

public JSONRC_0a41c52434474d75060edec9b8b557c0 (RC_0a41c52434474d75060edec9b8b557c0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrOrderStatus = ConvertToRestWithoutDefaults(s.ssENOrderStatus, new EN_5eda60810da752f579e01795bb7e0de0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure, config);
AttrOrderApproval = ConvertToRestWithoutDefaults(s.ssENOrderApproval, new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovalLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
AttrDaysInAssigment = ConvertToRestWithoutDefaults(s.ssDaysInAssigment, 0);
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
AttrOrderStatus = ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure(s.ssENOrderStatus, config);
AttrOrderApproval = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(s.ssENOrderApproval, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovalLevel, config);
AttrIsSelected = (bool?) s.ssIsSelected;
AttrDaysInAssigment = (int?) s.ssDaysInAssigment;
AttrCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0a41c52434474d75060edec9b8b557c0, RC_0a41c52434474d75060edec9b8b557c0> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0a41c52434474d75060edec9b8b557c0 s) => ToStructure(s, config);
}
public static RC_0a41c52434474d75060edec9b8b557c0 ToStructure(ssConectaProveedores.RestRecords.JSONRC_0a41c52434474d75060edec9b8b557c0 obj, IBehaviorsConfiguration config) { 
  RC_0a41c52434474d75060edec9b8b557c0 s = new RC_0a41c52434474d75060edec9b8b557c0();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency, config);
  s.ssENOrderStatus = ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.ToStructure(obj.AttrOrderStatus, config);
  s.ssENOrderApproval = ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.ToStructure(obj.AttrOrderApproval, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENOrderApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovalLevel, config);
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  s.ssDaysInAssigment = obj.AttrDaysInAssigment == null ? 0 : obj.AttrDaysInAssigment.Value;
  s.ssENCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_0a41c52434474d75060edec9b8b557c0, ssConectaProveedores.RestRecords.JSONRC_0a41c52434474d75060edec9b8b557c0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0a41c52434474d75060edec9b8b557c0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0a41c52434474d75060edec9b8b557c0 FromStructure(RC_0a41c52434474d75060edec9b8b557c0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0a41c52434474d75060edec9b8b557c0(s, config);
}

}


