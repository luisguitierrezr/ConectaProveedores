using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ACCOUNT_DETAILRecord
public class JSONRC_80a85ef874ec36a6401c319bb24497b9 : AbstractRESTStructure<RC_80a85ef874ec36a6401c319bb24497b9> {
[JsonProperty("ACCOUNT_DETAIL")]
[JsonPropertyName("ACCOUNT_DETAIL")]
public ssConectaProveedores.RestRecords.JSONST_d2beaf811f074c88054765b10d929011Structure AttrACCOUNT_DETAIL;

public JSONRC_80a85ef874ec36a6401c319bb24497b9() { }

public JSONRC_80a85ef874ec36a6401c319bb24497b9 (RC_80a85ef874ec36a6401c319bb24497b9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrACCOUNT_DETAIL = ConvertToRestWithoutDefaults(s.ssSTACCOUNT_DETAIL, new ST_d2beaf811f074c88054765b10d929011Structure(), ssConectaProveedores.RestRecords.JSONST_d2beaf811f074c88054765b10d929011Structure.FromStructure, config);
  } else {
AttrACCOUNT_DETAIL = ssConectaProveedores.RestRecords.JSONST_d2beaf811f074c88054765b10d929011Structure.FromStructure(s.ssSTACCOUNT_DETAIL, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_80a85ef874ec36a6401c319bb24497b9, RC_80a85ef874ec36a6401c319bb24497b9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_80a85ef874ec36a6401c319bb24497b9 s) => ToStructure(s, config);
}
public static RC_80a85ef874ec36a6401c319bb24497b9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_80a85ef874ec36a6401c319bb24497b9 obj, IBehaviorsConfiguration config) { 
  RC_80a85ef874ec36a6401c319bb24497b9 s = new RC_80a85ef874ec36a6401c319bb24497b9();
  if(obj != null) {
  s.ssSTACCOUNT_DETAIL = ssConectaProveedores.RestRecords.JSONST_d2beaf811f074c88054765b10d929011Structure.ToStructure(obj.AttrACCOUNT_DETAIL, config);
  }
  return s;
}

public static Func<RC_80a85ef874ec36a6401c319bb24497b9, ssConectaProveedores.RestRecords.JSONRC_80a85ef874ec36a6401c319bb24497b9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_80a85ef874ec36a6401c319bb24497b9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_80a85ef874ec36a6401c319bb24497b9 FromStructure(RC_80a85ef874ec36a6401c319bb24497b9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_80a85ef874ec36a6401c319bb24497b9(s, config);
}

}


