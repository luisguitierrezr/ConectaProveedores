using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IdRecord
public class RESTRC_77596ad92a148cdc1c9041931e7db72e : AbstractRESTStructure<RC_77596ad92a148cdc1c9041931e7db72e> {
[JsonProperty("Id")]
public long? AttrId;

public RESTRC_77596ad92a148cdc1c9041931e7db72e() { }

public RESTRC_77596ad92a148cdc1c9041931e7db72e (RC_77596ad92a148cdc1c9041931e7db72e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = ConvertToRestWithoutDefaults(s.ssId, 0L);
  } else {
AttrId = (long?) s.ssId;
  }
}

public static RC_77596ad92a148cdc1c9041931e7db72e ToStructure(ssConectaProveedores.RestRecords.RESTRC_77596ad92a148cdc1c9041931e7db72e obj) { 
  RC_77596ad92a148cdc1c9041931e7db72e s = new RC_77596ad92a148cdc1c9041931e7db72e();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  }
  return s;
}

public static Func<RC_77596ad92a148cdc1c9041931e7db72e, ssConectaProveedores.RestRecords.RESTRC_77596ad92a148cdc1c9041931e7db72e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_77596ad92a148cdc1c9041931e7db72e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_77596ad92a148cdc1c9041931e7db72e FromStructure(RC_77596ad92a148cdc1c9041931e7db72e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_77596ad92a148cdc1c9041931e7db72e(s, config);
}

}


