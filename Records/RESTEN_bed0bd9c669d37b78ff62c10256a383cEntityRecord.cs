using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedRelations
public class RESTEN_bed0bd9c669d37b78ff62c10256a383cEntityRecord : AbstractRESTStructure<EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("TipoRelacion")]
public string AttrTipoRelacion;

[JsonProperty("UUIDRelacionado")]
public string AttrUUIDRelacionado;

[JsonProperty("FolioRelacionado")]
public string AttrFolioRelacionado;

public RESTEN_bed0bd9c669d37b78ff62c10256a383cEntityRecord() { }

public RESTEN_bed0bd9c669d37b78ff62c10256a383cEntityRecord (EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
AttrTipoRelacion = ConvertToRestWithoutDefaults(s.ssTipoRelacion, "");
AttrUUIDRelacionado = ConvertToRestWithoutDefaults(s.ssUUIDRelacionado, "");
AttrFolioRelacionado = ConvertToRestWithoutDefaults(s.ssFolioRelacionado, "");
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrTipoRelacion = s.ssTipoRelacion;
AttrUUIDRelacionado = s.ssUUIDRelacionado;
AttrFolioRelacionado = s.ssFolioRelacionado;
  }
}

public static EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_bed0bd9c669d37b78ff62c10256a383cEntityRecord obj) { 
  EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord s = new EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssTipoRelacion = obj.AttrTipoRelacion == null ? "" : obj.AttrTipoRelacion;
  s.ssUUIDRelacionado = obj.AttrUUIDRelacionado == null ? "" : obj.AttrUUIDRelacionado;
  s.ssFolioRelacionado = obj.AttrFolioRelacionado == null ? "" : obj.AttrFolioRelacionado;
  }
  return s;
}

public static Func<EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord, ssConectaProveedores.RestRecords.RESTEN_bed0bd9c669d37b78ff62c10256a383cEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_bed0bd9c669d37b78ff62c10256a383cEntityRecord FromStructure(EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_bed0bd9c669d37b78ff62c10256a383cEntityRecord(s, config);
}

}


