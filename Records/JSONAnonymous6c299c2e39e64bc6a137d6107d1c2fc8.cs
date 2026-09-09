using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderAccConceptsOrderAccountingOrderMainAccountingDataTypeRecord
public class JSONRC_ab3c433102000c44a55e713fb2ce955d : AbstractRESTStructure<RC_ab3c433102000c44a55e713fb2ce955d> {
[JsonProperty("OrderAccConcepts")]
[JsonPropertyName("OrderAccConcepts")]
public ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord AttrOrderAccConcepts;

[JsonProperty("OrderAccounting")]
[JsonPropertyName("OrderAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord AttrOrderAccounting;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("AccountingDataType")]
[JsonPropertyName("AccountingDataType")]
public ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord AttrAccountingDataType;

public JSONRC_ab3c433102000c44a55e713fb2ce955d() { }

public JSONRC_ab3c433102000c44a55e713fb2ce955d (RC_ab3c433102000c44a55e713fb2ce955d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderAccConcepts = ConvertToRestWithoutDefaults(s.ssENOrderAccConcepts, new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure, config);
AttrOrderAccounting = ConvertToRestWithoutDefaults(s.ssENOrderAccounting, new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrAccountingDataType = ConvertToRestWithoutDefaults(s.ssENAccountingDataType, new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure, config);
  } else {
AttrOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure(s.ssENOrderAccConcepts, config);
AttrOrderAccounting = ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.FromStructure(s.ssENOrderAccounting, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrAccountingDataType = ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure(s.ssENAccountingDataType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ab3c433102000c44a55e713fb2ce955d, RC_ab3c433102000c44a55e713fb2ce955d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ab3c433102000c44a55e713fb2ce955d s) => ToStructure(s, config);
}
public static RC_ab3c433102000c44a55e713fb2ce955d ToStructure(ssConectaProveedores.RestRecords.JSONRC_ab3c433102000c44a55e713fb2ce955d obj, IBehaviorsConfiguration config) { 
  RC_ab3c433102000c44a55e713fb2ce955d s = new RC_ab3c433102000c44a55e713fb2ce955d();
  if(obj != null) {
  s.ssENOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure(obj.AttrOrderAccConcepts, config);
  s.ssENOrderAccounting = ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.ToStructure(obj.AttrOrderAccounting, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENAccountingDataType = ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.ToStructure(obj.AttrAccountingDataType, config);
  }
  return s;
}

public static Func<RC_ab3c433102000c44a55e713fb2ce955d, ssConectaProveedores.RestRecords.JSONRC_ab3c433102000c44a55e713fb2ce955d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ab3c433102000c44a55e713fb2ce955d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ab3c433102000c44a55e713fb2ce955d FromStructure(RC_ab3c433102000c44a55e713fb2ce955d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ab3c433102000c44a55e713fb2ce955d(s, config);
}

}


