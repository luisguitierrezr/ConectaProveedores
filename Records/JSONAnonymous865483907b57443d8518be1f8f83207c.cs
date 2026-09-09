using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TaxIndicatorRecord
public class JSONRC_680b4f2b38f7607d61faf8ef68fd2613 : AbstractRESTStructure<RC_680b4f2b38f7607d61faf8ef68fd2613> {
[JsonProperty("TaxIndicator")]
[JsonPropertyName("TaxIndicator")]
public ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord AttrTaxIndicator;

public JSONRC_680b4f2b38f7607d61faf8ef68fd2613() { }

public JSONRC_680b4f2b38f7607d61faf8ef68fd2613 (RC_680b4f2b38f7607d61faf8ef68fd2613 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTaxIndicator = ConvertToRestWithoutDefaults(s.ssENTaxIndicator, new EN_efc751d189a1545503ba31ced5225e86EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord.FromStructure, config);
  } else {
AttrTaxIndicator = ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord.FromStructure(s.ssENTaxIndicator, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_680b4f2b38f7607d61faf8ef68fd2613, RC_680b4f2b38f7607d61faf8ef68fd2613> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_680b4f2b38f7607d61faf8ef68fd2613 s) => ToStructure(s, config);
}
public static RC_680b4f2b38f7607d61faf8ef68fd2613 ToStructure(ssConectaProveedores.RestRecords.JSONRC_680b4f2b38f7607d61faf8ef68fd2613 obj, IBehaviorsConfiguration config) { 
  RC_680b4f2b38f7607d61faf8ef68fd2613 s = new RC_680b4f2b38f7607d61faf8ef68fd2613();
  if(obj != null) {
  s.ssENTaxIndicator = ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord.ToStructure(obj.AttrTaxIndicator, config);
  }
  return s;
}

public static Func<RC_680b4f2b38f7607d61faf8ef68fd2613, ssConectaProveedores.RestRecords.JSONRC_680b4f2b38f7607d61faf8ef68fd2613> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_680b4f2b38f7607d61faf8ef68fd2613 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_680b4f2b38f7607d61faf8ef68fd2613 FromStructure(RC_680b4f2b38f7607d61faf8ef68fd2613 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_680b4f2b38f7607d61faf8ef68fd2613(s, config);
}

}


