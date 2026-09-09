using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderAccConceptsPaymentTermsAdvancePaymentTypeRecord
public class JSONRC_fba480f5c1b92eb8b15d33020b0023b5 : AbstractRESTStructure<RC_fba480f5c1b92eb8b15d33020b0023b5> {
[JsonProperty("OrderAccConcepts")]
[JsonPropertyName("OrderAccConcepts")]
public ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord AttrOrderAccConcepts;

[JsonProperty("PaymentTerms")]
[JsonPropertyName("PaymentTerms")]
public ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord AttrPaymentTerms;

[JsonProperty("AdvancePaymentType")]
[JsonPropertyName("AdvancePaymentType")]
public ssConectaProveedores.RestRecords.JSONEN_485b44f219737098b3b1029e90069935EntityRecord AttrAdvancePaymentType;

public JSONRC_fba480f5c1b92eb8b15d33020b0023b5() { }

public JSONRC_fba480f5c1b92eb8b15d33020b0023b5 (RC_fba480f5c1b92eb8b15d33020b0023b5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderAccConcepts = ConvertToRestWithoutDefaults(s.ssENOrderAccConcepts, new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure, config);
AttrPaymentTerms = ConvertToRestWithoutDefaults(s.ssENPaymentTerms, new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure, config);
AttrAdvancePaymentType = ConvertToRestWithoutDefaults(s.ssENAdvancePaymentType, new EN_485b44f219737098b3b1029e90069935EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_485b44f219737098b3b1029e90069935EntityRecord.FromStructure, config);
  } else {
AttrOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure(s.ssENOrderAccConcepts, config);
AttrPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure(s.ssENPaymentTerms, config);
AttrAdvancePaymentType = ssConectaProveedores.RestRecords.JSONEN_485b44f219737098b3b1029e90069935EntityRecord.FromStructure(s.ssENAdvancePaymentType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_fba480f5c1b92eb8b15d33020b0023b5, RC_fba480f5c1b92eb8b15d33020b0023b5> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_fba480f5c1b92eb8b15d33020b0023b5 s) => ToStructure(s, config);
}
public static RC_fba480f5c1b92eb8b15d33020b0023b5 ToStructure(ssConectaProveedores.RestRecords.JSONRC_fba480f5c1b92eb8b15d33020b0023b5 obj, IBehaviorsConfiguration config) { 
  RC_fba480f5c1b92eb8b15d33020b0023b5 s = new RC_fba480f5c1b92eb8b15d33020b0023b5();
  if(obj != null) {
  s.ssENOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure(obj.AttrOrderAccConcepts, config);
  s.ssENPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.ToStructure(obj.AttrPaymentTerms, config);
  s.ssENAdvancePaymentType = ssConectaProveedores.RestRecords.JSONEN_485b44f219737098b3b1029e90069935EntityRecord.ToStructure(obj.AttrAdvancePaymentType, config);
  }
  return s;
}

public static Func<RC_fba480f5c1b92eb8b15d33020b0023b5, ssConectaProveedores.RestRecords.JSONRC_fba480f5c1b92eb8b15d33020b0023b5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fba480f5c1b92eb8b15d33020b0023b5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_fba480f5c1b92eb8b15d33020b0023b5 FromStructure(RC_fba480f5c1b92eb8b15d33020b0023b5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_fba480f5c1b92eb8b15d33020b0023b5(s, config);
}

}


