using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderAccConceptsAccountingDataTypeRecord
public class RESTRC_ea3a117956fd50e1901759909d3fbc2f : AbstractRESTStructure<RC_ea3a117956fd50e1901759909d3fbc2f> {
[JsonProperty("OrderAccConcepts")]
public ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord AttrOrderAccConcepts;

[JsonProperty("AccountingDataType")]
public ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord AttrAccountingDataType;

public RESTRC_ea3a117956fd50e1901759909d3fbc2f() { }

public RESTRC_ea3a117956fd50e1901759909d3fbc2f (RC_ea3a117956fd50e1901759909d3fbc2f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderAccConcepts = ConvertToRestWithoutDefaults(s.ssENOrderAccConcepts, new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure, config);
AttrAccountingDataType = ConvertToRestWithoutDefaults(s.ssENAccountingDataType, new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure, config);
  } else {
AttrOrderAccConcepts = ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure(s.ssENOrderAccConcepts, config);
AttrAccountingDataType = ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure(s.ssENAccountingDataType, config);
  }
}

public static RC_ea3a117956fd50e1901759909d3fbc2f ToStructure(ssConectaProveedores.RestRecords.RESTRC_ea3a117956fd50e1901759909d3fbc2f obj) { 
  RC_ea3a117956fd50e1901759909d3fbc2f s = new RC_ea3a117956fd50e1901759909d3fbc2f();
  if(obj != null) {
  s.ssENOrderAccConcepts = ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure(obj.AttrOrderAccConcepts);
  s.ssENAccountingDataType = ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.ToStructure(obj.AttrAccountingDataType);
  }
  return s;
}

public static Func<RC_ea3a117956fd50e1901759909d3fbc2f, ssConectaProveedores.RestRecords.RESTRC_ea3a117956fd50e1901759909d3fbc2f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ea3a117956fd50e1901759909d3fbc2f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ea3a117956fd50e1901759909d3fbc2f FromStructure(RC_ea3a117956fd50e1901759909d3fbc2f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ea3a117956fd50e1901759909d3fbc2f(s, config);
}

}


