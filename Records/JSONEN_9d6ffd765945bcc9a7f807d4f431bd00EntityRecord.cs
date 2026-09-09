using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Supplier
public class JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord : AbstractRESTStructure<EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Tratamiento")]
[JsonPropertyName("Tratamiento")]
public string AttrTratamiento;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Number")]
[JsonPropertyName("Number")]
public string AttrNumber;

[JsonProperty("Conceptobusq_1_2")]
[JsonPropertyName("Conceptobusq_1_2")]
public string AttrConceptobusq_1_2;

[JsonProperty("Calle_Numero")]
[JsonPropertyName("Calle_Numero")]
public string AttrCalle_Numero;

[JsonProperty("Distrito")]
[JsonPropertyName("Distrito")]
public string AttrDistrito;

[JsonProperty("Codigopostal_Pobl_")]
[JsonPropertyName("Codigopostal_Pobl_")]
public string AttrCodigopostal_Pobl_;

[JsonProperty("Pais")]
[JsonPropertyName("Pais")]
public string AttrPais;

[JsonProperty("Region_")]
[JsonPropertyName("Region_")]
public string AttrRegion_;

[JsonProperty("Idioma")]
[JsonPropertyName("Idioma")]
public string AttrIdioma;

[JsonProperty("Telefono")]
[JsonPropertyName("Telefono")]
public string AttrTelefono;

[JsonProperty("Extension")]
[JsonPropertyName("Extension")]
public string AttrExtension;

[JsonProperty("Fax")]
[JsonPropertyName("Fax")]
public string AttrFax;

[JsonProperty("Cliente")]
[JsonPropertyName("Cliente")]
public string AttrCliente;

[JsonProperty("Soc_GLasociada")]
[JsonPropertyName("Soc_GLasociada")]
public string AttrSoc_GLasociada;

[JsonProperty("Clavedegrupo")]
[JsonPropertyName("Clavedegrupo")]
public string AttrClavedegrupo;

[JsonProperty("N_ident_fis_1")]
[JsonPropertyName("N_ident_fis_1")]
public string AttrN_ident_fis_1;

[JsonProperty("Personafisica")]
[JsonPropertyName("Personafisica")]
public string AttrPersonafisica;

[JsonProperty("Ramo")]
[JsonPropertyName("Ramo")]
public string AttrRamo;

[JsonProperty("Grupodeporte")]
[JsonPropertyName("Grupodeporte")]
public string AttrGrupodeporte;

