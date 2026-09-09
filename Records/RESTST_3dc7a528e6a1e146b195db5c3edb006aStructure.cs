using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioScreenTableStructure
public class RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure : AbstractRESTStructure<ST_3dc7a528e6a1e146b195db5c3edb006aStructure> {
[JsonProperty("FolioId")]
public long? AttrFolioId;

[JsonProperty("FolioNumber")]
public string AttrFolioNumber;

[JsonProperty("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("SupplierName")]
public string AttrSupplierName;

[JsonProperty("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("Region")]
public string AttrRegion;

[JsonProperty("TotalAmount")]
public string AttrTotalAmount;

[JsonProperty("Currency")]
public string AttrCurrency;

[JsonProperty("UploadDate")]
public string AttrUploadDate;

[JsonProperty("Status")]
public string AttrStatus;

public RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure() { }

public RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure (ST_3dc7a528e6a1e146b195db5c3edb006aStructure s, IBehaviorsConfiguration config) {
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

public static ST_3dc7a528e6a1e146b195db5c3edb006aStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure obj) { 
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

public static Func<ST_3dc7a528e6a1e146b195db5c3edb006aStructure, ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3dc7a528e6a1e146b195db5c3edb006aStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure FromStructure(ST_3dc7a528e6a1e146b195db5c3edb006aStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_3dc7a528e6a1e146b195db5c3edb006aStructure(s, config);
}

}


