using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Project_Asset_ServiceRecord
public class JSONRC_1b08a2c1cecef1e3b3006a60b97fc68e : AbstractRESTStructure<RC_1b08a2c1cecef1e3b3006a60b97fc68e> {
[JsonProperty("Project_Asset_Service")]
[JsonPropertyName("Project_Asset_Service")]
public ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord AttrProject_Asset_Service;

public JSONRC_1b08a2c1cecef1e3b3006a60b97fc68e() { }

public JSONRC_1b08a2c1cecef1e3b3006a60b97fc68e (RC_1b08a2c1cecef1e3b3006a60b97fc68e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProject_Asset_Service = ConvertToRestWithoutDefaults(s.ssENProject_Asset_Service, new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure, config);
  } else {
AttrProject_Asset_Service = ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure(s.ssENProject_Asset_Service, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1b08a2c1cecef1e3b3006a60b97fc68e, RC_1b08a2c1cecef1e3b3006a60b97fc68e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1b08a2c1cecef1e3b3006a60b97fc68e s) => ToStructure(s, config);
}
public static RC_1b08a2c1cecef1e3b3006a60b97fc68e ToStructure(ssConectaProveedores.RestRecords.JSONRC_1b08a2c1cecef1e3b3006a60b97fc68e obj, IBehaviorsConfiguration config) { 
  RC_1b08a2c1cecef1e3b3006a60b97fc68e s = new RC_1b08a2c1cecef1e3b3006a60b97fc68e();
  if(obj != null) {
  s.ssENProject_Asset_Service = ssConectaProveedores.RestRecords.JSONEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.ToStructure(obj.AttrProject_Asset_Service, config);
  }
  return s;
}

public static Func<RC_1b08a2c1cecef1e3b3006a60b97fc68e, ssConectaProveedores.RestRecords.JSONRC_1b08a2c1cecef1e3b3006a60b97fc68e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1b08a2c1cecef1e3b3006a60b97fc68e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1b08a2c1cecef1e3b3006a60b97fc68e FromStructure(RC_1b08a2c1cecef1e3b3006a60b97fc68e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1b08a2c1cecef1e3b3006a60b97fc68e(s, config);
}

}


