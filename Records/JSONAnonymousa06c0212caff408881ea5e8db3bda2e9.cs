using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderDistributionConfigTelcelDirectionRegionRecord
public class JSONRC_c8d5cf7b74d96976f36c31131cf6e264 : AbstractRESTStructure<RC_c8d5cf7b74d96976f36c31131cf6e264> {
[JsonProperty("OrderDistributionConfig")]
[JsonPropertyName("OrderDistributionConfig")]
public ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord AttrOrderDistributionConfig;

[JsonProperty("TelcelDirection")]
[JsonPropertyName("TelcelDirection")]
public ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord AttrTelcelDirection;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_c8d5cf7b74d96976f36c31131cf6e264() { }

public JSONRC_c8d5cf7b74d96976f36c31131cf6e264 (RC_c8d5cf7b74d96976f36c31131cf6e264 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderDistributionConfig = ConvertToRestWithoutDefaults(s.ssENOrderDistributionConfig, new EN_4ad0cdb13562998fda111463f2af9c31EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord.FromStructure, config);
AttrTelcelDirection = ConvertToRestWithoutDefaults(s.ssENTelcelDirection, new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrOrderDistributionConfig = ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord.FromStructure(s.ssENOrderDistributionConfig, config);
AttrTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure(s.ssENTelcelDirection, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c8d5cf7b74d96976f36c31131cf6e264, RC_c8d5cf7b74d96976f36c31131cf6e264> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c8d5cf7b74d96976f36c31131cf6e264 s) => ToStructure(s, config);
}
public static RC_c8d5cf7b74d96976f36c31131cf6e264 ToStructure(ssConectaProveedores.RestRecords.JSONRC_c8d5cf7b74d96976f36c31131cf6e264 obj, IBehaviorsConfiguration config) { 
  RC_c8d5cf7b74d96976f36c31131cf6e264 s = new RC_c8d5cf7b74d96976f36c31131cf6e264();
  if(obj != null) {
  s.ssENOrderDistributionConfig = ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord.ToStructure(obj.AttrOrderDistributionConfig, config);
  s.ssENTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.ToStructure(obj.AttrTelcelDirection, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_c8d5cf7b74d96976f36c31131cf6e264, ssConectaProveedores.RestRecords.JSONRC_c8d5cf7b74d96976f36c31131cf6e264> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c8d5cf7b74d96976f36c31131cf6e264 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c8d5cf7b74d96976f36c31131cf6e264 FromStructure(RC_c8d5cf7b74d96976f36c31131cf6e264 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c8d5cf7b74d96976f36c31131cf6e264(s, config);
}

}


