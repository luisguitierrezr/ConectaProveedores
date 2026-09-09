using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MultiUploadInvoiceFileStruct
public class RESTST_5478c3bb197e3019856d4a634c17d91dStructure : AbstractRESTStructure<ST_5478c3bb197e3019856d4a634c17d91dStructure> {
[JsonProperty("InvoiceFileId")]
public long? AttrInvoiceFileId;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("BinaryDataZIP")]
public byte[] AttrBinaryDataZIP;

[JsonProperty("BinaryDataXML")]
public byte[] AttrBinaryDataXML;

[JsonProperty("BinaryDataPDF")]
public byte[] AttrBinaryDataPDF;

[JsonProperty("StorageId")]
public long? AttrStorageId;

[JsonProperty("ErrorMsg")]
public string AttrErrorMsg;

[JsonProperty("FileId")]
public long? AttrFileId;

public RESTST_5478c3bb197e3019856d4a634c17d91dStructure() { }

public RESTST_5478c3bb197e3019856d4a634c17d91dStructure (ST_5478c3bb197e3019856d4a634c17d91dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceFileId = ConvertToRestWithoutDefaults(s.ssInvoiceFileId, 0L);
AttrName = s.ssName;
AttrBinaryDataZIP = s.ssBinaryDataZIP;
AttrBinaryDataXML = s.ssBinaryDataXML;
AttrBinaryDataPDF = s.ssBinaryDataPDF;
AttrStorageId = ConvertToRestWithoutDefaults(s.ssStorageId, 0L);
AttrErrorMsg = ConvertToRestWithoutDefaults(s.ssErrorMsg, "");
AttrFileId = ConvertToRestWithoutDefaults(s.ssFileId, 0L);
  } else {
AttrInvoiceFileId = (long?) s.ssInvoiceFileId;
AttrName = s.ssName;
AttrBinaryDataZIP = s.ssBinaryDataZIP;
AttrBinaryDataXML = s.ssBinaryDataXML;
AttrBinaryDataPDF = s.ssBinaryDataPDF;
AttrStorageId = (long?) s.ssStorageId;
AttrErrorMsg = s.ssErrorMsg;
AttrFileId = (long?) s.ssFileId;
  }
}

public static ST_5478c3bb197e3019856d4a634c17d91dStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_5478c3bb197e3019856d4a634c17d91dStructure obj) { 
  ST_5478c3bb197e3019856d4a634c17d91dStructure s = new ST_5478c3bb197e3019856d4a634c17d91dStructure();
  if(obj != null) {
  s.ssInvoiceFileId = obj.AttrInvoiceFileId == null ? 0L : obj.AttrInvoiceFileId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssBinaryDataZIP = obj.AttrBinaryDataZIP == null ? new byte[] {} : obj.AttrBinaryDataZIP;
  s.ssBinaryDataXML = obj.AttrBinaryDataXML == null ? new byte[] {} : obj.AttrBinaryDataXML;
  s.ssBinaryDataPDF = obj.AttrBinaryDataPDF == null ? new byte[] {} : obj.AttrBinaryDataPDF;
  s.ssStorageId = obj.AttrStorageId == null ? 0L : obj.AttrStorageId.Value;
  s.ssErrorMsg = obj.AttrErrorMsg == null ? "" : obj.AttrErrorMsg;
  s.ssFileId = obj.AttrFileId == null ? 0L : obj.AttrFileId.Value;
  }
  return s;
}

public static Func<ST_5478c3bb197e3019856d4a634c17d91dStructure, ssConectaProveedores.RestRecords.RESTST_5478c3bb197e3019856d4a634c17d91dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5478c3bb197e3019856d4a634c17d91dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_5478c3bb197e3019856d4a634c17d91dStructure FromStructure(ST_5478c3bb197e3019856d4a634c17d91dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_5478c3bb197e3019856d4a634c17d91dStructure(s, config);
}

}


