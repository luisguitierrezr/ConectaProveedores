using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrdersToConsult
public class JSONST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure : AbstractRESTStructure<ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure> {
[JsonProperty("OrderMainId")]
[JsonPropertyName("OrderMainId")]
public long? AttrOrderMainId;

[JsonProperty("OrderNumber")]
[JsonPropertyName("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("OrderDate")]
[JsonPropertyName("OrderDate")]
public String AttrOrderDate;

[JsonProperty("OrderStatus")]
[JsonPropertyName("OrderStatus")]
public string AttrOrderStatus;

[JsonProperty("OrderStatusClass")]
[JsonPropertyName("OrderStatusClass")]
public string AttrOrderStatusClass;

[JsonProperty("OrderImportDateTime")]
[JsonPropertyName("OrderImportDateTime")]
public String AttrOrderImportDateTime;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public string AttrRegion;

[JsonProperty("TelcelDirection")]
[JsonPropertyName("TelcelDirection")]
public string AttrTelcelDirection;

[JsonProperty("SupplierName")]
[JsonPropertyName("SupplierName")]
public string AttrSupplierName;

[JsonProperty("SupplierNumber")]
[JsonPropertyName("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("FirstLevelUserName")]
[JsonPropertyName("FirstLevelUserName")]
public string AttrFirstLevelUserName;

[JsonProperty("FirstLevelJobTitle")]
[JsonPropertyName("FirstLevelJobTitle")]
public string AttrFirstLevelJobTitle;

[JsonProperty("FirstEntraRoleName")]
[JsonPropertyName("FirstEntraRoleName")]
public string AttrFirstEntraRoleName;

[JsonProperty("CurrLevelUserName")]
[JsonPropertyName("CurrLevelUserName")]
public string AttrCurrLevelUserName;

[JsonProperty("CurrLevelJobTitle")]
[JsonPropertyName("CurrLevelJobTitle")]
public string AttrCurrLevelJobTitle;

[JsonProperty("CurrEntraRoleName")]
[JsonPropertyName("CurrEntraRoleName")]
public string AttrCurrEntraRoleName;

[JsonProperty("AssignedOn")]
[JsonPropertyName("AssignedOn")]
public String AttrAssignedOn;

public JSONST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure() { }

public JSONST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure (ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMainId = ConvertToRestWithoutDefaults(s.ssOrderMainId, 0L);
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrOrderDate = ConvertDateToRestWithoutDefaults(s.ssOrderDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrOrderStatus = ConvertToRestWithoutDefaults(s.ssOrderStatus, "");
AttrOrderStatusClass = ConvertToRestWithoutDefaults(s.ssOrderStatusClass, "");
AttrOrderImportDateTime = ConvertDateTimeToRestWithoutDefaults(s.ssOrderImportDateTime, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrRegion = ConvertToRestWithoutDefaults(s.ssRegion, "");
AttrTelcelDirection = ConvertToRestWithoutDefaults(s.ssTelcelDirection, "");
AttrSupplierName = ConvertToRestWithoutDefaults(s.ssSupplierName, "");
AttrSupplierNumber = ConvertToRestWithoutDefaults(s.ssSupplierNumber, "");
AttrFirstLevelUserName = ConvertToRestWithoutDefaults(s.ssFirstLevelUserName, "");
AttrFirstLevelJobTitle = ConvertToRestWithoutDefaults(s.ssFirstLevelJobTitle, "");
AttrFirstEntraRoleName = ConvertToRestWithoutDefaults(s.ssFirstEntraRoleName, "");
AttrCurrLevelUserName = ConvertToRestWithoutDefaults(s.ssCurrLevelUserName, "");
AttrCurrLevelJobTitle = ConvertToRestWithoutDefaults(s.ssCurrLevelJobTitle, "");
AttrCurrEntraRoleName = ConvertToRestWithoutDefaults(s.ssCurrEntraRoleName, "");
AttrAssignedOn = ConvertDateTimeToRestWithoutDefaults(s.ssAssignedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrOrderMainId = (long?) s.ssOrderMainId;
AttrOrderNumber = s.ssOrderNumber;
AttrOrderDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssOrderDate);
AttrOrderStatus = s.ssOrderStatus;
AttrOrderStatusClass = s.ssOrderStatusClass;
AttrOrderImportDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssOrderImportDateTime, config.DateTimeFormat);
AttrRegion = s.ssRegion;
AttrTelcelDirection = s.ssTelcelDirection;
AttrSupplierName = s.ssSupplierName;
AttrSupplierNumber = s.ssSupplierNumber;
AttrFirstLevelUserName = s.ssFirstLevelUserName;
AttrFirstLevelJobTitle = s.ssFirstLevelJobTitle;
AttrFirstEntraRoleName = s.ssFirstEntraRoleName;
AttrCurrLevelUserName = s.ssCurrLevelUserName;
AttrCurrLevelJobTitle = s.ssCurrLevelJobTitle;
AttrCurrEntraRoleName = s.ssCurrEntraRoleName;
AttrAssignedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssAssignedOn, config.DateTimeFormat);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure, ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure s) => ToStructure(s, config);
}
public static ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure obj, IBehaviorsConfiguration config) { 
  ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure s = new ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure();
  if(obj != null) {
  s.ssOrderMainId = obj.AttrOrderMainId == null ? 0L : obj.AttrOrderMainId.Value;
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssOrderDate = obj.AttrOrderDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrOrderDate);
  s.ssOrderStatus = obj.AttrOrderStatus == null ? "" : obj.AttrOrderStatus;
  s.ssOrderStatusClass = obj.AttrOrderStatusClass == null ? "" : obj.AttrOrderStatusClass;
  s.ssOrderImportDateTime = obj.AttrOrderImportDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrOrderImportDateTime, config.DateTimeFormat);
  s.ssRegion = obj.AttrRegion == null ? "" : obj.AttrRegion;
  s.ssTelcelDirection = obj.AttrTelcelDirection == null ? "" : obj.AttrTelcelDirection;
  s.ssSupplierName = obj.AttrSupplierName == null ? "" : obj.AttrSupplierName;
  s.ssSupplierNumber = obj.AttrSupplierNumber == null ? "" : obj.AttrSupplierNumber;
  s.ssFirstLevelUserName = obj.AttrFirstLevelUserName == null ? "" : obj.AttrFirstLevelUserName;
  s.ssFirstLevelJobTitle = obj.AttrFirstLevelJobTitle == null ? "" : obj.AttrFirstLevelJobTitle;
  s.ssFirstEntraRoleName = obj.AttrFirstEntraRoleName == null ? "" : obj.AttrFirstEntraRoleName;
  s.ssCurrLevelUserName = obj.AttrCurrLevelUserName == null ? "" : obj.AttrCurrLevelUserName;
  s.ssCurrLevelJobTitle = obj.AttrCurrLevelJobTitle == null ? "" : obj.AttrCurrLevelJobTitle;
  s.ssCurrEntraRoleName = obj.AttrCurrEntraRoleName == null ? "" : obj.AttrCurrEntraRoleName;
  s.ssAssignedOn = obj.AttrAssignedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrAssignedOn, config.DateTimeFormat);
  }
  return s;
}

public static Func<ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure, ssConectaProveedores.RestRecords.JSONST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure FromStructure(ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure(s, config);
}

}


