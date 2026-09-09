using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderAccConceptsOrderAccountingRecord
public class JSONRC_5d55fb38ff8b802f4f2bfe6c27a16f41 : AbstractRESTStructure<RC_5d55fb38ff8b802f4f2bfe6c27a16f41> {
[JsonProperty("OrderAccConcepts")]
[JsonPropertyName("OrderAccConcepts")]
public ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord AttrOrderAccConcepts;

[JsonProperty("OrderAccounting")]
[JsonPropertyName("OrderAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord AttrOrderAccounting;

public JSONRC_5d55fb38ff8b802f4f2bfe6c27a16f41() { }

public JSONRC_5d55fb38ff8b802f4f2bfe6c27a16f41 (RC_5d55fb38ff8b802f4f2bfe6c27a16f41 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderAccConcepts = ConvertToRestWithoutDefaults(s.ssENOrderAccConcepts, new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure, config);
AttrOrderAccounting = ConvertToRestWithoutDefaults(s.ssENOrderAccounting, new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.FromStructure, config);
  } else {
AttrOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure(s.ssENOrderAccConcepts, config);
AttrOrderAccounting = ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.FromStructure(s.ssENOrderAccounting, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_5d55fb38ff8b802f4f2bfe6c27a16f41, RC_5d55fb38ff8b802f4f2bfe6c27a16f41> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_5d55fb38ff8b802f4f2bfe6c27a16f41 s) => ToStructure(s, config);
}
public static RC_5d55fb38ff8b802f4f2bfe6c27a16f41 ToStructure(ssConectaProveedores.RestRecords.JSONRC_5d55fb38ff8b802f4f2bfe6c27a16f41 obj, IBehaviorsConfiguration config) { 
  RC_5d55fb38ff8b802f4f2bfe6c27a16f41 s = new RC_5d55fb38ff8b802f4f2bfe6c27a16f41();
  if(obj != null) {
  s.ssENOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure(obj.AttrOrderAccConcepts, config);
  s.ssENOrderAccounting = ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.ToStructure(obj.AttrOrderAccounting, config);
  }
  return s;
}

public static Func<RC_5d55fb38ff8b802f4f2bfe6c27a16f41, ssConectaProveedores.RestRecords.JSONRC_5d55fb38ff8b802f4f2bfe6c27a16f41> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5d55fb38ff8b802f4f2bfe6c27a16f41 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_5d55fb38ff8b802f4f2bfe6c27a16f41 FromStructure(RC_5d55fb38ff8b802f4f2bfe6c27a16f41 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_5d55fb38ff8b802f4f2bfe6c27a16f41(s, config);
}

}


