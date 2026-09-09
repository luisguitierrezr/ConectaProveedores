using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IdRecord
public class JSONRC_77596ad92a148cdc1c9041931e7db72e : AbstractRESTStructure<RC_77596ad92a148cdc1c9041931e7db72e> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

public JSONRC_77596ad92a148cdc1c9041931e7db72e() { }

public JSONRC_77596ad92a148cdc1c9041931e7db72e (RC_77596ad92a148cdc1c9041931e7db72e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = ConvertToRestWithoutDefaults(s.ssId, 0L);
  } else {
AttrId = (long?) s.ssId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_77596ad92a148cdc1c9041931e7db72e, RC_77596ad92a148cdc1c9041931e7db72e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_77596ad92a148cdc1c9041931e7db72e s) => ToStructure(s, config);
}
public static RC_77596ad92a148cdc1c9041931e7db72e ToStructure(ssConectaProveedores.RestRecords.JSONRC_77596ad92a148cdc1c9041931e7db72e obj, IBehaviorsConfiguration config) { 
  RC_77596ad92a148cdc1c9041931e7db72e s = new RC_77596ad92a148cdc1c9041931e7db72e();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  }
  return s;
}

public static Func<RC_77596ad92a148cdc1c9041931e7db72e, ssConectaProveedores.RestRecords.JSONRC_77596ad92a148cdc1c9041931e7db72e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_77596ad92a148cdc1c9041931e7db72e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_77596ad92a148cdc1c9041931e7db72e FromStructure(RC_77596ad92a148cdc1c9041931e7db72e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_77596ad92a148cdc1c9041931e7db72e(s, config);
}

}


