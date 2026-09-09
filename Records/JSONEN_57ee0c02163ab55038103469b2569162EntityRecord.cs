using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SupplierDetail
public class JSONEN_57ee0c02163ab55038103469b2569162EntityRecord : AbstractRESTStructure<EN_57ee0c02163ab55038103469b2569162EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("SupplierId")]
[JsonPropertyName("SupplierId")]
public long? AttrSupplierId;

[JsonProperty("SociedadeId")]
[JsonPropertyName("SociedadeId")]
public long? AttrSociedadeId;

[JsonProperty("Bloqueocontabilidad")]
[JsonPropertyName("Bloqueocontabilidad")]
public string AttrBloqueocontabilidad;

[JsonProperty("Bloqueopedido")]
[JsonPropertyName("Bloqueopedido")]
public string AttrBloqueopedido;

[JsonProperty("Pais2")]
[JsonPropertyName("Pais2")]
public string AttrPais2;

[JsonProperty("Clavebanco")]
[JsonPropertyName("Clavebanco")]
public string AttrClavebanco;

[JsonProperty("Cuentabancaria")]
[JsonPropertyName("Cuentabancaria")]
public string AttrCuentabancaria;

[JsonProperty("Titular")]
[JsonPropertyName("Titular")]
public string AttrTitular;

[JsonProperty("TpBco")]
[JsonPropertyName("TpBco")]
public string AttrTpBco;

[JsonProperty("Referencia")]
[JsonPropertyName("Referencia")]
public string AttrReferencia;

[JsonProperty("Autoriz_Extraccion")]
[JsonPropertyName("Autoriz_Extraccion")]
public string AttrAutoriz_Extraccion;

[JsonProperty("Nombredelainstitucionfinanci")]
[JsonPropertyName("Nombredelainstitucionfinanci")]
public string AttrNombredelainstitucionfinanci;

[JsonProperty("Cuentaasociada")]
[JsonPropertyName("Cuentaasociada")]
public string AttrCuentaasociada;

[JsonProperty("Claveclasific_")]
[JsonPropertyName("Claveclasific_")]
public string AttrClaveclasific_;

[JsonProperty("GrupodeTesoreria")]
[JsonPropertyName("GrupodeTesoreria")]
public string AttrGrupodeTesoreria;

[JsonProperty("N_cta_anterior")]
[JsonPropertyName("N_cta_anterior")]
public string AttrN_cta_anterior;

[JsonProperty("Cond_pago")]
[JsonPropertyName("Cond_pago")]
public string AttrCond_pago;

[JsonProperty("Viasdepago")]
[JsonPropertyName("Viasdepago")]
public string AttrViasdepago;

[JsonProperty("Bloqueopago")]
[JsonPropertyName("Bloqueopago")]
public string AttrBloqueopago;

[JsonProperty("Paisderetencion")]
[JsonPropertyName("Paisderetencion")]
public string AttrPaisderetencion;

[JsonProperty("Tp_retenc_")]
[JsonPropertyName("Tp_retenc_")]
public string AttrTp_retenc_;

[JsonProperty("InRet")]
[JsonPropertyName("InRet")]
public string AttrInRet;

[JsonProperty("Sujeto")]
[JsonPropertyName("Sujeto")]
public string AttrSujeto;

[JsonProperty("Exen__")]
[JsonPropertyName("Exen__")]
public string AttrExen__;

[JsonProperty("Descripcion")]
[JsonPropertyName("Descripcion")]
public string AttrDescripcion;

public JSONEN_57ee0c02163ab55038103469b2569162EntityRecord() { }

