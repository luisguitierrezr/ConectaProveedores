using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioQ
public class JSONST_118fe20454dd0bf1f0e6d925e7d7544bStructure : AbstractRESTStructure<ST_118fe20454dd0bf1f0e6d925e7d7544bStructure> {
[JsonProperty("Number")]
[JsonPropertyName("Number")]
public int? AttrNumber;

[JsonProperty("OrderNumber")]
[JsonPropertyName("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("OrderMainItem")]
[JsonPropertyName("OrderMainItem")]
public long? AttrOrderMainItem;

[JsonProperty("Position")]
[JsonPropertyName("Position")]
public int? AttrPosition;

[JsonProperty("DeliveryDate")]
[JsonPropertyName("DeliveryDate")]
public string AttrDeliveryDate;

[JsonProperty("InvoiceQuantity")]
[JsonPropertyName("InvoiceQuantity")]
public decimal? AttrInvoiceQuantity;

[JsonProperty("WaitingQuantity")]
[JsonPropertyName("WaitingQuantity")]
public decimal? AttrWaitingQuantity;

[JsonProperty("DeliveredQuantity")]
[JsonPropertyName("DeliveredQuantity")]
public int? AttrDeliveredQuantity;

[JsonProperty("Quantity")]
[JsonPropertyName("Quantity")]
public decimal? AttrQuantity;

[JsonProperty("UserEmail")]
[JsonPropertyName("UserEmail")]
public string AttrUserEmail;

[JsonProperty("InvoiceFilenamePdf")]
[JsonPropertyName("InvoiceFilenamePdf")]
public string AttrInvoiceFilenamePdf;

[JsonProperty("InvoiceFilenameXml")]
[JsonPropertyName("InvoiceFilenameXml")]
public string AttrInvoiceFilenameXml;

[JsonProperty("IsValidInvoiceFilenamePdf")]
[JsonPropertyName("IsValidInvoiceFilenamePdf")]
public bool? AttrIsValidInvoiceFilenamePdf;

[JsonProperty("IsValidInvoiceFilenameXml")]
[JsonPropertyName("IsValidInvoiceFilenameXml")]
public bool? AttrIsValidInvoiceFilenameXml;

[JsonProperty("PEP")]
[JsonPropertyName("PEP")]
public string AttrPEP;

[JsonProperty("PlaceId")]
[JsonPropertyName("PlaceId")]
public string AttrPlaceId;

[JsonProperty("PlaceName")]
[JsonPropertyName("PlaceName")]
public string AttrPlaceName;

[JsonProperty("MaterialCode")]
[JsonPropertyName("MaterialCode")]
public string AttrMaterialCode;

[JsonProperty("MaterialDescription")]
[JsonPropertyName("MaterialDescription")]
public string AttrMaterialDescription;

[JsonProperty("AssigmentCode")]
[JsonPropertyName("AssigmentCode")]
public string AttrAssigmentCode;

[JsonProperty("UnitPrice")]
[JsonPropertyName("UnitPrice")]
public decimal? AttrUnitPrice;

[JsonProperty("AmountDelivered")]
[JsonPropertyName("AmountDelivered")]
public decimal? AttrAmountDelivered;

[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public string AttrCurrency;

[JsonProperty("FolioQFilesList")]
[JsonPropertyName("FolioQFilesList")]
public ssConectaProveedores.RestRecords.JSONST_b9bc0a93e29018653085b5de5dd1951eStructure[] AttrFolioQFilesList;

[JsonProperty("WithError")]
[JsonPropertyName("WithError")]
public bool? AttrWithError;

[JsonProperty("Message")]
[JsonPropertyName("Message")]
public string AttrMessage;

[JsonProperty("BaseQuantity")]
[JsonPropertyName("BaseQuantity")]
public int? AttrBaseQuantity;

[JsonProperty("VATRate")]
[JsonPropertyName("VATRate")]
public decimal? AttrVATRate;

public JSONST_118fe20454dd0bf1f0e6d925e7d7544bStructure() { }

public JSONST_118fe20454dd0bf1f0e6d925e7d7544bStructure (ST_118fe20454dd0bf1f0e6d925e7d7544bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNumber = ConvertToRestWithoutDefaults(s.ssNumber, 0);
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssOrderMainItem, 0L);
AttrPosition = ConvertToRestWithoutDefaults(s.ssPosition, 0);
AttrDeliveryDate = ConvertToRestWithoutDefaults(s.ssDeliveryDate, "");
AttrInvoiceQuantity = ConvertToRestWithoutDefaults(s.ssInvoiceQuantity, 0.0M);
AttrWaitingQuantity = ConvertToRestWithoutDefaults(s.ssWaitingQuantity, 0.0M);
AttrDeliveredQuantity = ConvertToRestWithoutDefaults(s.ssDeliveredQuantity, 0);
AttrQuantity = ConvertToRestWithoutDefaults(s.ssQuantity, 0.0M);
AttrUserEmail = ConvertToRestWithoutDefaults(s.ssUserEmail, "");
AttrInvoiceFilenamePdf = ConvertToRestWithoutDefaults(s.ssInvoiceFilenamePdf, "");
AttrInvoiceFilenameXml = ConvertToRestWithoutDefaults(s.ssInvoiceFilenameXml, "");
AttrIsValidInvoiceFilenamePdf = ConvertToRestWithoutDefaults(s.ssIsValidInvoiceFilenamePdf, false);
AttrIsValidInvoiceFilenameXml = ConvertToRestWithoutDefaults(s.ssIsValidInvoiceFilenameXml, false);
AttrPEP = ConvertToRestWithoutDefaults(s.ssPEP, "");
AttrPlaceId = ConvertToRestWithoutDefaults(s.ssPlaceId, "");
AttrPlaceName = ConvertToRestWithoutDefaults(s.ssPlaceName, "");
AttrMaterialCode = ConvertToRestWithoutDefaults(s.ssMaterialCode, "");
AttrMaterialDescription = ConvertToRestWithoutDefaults(s.ssMaterialDescription, "");
AttrAssigmentCode = ConvertToRestWithoutDefaults(s.ssAssigmentCode, "");
AttrUnitPrice = ConvertToRestWithoutDefaults(s.ssUnitPrice, 0.0M);
AttrAmountDelivered = ConvertToRestWithoutDefaults(s.ssAmountDelivered, 0.0M);
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
AttrFolioQFilesList = s.ssFolioQFilesList.Length == 0 ? null : s.ssFolioQFilesList.ToArray<ssConectaProveedores.RestRecords.JSONST_b9bc0a93e29018653085b5de5dd1951eStructure>(ssConectaProveedores.RestRecords.JSONST_b9bc0a93e29018653085b5de5dd1951eStructure.FromStructureDelegate(config));
AttrWithError = ConvertToRestWithoutDefaults(s.ssWithError, false);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
AttrBaseQuantity = ConvertToRestWithoutDefaults(s.ssBaseQuantity, 0);
AttrVATRate = ConvertToRestWithoutDefaults(s.ssVATRate, 0.0M);
  } else {
AttrNumber = (int?) s.ssNumber;
AttrOrderNumber = s.ssOrderNumber;
AttrOrderMainItem = (long?) s.ssOrderMainItem;
AttrPosition = (int?) s.ssPosition;
AttrDeliveryDate = s.ssDeliveryDate;
AttrInvoiceQuantity = (decimal?) s.ssInvoiceQuantity;
AttrWaitingQuantity = (decimal?) s.ssWaitingQuantity;
AttrDeliveredQuantity = (int?) s.ssDeliveredQuantity;
AttrQuantity = (decimal?) s.ssQuantity;
AttrUserEmail = s.ssUserEmail;
AttrInvoiceFilenamePdf = s.ssInvoiceFilenamePdf;
AttrInvoiceFilenameXml = s.ssInvoiceFilenameXml;
AttrIsValidInvoiceFilenamePdf = (bool?) s.ssIsValidInvoiceFilenamePdf;
AttrIsValidInvoiceFilenameXml = (bool?) s.ssIsValidInvoiceFilenameXml;
AttrPEP = s.ssPEP;
AttrPlaceId = s.ssPlaceId;
AttrPlaceName = s.ssPlaceName;
AttrMaterialCode = s.ssMaterialCode;
AttrMaterialDescription = s.ssMaterialDescription;
AttrAssigmentCode = s.ssAssigmentCode;
AttrUnitPrice = (decimal?) s.ssUnitPrice;
AttrAmountDelivered = (decimal?) s.ssAmountDelivered;
AttrCurrency = s.ssCurrency;
AttrFolioQFilesList = s.ssFolioQFilesList.ToArray<ssConectaProveedores.RestRecords.JSONST_b9bc0a93e29018653085b5de5dd1951eStructure>(ssConectaProveedores.RestRecords.JSONST_b9bc0a93e29018653085b5de5dd1951eStructure.FromStructureDelegate(config));
AttrWithError = (bool?) s.ssWithError;
AttrMessage = s.ssMessage;
AttrBaseQuantity = (int?) s.ssBaseQuantity;
AttrVATRate = (decimal?) s.ssVATRate;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_118fe20454dd0bf1f0e6d925e7d7544bStructure, ST_118fe20454dd0bf1f0e6d925e7d7544bStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_118fe20454dd0bf1f0e6d925e7d7544bStructure s) => ToStructure(s, config);
}
public static ST_118fe20454dd0bf1f0e6d925e7d7544bStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_118fe20454dd0bf1f0e6d925e7d7544bStructure obj, IBehaviorsConfiguration config) { 
  ST_118fe20454dd0bf1f0e6d925e7d7544bStructure s = new ST_118fe20454dd0bf1f0e6d925e7d7544bStructure();
  if(obj != null) {
  s.ssNumber = obj.AttrNumber == null ? 0 : obj.AttrNumber.Value;
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssOrderMainItem = obj.AttrOrderMainItem == null ? 0L : obj.AttrOrderMainItem.Value;
  s.ssPosition = obj.AttrPosition == null ? 0 : obj.AttrPosition.Value;
  s.ssDeliveryDate = obj.AttrDeliveryDate == null ? "" : obj.AttrDeliveryDate;
  s.ssInvoiceQuantity = obj.AttrInvoiceQuantity == null ? 0.0M : obj.AttrInvoiceQuantity.Value;
  s.ssWaitingQuantity = obj.AttrWaitingQuantity == null ? 0.0M : obj.AttrWaitingQuantity.Value;
  s.ssDeliveredQuantity = obj.AttrDeliveredQuantity == null ? 0 : obj.AttrDeliveredQuantity.Value;
  s.ssQuantity = obj.AttrQuantity == null ? 0.0M : obj.AttrQuantity.Value;
  s.ssUserEmail = obj.AttrUserEmail == null ? "" : obj.AttrUserEmail;
  s.ssInvoiceFilenamePdf = obj.AttrInvoiceFilenamePdf == null ? "" : obj.AttrInvoiceFilenamePdf;
  s.ssInvoiceFilenameXml = obj.AttrInvoiceFilenameXml == null ? "" : obj.AttrInvoiceFilenameXml;
  s.ssIsValidInvoiceFilenamePdf = obj.AttrIsValidInvoiceFilenamePdf == null ? false : obj.AttrIsValidInvoiceFilenamePdf.Value;
  s.ssIsValidInvoiceFilenameXml = obj.AttrIsValidInvoiceFilenameXml == null ? false : obj.AttrIsValidInvoiceFilenameXml.Value;
  s.ssPEP = obj.AttrPEP == null ? "" : obj.AttrPEP;
  s.ssPlaceId = obj.AttrPlaceId == null ? "" : obj.AttrPlaceId;
  s.ssPlaceName = obj.AttrPlaceName == null ? "" : obj.AttrPlaceName;
  s.ssMaterialCode = obj.AttrMaterialCode == null ? "" : obj.AttrMaterialCode;
  s.ssMaterialDescription = obj.AttrMaterialDescription == null ? "" : obj.AttrMaterialDescription;
  s.ssAssigmentCode = obj.AttrAssigmentCode == null ? "" : obj.AttrAssigmentCode;
  s.ssUnitPrice = obj.AttrUnitPrice == null ? 0.0M : obj.AttrUnitPrice.Value;
  s.ssAmountDelivered = obj.AttrAmountDelivered == null ? 0.0M : obj.AttrAmountDelivered.Value;
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  s.ssFolioQFilesList = RL_d6af4e3a9c01393365c1248e2444fa63.ToList(obj.AttrFolioQFilesList, ssConectaProveedores.RestRecords.JSONST_b9bc0a93e29018653085b5de5dd1951eStructure.ToStructureDelegate(config));
  s.ssWithError = obj.AttrWithError == null ? false : obj.AttrWithError.Value;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssBaseQuantity = obj.AttrBaseQuantity == null ? 0 : obj.AttrBaseQuantity.Value;
  s.ssVATRate = obj.AttrVATRate == null ? 0.0M : obj.AttrVATRate.Value;
  }
  return s;
}

public static Func<ST_118fe20454dd0bf1f0e6d925e7d7544bStructure, ssConectaProveedores.RestRecords.JSONST_118fe20454dd0bf1f0e6d925e7d7544bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_118fe20454dd0bf1f0e6d925e7d7544bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_118fe20454dd0bf1f0e6d925e7d7544bStructure FromStructure(ST_118fe20454dd0bf1f0e6d925e7d7544bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_118fe20454dd0bf1f0e6d925e7d7544bStructure(s, config);
}

}


