using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFileStruct
public class RESTST_7837994e68174a4794f15e4233b48555Structure : AbstractRESTStructure<ST_7837994e68174a4794f15e4233b48555Structure> {
[JsonProperty("InvoiceFileId")]
public long? AttrInvoiceFileId;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("BinaryData")]
public byte[] AttrBinaryData;

[JsonProperty("StorageId")]
public long? AttrStorageId;

[JsonProperty("FileId")]
public long? AttrFileId;

public RESTST_7837994e68174a4794f15e4233b48555Structure() { }

public RESTST_7837994e68174a4794f15e4233b48555Structure (ST_7837994e68174a4794f15e4233b48555Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceFileId = ConvertToRestWithoutDefaults(s.ssInvoiceFileId, 0L);
AttrName = s.ssName;
AttrBinaryData = s.ssBinaryData;
AttrStorageId = ConvertToRestWithoutDefaults(s.ssStorageId, 0L);
AttrFileId = ConvertToRestWithoutDefaults(s.ssFileId, 0L);
  } else {
AttrInvoiceFileId = (long?) s.ssInvoiceFileId;
AttrName = s.ssName;
AttrBinaryData = s.ssBinaryData;
AttrStorageId = (long?) s.ssStorageId;
AttrFileId = (long?) s.ssFileId;
  }
}

public static ST_7837994e68174a4794f15e4233b48555Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_7837994e68174a4794f15e4233b48555Structure obj) { 
  ST_7837994e68174a4794f15e4233b48555Structure s = new ST_7837994e68174a4794f15e4233b48555Structure();
  if(obj != null) {
  s.ssInvoiceFileId = obj.AttrInvoiceFileId == null ? 0L : obj.AttrInvoiceFileId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssBinaryData = obj.AttrBinaryData == null ? new byte[] {} : obj.AttrBinaryData;
  s.ssStorageId = obj.AttrStorageId == null ? 0L : obj.AttrStorageId.Value;
  s.ssFileId = obj.AttrFileId == null ? 0L : obj.AttrFileId.Value;
  }
  return s;
}

public static Func<ST_7837994e68174a4794f15e4233b48555Structure, ssConectaProveedores.RestRecords.RESTST_7837994e68174a4794f15e4233b48555Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7837994e68174a4794f15e4233b48555Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_7837994e68174a4794f15e4233b48555Structure FromStructure(ST_7837994e68174a4794f15e4233b48555Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_7837994e68174a4794f15e4233b48555Structure(s, config);
}

}


