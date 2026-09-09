using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Order
public class RESTST_1a18ac43e89b6e5649de540bf9caa846Structure : AbstractRESTStructure<ST_1a18ac43e89b6e5649de540bf9caa846Structure> {
[JsonProperty("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("OrderDate")]
public String AttrOrderDate;

[JsonProperty("OrderStatus")]
public string AttrOrderStatus;

[JsonProperty("Region")]
public string AttrRegion;

[JsonProperty("SupplierName")]
public string AttrSupplierName;

[JsonProperty("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("FirstLevelUserName")]
public string AttrFirstLevelUserName;

[JsonProperty("FirstLevelEmail")]
public string AttrFirstLevelEmail;

[JsonProperty("FirstLevelJobTitle")]
public string AttrFirstLevelJobTitle;

[JsonProperty("FirstEntraRoleName")]
public string AttrFirstEntraRoleName;

[JsonProperty("CurrLevelUserName")]
public string AttrCurrLevelUserName;

[JsonProperty("CurrLevelEmail")]
public string AttrCurrLevelEmail;

[JsonProperty("CurrLevelJobTitle")]
public string AttrCurrLevelJobTitle;

[JsonProperty("CurrEntraRoleName")]
public string AttrCurrEntraRoleName;

[JsonProperty("AssignedOn")]
public String AttrAssignedOn;

public RESTST_1a18ac43e89b6e5649de540bf9caa846Structure() { }

public RESTST_1a18ac43e89b6e5649de540bf9caa846Structure (ST_1a18ac43e89b6e5649de540bf9caa846Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrOrderDate = ConvertDateToRestWithoutDefaults(s.ssOrderDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrOrderStatus = ConvertToRestWithoutDefaults(s.ssOrderStatus, "");
AttrRegion = ConvertToRestWithoutDefaults(s.ssRegion, "");
AttrSupplierName = ConvertToRestWithoutDefaults(s.ssSupplierName, "");
AttrSupplierNumber = ConvertToRestWithoutDefaults(s.ssSupplierNumber, "");
AttrFirstLevelUserName = ConvertToRestWithoutDefaults(s.ssFirstLevelUserName, "");
AttrFirstLevelEmail = ConvertToRestWithoutDefaults(s.ssFirstLevelEmail, "");
AttrFirstLevelJobTitle = ConvertToRestWithoutDefaults(s.ssFirstLevelJobTitle, "");
AttrFirstEntraRoleName = ConvertToRestWithoutDefaults(s.ssFirstEntraRoleName, "");
AttrCurrLevelUserName = ConvertToRestWithoutDefaults(s.ssCurrLevelUserName, "");
AttrCurrLevelEmail = ConvertToRestWithoutDefaults(s.ssCurrLevelEmail, "");
AttrCurrLevelJobTitle = ConvertToRestWithoutDefaults(s.ssCurrLevelJobTitle, "");
AttrCurrEntraRoleName = ConvertToRestWithoutDefaults(s.ssCurrEntraRoleName, "");
AttrAssignedOn = ConvertDateTimeToRestWithoutDefaults(s.ssAssignedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrOrderNumber = s.ssOrderNumber;
AttrOrderDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssOrderDate);
AttrOrderStatus = s.ssOrderStatus;
AttrRegion = s.ssRegion;
AttrSupplierName = s.ssSupplierName;
AttrSupplierNumber = s.ssSupplierNumber;
AttrFirstLevelUserName = s.ssFirstLevelUserName;
AttrFirstLevelEmail = s.ssFirstLevelEmail;
AttrFirstLevelJobTitle = s.ssFirstLevelJobTitle;
AttrFirstEntraRoleName = s.ssFirstEntraRoleName;
AttrCurrLevelUserName = s.ssCurrLevelUserName;
AttrCurrLevelEmail = s.ssCurrLevelEmail;
AttrCurrLevelJobTitle = s.ssCurrLevelJobTitle;
AttrCurrEntraRoleName = s.ssCurrEntraRoleName;
AttrAssignedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssAssignedOn, config.DateTimeFormat);
  }
}

public static ST_1a18ac43e89b6e5649de540bf9caa846Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_1a18ac43e89b6e5649de540bf9caa846Structure obj) { 
  ST_1a18ac43e89b6e5649de540bf9caa846Structure s = new ST_1a18ac43e89b6e5649de540bf9caa846Structure();
  if(obj != null) {
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssOrderDate = obj.AttrOrderDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrOrderDate);
  s.ssOrderStatus = obj.AttrOrderStatus == null ? "" : obj.AttrOrderStatus;
  s.ssRegion = obj.AttrRegion == null ? "" : obj.AttrRegion;
  s.ssSupplierName = obj.AttrSupplierName == null ? "" : obj.AttrSupplierName;
  s.ssSupplierNumber = obj.AttrSupplierNumber == null ? "" : obj.AttrSupplierNumber;
  s.ssFirstLevelUserName = obj.AttrFirstLevelUserName == null ? "" : obj.AttrFirstLevelUserName;
  s.ssFirstLevelEmail = obj.AttrFirstLevelEmail == null ? "" : obj.AttrFirstLevelEmail;
  s.ssFirstLevelJobTitle = obj.AttrFirstLevelJobTitle == null ? "" : obj.AttrFirstLevelJobTitle;
  s.ssFirstEntraRoleName = obj.AttrFirstEntraRoleName == null ? "" : obj.AttrFirstEntraRoleName;
  s.ssCurrLevelUserName = obj.AttrCurrLevelUserName == null ? "" : obj.AttrCurrLevelUserName;
  s.ssCurrLevelEmail = obj.AttrCurrLevelEmail == null ? "" : obj.AttrCurrLevelEmail;
  s.ssCurrLevelJobTitle = obj.AttrCurrLevelJobTitle == null ? "" : obj.AttrCurrLevelJobTitle;
  s.ssCurrEntraRoleName = obj.AttrCurrEntraRoleName == null ? "" : obj.AttrCurrEntraRoleName;
  s.ssAssignedOn = obj.AttrAssignedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrAssignedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<ST_1a18ac43e89b6e5649de540bf9caa846Structure, ssConectaProveedores.RestRecords.RESTST_1a18ac43e89b6e5649de540bf9caa846Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1a18ac43e89b6e5649de540bf9caa846Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_1a18ac43e89b6e5649de540bf9caa846Structure FromStructure(ST_1a18ac43e89b6e5649de540bf9caa846Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_1a18ac43e89b6e5649de540bf9caa846Structure(s, config);
}

}


