using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyIdCostCenterSAPIdDivisionIdDocumentClassIdGLAccountIdRegionIdRecord
public class JSONRC_98e72683eb82d34cf7fcf42a642043ce : AbstractRESTStructure<RC_98e72683eb82d34cf7fcf42a642043ce> {
[JsonProperty("CurrencyId")]
[JsonPropertyName("CurrencyId")]
public string AttrCurrencyId;

[JsonProperty("CostCenterSAPId")]
[JsonPropertyName("CostCenterSAPId")]
public long? AttrCostCenterSAPId;

[JsonProperty("DivisionId")]
[JsonPropertyName("DivisionId")]
public long? AttrDivisionId;

[JsonProperty("DocumentClassId")]
[JsonPropertyName("DocumentClassId")]
public long? AttrDocumentClassId;

[JsonProperty("GLAccountId")]
[JsonPropertyName("GLAccountId")]
public long? AttrGLAccountId;

[JsonProperty("RegionId")]
[JsonPropertyName("RegionId")]
public long? AttrRegionId;

public JSONRC_98e72683eb82d34cf7fcf42a642043ce() { }

public JSONRC_98e72683eb82d34cf7fcf42a642043ce (RC_98e72683eb82d34cf7fcf42a642043ce s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrencyId = ConvertToRestWithoutDefaults(s.ssCurrencyId, "");
AttrCostCenterSAPId = ConvertToRestWithoutDefaults(s.ssCostCenterSAPId, 0L);
AttrDivisionId = ConvertToRestWithoutDefaults(s.ssDivisionId, 0L);
AttrDocumentClassId = ConvertToRestWithoutDefaults(s.ssDocumentClassId, 0L);
AttrGLAccountId = ConvertToRestWithoutDefaults(s.ssGLAccountId, 0L);
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
  } else {
AttrCurrencyId = s.ssCurrencyId;
AttrCostCenterSAPId = (long?) s.ssCostCenterSAPId;
AttrDivisionId = (long?) s.ssDivisionId;
AttrDocumentClassId = (long?) s.ssDocumentClassId;
AttrGLAccountId = (long?) s.ssGLAccountId;
AttrRegionId = (long?) s.ssRegionId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_98e72683eb82d34cf7fcf42a642043ce, RC_98e72683eb82d34cf7fcf42a642043ce> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_98e72683eb82d34cf7fcf42a642043ce s) => ToStructure(s, config);
}
public static RC_98e72683eb82d34cf7fcf42a642043ce ToStructure(ssConectaProveedores.RestRecords.JSONRC_98e72683eb82d34cf7fcf42a642043ce obj, IBehaviorsConfiguration config) { 
  RC_98e72683eb82d34cf7fcf42a642043ce s = new RC_98e72683eb82d34cf7fcf42a642043ce();
  if(obj != null) {
  s.ssCurrencyId = obj.AttrCurrencyId == null ? "" : obj.AttrCurrencyId;
  s.ssCostCenterSAPId = obj.AttrCostCenterSAPId == null ? 0L : obj.AttrCostCenterSAPId.Value;
  s.ssDivisionId = obj.AttrDivisionId == null ? 0L : obj.AttrDivisionId.Value;
  s.ssDocumentClassId = obj.AttrDocumentClassId == null ? 0L : obj.AttrDocumentClassId.Value;
  s.ssGLAccountId = obj.AttrGLAccountId == null ? 0L : obj.AttrGLAccountId.Value;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  }
  return s;
}

public static Func<RC_98e72683eb82d34cf7fcf42a642043ce, ssConectaProveedores.RestRecords.JSONRC_98e72683eb82d34cf7fcf42a642043ce> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_98e72683eb82d34cf7fcf42a642043ce s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_98e72683eb82d34cf7fcf42a642043ce FromStructure(RC_98e72683eb82d34cf7fcf42a642043ce s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_98e72683eb82d34cf7fcf42a642043ce(s, config);
}

}


