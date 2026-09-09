using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioItem
public class JSONST_1bddfac19e9b0cef65924aa7568fd106Structure : AbstractRESTStructure<ST_1bddfac19e9b0cef65924aa7568fd106Structure> {
[JsonProperty("Select")]
[JsonPropertyName("Select")]
public bool? AttrSelect;

[JsonProperty("OrderMainItemId")]
[JsonPropertyName("OrderMainItemId")]
public long? AttrOrderMainItemId;

[JsonProperty("OrderNumber")]
[JsonPropertyName("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("Position")]
[JsonPropertyName("Position")]
public string AttrPosition;

[JsonProperty("MaterialCode")]
[JsonPropertyName("MaterialCode")]
public string AttrMaterialCode;

[JsonProperty("MaterialDescription")]
[JsonPropertyName("MaterialDescription")]
public string AttrMaterialDescription;

[JsonProperty("Quantity")]
[JsonPropertyName("Quantity")]
public decimal? AttrQuantity;

[JsonProperty("QuantityDelivered")]
[JsonPropertyName("QuantityDelivered")]
public decimal? AttrQuantityDelivered;

[JsonProperty("QuantityAvailable")]
[JsonPropertyName("QuantityAvailable")]
public decimal? AttrQuantityAvailable;

[JsonProperty("OrderUnitOfMeasure")]
[JsonPropertyName("OrderUnitOfMeasure")]
public string AttrOrderUnitOfMeasure;

[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public string AttrCurrency;

[JsonProperty("TotalAmount")]
[JsonPropertyName("TotalAmount")]
public decimal? AttrTotalAmount;

[JsonProperty("Status")]
[JsonPropertyName("Status")]
public string AttrStatus;

[JsonProperty("StatusClass")]
[JsonPropertyName("StatusClass")]
public string AttrStatusClass;

[JsonProperty("DeliveryDate")]
[JsonPropertyName("DeliveryDate")]
public String AttrDeliveryDate;

[JsonProperty("UnitPrice")]
[JsonPropertyName("UnitPrice")]
public decimal? AttrUnitPrice;

[JsonProperty("AssigmentCode")]
[JsonPropertyName("AssigmentCode")]
public string AttrAssigmentCode;

[JsonProperty("VATRate")]
[JsonPropertyName("VATRate")]
public decimal? AttrVATRate;

[JsonProperty("ImportDelivered")]
[JsonPropertyName("ImportDelivered")]
public decimal? AttrImportDelivered;

[JsonProperty("IsDeleted")]
[JsonPropertyName("IsDeleted")]
public bool? AttrIsDeleted;

[JsonProperty("IsBlocked")]
[JsonPropertyName("IsBlocked")]
public bool? AttrIsBlocked;

[JsonProperty("BaseQuantity")]
[JsonPropertyName("BaseQuantity")]
public int? AttrBaseQuantity;

[JsonProperty("IsFinalDelivered")]
[JsonPropertyName("IsFinalDelivered")]
public bool? AttrIsFinalDelivered;

[JsonProperty("PEP")]
[JsonPropertyName("PEP")]
public string AttrPEP;

[JsonProperty("IsMultipleImputation")]
[JsonPropertyName("IsMultipleImputation")]
public bool? AttrIsMultipleImputation;

public JSONST_1bddfac19e9b0cef65924aa7568fd106Structure() { }

public JSONST_1bddfac19e9b0cef65924aa7568fd106Structure (ST_1bddfac19e9b0cef65924aa7568fd106Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSelect = ConvertToRestWithoutDefaults(s.ssSelect, false);
AttrOrderMainItemId = ConvertToRestWithoutDefaults(s.ssOrderMainItemId, 0L);
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrPosition = ConvertToRestWithoutDefaults(s.ssPosition, "");
AttrMaterialCode = ConvertToRestWithoutDefaults(s.ssMaterialCode, "");
AttrMaterialDescription = ConvertToRestWithoutDefaults(s.ssMaterialDescription, "");
AttrQuantity = ConvertToRestWithoutDefaults(s.ssQuantity, 0.0M);
AttrQuantityDelivered = ConvertToRestWithoutDefaults(s.ssQuantityDelivered, 0.0M);
AttrQuantityAvailable = ConvertToRestWithoutDefaults(s.ssQuantityAvailable, 0.0M);
AttrOrderUnitOfMeasure = ConvertToRestWithoutDefaults(s.ssOrderUnitOfMeasure, "");
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, 0.0M);
AttrStatus = ConvertToRestWithoutDefaults(s.ssStatus, "");
AttrStatusClass = ConvertToRestWithoutDefaults(s.ssStatusClass, "");
AttrDeliveryDate = ConvertDateToRestWithoutDefaults(s.ssDeliveryDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrUnitPrice = ConvertToRestWithoutDefaults(s.ssUnitPrice, 0.0M);
AttrAssigmentCode = ConvertToRestWithoutDefaults(s.ssAssigmentCode, "");
AttrVATRate = ConvertToRestWithoutDefaults(s.ssVATRate, 0.0M);
AttrImportDelivered = ConvertToRestWithoutDefaults(s.ssImportDelivered, 0.0M);
AttrIsDeleted = ConvertToRestWithoutDefaults(s.ssIsDeleted, false);
AttrIsBlocked = ConvertToRestWithoutDefaults(s.ssIsBlocked, false);
AttrBaseQuantity = ConvertToRestWithoutDefaults(s.ssBaseQuantity, 0);
AttrIsFinalDelivered = ConvertToRestWithoutDefaults(s.ssIsFinalDelivered, false);
AttrPEP = ConvertToRestWithoutDefaults(s.ssPEP, "");
AttrIsMultipleImputation = ConvertToRestWithoutDefaults(s.ssIsMultipleImputation, false);
  } else {
AttrSelect = (bool?) s.ssSelect;
AttrOrderMainItemId = (long?) s.ssOrderMainItemId;
AttrOrderNumber = s.ssOrderNumber;
AttrPosition = s.ssPosition;
AttrMaterialCode = s.ssMaterialCode;
AttrMaterialDescription = s.ssMaterialDescription;
AttrQuantity = (decimal?) s.ssQuantity;
AttrQuantityDelivered = (decimal?) s.ssQuantityDelivered;
AttrQuantityAvailable = (decimal?) s.ssQuantityAvailable;
AttrOrderUnitOfMeasure = s.ssOrderUnitOfMeasure;
AttrCurrency = s.ssCurrency;
AttrTotalAmount = (decimal?) s.ssTotalAmount;
AttrStatus = s.ssStatus;
AttrStatusClass = s.ssStatusClass;
AttrDeliveryDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssDeliveryDate);
AttrUnitPrice = (decimal?) s.ssUnitPrice;
AttrAssigmentCode = s.ssAssigmentCode;
AttrVATRate = (decimal?) s.ssVATRate;
AttrImportDelivered = (decimal?) s.ssImportDelivered;
AttrIsDeleted = (bool?) s.ssIsDeleted;
AttrIsBlocked = (bool?) s.ssIsBlocked;
AttrBaseQuantity = (int?) s.ssBaseQuantity;
AttrIsFinalDelivered = (bool?) s.ssIsFinalDelivered;
AttrPEP = s.ssPEP;
AttrIsMultipleImputation = (bool?) s.ssIsMultipleImputation;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_1bddfac19e9b0cef65924aa7568fd106Structure, ST_1bddfac19e9b0cef65924aa7568fd106Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_1bddfac19e9b0cef65924aa7568fd106Structure s) => ToStructure(s, config);
}
public static ST_1bddfac19e9b0cef65924aa7568fd106Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_1bddfac19e9b0cef65924aa7568fd106Structure obj, IBehaviorsConfiguration config) { 
  ST_1bddfac19e9b0cef65924aa7568fd106Structure s = new ST_1bddfac19e9b0cef65924aa7568fd106Structure();
  if(obj != null) {
  s.ssSelect = obj.AttrSelect == null ? false : obj.AttrSelect.Value;
  s.ssOrderMainItemId = obj.AttrOrderMainItemId == null ? 0L : obj.AttrOrderMainItemId.Value;
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssPosition = obj.AttrPosition == null ? "" : obj.AttrPosition;
  s.ssMaterialCode = obj.AttrMaterialCode == null ? "" : obj.AttrMaterialCode;
  s.ssMaterialDescription = obj.AttrMaterialDescription == null ? "" : obj.AttrMaterialDescription;
  s.ssQuantity = obj.AttrQuantity == null ? 0.0M : obj.AttrQuantity.Value;
  s.ssQuantityDelivered = obj.AttrQuantityDelivered == null ? 0.0M : obj.AttrQuantityDelivered.Value;
  s.ssQuantityAvailable = obj.AttrQuantityAvailable == null ? 0.0M : obj.AttrQuantityAvailable.Value;
  s.ssOrderUnitOfMeasure = obj.AttrOrderUnitOfMeasure == null ? "" : obj.AttrOrderUnitOfMeasure;
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? 0.0M : obj.AttrTotalAmount.Value;
  s.ssStatus = obj.AttrStatus == null ? "" : obj.AttrStatus;
  s.ssStatusClass = obj.AttrStatusClass == null ? "" : obj.AttrStatusClass;
  s.ssDeliveryDate = obj.AttrDeliveryDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrDeliveryDate);
  s.ssUnitPrice = obj.AttrUnitPrice == null ? 0.0M : obj.AttrUnitPrice.Value;
  s.ssAssigmentCode = obj.AttrAssigmentCode == null ? "" : obj.AttrAssigmentCode;
  s.ssVATRate = obj.AttrVATRate == null ? 0.0M : obj.AttrVATRate.Value;
  s.ssImportDelivered = obj.AttrImportDelivered == null ? 0.0M : obj.AttrImportDelivered.Value;
  s.ssIsDeleted = obj.AttrIsDeleted == null ? false : obj.AttrIsDeleted.Value;
  s.ssIsBlocked = obj.AttrIsBlocked == null ? false : obj.AttrIsBlocked.Value;
  s.ssBaseQuantity = obj.AttrBaseQuantity == null ? 0 : obj.AttrBaseQuantity.Value;
  s.ssIsFinalDelivered = obj.AttrIsFinalDelivered == null ? false : obj.AttrIsFinalDelivered.Value;
  s.ssPEP = obj.AttrPEP == null ? "" : obj.AttrPEP;
  s.ssIsMultipleImputation = obj.AttrIsMultipleImputation == null ? false : obj.AttrIsMultipleImputation.Value;
  }
  return s;
}

public static Func<ST_1bddfac19e9b0cef65924aa7568fd106Structure, ssConectaProveedores.RestRecords.JSONST_1bddfac19e9b0cef65924aa7568fd106Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1bddfac19e9b0cef65924aa7568fd106Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_1bddfac19e9b0cef65924aa7568fd106Structure FromStructure(ST_1bddfac19e9b0cef65924aa7568fd106Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_1bddfac19e9b0cef65924aa7568fd106Structure(s, config);
}

}


