using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioScreenTableStructure
public class JSONST_3dc7a528e6a1e146b195db5c3edb006aStructure : AbstractRESTStructure<ST_3dc7a528e6a1e146b195db5c3edb006aStructure> {
[JsonProperty("FolioId")]
[JsonPropertyName("FolioId")]
public long? AttrFolioId;

[JsonProperty("FolioNumber")]
[JsonPropertyName("FolioNumber")]
public string AttrFolioNumber;

[JsonProperty("OrderNumber")]
[JsonPropertyName("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("SupplierName")]
[JsonPropertyName("SupplierName")]
public string AttrSupplierName;

[JsonProperty("SupplierNumber")]
[JsonPropertyName("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public string AttrRegion;

[JsonProperty("TotalAmount")]
[JsonPropertyName("TotalAmount")]
public string AttrTotalAmount;

[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public string AttrCurrency;

[JsonProperty("UploadDate")]
[JsonPropertyName("UploadDate")]
public string AttrUploadDate;

[JsonProperty("Status")]
[JsonPropertyName("Status")]
public string AttrStatus;

public JSONST_3dc7a528e6a1e146b195db5c3edb006aStructure() { }

public JSONST_3dc7a528e6a1e146b195db5c3edb006aStructure (ST_3dc7a528e6a1e146b195db5c3edb006aStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioId = ConvertToRestWithoutDefaults(s.ssFolioId, 0L);
AttrFolioNumber = ConvertToRestWithoutDefaults(s.ssFolioNumber, "");
AttrOrderNumber = ConvertToRestWithoutDefaults(s.ssOrderNumber, "");
AttrSupplierName = ConvertToRestWithoutDefaults(s.ssSupplierName, "");
AttrSupplierNumber = ConvertToRestWithoutDefaults(s.ssSupplierNumber, "");
AttrRegion = ConvertToRestWithoutDefaults(s.ssRegion, "");
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, "");
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
AttrUploadDate = ConvertToRestWithoutDefaults(s.ssUploadDate, "");
AttrStatus = ConvertToRestWithoutDefaults(s.ssStatus, "");
  } else {
AttrFolioId = (long?) s.ssFolioId;
AttrFolioNumber = s.ssFolioNumber;
AttrOrderNumber = s.ssOrderNumber;
AttrSupplierName = s.ssSupplierName;
AttrSupplierNumber = s.ssSupplierNumber;
AttrRegion = s.ssRegion;
AttrTotalAmount = s.ssTotalAmount;
AttrCurrency = s.ssCurrency;
AttrUploadDate = s.ssUploadDate;
AttrStatus = s.ssStatus;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_3dc7a528e6a1e146b195db5c3edb006aStructure, ST_3dc7a528e6a1e146b195db5c3edb006aStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_3dc7a528e6a1e146b195db5c3edb006aStructure s) => ToStructure(s, config);
}
public static ST_3dc7a528e6a1e146b195db5c3edb006aStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_3dc7a528e6a1e146b195db5c3edb006aStructure obj, IBehaviorsConfiguration config) { 
  ST_3dc7a528e6a1e146b195db5c3edb006aStructure s = new ST_3dc7a528e6a1e146b195db5c3edb006aStructure();
  if(obj != null) {
  s.ssFolioId = obj.AttrFolioId == null ? 0L : obj.AttrFolioId.Value;
  s.ssFolioNumber = obj.AttrFolioNumber == null ? "" : obj.AttrFolioNumber;
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssSupplierName = obj.AttrSupplierName == null ? "" : obj.AttrSupplierName;
  s.ssSupplierNumber = obj.AttrSupplierNumber == null ? "" : obj.AttrSupplierNumber;
  s.ssRegion = obj.AttrRegion == null ? "" : obj.AttrRegion;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? "" : obj.AttrTotalAmount;
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  s.ssUploadDate = obj.AttrUploadDate == null ? "" : obj.AttrUploadDate;
  s.ssStatus = obj.AttrStatus == null ? "" : obj.AttrStatus;
  }
  return s;
}

public static Func<ST_3dc7a528e6a1e146b195db5c3edb006aStructure, ssConectaProveedores.RestRecords.JSONST_3dc7a528e6a1e146b195db5c3edb006aStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3dc7a528e6a1e146b195db5c3edb006aStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_3dc7a528e6a1e146b195db5c3edb006aStructure FromStructure(ST_3dc7a528e6a1e146b195db5c3edb006aStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_3dc7a528e6a1e146b195db5c3edb006aStructure(s, config);
}

}


