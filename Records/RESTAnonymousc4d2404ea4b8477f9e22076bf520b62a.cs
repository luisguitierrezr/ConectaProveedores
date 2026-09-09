using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AccountingDataTypeRecord
public class RESTRC_a222d17a2b10e551d257fa2f5892499c : AbstractRESTStructure<RC_a222d17a2b10e551d257fa2f5892499c> {
[JsonProperty("AccountingDataType")]
public ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord AttrAccountingDataType;

public RESTRC_a222d17a2b10e551d257fa2f5892499c() { }

public RESTRC_a222d17a2b10e551d257fa2f5892499c (RC_a222d17a2b10e551d257fa2f5892499c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccountingDataType = ConvertToRestWithoutDefaults(s.ssENAccountingDataType, new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure, config);
  } else {
AttrAccountingDataType = ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure(s.ssENAccountingDataType, config);
  }
}

public static RC_a222d17a2b10e551d257fa2f5892499c ToStructure(ssConectaProveedores.RestRecords.RESTRC_a222d17a2b10e551d257fa2f5892499c obj) { 
  RC_a222d17a2b10e551d257fa2f5892499c s = new RC_a222d17a2b10e551d257fa2f5892499c();
  if(obj != null) {
  s.ssENAccountingDataType = ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.ToStructure(obj.AttrAccountingDataType);
  }
  return s;
}

public static Func<RC_a222d17a2b10e551d257fa2f5892499c, ssConectaProveedores.RestRecords.RESTRC_a222d17a2b10e551d257fa2f5892499c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a222d17a2b10e551d257fa2f5892499c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a222d17a2b10e551d257fa2f5892499c FromStructure(RC_a222d17a2b10e551d257fa2f5892499c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a222d17a2b10e551d257fa2f5892499c(s, config);
}

}