[JsonProperty("Email")]
[JsonPropertyName("Email")]
public string AttrEmail;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
[JsonPropertyName("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("RegionId")]
[JsonPropertyName("RegionId")]
public long? AttrRegionId;

public JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord() { }

public JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrTratamiento = ConvertToRestWithoutDefaults(s.ssTratamiento, "");
AttrName = s.ssName;
AttrNumber = s.ssNumber;
AttrConceptobusq_1_2 = ConvertToRestWithoutDefaults(s.ssConceptobusq_1_2, "");
AttrCalle_Numero = ConvertToRestWithoutDefaults(s.ssCalle_Numero, "");
AttrDistrito = ConvertToRestWithoutDefaults(s.ssDistrito, "");
AttrCodigopostal_Pobl_ = ConvertToRestWithoutDefaults(s.ssCodigopostal_Pobl_, "");
AttrPais = ConvertToRestWithoutDefaults(s.ssPais, "");
AttrRegion_ = ConvertToRestWithoutDefaults(s.ssRegion_, "");
AttrIdioma = ConvertToRestWithoutDefaults(s.ssIdioma, "");
AttrTelefono = ConvertToRestWithoutDefaults(s.ssTelefono, "");
AttrExtension = ConvertToRestWithoutDefaults(s.ssExtension, "");
AttrFax = ConvertToRestWithoutDefaults(s.ssFax, "");
AttrCliente = ConvertToRestWithoutDefaults(s.ssCliente, "");
AttrSoc_GLasociada = ConvertToRestWithoutDefaults(s.ssSoc_GLasociada, "");
AttrClavedegrupo = ConvertToRestWithoutDefaults(s.ssClavedegrupo, "");
AttrN_ident_fis_1 = ConvertToRestWithoutDefaults(s.ssN_ident_fis_1, "");
AttrPersonafisica = ConvertToRestWithoutDefaults(s.ssPersonafisica, "");
AttrRamo = ConvertToRestWithoutDefaults(s.ssRamo, "");
AttrGrupodeporte = ConvertToRestWithoutDefaults(s.ssGrupodeporte, "");
AttrEmail = ConvertToRestWithoutDefaults(s.ssEmail, "");
AttrIsActive = (bool?) s.ssIsActive;
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
  } else {
AttrId = (long?) s.ssId;
AttrTratamiento = s.ssTratamiento;
AttrName = s.ssName;
AttrNumber = s.ssNumber;
AttrConceptobusq_1_2 = s.ssConceptobusq_1_2;
AttrCalle_Numero = s.ssCalle_Numero;
AttrDistrito = s.ssDistrito;
AttrCodigopostal_Pobl_ = s.ssCodigopostal_Pobl_;
AttrPais = s.ssPais;
AttrRegion_ = s.ssRegion_;
AttrIdioma = s.ssIdioma;
AttrTelefono = s.ssTelefono;
AttrExtension = s.ssExtension;
AttrFax = s.ssFax;
AttrCliente = s.ssCliente;
AttrSoc_GLasociada = s.ssSoc_GLasociada;
AttrClavedegrupo = s.ssClavedegrupo;
AttrN_ident_fis_1 = s.ssN_ident_fis_1;
AttrPersonafisica = s.ssPersonafisica;
AttrRamo = s.ssRamo;
AttrGrupodeporte = s.ssGrupodeporte;
AttrEmail = s.ssEmail;
AttrIsActive = (bool?) s.ssIsActive;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrRegionId = (long?) s.ssRegionId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord, EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord s) => ToStructure(s, config);
}
public static EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord s = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssTratamiento = obj.AttrTratamiento == null ? "" : obj.AttrTratamiento;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssNumber = obj.AttrNumber == null ? "" : obj.AttrNumber;
  s.ssConceptobusq_1_2 = obj.AttrConceptobusq_1_2 == null ? "" : obj.AttrConceptobusq_1_2;
  s.ssCalle_Numero = obj.AttrCalle_Numero == null ? "" : obj.AttrCalle_Numero;
  s.ssDistrito = obj.AttrDistrito == null ? "" : obj.AttrDistrito;
  s.ssCodigopostal_Pobl_ = obj.AttrCodigopostal_Pobl_ == null ? "" : obj.AttrCodigopostal_Pobl_;
  s.ssPais = obj.AttrPais == null ? "" : obj.AttrPais;
  s.ssRegion_ = obj.AttrRegion_ == null ? "" : obj.AttrRegion_;
  s.ssIdioma = obj.AttrIdioma == null ? "" : obj.AttrIdioma;
  s.ssTelefono = obj.AttrTelefono == null ? "" : obj.AttrTelefono;
  s.ssExtension = obj.AttrExtension == null ? "" : obj.AttrExtension;
  s.ssFax = obj.AttrFax == null ? "" : obj.AttrFax;
  s.ssCliente = obj.AttrCliente == null ? "" : obj.AttrCliente;
  s.ssSoc_GLasociada = obj.AttrSoc_GLasociada == null ? "" : obj.AttrSoc_GLasociada;
  s.ssClavedegrupo = obj.AttrClavedegrupo == null ? "" : obj.AttrClavedegrupo;
  s.ssN_ident_fis_1 = obj.AttrN_ident_fis_1 == null ? "" : obj.AttrN_ident_fis_1;
  s.ssPersonafisica = obj.AttrPersonafisica == null ? "" : obj.AttrPersonafisica;
  s.ssRamo = obj.AttrRamo == null ? "" : obj.AttrRamo;
  s.ssGrupodeporte = obj.AttrGrupodeporte == null ? "" : obj.AttrGrupodeporte;
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssIsActive = obj.AttrIsActive == null ? true : obj.AttrIsActive.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  }
  return s;
}

public static Func<EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord, ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord FromStructure(EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(s, config);
}

}


