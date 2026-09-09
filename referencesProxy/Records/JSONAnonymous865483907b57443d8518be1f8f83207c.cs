using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// TaxIndicatorRecord
public class JSONRC_680b4f2b38f7607d61faf8ef68fd2613 : AbstractRESTStructure<RC_680b4f2b38f7607d61faf8ef68fd2613> {
[JsonProperty("TaxIndicator")]
[JsonPropertyName("TaxIndicator")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord AttrTaxIndicator;

public JSONRC_680b4f2b38f7607d61faf8ef68fd2613() { }

public JSONRC_680b4f2b38f7607d61faf8ef68fd2613 (RC_680b4f2b38f7607d61faf8ef68fd2613 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTaxIndicator = ConvertToRestWithoutDefaults(s.ssENTaxIndicator, new EN_efc751d189a1545503ba31ced5225e86EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord.FromStructure, config);
  } else {
AttrTaxIndicator = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord.FromStructure(s.ssENTaxIndicator, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_680b4f2b38f7607d61faf8ef68fd2613, RC_680b4f2b38f7607d61faf8ef68fd2613> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_680b4f2b38f7607d61faf8ef68fd2613 s) => ToStructure(s, config);
}
public static RC_680b4f2b38f7607d61faf8ef68fd2613 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_680b4f2b38f7607d61faf8ef68fd2613 obj, IBehaviorsConfiguration config) { 
  RC_680b4f2b38f7607d61faf8ef68fd2613 s = new RC_680b4f2b38f7607d61faf8ef68fd2613();
  if(obj != null) {
  s.ssENTaxIndicator = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord.ToStructure(obj.AttrTaxIndicator, config);
  }
  return s;
}

public static Func<RC_680b4f2b38f7607d61faf8ef68fd2613, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_680b4f2b38f7607d61faf8ef68fd2613> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_680b4f2b38f7607d61faf8ef68fd2613 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_680b4f2b38f7607d61faf8ef68fd2613 FromStructure(RC_680b4f2b38f7607d61faf8ef68fd2613 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_680b4f2b38f7607d61faf8ef68fd2613(s, config);
}

}


