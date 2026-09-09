using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderAccConceptsAccountingDataTypeRecord
public class JSONRC_ea3a117956fd50e1901759909d3fbc2f : AbstractRESTStructure<RC_ea3a117956fd50e1901759909d3fbc2f> {
[JsonProperty("OrderAccConcepts")]
[JsonPropertyName("OrderAccConcepts")]
public ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord AttrOrderAccConcepts;

[JsonProperty("AccountingDataType")]
[JsonPropertyName("AccountingDataType")]
public ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord AttrAccountingDataType;

public JSONRC_ea3a117956fd50e1901759909d3fbc2f() { }

public JSONRC_ea3a117956fd50e1901759909d3fbc2f (RC_ea3a117956fd50e1901759909d3fbc2f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderAccConcepts = ConvertToRestWithoutDefaults(s.ssENOrderAccConcepts, new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure, config);
AttrAccountingDataType = ConvertToRestWithoutDefaults(s.ssENAccountingDataType, new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure, config);
  } else {
AttrOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure(s.ssENOrderAccConcepts, config);
AttrAccountingDataType = ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure(s.ssENAccountingDataType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ea3a117956fd50e1901759909d3fbc2f, RC_ea3a117956fd50e1901759909d3fbc2f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ea3a117956fd50e1901759909d3fbc2f s) => ToStructure(s, config);
}
public static RC_ea3a117956fd50e1901759909d3fbc2f ToStructure(ssConectaProveedores.RestRecords.JSONRC_ea3a117956fd50e1901759909d3fbc2f obj, IBehaviorsConfiguration config) { 
  RC_ea3a117956fd50e1901759909d3fbc2f s = new RC_ea3a117956fd50e1901759909d3fbc2f();
  if(obj != null) {
  s.ssENOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure(obj.AttrOrderAccConcepts, config);
  s.ssENAccountingDataType = ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.ToStructure(obj.AttrAccountingDataType, config);
  }
  return s;
}

public static Func<RC_ea3a117956fd50e1901759909d3fbc2f, ssConectaProveedores.RestRecords.JSONRC_ea3a117956fd50e1901759909d3fbc2f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ea3a117956fd50e1901759909d3fbc2f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ea3a117956fd50e1901759909d3fbc2f FromStructure(RC_ea3a117956fd50e1901759909d3fbc2f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ea3a117956fd50e1901759909d3fbc2f(s, config);
}

}


