using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CountLogsRecord
public class RESTRC_d896ddfd96504faa41bec68e2ff8d0eb : AbstractRESTStructure<RC_d896ddfd96504faa41bec68e2ff8d0eb> {
[JsonProperty("CountLogs")]
public long? AttrCountLogs;

public RESTRC_d896ddfd96504faa41bec68e2ff8d0eb() { }

public RESTRC_d896ddfd96504faa41bec68e2ff8d0eb (RC_d896ddfd96504faa41bec68e2ff8d0eb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCountLogs = ConvertToRestWithoutDefaults(s.ssCountLogs, 0L);
  } else {
AttrCountLogs = (long?) s.ssCountLogs;
  }
}

public static RC_d896ddfd96504faa41bec68e2ff8d0eb ToStructure(ssConectaProveedores.RestRecords.RESTRC_d896ddfd96504faa41bec68e2ff8d0eb obj) { 
  RC_d896ddfd96504faa41bec68e2ff8d0eb s = new RC_d896ddfd96504faa41bec68e2ff8d0eb();
  if(obj != null) {
  s.ssCountLogs = obj.AttrCountLogs == null ? 0L : obj.AttrCountLogs.Value;
  }
  return s;
}

public static Func<RC_d896ddfd96504faa41bec68e2ff8d0eb, ssConectaProveedores.RestRecords.RESTRC_d896ddfd96504faa41bec68e2ff8d0eb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d896ddfd96504faa41bec68e2ff8d0eb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d896ddfd96504faa41bec68e2ff8d0eb FromStructure(RC_d896ddfd96504faa41bec68e2ff8d0eb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d896ddfd96504faa41bec68e2ff8d0eb(s, config);
}

}


