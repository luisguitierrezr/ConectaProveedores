using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CostCenterSAP
public class RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord : AbstractRESTStructure<EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("RegionId")]
public long? AttrRegionId;

[JsonProperty("CompanyId")]
public long? AttrCompanyId;

[JsonProperty("Soc_")]
public string AttrSoc_;

[JsonProperty("Div_")]
public string AttrDiv_;

[JsonProperty("Area")]
public string AttrArea;

[JsonProperty("Ce_coste")]
public string AttrCe_coste;

[JsonProperty("CeBe")]
public string AttrCeBe;

[JsonProperty("Denominacion")]
public string AttrDenominacion;

[JsonProperty("Descripcion")]
public string AttrDescripcion;

[JsonProperty("Responsable")]
public string AttrResponsable;

[JsonProperty("CeCo")]
public string AttrCeCo;

[JsonProperty("Costesprim_reales_Ind_debloq")]
public string AttrCostesprim_reales_Ind_debloq;

[JsonProperty("Costessecund_reales_Ind_debl")]
public string AttrCostessecund_reales_Ind_debl;

[JsonProperty("Ingresosreales_Ind_debloqueo")]
public string AttrIngresosreales_Ind_debloqueo;

[JsonProperty("Actualiz_comprom__Ind_debloq")]
public string AttrActualiz_comprom__Ind_debloq;

[JsonProperty("Costesprimariosplan_Ind_debl")]
public string AttrCostesprimariosplan_Ind_debl;

[JsonProperty("Costessecund_plan_Ind_debloq")]
public string AttrCostessecund_plan_Ind_debloq;

[JsonProperty("Ingresosplan_Ind_debloqueo_")]
public string AttrIngresosplan_Ind_debloqueo_;

[JsonProperty("Autor")]
public string AttrAutor;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("IsActive")]
public bool? AttrIsActive;

public RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord() { }

public RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord (EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
AttrCompanyId = ConvertToRestWithoutDefaults(s.ssCompanyId, 0L);
AttrSoc_ = s.ssSoc_;
AttrDiv_ = s.ssDiv_;
AttrArea = s.ssArea;
AttrCe_coste = s.ssCe_coste;
AttrCeBe = s.ssCeBe;
AttrDenominacion = s.ssDenominacion;
AttrDescripcion = s.ssDescripcion;
AttrResponsable = s.ssResponsable;
AttrCeCo = s.ssCeCo;
AttrCostesprim_reales_Ind_debloq = ConvertToRestWithoutDefaults(s.ssCostesprim_reales_Ind_debloq, "");
AttrCostessecund_reales_Ind_debl = ConvertToRestWithoutDefaults(s.ssCostessecund_reales_Ind_debl, "");
AttrIngresosreales_Ind_debloqueo = s.ssIngresosreales_Ind_debloqueo;
AttrActualiz_comprom__Ind_debloq = s.ssActualiz_comprom__Ind_debloq;
AttrCostesprimariosplan_Ind_debl = ConvertToRestWithoutDefaults(s.ssCostesprimariosplan_Ind_debl, "");
AttrCostessecund_plan_Ind_debloq = ConvertToRestWithoutDefaults(s.ssCostessecund_plan_Ind_debloq, "");
AttrIngresosplan_Ind_debloqueo_ = s.ssIngresosplan_Ind_debloqueo_;
AttrAutor = s.ssAutor;
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrIsActive = (bool?) s.ssIsActive;
  } else {
AttrId = (long?) s.ssId;
AttrRegionId = (long?) s.ssRegionId;
AttrCompanyId = (long?) s.ssCompanyId;
AttrSoc_ = s.ssSoc_;
AttrDiv_ = s.ssDiv_;
AttrArea = s.ssArea;
AttrCe_coste = s.ssCe_coste;
AttrCeBe = s.ssCeBe;
AttrDenominacion = s.ssDenominacion;
AttrDescripcion = s.ssDescripcion;
AttrResponsable = s.ssResponsable;
AttrCeCo = s.ssCeCo;
AttrCostesprim_reales_Ind_debloq = s.ssCostesprim_reales_Ind_debloq;
AttrCostessecund_reales_Ind_debl = s.ssCostessecund_reales_Ind_debl;
AttrIngresosreales_Ind_debloqueo = s.ssIngresosreales_Ind_debloqueo;
AttrActualiz_comprom__Ind_debloq = s.ssActualiz_comprom__Ind_debloq;
AttrCostesprimariosplan_Ind_debl = s.ssCostesprimariosplan_Ind_debl;
AttrCostessecund_plan_Ind_debloq = s.ssCostessecund_plan_Ind_debloq;
AttrIngresosplan_Ind_debloqueo_ = s.ssIngresosplan_Ind_debloqueo_;
AttrAutor = s.ssAutor;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrIsActive = (bool?) s.ssIsActive;
  }
}

public static EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord obj) { 
  EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord s = new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  s.ssCompanyId = obj.AttrCompanyId == null ? 0L : obj.AttrCompanyId.Value;
  s.ssSoc_ = obj.AttrSoc_ == null ? "" : obj.AttrSoc_;
  s.ssDiv_ = obj.AttrDiv_ == null ? "" : obj.AttrDiv_;
  s.ssArea = obj.AttrArea == null ? "" : obj.AttrArea;
  s.ssCe_coste = obj.AttrCe_coste == null ? "" : obj.AttrCe_coste;
  s.ssCeBe = obj.AttrCeBe == null ? "" : obj.AttrCeBe;
  s.ssDenominacion = obj.AttrDenominacion == null ? "" : obj.AttrDenominacion;
  s.ssDescripcion = obj.AttrDescripcion == null ? "" : obj.AttrDescripcion;
  s.ssResponsable = obj.AttrResponsable == null ? "" : obj.AttrResponsable;
  s.ssCeCo = obj.AttrCeCo == null ? "" : obj.AttrCeCo;
  s.ssCostesprim_reales_Ind_debloq = obj.AttrCostesprim_reales_Ind_debloq == null ? "" : obj.AttrCostesprim_reales_Ind_debloq;
  s.ssCostessecund_reales_Ind_debl = obj.AttrCostessecund_reales_Ind_debl == null ? "" : obj.AttrCostessecund_reales_Ind_debl;
  s.ssIngresosreales_Ind_debloqueo = obj.AttrIngresosreales_Ind_debloqueo == null ? "" : obj.AttrIngresosreales_Ind_debloqueo;
  s.ssActualiz_comprom__Ind_debloq = obj.AttrActualiz_comprom__Ind_debloq == null ? "" : obj.AttrActualiz_comprom__Ind_debloq;
  s.ssCostesprimariosplan_Ind_debl = obj.AttrCostesprimariosplan_Ind_debl == null ? "" : obj.AttrCostesprimariosplan_Ind_debl;
  s.ssCostessecund_plan_Ind_debloq = obj.AttrCostessecund_plan_Ind_debloq == null ? "" : obj.AttrCostessecund_plan_Ind_debloq;
  s.ssIngresosplan_Ind_debloqueo_ = obj.AttrIngresosplan_Ind_debloqueo_ == null ? "" : obj.AttrIngresosplan_Ind_debloqueo_;
  s.ssAutor = obj.AttrAutor == null ? "" : obj.AttrAutor;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssIsActive = obj.AttrIsActive == null ? true : obj.AttrIsActive.Value;
  }
  return s;
}

public static Func<EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord, ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord FromStructure(EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord(s, config);
}

}


