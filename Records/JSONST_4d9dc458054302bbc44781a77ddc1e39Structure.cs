using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LinesReport63
public class JSONST_4d9dc458054302bbc44781a77ddc1e39Structure : AbstractRESTStructure<ST_4d9dc458054302bbc44781a77ddc1e39Structure> {
[JsonProperty("OrderNumber")]
[JsonPropertyName("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public string AttrCreatedOn;

[JsonProperty("SupplierNumber")]
[JsonPropertyName("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("SupplierName")]
[JsonPropertyName("SupplierName")]
public string AttrSupplierName;

[JsonProperty("IsDeleted")]
[JsonPropertyName("IsDeleted")]
public string AttrIsDeleted;

[JsonProperty("IsReleased")]
[JsonPropertyName("IsReleased")]
public string AttrIsReleased;

[JsonProperty("isFinalDelivery")]
[JsonPropertyName("isFinalDelivery")]
public string AttrisFinalDelivery;

[JsonProperty("Applicant")]
[JsonPropertyName("Applicant")]
public string AttrApplicant;

[JsonProperty("AssignmentCode")]
[JsonPropertyName("AssignmentCode")]
public string AttrAssignmentCode;

[JsonProperty("Sociedad")]
[JsonPropertyName("Sociedad")]
public string AttrSociedad;

[JsonProperty("Position")]
[JsonPropertyName("Position")]
public int? AttrPosition;

[JsonProperty("MaterialCode")]
[JsonPropertyName("MaterialCode")]
public string AttrMaterialCode;

[JsonProperty("MaterialDescription")]
[JsonPropertyName("MaterialDescription")]
public string AttrMaterialDescription;

[JsonProperty("Quantity")]
[JsonPropertyName("Quantity")]
public string AttrQuantity;

[JsonProperty("QuantityDelivered")]
[JsonPropertyName("QuantityDelivered")]
public string AttrQuantityDelivered;

[JsonProperty("QuantityAvailable")]
[JsonPropertyName("QuantityAvailable")]
public string AttrQuantityAvailable;

[JsonProperty("UnitPrice")]
[JsonPropertyName("UnitPrice")]
public string AttrUnitPrice;

[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public string AttrCurrency;

[JsonProperty("Total")]
[JsonPropertyName("Total")]
public string AttrTotal;

[JsonProperty("DeliveryStatus")]
[JsonPropertyName("DeliveryStatus")]
public string AttrDeliveryStatus;

[JsonProperty("OrderStatus")]
[JsonPropertyName("OrderStatus")]
public string AttrOrderStatus;

[JsonProperty("User")]
[JsonPropertyName("User")]
public string AttrUser;

[JsonProperty("UserJobTitle")]
[JsonPropertyName("UserJobTitle")]
public string AttrUserJobTitle;

public JSONST_4d9dc458054302bbc44781a77ddc1e39Structure() { }

public JSONST_4d9dc458054302bbc44781a77ddc1e39Structure (ST_4d9dc458054302bbc44781a77ddc1e39Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrCreatedOn = s.ssCreatedOn;
AttrSupplierNumber = ConvertToRestWithoutDefaults(s.ssSupplierNumber, "");
AttrSupplierName = ConvertToRestWithoutDefaults(s.ssSupplierName, "");
AttrIsDeleted = ConvertToRestWithoutDefaults(s.ssIsDeleted, "");
AttrIsReleased = ConvertToRestWithoutDefaults(s.ssIsReleased, "");
AttrisFinalDelivery = ConvertToRestWithoutDefaults(s.ssisFinalDelivery, "");
AttrApplicant = ConvertToRestWithoutDefaults(s.ssApplicant, "");
AttrAssignmentCode = ConvertToRestWithoutDefaults(s.ssAssignmentCode, "");
AttrSociedad = ConvertToRestWithoutDefaults(s.ssSociedad, "");
AttrPosition = ConvertToRestWithoutDefaults(s.ssPosition, 0);
AttrMaterialCode = ConvertToRestWithoutDefaults(s.ssMaterialCode, "");
AttrMaterialDescription = ConvertToRestWithoutDefaults(s.ssMaterialDescription, "");
AttrQuantity = ConvertToRestWithoutDefaults(s.ssQuantity, "");
AttrQuantityDelivered = ConvertToRestWithoutDefaults(s.ssQuantityDelivered, "");
AttrQuantityAvailable = ConvertToRestWithoutDefaults(s.ssQuantityAvailable, "");
AttrUnitPrice = ConvertToRestWithoutDefaults(s.ssUnitPrice, "");
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
AttrTotal = ConvertToRestWithoutDefaults(s.ssTotal, "");
AttrDeliveryStatus = ConvertToRestWithoutDefaults(s.ssDeliveryStatus, "");
AttrOrderStatus = ConvertToRestWithoutDefaults(s.ssOrderStatus, "");
AttrUser = ConvertToRestWithoutDefaults(s.ssUser, "");
AttrUserJobTitle = ConvertToRestWithoutDefaults(s.ssUserJobTitle, "");
  } else {
AttrOrderNumber = s.ssOrderNumber;
AttrCreatedOn = s.ssCreatedOn;
AttrSupplierNumber = s.ssSupplierNumber;
AttrSupplierName = s.ssSupplierName;
AttrIsDeleted = s.ssIsDeleted;
AttrIsReleased = s.ssIsReleased;
AttrisFinalDelivery = s.ssisFinalDelivery;
AttrApplicant = s.ssApplicant;
AttrAssignmentCode = s.ssAssignmentCode;
AttrSociedad = s.ssSociedad;
AttrPosition = (int?) s.ssPosition;
AttrMaterialCode = s.ssMaterialCode;
AttrMaterialDescription = s.ssMaterialDescription;
AttrQuantity = s.ssQuantity;
AttrQuantityDelivered = s.ssQuantityDelivered;
AttrQuantityAvailable = s.ssQuantityAvailable;
AttrUnitPrice = s.ssUnitPrice;
AttrCurrency = s.ssCurrency;
AttrTotal = s.ssTotal;
AttrDeliveryStatus = s.ssDeliveryStatus;
AttrOrderStatus = s.ssOrderStatus;
AttrUser = s.ssUser;
AttrUserJobTitle = s.ssUserJobTitle;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_4d9dc458054302bbc44781a77ddc1e39Structure, ST_4d9dc458054302bbc44781a77ddc1e39Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_4d9dc458054302bbc44781a77ddc1e39Structure s) => ToStructure(s, config);
}
public static ST_4d9dc458054302bbc44781a77ddc1e39Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_4d9dc458054302bbc44781a77ddc1e39Structure obj, IBehaviorsConfiguration config) { 
  ST_4d9dc458054302bbc44781a77ddc1e39Structure s = new ST_4d9dc458054302bbc44781a77ddc1e39Structure();
  if(obj != null) {
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? "" : obj.AttrCreatedOn;
  s.ssSupplierNumber = obj.AttrSupplierNumber == null ? "" : obj.AttrSupplierNumber;
  s.ssSupplierName = obj.AttrSupplierName == null ? "" : obj.AttrSupplierName;
  s.ssIsDeleted = obj.AttrIsDeleted == null ? "" : obj.AttrIsDeleted;
  s.ssIsReleased = obj.AttrIsReleased == null ? "" : obj.AttrIsReleased;
  s.ssisFinalDelivery = obj.AttrisFinalDelivery == null ? "" : obj.AttrisFinalDelivery;
  s.ssApplicant = obj.AttrApplicant == null ? "" : obj.AttrApplicant;
  s.ssAssignmentCode = obj.AttrAssignmentCode == null ? "" : obj.AttrAssignmentCode;
  s.ssSociedad = obj.AttrSociedad == null ? "" : obj.AttrSociedad;
  s.ssPosition = obj.AttrPosition == null ? 0 : obj.AttrPosition.Value;
  s.ssMaterialCode = obj.AttrMaterialCode == null ? "" : obj.AttrMaterialCode;
  s.ssMaterialDescription = obj.AttrMaterialDescription == null ? "" : obj.AttrMaterialDescription;
  s.ssQuantity = obj.AttrQuantity == null ? "" : obj.AttrQuantity;
  s.ssQuantityDelivered = obj.AttrQuantityDelivered == null ? "" : obj.AttrQuantityDelivered;
  s.ssQuantityAvailable = obj.AttrQuantityAvailable == null ? "" : obj.AttrQuantityAvailable;
  s.ssUnitPrice = obj.AttrUnitPrice == null ? "" : obj.AttrUnitPrice;
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  s.ssTotal = obj.AttrTotal == null ? "" : obj.AttrTotal;
  s.ssDeliveryStatus = obj.AttrDeliveryStatus == null ? "" : obj.AttrDeliveryStatus;
  s.ssOrderStatus = obj.AttrOrderStatus == null ? "" : obj.AttrOrderStatus;
  s.ssUser = obj.AttrUser == null ? "" : obj.AttrUser;
  s.ssUserJobTitle = obj.AttrUserJobTitle == null ? "" : obj.AttrUserJobTitle;
  }
  return s;
}

public static Func<ST_4d9dc458054302bbc44781a77ddc1e39Structure, ssConectaProveedores.RestRecords.JSONST_4d9dc458054302bbc44781a77ddc1e39Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_4d9dc458054302bbc44781a77ddc1e39Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_4d9dc458054302bbc44781a77ddc1e39Structure FromStructure(ST_4d9dc458054302bbc44781a77ddc1e39Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_4d9dc458054302bbc44781a77ddc1e39Structure(s, config);
}

}


