using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAuditFilesList
public class RESTST_15467825cb087ac1591b96b0d1989badStructure : AbstractRESTStructure<ST_15467825cb087ac1591b96b0d1989badStructure> {
[JsonProperty("IsSelected")]
public bool? AttrIsSelected;

[JsonProperty("Filename")]
public string AttrFilename;

[JsonProperty("IsExtra")]
public bool? AttrIsExtra;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("StorageId")]
public long? AttrStorageId;

[JsonProperty("StorageSize")]
public long? AttrStorageSize;

[JsonProperty("UserName")]
public string AttrUserName;

public RESTST_15467825cb087ac1591b96b0d1989badStructure() { }

public RESTST_15467825cb087ac1591b96b0d1989badStructure (ST_15467825cb087ac1591b96b0d1989badStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
AttrFilename = ConvertToRestWithoutDefaults(s.ssFilename, "");
AttrIsExtra = ConvertToRestWithoutDefaults(s.ssIsExtra, false);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrStorageId = ConvertToRestWithoutDefaults(s.ssStorageId, 0L);
AttrStorageSize = ConvertToRestWithoutDefaults(s.ssStorageSize, 0L);
AttrUserName = ConvertToRestWithoutDefaults(s.ssUserName, "");
  } else {
AttrIsSelected = (bool?) s.ssIsSelected;
AttrFilename = s.ssFilename;
AttrIsExtra = (bool?) s.ssIsExtra;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrStorageId = (long?) s.ssStorageId;
AttrStorageSize = (long?) s.ssStorageSize;
AttrUserName = s.ssUserName;
  }
}

public static ST_15467825cb087ac1591b96b0d1989badStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure obj) { 
  ST_15467825cb087ac1591b96b0d1989badStructure s = new ST_15467825cb087ac1591b96b0d1989badStructure();
  if(obj != null) {
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  s.ssFilename = obj.AttrFilename == null ? "" : obj.AttrFilename;
  s.ssIsExtra = obj.AttrIsExtra == null ? false : obj.AttrIsExtra.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssStorageId = obj.AttrStorageId == null ? 0L : obj.AttrStorageId.Value;
  s.ssStorageSize = obj.AttrStorageSize == null ? 0L : obj.AttrStorageSize.Value;
  s.ssUserName = obj.AttrUserName == null ? "" : obj.AttrUserName;
  }
  return s;
}

public static Func<ST_15467825cb087ac1591b96b0d1989badStructure, ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_15467825cb087ac1591b96b0d1989badStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure FromStructure(ST_15467825cb087ac1591b96b0d1989badStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure(s, config);
}

}


