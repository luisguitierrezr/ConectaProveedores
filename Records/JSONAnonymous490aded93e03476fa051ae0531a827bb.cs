using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioOrderMainSupplierRegionRecord
public class JSONRC_428141695aee6b3458a97f3fa044a69e : AbstractRESTStructure<RC_428141695aee6b3458a97f3fa044a69e> {
[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_428141695aee6b3458a97f3fa044a69e() { }

public JSONRC_428141695aee6b3458a97f3fa044a69e (RC_428141695aee6b3458a97f3fa044a69e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_428141695aee6b3458a97f3fa044a69e, RC_428141695aee6b3458a97f3fa044a69e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_428141695aee6b3458a97f3fa044a69e s) => ToStructure(s, config);
}
public static RC_428141695aee6b3458a97f3fa044a69e ToStructure(ssConectaProveedores.RestRecords.JSONRC_428141695aee6b3458a97f3fa044a69e obj, IBehaviorsConfiguration config) { 
  RC_428141695aee6b3458a97f3fa044a69e s = new RC_428141695aee6b3458a97f3fa044a69e();
  if(obj != null) {
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_428141695aee6b3458a97f3fa044a69e, ssConectaProveedores.RestRecords.JSONRC_428141695aee6b3458a97f3fa044a69e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_428141695aee6b3458a97f3fa044a69e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_428141695aee6b3458a97f3fa044a69e FromStructure(RC_428141695aee6b3458a97f3fa044a69e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_428141695aee6b3458a97f3fa044a69e(s, config);
}

}


