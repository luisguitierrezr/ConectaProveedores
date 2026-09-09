using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedIssuer
public class JSONEN_1ca446167f1a5fee035306f622895668EntityRecord : AbstractRESTStructure<EN_1ca446167f1a5fee035306f622895668EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("RFC")]
[JsonPropertyName("RFC")]
public string AttrRFC;

[JsonProperty("Nombre")]
[JsonPropertyName("Nombre")]
public string AttrNombre;

[JsonProperty("RegimenFiscal")]
[JsonPropertyName("RegimenFiscal")]
public string AttrRegimenFiscal;

[JsonProperty("CodigoPostal")]
[JsonPropertyName("CodigoPostal")]
public string AttrCodigoPostal;

public JSONEN_1ca446167f1a5fee035306f622895668EntityRecord() { }

public JSONEN_1ca446167f1a5fee035306f622895668EntityRecord (EN_1ca446167f1a5fee035306f622895668EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrRFC = ConvertToRestWithoutDefaults(s.ssRFC, "");
AttrNombre = ConvertToRestWithoutDefaults(s.ssNombre, "");
AttrRegimenFiscal = ConvertToRestWithoutDefaults(s.ssRegimenFiscal, "");
AttrCodigoPostal = ConvertToRestWithoutDefaults(s.ssCodigoPostal, "");
  } else {
AttrId = (long?) s.ssId;
AttrRFC = s.ssRFC;
AttrNombre = s.ssNombre;
AttrRegimenFiscal = s.ssRegimenFiscal;
AttrCodigoPostal = s.ssCodigoPostal;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord, EN_1ca446167f1a5fee035306f622895668EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord s) => ToStructure(s, config);
}
public static EN_1ca446167f1a5fee035306f622895668EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_1ca446167f1a5fee035306f622895668EntityRecord s = new EN_1ca446167f1a5fee035306f622895668EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssRFC = obj.AttrRFC == null ? "" : obj.AttrRFC;
  s.ssNombre = obj.AttrNombre == null ? "" : obj.AttrNombre;
  s.ssRegimenFiscal = obj.AttrRegimenFiscal == null ? "" : obj.AttrRegimenFiscal;
  s.ssCodigoPostal = obj.AttrCodigoPostal == null ? "" : obj.AttrCodigoPostal;
  }
  return s;
}

public static Func<EN_1ca446167f1a5fee035306f622895668EntityRecord, ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_1ca446167f1a5fee035306f622895668EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord FromStructure(EN_1ca446167f1a5fee035306f622895668EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord(s, config);
}

}


