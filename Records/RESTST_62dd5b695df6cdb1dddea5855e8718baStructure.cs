using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioDetailInfo
public class RESTST_62dd5b695df6cdb1dddea5855e8718baStructure : AbstractRESTStructure<ST_62dd5b695df6cdb1dddea5855e8718baStructure> {
[JsonProperty("SupplierName")]
public string AttrSupplierName;

[JsonProperty("SupplierRFC")]
public string AttrSupplierRFC;

[JsonProperty("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("SupplierRegion")]
public string AttrSupplierRegion;

[JsonProperty("CompanyName")]
public string AttrCompanyName;

[JsonProperty("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("CurrencyCode")]
public string AttrCurrencyCode;

[JsonProperty("CurrencyText")]
public string AttrCurrencyText;

[JsonProperty("CreationDays")]
public int? AttrCreationDays;

[JsonProperty("TotalAmount")]
public decimal? AttrTotalAmount;

[JsonProperty("Flux")]
public string AttrFlux;

[JsonProperty("FluxType")]
public string AttrFluxType;

public RESTST_62dd5b695df6cdb1dddea5855e8718baStructure() { }

public RESTST_62dd5b695df6cdb1dddea5855e8718baStructure (ST_62dd5b695df6cdb1dddea5855e8718baStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSupplierName = ConvertToRestWithoutDefaults(s.ssSupplierName, "");
AttrSupplierRFC = ConvertToRestWithoutDefaults(s.ssSupplierRFC, "");
AttrSupplierNumber = ConvertToRestWithoutDefaults(s.ssSupplierNumber, "");
AttrSupplierRegion = ConvertToRestWithoutDefaults(s.ssSupplierRegion, "");
AttrCompanyName = ConvertToRestWithoutDefaults(s.ssCompanyName, "");
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrCurrencyCode = ConvertToRestWithoutDefaults(s.ssCurrencyCode, "");
AttrCurrencyText = ConvertToRestWithoutDefaults(s.ssCurrencyText, "");
AttrCreationDays = ConvertToRestWithoutDefaults(s.ssCreationDays, 0);
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, 0.0M);
AttrFlux = ConvertToRestWithoutDefaults(s.ssFlux, "");
AttrFluxType = ConvertToRestWithoutDefaults(s.ssFluxType, "");
  } else {
AttrSupplierName = s.ssSupplierName;
AttrSupplierRFC = s.ssSupplierRFC;
AttrSupplierNumber = s.ssSupplierNumber;
AttrSupplierRegion = s.ssSupplierRegion;
AttrCompanyName = s.ssCompanyName;
AttrOrderNumber = s.ssOrderNumber;
AttrCurrencyCode = s.ssCurrencyCode;
AttrCurrencyText = s.ssCurrencyText;
AttrCreationDays = (int?) s.ssCreationDays;
AttrTotalAmount = (decimal?) s.ssTotalAmount;
AttrFlux = s.ssFlux;
AttrFluxType = s.ssFluxType;
  }
}

public static ST_62dd5b695df6cdb1dddea5855e8718baStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_62dd5b695df6cdb1dddea5855e8718baStructure obj) { 
  ST_62dd5b695df6cdb1dddea5855e8718baStructure s = new ST_62dd5b695df6cdb1dddea5855e8718baStructure();
  if(obj != null) {
  s.ssSupplierName = obj.AttrSupplierName == null ? "" : obj.AttrSupplierName;
  s.ssSupplierRFC = obj.AttrSupplierRFC == null ? "" : obj.AttrSupplierRFC;
  s.ssSupplierNumber = obj.AttrSupplierNumber == null ? "" : obj.AttrSupplierNumber;
  s.ssSupplierRegion = obj.AttrSupplierRegion == null ? "" : obj.AttrSupplierRegion;
  s.ssCompanyName = obj.AttrCompanyName == null ? "" : obj.AttrCompanyName;
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssCurrencyCode = obj.AttrCurrencyCode == null ? "" : obj.AttrCurrencyCode;
  s.ssCurrencyText = obj.AttrCurrencyText == null ? "" : obj.AttrCurrencyText;
  s.ssCreationDays = obj.AttrCreationDays == null ? 0 : obj.AttrCreationDays.Value;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? 0.0M : obj.AttrTotalAmount.Value;
  s.ssFlux = obj.AttrFlux == null ? "" : obj.AttrFlux;
  s.ssFluxType = obj.AttrFluxType == null ? "" : obj.AttrFluxType;
  }
  return s;
}

public static Func<ST_62dd5b695df6cdb1dddea5855e8718baStructure, ssConectaProveedores.RestRecords.RESTST_62dd5b695df6cdb1dddea5855e8718baStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_62dd5b695df6cdb1dddea5855e8718baStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_62dd5b695df6cdb1dddea5855e8718baStructure FromStructure(ST_62dd5b695df6cdb1dddea5855e8718baStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_62dd5b695df6cdb1dddea5855e8718baStructure(s, config);
}

}


