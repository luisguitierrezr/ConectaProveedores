using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderAccConceptsOrderAccountingAccountingDataTypeRecord
public class JSONRC_27125ab538212d639b6d08211936027a : AbstractRESTStructure<RC_27125ab538212d639b6d08211936027a> {
[JsonProperty("OrderAccConcepts")]
[JsonPropertyName("OrderAccConcepts")]
public ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord AttrOrderAccConcepts;

[JsonProperty("OrderAccounting")]
[JsonPropertyName("OrderAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord AttrOrderAccounting;

[JsonProperty("AccountingDataType")]
[JsonPropertyName("AccountingDataType")]
public ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord AttrAccountingDataType;

public JSONRC_27125ab538212d639b6d08211936027a() { }

public JSONRC_27125ab538212d639b6d08211936027a (RC_27125ab538212d639b6d08211936027a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderAccConcepts = ConvertToRestWithoutDefaults(s.ssENOrderAccConcepts, new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure, config);
AttrOrderAccounting = ConvertToRestWithoutDefaults(s.ssENOrderAccounting, new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.FromStructure, config);
AttrAccountingDataType = ConvertToRestWithoutDefaults(s.ssENAccountingDataType, new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure, config);
  } else {
AttrOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure(s.ssENOrderAccConcepts, config);
AttrOrderAccounting = ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.FromStructure(s.ssENOrderAccounting, config);
AttrAccountingDataType = ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure(s.ssENAccountingDataType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_27125ab538212d639b6d08211936027a, RC_27125ab538212d639b6d08211936027a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_27125ab538212d639b6d08211936027a s) => ToStructure(s, config);
}
public static RC_27125ab538212d639b6d08211936027a ToStructure(ssConectaProveedores.RestRecords.JSONRC_27125ab538212d639b6d08211936027a obj, IBehaviorsConfiguration config) { 
  RC_27125ab538212d639b6d08211936027a s = new RC_27125ab538212d639b6d08211936027a();
  if(obj != null) {
  s.ssENOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure(obj.AttrOrderAccConcepts, config);
  s.ssENOrderAccounting = ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.ToStructure(obj.AttrOrderAccounting, config);
  s.ssENAccountingDataType = ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.ToStructure(obj.AttrAccountingDataType, config);
  }
  return s;
}

public static Func<RC_27125ab538212d639b6d08211936027a, ssConectaProveedores.RestRecords.JSONRC_27125ab538212d639b6d08211936027a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_27125ab538212d639b6d08211936027a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_27125ab538212d639b6d08211936027a FromStructure(RC_27125ab538212d639b6d08211936027a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_27125ab538212d639b6d08211936027a(s, config);
}

}


