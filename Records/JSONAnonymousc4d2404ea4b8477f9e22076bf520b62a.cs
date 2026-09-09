using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AccountingDataTypeRecord
public class JSONRC_a222d17a2b10e551d257fa2f5892499c : AbstractRESTStructure<RC_a222d17a2b10e551d257fa2f5892499c> {
[JsonProperty("AccountingDataType")]
[JsonPropertyName("AccountingDataType")]
public ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord AttrAccountingDataType;

public JSONRC_a222d17a2b10e551d257fa2f5892499c() { }

public JSONRC_a222d17a2b10e551d257fa2f5892499c (RC_a222d17a2b10e551d257fa2f5892499c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccountingDataType = ConvertToRestWithoutDefaults(s.ssENAccountingDataType, new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure, config);
  } else {
AttrAccountingDataType = ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure(s.ssENAccountingDataType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a222d17a2b10e551d257fa2f5892499c, RC_a222d17a2b10e551d257fa2f5892499c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a222d17a2b10e551d257fa2f5892499c s) => ToStructure(s, config);
}
public static RC_a222d17a2b10e551d257fa2f5892499c ToStructure(ssConectaProveedores.RestRecords.JSONRC_a222d17a2b10e551d257fa2f5892499c obj, IBehaviorsConfiguration config) { 
  RC_a222d17a2b10e551d257fa2f5892499c s = new RC_a222d17a2b10e551d257fa2f5892499c();
  if(obj != null) {
  s.ssENAccountingDataType = ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.ToStructure(obj.AttrAccountingDataType, config);
  }
  return s;
}

public static Func<RC_a222d17a2b10e551d257fa2f5892499c, ssConectaProveedores.RestRecords.JSONRC_a222d17a2b10e551d257fa2f5892499c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a222d17a2b10e551d257fa2f5892499c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a222d17a2b10e551d257fa2f5892499c FromStructure(RC_a222d17a2b10e551d257fa2f5892499c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a222d17a2b10e551d257fa2f5892499c(s, config);
}

}


