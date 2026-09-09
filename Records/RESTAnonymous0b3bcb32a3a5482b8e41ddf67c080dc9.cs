using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Project_Asset_ServiceRecord
public class RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e : AbstractRESTStructure<RC_1b08a2c1cecef1e3b3006a60b97fc68e> {
[JsonProperty("Project_Asset_Service")]
public ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord AttrProject_Asset_Service;

public RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e() { }

public RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e (RC_1b08a2c1cecef1e3b3006a60b97fc68e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProject_Asset_Service = ConvertToRestWithoutDefaults(s.ssENProject_Asset_Service, new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure, config);
  } else {
AttrProject_Asset_Service = ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure(s.ssENProject_Asset_Service, config);
  }
}

public static RC_1b08a2c1cecef1e3b3006a60b97fc68e ToStructure(ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e obj) { 
  RC_1b08a2c1cecef1e3b3006a60b97fc68e s = new RC_1b08a2c1cecef1e3b3006a60b97fc68e();
  if(obj != null) {
  s.ssENProject_Asset_Service = ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.ToStructure(obj.AttrProject_Asset_Service);
  }
  return s;
}

public static Func<RC_1b08a2c1cecef1e3b3006a60b97fc68e, ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1b08a2c1cecef1e3b3006a60b97fc68e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e FromStructure(RC_1b08a2c1cecef1e3b3006a60b97fc68e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e(s, config);
}

}


