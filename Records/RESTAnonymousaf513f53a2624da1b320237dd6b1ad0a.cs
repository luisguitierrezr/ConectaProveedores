using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderAccConceptsPaymentTermsAdvancePaymentTypeRecord
public class RESTRC_fba480f5c1b92eb8b15d33020b0023b5 : AbstractRESTStructure<RC_fba480f5c1b92eb8b15d33020b0023b5> {
[JsonProperty("OrderAccConcepts")]
public ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord AttrOrderAccConcepts;

[JsonProperty("PaymentTerms")]
public ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord AttrPaymentTerms;

[JsonProperty("AdvancePaymentType")]
public ssConectaProveedores.RestRecords.RESTEN_485b44f219737098b3b1029e90069935EntityRecord AttrAdvancePaymentType;

public RESTRC_fba480f5c1b92eb8b15d33020b0023b5() { }

public RESTRC_fba480f5c1b92eb8b15d33020b0023b5 (RC_fba480f5c1b92eb8b15d33020b0023b5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderAccConcepts = ConvertToRestWithoutDefaults(s.ssENOrderAccConcepts, new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure, config);
AttrPaymentTerms = ConvertToRestWithoutDefaults(s.ssENPaymentTerms, new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure, config);
AttrAdvancePaymentType = ConvertToRestWithoutDefaults(s.ssENAdvancePaymentType, new EN_485b44f219737098b3b1029e90069935EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_485b44f219737098b3b1029e90069935EntityRecord.FromStructure, config);
  } else {
AttrOrderAccConcepts = ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure(s.ssENOrderAccConcepts, config);
AttrPaymentTerms = ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure(s.ssENPaymentTerms, config);
AttrAdvancePaymentType = ssConectaProveedores.RestRecords.RESTEN_485b44f219737098b3b1029e90069935EntityRecord.FromStructure(s.ssENAdvancePaymentType, config);
  }
}

public static RC_fba480f5c1b92eb8b15d33020b0023b5 ToStructure(ssConectaProveedores.RestRecords.RESTRC_fba480f5c1b92eb8b15d33020b0023b5 obj) { 
  RC_fba480f5c1b92eb8b15d33020b0023b5 s = new RC_fba480f5c1b92eb8b15d33020b0023b5();
  if(obj != null) {
  s.ssENOrderAccConcepts = ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure(obj.AttrOrderAccConcepts);
  s.ssENPaymentTerms = ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.ToStructure(obj.AttrPaymentTerms);
  s.ssENAdvancePaymentType = ssConectaProveedores.RestRecords.RESTEN_485b44f219737098b3b1029e90069935EntityRecord.ToStructure(obj.AttrAdvancePaymentType);
  }
  return s;
}

public static Func<RC_fba480f5c1b92eb8b15d33020b0023b5, ssConectaProveedores.RestRecords.RESTRC_fba480f5c1b92eb8b15d33020b0023b5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fba480f5c1b92eb8b15d33020b0023b5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_fba480f5c1b92eb8b15d33020b0023b5 FromStructure(RC_fba480f5c1b92eb8b15d33020b0023b5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_fba480f5c1b92eb8b15d33020b0023b5(s, config);
}

}


