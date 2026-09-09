using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderAccConceptsPaymentTermsRecord
public class RESTRC_a10c541c5bb512cec4a0951b15921126 : AbstractRESTStructure<RC_a10c541c5bb512cec4a0951b15921126> {
[JsonProperty("OrderAccConcepts")]
public ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord AttrOrderAccConcepts;

[JsonProperty("PaymentTerms")]
public ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord AttrPaymentTerms;

public RESTRC_a10c541c5bb512cec4a0951b15921126() { }

public RESTRC_a10c541c5bb512cec4a0951b15921126 (RC_a10c541c5bb512cec4a0951b15921126 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderAccConcepts = ConvertToRestWithoutDefaults(s.ssENOrderAccConcepts, new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure, config);
AttrPaymentTerms = ConvertToRestWithoutDefaults(s.ssENPaymentTerms, new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure, config);
  } else {
AttrOrderAccConcepts = ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure(s.ssENOrderAccConcepts, config);
AttrPaymentTerms = ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure(s.ssENPaymentTerms, config);
  }
}

public static RC_a10c541c5bb512cec4a0951b15921126 ToStructure(ssConectaProveedores.RestRecords.RESTRC_a10c541c5bb512cec4a0951b15921126 obj) { 
  RC_a10c541c5bb512cec4a0951b15921126 s = new RC_a10c541c5bb512cec4a0951b15921126();
  if(obj != null) {
  s.ssENOrderAccConcepts = ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure(obj.AttrOrderAccConcepts);
  s.ssENPaymentTerms = ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.ToStructure(obj.AttrPaymentTerms);
  }
  return s;
}

public static Func<RC_a10c541c5bb512cec4a0951b15921126, ssConectaProveedores.RestRecords.RESTRC_a10c541c5bb512cec4a0951b15921126> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a10c541c5bb512cec4a0951b15921126 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a10c541c5bb512cec4a0951b15921126 FromStructure(RC_a10c541c5bb512cec4a0951b15921126 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a10c541c5bb512cec4a0951b15921126(s, config);
}

}


