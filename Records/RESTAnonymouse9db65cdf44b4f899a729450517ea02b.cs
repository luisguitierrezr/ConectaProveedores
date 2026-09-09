using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderApprovaLevelIdOrderMainIdRecord
public class RESTRC_1b6a0ce1f3825bc6a50605a3cd525b9e : AbstractRESTStructure<RC_1b6a0ce1f3825bc6a50605a3cd525b9e> {
[JsonProperty("OrderApprovaLevelId")]
public long? AttrOrderApprovaLevelId;

[JsonProperty("OrderMainId")]
public long? AttrOrderMainId;

public RESTRC_1b6a0ce1f3825bc6a50605a3cd525b9e() { }

public RESTRC_1b6a0ce1f3825bc6a50605a3cd525b9e (RC_1b6a0ce1f3825bc6a50605a3cd525b9e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderApprovaLevelId = ConvertToRestWithoutDefaults(s.ssOrderApprovaLevelId, 0L);
AttrOrderMainId = ConvertToRestWithoutDefaults(s.ssOrderMainId, 0L);
  } else {
AttrOrderApprovaLevelId = (long?) s.ssOrderApprovaLevelId;
AttrOrderMainId = (long?) s.ssOrderMainId;
  }
}

public static RC_1b6a0ce1f3825bc6a50605a3cd525b9e ToStructure(ssConectaProveedores.RestRecords.RESTRC_1b6a0ce1f3825bc6a50605a3cd525b9e obj) { 
  RC_1b6a0ce1f3825bc6a50605a3cd525b9e s = new RC_1b6a0ce1f3825bc6a50605a3cd525b9e();
  if(obj != null) {
  s.ssOrderApprovaLevelId = obj.AttrOrderApprovaLevelId == null ? 0L : obj.AttrOrderApprovaLevelId.Value;
  s.ssOrderMainId = obj.AttrOrderMainId == null ? 0L : obj.AttrOrderMainId.Value;
  }
  return s;
}

public static Func<RC_1b6a0ce1f3825bc6a50605a3cd525b9e, ssConectaProveedores.RestRecords.RESTRC_1b6a0ce1f3825bc6a50605a3cd525b9e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1b6a0ce1f3825bc6a50605a3cd525b9e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1b6a0ce1f3825bc6a50605a3cd525b9e FromStructure(RC_1b6a0ce1f3825bc6a50605a3cd525b9e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1b6a0ce1f3825bc6a50605a3cd525b9e(s, config);
}

}


