using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderDistributionConfigRecord
public class JSONRC_9fc59bda41db740ae87f91f135d24811 : AbstractRESTStructure<RC_9fc59bda41db740ae87f91f135d24811> {
[JsonProperty("OrderDistributionConfig")]
[JsonPropertyName("OrderDistributionConfig")]
public ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord AttrOrderDistributionConfig;

public JSONRC_9fc59bda41db740ae87f91f135d24811() { }

public JSONRC_9fc59bda41db740ae87f91f135d24811 (RC_9fc59bda41db740ae87f91f135d24811 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderDistributionConfig = ConvertToRestWithoutDefaults(s.ssENOrderDistributionConfig, new EN_4ad0cdb13562998fda111463f2af9c31EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord.FromStructure, config);
  } else {
AttrOrderDistributionConfig = ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord.FromStructure(s.ssENOrderDistributionConfig, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_9fc59bda41db740ae87f91f135d24811, RC_9fc59bda41db740ae87f91f135d24811> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_9fc59bda41db740ae87f91f135d24811 s) => ToStructure(s, config);
}
public static RC_9fc59bda41db740ae87f91f135d24811 ToStructure(ssConectaProveedores.RestRecords.JSONRC_9fc59bda41db740ae87f91f135d24811 obj, IBehaviorsConfiguration config) { 
  RC_9fc59bda41db740ae87f91f135d24811 s = new RC_9fc59bda41db740ae87f91f135d24811();
  if(obj != null) {
  s.ssENOrderDistributionConfig = ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord.ToStructure(obj.AttrOrderDistributionConfig, config);
  }
  return s;
}

public static Func<RC_9fc59bda41db740ae87f91f135d24811, ssConectaProveedores.RestRecords.JSONRC_9fc59bda41db740ae87f91f135d24811> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9fc59bda41db740ae87f91f135d24811 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_9fc59bda41db740ae87f91f135d24811 FromStructure(RC_9fc59bda41db740ae87f91f135d24811 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_9fc59bda41db740ae87f91f135d24811(s, config);
}

}


