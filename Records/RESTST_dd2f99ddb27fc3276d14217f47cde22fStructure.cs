using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrdersToConsultReport
public class RESTST_dd2f99ddb27fc3276d14217f47cde22fStructure : AbstractRESTStructure<ST_dd2f99ddb27fc3276d14217f47cde22fStructure> {
[JsonProperty("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("OrderDate")]
public String AttrOrderDate;

[JsonProperty("OrderStatus")]
public string AttrOrderStatus;

[JsonProperty("OrderImportDate")]
public String AttrOrderImportDate;

[JsonProperty("Region")]
public string AttrRegion;

[JsonProperty("TelcelDirection")]
public string AttrTelcelDirection;

[JsonProperty("SupplierName")]
public string AttrSupplierName;

[JsonProperty("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("FirstLevelUserName")]
public string AttrFirstLevelUserName;

[JsonProperty("FirstLevelJobTitle_EntraRoleName")]
public string AttrFirstLevelJobTitle_EntraRoleName;

[JsonProperty("CurrLevelUserName")]
public string AttrCurrLevelUserName;

[JsonProperty("CurrLevelJobTitle")]
public string AttrCurrLevelJobTitle;

[JsonProperty("AssignedOn")]
public String AttrAssignedOn;

[JsonProperty("AssignedOnTime")]
public String AttrAssignedOnTime;

public RESTST_dd2f99ddb27fc3276d14217f47cde22fStructure() { }

public RESTST_dd2f99ddb27fc3276d14217f47cde22fStructure (ST_dd2f99ddb27fc3276d14217f47cde22fStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrOrderDate = ConvertDateToRestWithoutDefaults(s.ssOrderDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrOrderStatus = ConvertToRestWithoutDefaults(s.ssOrderStatus, "");
AttrOrderImportDate = ConvertDateToRestWithoutDefaults(s.ssOrderImportDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrRegion = ConvertToRestWithoutDefaults(s.ssRegion, "");
AttrTelcelDirection = ConvertToRestWithoutDefaults(s.ssTelcelDirection, "");
AttrSupplierName = ConvertToRestWithoutDefaults(s.ssSupplierName, "");
AttrSupplierNumber = ConvertToRestWithoutDefaults(s.ssSupplierNumber, "");
AttrFirstLevelUserName = ConvertToRestWithoutDefaults(s.ssFirstLevelUserName, "");
AttrFirstLevelJobTitle_EntraRoleName = ConvertToRestWithoutDefaults(s.ssFirstLevelJobTitle_EntraRoleName, "");
AttrCurrLevelUserName = ConvertToRestWithoutDefaults(s.ssCurrLevelUserName, "");
AttrCurrLevelJobTitle = ConvertToRestWithoutDefaults(s.ssCurrLevelJobTitle, "");
AttrAssignedOn = ConvertDateToRestWithoutDefaults(s.ssAssignedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrAssignedOnTime = ConvertTimeToRestWithoutDefaults(s.ssAssignedOnTime, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
  } else {
AttrOrderNumber = s.ssOrderNumber;
AttrOrderDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssOrderDate);
AttrOrderStatus = s.ssOrderStatus;
AttrOrderImportDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssOrderImportDate);
AttrRegion = s.ssRegion;
AttrTelcelDirection = s.ssTelcelDirection;
AttrSupplierName = s.ssSupplierName;
AttrSupplierNumber = s.ssSupplierNumber;
AttrFirstLevelUserName = s.ssFirstLevelUserName;
AttrFirstLevelJobTitle_EntraRoleName = s.ssFirstLevelJobTitle_EntraRoleName;
AttrCurrLevelUserName = s.ssCurrLevelUserName;
AttrCurrLevelJobTitle = s.ssCurrLevelJobTitle;
AttrAssignedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssAssignedOn);
AttrAssignedOnTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.TimeToText(s.ssAssignedOnTime);
  }
}

public static ST_dd2f99ddb27fc3276d14217f47cde22fStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_dd2f99ddb27fc3276d14217f47cde22fStructure obj) { 
  ST_dd2f99ddb27fc3276d14217f47cde22fStructure s = new ST_dd2f99ddb27fc3276d14217f47cde22fStructure();
  if(obj != null) {
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssOrderDate = obj.AttrOrderDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrOrderDate);
  s.ssOrderStatus = obj.AttrOrderStatus == null ? "" : obj.AttrOrderStatus;
  s.ssOrderImportDate = obj.AttrOrderImportDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrOrderImportDate);
  s.ssRegion = obj.AttrRegion == null ? "" : obj.AttrRegion;
  s.ssTelcelDirection = obj.AttrTelcelDirection == null ? "" : obj.AttrTelcelDirection;
  s.ssSupplierName = obj.AttrSupplierName == null ? "" : obj.AttrSupplierName;
  s.ssSupplierNumber = obj.AttrSupplierNumber == null ? "" : obj.AttrSupplierNumber;
  s.ssFirstLevelUserName = obj.AttrFirstLevelUserName == null ? "" : obj.AttrFirstLevelUserName;
  s.ssFirstLevelJobTitle_EntraRoleName = obj.AttrFirstLevelJobTitle_EntraRoleName == null ? "" : obj.AttrFirstLevelJobTitle_EntraRoleName;
  s.ssCurrLevelUserName = obj.AttrCurrLevelUserName == null ? "" : obj.AttrCurrLevelUserName;
  s.ssCurrLevelJobTitle = obj.AttrCurrLevelJobTitle == null ? "" : obj.AttrCurrLevelJobTitle;
  s.ssAssignedOn = obj.AttrAssignedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrAssignedOn);
  s.ssAssignedOnTime = obj.AttrAssignedOnTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToTime(obj.AttrAssignedOnTime);
  }
  return s;
}

public static Func<ST_dd2f99ddb27fc3276d14217f47cde22fStructure, ssConectaProveedores.RestRecords.RESTST_dd2f99ddb27fc3276d14217f47cde22fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_dd2f99ddb27fc3276d14217f47cde22fStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_dd2f99ddb27fc3276d14217f47cde22fStructure FromStructure(ST_dd2f99ddb27fc3276d14217f47cde22fStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_dd2f99ddb27fc3276d14217f47cde22fStructure(s, config);
}

}


