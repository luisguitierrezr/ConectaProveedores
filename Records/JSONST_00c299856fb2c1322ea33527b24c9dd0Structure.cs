using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderListTableStructure
public class JSONST_00c299856fb2c1322ea33527b24c9dd0Structure : AbstractRESTStructure<ST_00c299856fb2c1322ea33527b24c9dd0Structure> {
[JsonProperty("OrderMainId")]
[JsonPropertyName("OrderMainId")]
public long? AttrOrderMainId;

[JsonProperty("ApprovalStatus")]
[JsonPropertyName("ApprovalStatus")]
public string AttrApprovalStatus;

[JsonProperty("OrderNumber")]
[JsonPropertyName("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("OrderStatus")]
[JsonPropertyName("OrderStatus")]
public string AttrOrderStatus;

[JsonProperty("SupplierName_Number")]
[JsonPropertyName("SupplierName_Number")]
public string AttrSupplierName_Number;

[JsonProperty("Buyer")]
[JsonPropertyName("Buyer")]
public string AttrBuyer;

[JsonProperty("Company")]
[JsonPropertyName("Company")]
public string AttrCompany;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public string AttrRegion;

[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public string AttrCurrency;

[JsonProperty("TotalAmount")]
[JsonPropertyName("TotalAmount")]
public string AttrTotalAmount;

public JSONST_00c299856fb2c1322ea33527b24c9dd0Structure() { }

public JSONST_00c299856fb2c1322ea33527b24c9dd0Structure (ST_00c299856fb2c1322ea33527b24c9dd0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMainId = ConvertToRestWithoutDefaults(s.ssOrderMainId, 0L);
AttrApprovalStatus = ConvertToRestWithoutDefaults(s.ssApprovalStatus, "");
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrOrderStatus = ConvertToRestWithoutDefaults(s.ssOrderStatus, "");
AttrSupplierName_Number = ConvertToRestWithoutDefaults(s.ssSupplierName_Number, "");
AttrBuyer = ConvertToRestWithoutDefaults(s.ssBuyer, "");
AttrCompany = ConvertToRestWithoutDefaults(s.ssCompany, "");
AttrRegion = ConvertToRestWithoutDefaults(s.ssRegion, "");
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, "");
  } else {
AttrOrderMainId = (long?) s.ssOrderMainId;
AttrApprovalStatus = s.ssApprovalStatus;
AttrOrderNumber = s.ssOrderNumber;
AttrOrderStatus = s.ssOrderStatus;
AttrSupplierName_Number = s.ssSupplierName_Number;
AttrBuyer = s.ssBuyer;
AttrCompany = s.ssCompany;
AttrRegion = s.ssRegion;
AttrCurrency = s.ssCurrency;
AttrTotalAmount = s.ssTotalAmount;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_00c299856fb2c1322ea33527b24c9dd0Structure, ST_00c299856fb2c1322ea33527b24c9dd0Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_00c299856fb2c1322ea33527b24c9dd0Structure s) => ToStructure(s, config);
}
public static ST_00c299856fb2c1322ea33527b24c9dd0Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_00c299856fb2c1322ea33527b24c9dd0Structure obj, IBehaviorsConfiguration config) { 
  ST_00c299856fb2c1322ea33527b24c9dd0Structure s = new ST_00c299856fb2c1322ea33527b24c9dd0Structure();
  if(obj != null) {
  s.ssOrderMainId = obj.AttrOrderMainId == null ? 0L : obj.AttrOrderMainId.Value;
  s.ssApprovalStatus = obj.AttrApprovalStatus == null ? "" : obj.AttrApprovalStatus;
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssOrderStatus = obj.AttrOrderStatus == null ? "" : obj.AttrOrderStatus;
  s.ssSupplierName_Number = obj.AttrSupplierName_Number == null ? "" : obj.AttrSupplierName_Number;
  s.ssBuyer = obj.AttrBuyer == null ? "" : obj.AttrBuyer;
  s.ssCompany = obj.AttrCompany == null ? "" : obj.AttrCompany;
  s.ssRegion = obj.AttrRegion == null ? "" : obj.AttrRegion;
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? "" : obj.AttrTotalAmount;
  }
  return s;
}

public static Func<ST_00c299856fb2c1322ea33527b24c9dd0Structure, ssConectaProveedores.RestRecords.JSONST_00c299856fb2c1322ea33527b24c9dd0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_00c299856fb2c1322ea33527b24c9dd0Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_00c299856fb2c1322ea33527b24c9dd0Structure FromStructure(ST_00c299856fb2c1322ea33527b24c9dd0Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_00c299856fb2c1322ea33527b24c9dd0Structure(s, config);
}

}


