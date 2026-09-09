using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderAccConceptsPaymentTermsRecord
public class JSONRC_a10c541c5bb512cec4a0951b15921126 : AbstractRESTStructure<RC_a10c541c5bb512cec4a0951b15921126> {
[JsonProperty("OrderAccConcepts")]
[JsonPropertyName("OrderAccConcepts")]
public ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord AttrOrderAccConcepts;

[JsonProperty("PaymentTerms")]
[JsonPropertyName("PaymentTerms")]
public ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord AttrPaymentTerms;

public JSONRC_a10c541c5bb512cec4a0951b15921126() { }

public JSONRC_a10c541c5bb512cec4a0951b15921126 (RC_a10c541c5bb512cec4a0951b15921126 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderAccConcepts = ConvertToRestWithoutDefaults(s.ssENOrderAccConcepts, new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure, config);
AttrPaymentTerms = ConvertToRestWithoutDefaults(s.ssENPaymentTerms, new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure, config);
  } else {
AttrOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure(s.ssENOrderAccConcepts, config);
AttrPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure(s.ssENPaymentTerms, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a10c541c5bb512cec4a0951b15921126, RC_a10c541c5bb512cec4a0951b15921126> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a10c541c5bb512cec4a0951b15921126 s) => ToStructure(s, config);
}
public static RC_a10c541c5bb512cec4a0951b15921126 ToStructure(ssConectaProveedores.RestRecords.JSONRC_a10c541c5bb512cec4a0951b15921126 obj, IBehaviorsConfiguration config) { 
  RC_a10c541c5bb512cec4a0951b15921126 s = new RC_a10c541c5bb512cec4a0951b15921126();
  if(obj != null) {
  s.ssENOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure(obj.AttrOrderAccConcepts, config);
  s.ssENPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.ToStructure(obj.AttrPaymentTerms, config);
  }
  return s;
}

public static Func<RC_a10c541c5bb512cec4a0951b15921126, ssConectaProveedores.RestRecords.JSONRC_a10c541c5bb512cec4a0951b15921126> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a10c541c5bb512cec4a0951b15921126 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a10c541c5bb512cec4a0951b15921126 FromStructure(RC_a10c541c5bb512cec4a0951b15921126 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a10c541c5bb512cec4a0951b15921126(s, config);
}

}


