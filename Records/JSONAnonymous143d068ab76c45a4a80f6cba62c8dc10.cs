using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainCompanyRegionRecord
public class JSONRC_71c861973e22846762035e2ce8e6ef99 : AbstractRESTStructure<RC_71c861973e22846762035e2ce8e6ef99> {
[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("Company")]
[JsonPropertyName("Company")]
public ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_71c861973e22846762035e2ce8e6ef99() { }

public JSONRC_71c861973e22846762035e2ce8e6ef99 (RC_71c861973e22846762035e2ce8e6ef99 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_71c861973e22846762035e2ce8e6ef99, RC_71c861973e22846762035e2ce8e6ef99> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_71c861973e22846762035e2ce8e6ef99 s) => ToStructure(s, config);
}
public static RC_71c861973e22846762035e2ce8e6ef99 ToStructure(ssConectaProveedores.RestRecords.JSONRC_71c861973e22846762035e2ce8e6ef99 obj, IBehaviorsConfiguration config) { 
  RC_71c861973e22846762035e2ce8e6ef99 s = new RC_71c861973e22846762035e2ce8e6ef99();
  if(obj != null) {
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_71c861973e22846762035e2ce8e6ef99, ssConectaProveedores.RestRecords.JSONRC_71c861973e22846762035e2ce8e6ef99> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_71c861973e22846762035e2ce8e6ef99 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_71c861973e22846762035e2ce8e6ef99 FromStructure(RC_71c861973e22846762035e2ce8e6ef99 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_71c861973e22846762035e2ce8e6ef99(s, config);
}

}


