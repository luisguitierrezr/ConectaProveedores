using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Order
public class JSONST_1a18ac43e89b6e5649de540bf9caa846Structure : AbstractRESTStructure<ST_1a18ac43e89b6e5649de540bf9caa846Structure> {
[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public string AttrOrderNumber;

[JsonProperty("Fecha")]
[JsonPropertyName("Fecha")]
public String AttrOrderDate;

[JsonProperty("Estado")]
[JsonPropertyName("Estado")]
public string AttrOrderStatus;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public string AttrRegion;

[JsonProperty("Proveedor")]
[JsonPropertyName("Proveedor")]
public string AttrSupplierName;

[JsonProperty("NumeroProveedor")]
[JsonPropertyName("NumeroProveedor")]
public string AttrSupplierNumber;

[JsonProperty("Responsable")]
[JsonPropertyName("Responsable")]
public string AttrFirstLevelUserName;

[JsonProperty("Responsable_Correo")]
[JsonPropertyName("Responsable_Correo")]
public string AttrFirstLevelEmail;

[JsonProperty("Responsable_Puesto")]
[JsonPropertyName("Responsable_Puesto")]
public string AttrFirstLevelJobTitle;

[JsonProperty("Responsable_PuestoEntra")]
[JsonPropertyName("Responsable_PuestoEntra")]
public string AttrFirstEntraRoleName;

[JsonProperty("AsignadoActual")]
[JsonPropertyName("AsignadoActual")]
public string AttrCurrLevelUserName;

[JsonProperty("AsignadoActual_Correo")]
[JsonPropertyName("AsignadoActual_Correo")]
public string AttrCurrLevelEmail;

[JsonProperty("AsignadoActual_Puesto")]
[JsonPropertyName("AsignadoActual_Puesto")]
public string AttrCurrLevelJobTitle;

[JsonProperty("AsignadoActual_PuestoEntra")]
[JsonPropertyName("AsignadoActual_PuestoEntra")]
public string AttrCurrEntraRoleName;

[JsonProperty("FechaAsignacion")]
[JsonPropertyName("FechaAsignacion")]
public String AttrAssignedOn;

public JSONST_1a18ac43e89b6e5649de540bf9caa846Structure() { }

public JSONST_1a18ac43e89b6e5649de540bf9caa846Structure (ST_1a18ac43e89b6e5649de540bf9caa846Structure s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONST_1a18ac43e89b6e5649de540bf9caa846Structure, ST_1a18ac43e89b6e5649de540bf9caa846Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_1a18ac43e89b6e5649de540bf9caa846Structure s) => ToStructure(s, config);
}
public static ST_1a18ac43e89b6e5649de540bf9caa846Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_1a18ac43e89b6e5649de540bf9caa846Structure obj, IBehaviorsConfiguration config) { 
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
  s.ssAssignedOn = obj.AttrAssignedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrAssignedOn, config.DateTimeFormat);
  }
  return s;
}

public static Func<ST_1a18ac43e89b6e5649de540bf9caa846Structure, ssConectaProveedores.RestRecords.JSONST_1a18ac43e89b6e5649de540bf9caa846Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1a18ac43e89b6e5649de540bf9caa846Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_1a18ac43e89b6e5649de540bf9caa846Structure FromStructure(ST_1a18ac43e89b6e5649de540bf9caa846Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_1a18ac43e89b6e5649de540bf9caa846Structure(s, config);
}

}


