using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderDistributionConfigFirstApproverEntraRoleFirstContactEntraRoleSecondApproverEntraRoleSecondContactEntraRoleRegionNumberTelcelDirectionRegionRecord
public class JSONRC_c1e2ad1f67f216fd0b4fb3f61e1c54ad : AbstractRESTStructure<RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad> {
[JsonProperty("OrderDistributionConfig")]
[JsonPropertyName("OrderDistributionConfig")]
public ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord AttrOrderDistributionConfig;

[JsonProperty("FirstApproverEntraRole")]
[JsonPropertyName("FirstApproverEntraRole")]
public ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrFirstApproverEntraRole;

[JsonProperty("FirstContactEntraRole")]
[JsonPropertyName("FirstContactEntraRole")]
public ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrFirstContactEntraRole;

[JsonProperty("SecondApproverEntraRole")]
[JsonPropertyName("SecondApproverEntraRole")]
public ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrSecondApproverEntraRole;

[JsonProperty("SecondContactEntraRole")]
[JsonPropertyName("SecondContactEntraRole")]
public ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrSecondContactEntraRole;

[JsonProperty("RegionNumber")]
[JsonPropertyName("RegionNumber")]
public string AttrRegionNumber;

[JsonProperty("TelcelDirection")]
[JsonPropertyName("TelcelDirection")]
public ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord AttrTelcelDirection;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_c1e2ad1f67f216fd0b4fb3f61e1c54ad() { }

public JSONRC_c1e2ad1f67f216fd0b4fb3f61e1c54ad (RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderDistributionConfig = ConvertToRestWithoutDefaults(s.ssENOrderDistributionConfig, new EN_4ad0cdb13562998fda111463f2af9c31EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord.FromStructure, config);
AttrFirstApproverEntraRole = ConvertToRestWithoutDefaults(s.ssENFirstApproverEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
AttrFirstContactEntraRole = ConvertToRestWithoutDefaults(s.ssENFirstContactEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
AttrSecondApproverEntraRole = ConvertToRestWithoutDefaults(s.ssENSecondApproverEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
AttrSecondContactEntraRole = ConvertToRestWithoutDefaults(s.ssENSecondContactEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
AttrRegionNumber = ConvertToRestWithoutDefaults(s.ssRegionNumber, "");
AttrTelcelDirection = ConvertToRestWithoutDefaults(s.ssENTelcelDirection, new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrOrderDistributionConfig = ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord.FromStructure(s.ssENOrderDistributionConfig, config);
AttrFirstApproverEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENFirstApproverEntraRole, config);
AttrFirstContactEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENFirstContactEntraRole, config);
AttrSecondApproverEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENSecondApproverEntraRole, config);
AttrSecondContactEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENSecondContactEntraRole, config);
AttrRegionNumber = s.ssRegionNumber;
AttrTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure(s.ssENTelcelDirection, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c1e2ad1f67f216fd0b4fb3f61e1c54ad, RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c1e2ad1f67f216fd0b4fb3f61e1c54ad s) => ToStructure(s, config);
}
public static RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad ToStructure(ssConectaProveedores.RestRecords.JSONRC_c1e2ad1f67f216fd0b4fb3f61e1c54ad obj, IBehaviorsConfiguration config) { 
  RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad s = new RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad();
  if(obj != null) {
  s.ssENOrderDistributionConfig = ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord.ToStructure(obj.AttrOrderDistributionConfig, config);
  s.ssENFirstApproverEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrFirstApproverEntraRole, config);
  s.ssENFirstContactEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrFirstContactEntraRole, config);
  s.ssENSecondApproverEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrSecondApproverEntraRole, config);
  s.ssENSecondContactEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrSecondContactEntraRole, config);
  s.ssRegionNumber = obj.AttrRegionNumber == null ? "" : obj.AttrRegionNumber;
  s.ssENTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.ToStructure(obj.AttrTelcelDirection, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad, ssConectaProveedores.RestRecords.JSONRC_c1e2ad1f67f216fd0b4fb3f61e1c54ad> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c1e2ad1f67f216fd0b4fb3f61e1c54ad FromStructure(RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c1e2ad1f67f216fd0b4fb3f61e1c54ad(s, config);
}

}


