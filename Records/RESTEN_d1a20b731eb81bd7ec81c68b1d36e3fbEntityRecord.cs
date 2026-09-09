using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioSAPData
public class RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord : AbstractRESTStructure<EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("FolioId")]
public long? AttrFolioId;

[JsonProperty("Service")]
public string AttrService;

[JsonProperty("PO_DOCUMENTO_MATERIAL_EM")]
public string AttrPO_DOCUMENTO_MATERIAL_EM;

[JsonProperty("PO_DOCUMENTO_MATERIAL_SM")]
public string AttrPO_DOCUMENTO_MATERIAL_SM;

[JsonProperty("PO_DOCUMENTO_MATERIAL_221")]
public string AttrPO_DOCUMENTO_MATERIAL_221;

[JsonProperty("PO_DOCUMENTO_MATERIAL_415")]
public string AttrPO_DOCUMENTO_MATERIAL_415;

[JsonProperty("PO_EJERCICIO_EM")]
public string AttrPO_EJERCICIO_EM;

[JsonProperty("PO_EJERCICIO_SM")]
public string AttrPO_EJERCICIO_SM;

[JsonProperty("PO_EJERCICIO_221")]
public string AttrPO_EJERCICIO_221;

[JsonProperty("PO_EJERCICIO_415")]
public string AttrPO_EJERCICIO_415;

[JsonProperty("PO_FOLIO_AGRUPADOS")]
public string AttrPO_FOLIO_AGRUPADOS;

[JsonProperty("PO_RESULTADO")]
public string AttrPO_RESULTADO;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

public RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord() { }

public RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord (EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrFolioId = ConvertToRestWithoutDefaults(s.ssFolioId, 0L);
AttrService = ConvertToRestWithoutDefaults(s.ssService, "");
AttrPO_DOCUMENTO_MATERIAL_EM = ConvertToRestWithoutDefaults(s.ssPO_DOCUMENTO_MATERIAL_EM, "");
AttrPO_DOCUMENTO_MATERIAL_SM = ConvertToRestWithoutDefaults(s.ssPO_DOCUMENTO_MATERIAL_SM, "");
AttrPO_DOCUMENTO_MATERIAL_221 = ConvertToRestWithoutDefaults(s.ssPO_DOCUMENTO_MATERIAL_221, "");
AttrPO_DOCUMENTO_MATERIAL_415 = ConvertToRestWithoutDefaults(s.ssPO_DOCUMENTO_MATERIAL_415, "");
AttrPO_EJERCICIO_EM = ConvertToRestWithoutDefaults(s.ssPO_EJERCICIO_EM, "");
AttrPO_EJERCICIO_SM = ConvertToRestWithoutDefaults(s.ssPO_EJERCICIO_SM, "");
AttrPO_EJERCICIO_221 = ConvertToRestWithoutDefaults(s.ssPO_EJERCICIO_221, "");
AttrPO_EJERCICIO_415 = ConvertToRestWithoutDefaults(s.ssPO_EJERCICIO_415, "");
AttrPO_FOLIO_AGRUPADOS = ConvertToRestWithoutDefaults(s.ssPO_FOLIO_AGRUPADOS, "");
AttrPO_RESULTADO = ConvertToRestWithoutDefaults(s.ssPO_RESULTADO, "");
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrId = (long?) s.ssId;
AttrFolioId = (long?) s.ssFolioId;
AttrService = s.ssService;
AttrPO_DOCUMENTO_MATERIAL_EM = s.ssPO_DOCUMENTO_MATERIAL_EM;
AttrPO_DOCUMENTO_MATERIAL_SM = s.ssPO_DOCUMENTO_MATERIAL_SM;
AttrPO_DOCUMENTO_MATERIAL_221 = s.ssPO_DOCUMENTO_MATERIAL_221;
AttrPO_DOCUMENTO_MATERIAL_415 = s.ssPO_DOCUMENTO_MATERIAL_415;
AttrPO_EJERCICIO_EM = s.ssPO_EJERCICIO_EM;
AttrPO_EJERCICIO_SM = s.ssPO_EJERCICIO_SM;
AttrPO_EJERCICIO_221 = s.ssPO_EJERCICIO_221;
AttrPO_EJERCICIO_415 = s.ssPO_EJERCICIO_415;
AttrPO_FOLIO_AGRUPADOS = s.ssPO_FOLIO_AGRUPADOS;
AttrPO_RESULTADO = s.ssPO_RESULTADO;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
  }
}

public static EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord obj) { 
  EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord s = new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssFolioId = obj.AttrFolioId == null ? 0L : obj.AttrFolioId.Value;
  s.ssService = obj.AttrService == null ? "" : obj.AttrService;
  s.ssPO_DOCUMENTO_MATERIAL_EM = obj.AttrPO_DOCUMENTO_MATERIAL_EM == null ? "" : obj.AttrPO_DOCUMENTO_MATERIAL_EM;
  s.ssPO_DOCUMENTO_MATERIAL_SM = obj.AttrPO_DOCUMENTO_MATERIAL_SM == null ? "" : obj.AttrPO_DOCUMENTO_MATERIAL_SM;
  s.ssPO_DOCUMENTO_MATERIAL_221 = obj.AttrPO_DOCUMENTO_MATERIAL_221 == null ? "" : obj.AttrPO_DOCUMENTO_MATERIAL_221;
  s.ssPO_DOCUMENTO_MATERIAL_415 = obj.AttrPO_DOCUMENTO_MATERIAL_415 == null ? "" : obj.AttrPO_DOCUMENTO_MATERIAL_415;
  s.ssPO_EJERCICIO_EM = obj.AttrPO_EJERCICIO_EM == null ? "" : obj.AttrPO_EJERCICIO_EM;
  s.ssPO_EJERCICIO_SM = obj.AttrPO_EJERCICIO_SM == null ? "" : obj.AttrPO_EJERCICIO_SM;
  s.ssPO_EJERCICIO_221 = obj.AttrPO_EJERCICIO_221 == null ? "" : obj.AttrPO_EJERCICIO_221;
  s.ssPO_EJERCICIO_415 = obj.AttrPO_EJERCICIO_415 == null ? "" : obj.AttrPO_EJERCICIO_415;
  s.ssPO_FOLIO_AGRUPADOS = obj.AttrPO_FOLIO_AGRUPADOS == null ? "" : obj.AttrPO_FOLIO_AGRUPADOS;
  s.ssPO_RESULTADO = obj.AttrPO_RESULTADO == null ? "" : obj.AttrPO_RESULTADO;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord, ssConectaProveedores.RestRecords.RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord FromStructure(EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord(s, config);
}

}


