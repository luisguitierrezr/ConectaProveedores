using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderDistributionConfigTelcelDirectionRegionRecord
public class RESTRC_c8d5cf7b74d96976f36c31131cf6e264 : AbstractRESTStructure<RC_c8d5cf7b74d96976f36c31131cf6e264> {
[JsonProperty("OrderDistributionConfig")]
public ssConectaProveedores.RestRecords.RESTEN_4ad0cdb13562998fda111463f2af9c31EntityRecord AttrOrderDistributionConfig;

[JsonProperty("TelcelDirection")]
public ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord AttrTelcelDirection;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_c8d5cf7b74d96976f36c31131cf6e264() { }

public RESTRC_c8d5cf7b74d96976f36c31131cf6e264 (RC_c8d5cf7b74d96976f36c31131cf6e264 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderDistributionConfig = ConvertToRestWithoutDefaults(s.ssENOrderDistributionConfig, new EN_4ad0cdb13562998fda111463f2af9c31EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4ad0cdb13562998fda111463f2af9c31EntityRecord.FromStructure, config);
AttrTelcelDirection = ConvertToRestWithoutDefaults(s.ssENTelcelDirection, new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrOrderDistributionConfig = ssConectaProveedores.RestRecords.RESTEN_4ad0cdb13562998fda111463f2af9c31EntityRecord.FromStructure(s.ssENOrderDistributionConfig, config);
AttrTelcelDirection = ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure(s.ssENTelcelDirection, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_c8d5cf7b74d96976f36c31131cf6e264 ToStructure(ssConectaProveedores.RestRecords.RESTRC_c8d5cf7b74d96976f36c31131cf6e264 obj) { 
  RC_c8d5cf7b74d96976f36c31131cf6e264 s = new RC_c8d5cf7b74d96976f36c31131cf6e264();
  if(obj != null) {
  s.ssENOrderDistributionConfig = ssConectaProveedores.RestRecords.RESTEN_4ad0cdb13562998fda111463f2af9c31EntityRecord.ToStructure(obj.AttrOrderDistributionConfig);
  s.ssENTelcelDirection = ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.ToStructure(obj.AttrTelcelDirection);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_c8d5cf7b74d96976f36c31131cf6e264, ssConectaProveedores.RestRecords.RESTRC_c8d5cf7b74d96976f36c31131cf6e264> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c8d5cf7b74d96976f36c31131cf6e264 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c8d5cf7b74d96976f36c31131cf6e264 FromStructure(RC_c8d5cf7b74d96976f36c31131cf6e264 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c8d5cf7b74d96976f36c31131cf6e264(s, config);
}

}


