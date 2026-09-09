using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TaxIndicatorRecord
public class RESTRC_680b4f2b38f7607d61faf8ef68fd2613 : AbstractRESTStructure<RC_680b4f2b38f7607d61faf8ef68fd2613> {
[JsonProperty("TaxIndicator")]
public ssConectaProveedores.RestRecords.RESTEN_efc751d189a1545503ba31ced5225e86EntityRecord AttrTaxIndicator;

public RESTRC_680b4f2b38f7607d61faf8ef68fd2613() { }

public RESTRC_680b4f2b38f7607d61faf8ef68fd2613 (RC_680b4f2b38f7607d61faf8ef68fd2613 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTaxIndicator = ConvertToRestWithoutDefaults(s.ssENTaxIndicator, new EN_efc751d189a1545503ba31ced5225e86EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_efc751d189a1545503ba31ced5225e86EntityRecord.FromStructure, config);
  } else {
AttrTaxIndicator = ssConectaProveedores.RestRecords.RESTEN_efc751d189a1545503ba31ced5225e86EntityRecord.FromStructure(s.ssENTaxIndicator, config);
  }
}

public static RC_680b4f2b38f7607d61faf8ef68fd2613 ToStructure(ssConectaProveedores.RestRecords.RESTRC_680b4f2b38f7607d61faf8ef68fd2613 obj) { 
  RC_680b4f2b38f7607d61faf8ef68fd2613 s = new RC_680b4f2b38f7607d61faf8ef68fd2613();
  if(obj != null) {
  s.ssENTaxIndicator = ssConectaProveedores.RestRecords.RESTEN_efc751d189a1545503ba31ced5225e86EntityRecord.ToStructure(obj.AttrTaxIndicator);
  }
  return s;
}

public static Func<RC_680b4f2b38f7607d61faf8ef68fd2613, ssConectaProveedores.RestRecords.RESTRC_680b4f2b38f7607d61faf8ef68fd2613> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_680b4f2b38f7607d61faf8ef68fd2613 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_680b4f2b38f7607d61faf8ef68fd2613 FromStructure(RC_680b4f2b38f7607d61faf8ef68fd2613 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_680b4f2b38f7607d61faf8ef68fd2613(s, config);
}

}