public JSONEN_57ee0c02163ab55038103469b2569162EntityRecord (EN_57ee0c02163ab55038103469b2569162EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrSupplierId = ConvertToRestWithoutDefaults(s.ssSupplierId, 0L);
AttrSociedadeId = ConvertToRestWithoutDefaults(s.ssSociedadeId, 0L);
AttrBloqueocontabilidad = ConvertToRestWithoutDefaults(s.ssBloqueocontabilidad, "");
AttrBloqueopedido = ConvertToRestWithoutDefaults(s.ssBloqueopedido, "");
AttrPais2 = ConvertToRestWithoutDefaults(s.ssPais2, "");
AttrClavebanco = ConvertToRestWithoutDefaults(s.ssClavebanco, "");
AttrCuentabancaria = ConvertToRestWithoutDefaults(s.ssCuentabancaria, "");
AttrTitular = ConvertToRestWithoutDefaults(s.ssTitular, "");
AttrTpBco = ConvertToRestWithoutDefaults(s.ssTpBco, "");
AttrReferencia = ConvertToRestWithoutDefaults(s.ssReferencia, "");
AttrAutoriz_Extraccion = ConvertToRestWithoutDefaults(s.ssAutoriz_Extraccion, "");
AttrNombredelainstitucionfinanci = ConvertToRestWithoutDefaults(s.ssNombredelainstitucionfinanci, "");
AttrCuentaasociada = ConvertToRestWithoutDefaults(s.ssCuentaasociada, "");
AttrClaveclasific_ = ConvertToRestWithoutDefaults(s.ssClaveclasific_, "");
AttrGrupodeTesoreria = ConvertToRestWithoutDefaults(s.ssGrupodeTesoreria, "");
AttrN_cta_anterior = ConvertToRestWithoutDefaults(s.ssN_cta_anterior, "");
AttrCond_pago = ConvertToRestWithoutDefaults(s.ssCond_pago, "");
AttrViasdepago = ConvertToRestWithoutDefaults(s.ssViasdepago, "");
AttrBloqueopago = ConvertToRestWithoutDefaults(s.ssBloqueopago, "");
AttrPaisderetencion = ConvertToRestWithoutDefaults(s.ssPaisderetencion, "");
AttrTp_retenc_ = ConvertToRestWithoutDefaults(s.ssTp_retenc_, "");
AttrInRet = ConvertToRestWithoutDefaults(s.ssInRet, "");
AttrSujeto = ConvertToRestWithoutDefaults(s.ssSujeto, "");
AttrExen__ = ConvertToRestWithoutDefaults(s.ssExen__, "");
AttrDescripcion = ConvertToRestWithoutDefaults(s.ssDescripcion, "");
  } else {
AttrId = (long?) s.ssId;
AttrSupplierId = (long?) s.ssSupplierId;
AttrSociedadeId = (long?) s.ssSociedadeId;
AttrBloqueocontabilidad = s.ssBloqueocontabilidad;
AttrBloqueopedido = s.ssBloqueopedido;
AttrPais2 = s.ssPais2;
AttrClavebanco = s.ssClavebanco;
AttrCuentabancaria = s.ssCuentabancaria;
AttrTitular = s.ssTitular;
AttrTpBco = s.ssTpBco;
AttrReferencia = s.ssReferencia;
AttrAutoriz_Extraccion = s.ssAutoriz_Extraccion;
AttrNombredelainstitucionfinanci = s.ssNombredelainstitucionfinanci;
AttrCuentaasociada = s.ssCuentaasociada;
AttrClaveclasific_ = s.ssClaveclasific_;
AttrGrupodeTesoreria = s.ssGrupodeTesoreria;
AttrN_cta_anterior = s.ssN_cta_anterior;
AttrCond_pago = s.ssCond_pago;
AttrViasdepago = s.ssViasdepago;
AttrBloqueopago = s.ssBloqueopago;
AttrPaisderetencion = s.ssPaisderetencion;
AttrTp_retenc_ = s.ssTp_retenc_;
AttrInRet = s.ssInRet;
AttrSujeto = s.ssSujeto;
AttrExen__ = s.ssExen__;
AttrDescripcion = s.ssDescripcion;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord, EN_57ee0c02163ab55038103469b2569162EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord s) => ToStructure(s, config);
}
public static EN_57ee0c02163ab55038103469b2569162EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_57ee0c02163ab55038103469b2569162EntityRecord s = new EN_57ee0c02163ab55038103469b2569162EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssSupplierId = obj.AttrSupplierId == null ? 0L : obj.AttrSupplierId.Value;
  s.ssSociedadeId = obj.AttrSociedadeId == null ? 0L : obj.AttrSociedadeId.Value;
  s.ssBloqueocontabilidad = obj.AttrBloqueocontabilidad == null ? "" : obj.AttrBloqueocontabilidad;
  s.ssBloqueopedido = obj.AttrBloqueopedido == null ? "" : obj.AttrBloqueopedido;
  s.ssPais2 = obj.AttrPais2 == null ? "" : obj.AttrPais2;
  s.ssClavebanco = obj.AttrClavebanco == null ? "" : obj.AttrClavebanco;
  s.ssCuentabancaria = obj.AttrCuentabancaria == null ? "" : obj.AttrCuentabancaria;
  s.ssTitular = obj.AttrTitular == null ? "" : obj.AttrTitular;
  s.ssTpBco = obj.AttrTpBco == null ? "" : obj.AttrTpBco;
  s.ssReferencia = obj.AttrReferencia == null ? "" : obj.AttrReferencia;
  s.ssAutoriz_Extraccion = obj.AttrAutoriz_Extraccion == null ? "" : obj.AttrAutoriz_Extraccion;
  s.ssNombredelainstitucionfinanci = obj.AttrNombredelainstitucionfinanci == null ? "" : obj.AttrNombredelainstitucionfinanci;
  s.ssCuentaasociada = obj.AttrCuentaasociada == null ? "" : obj.AttrCuentaasociada;
  s.ssClaveclasific_ = obj.AttrClaveclasific_ == null ? "" : obj.AttrClaveclasific_;
  s.ssGrupodeTesoreria = obj.AttrGrupodeTesoreria == null ? "" : obj.AttrGrupodeTesoreria;
  s.ssN_cta_anterior = obj.AttrN_cta_anterior == null ? "" : obj.AttrN_cta_anterior;
  s.ssCond_pago = obj.AttrCond_pago == null ? "" : obj.AttrCond_pago;
  s.ssViasdepago = obj.AttrViasdepago == null ? "" : obj.AttrViasdepago;
  s.ssBloqueopago = obj.AttrBloqueopago == null ? "" : obj.AttrBloqueopago;
  s.ssPaisderetencion = obj.AttrPaisderetencion == null ? "" : obj.AttrPaisderetencion;
  s.ssTp_retenc_ = obj.AttrTp_retenc_ == null ? "" : obj.AttrTp_retenc_;
  s.ssInRet = obj.AttrInRet == null ? "" : obj.AttrInRet;
  s.ssSujeto = obj.AttrSujeto == null ? "" : obj.AttrSujeto;
  s.ssExen__ = obj.AttrExen__ == null ? "" : obj.AttrExen__;
  s.ssDescripcion = obj.AttrDescripcion == null ? "" : obj.AttrDescripcion;
  }
  return s;
}

public static Func<EN_57ee0c02163ab55038103469b2569162EntityRecord, ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_57ee0c02163ab55038103469b2569162EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord FromStructure(EN_57ee0c02163ab55038103469b2569162EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord(s, config);
}

}


