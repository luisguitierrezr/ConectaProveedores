using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainSupplierRegionRecord
public class JSONRC_5ad46beda6daded312a458bcd914266d : AbstractRESTStructure<RC_5ad46beda6daded312a458bcd914266d> {
[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_5ad46beda6daded312a458bcd914266d() { }

public JSONRC_5ad46beda6daded312a458bcd914266d (RC_5ad46beda6daded312a458bcd914266d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_5ad46beda6daded312a458bcd914266d, RC_5ad46beda6daded312a458bcd914266d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_5ad46beda6daded312a458bcd914266d s) => ToStructure(s, config);
}
public static RC_5ad46beda6daded312a458bcd914266d ToStructure(ssConectaProveedores.RestRecords.JSONRC_5ad46beda6daded312a458bcd914266d obj, IBehaviorsConfiguration config) { 
  RC_5ad46beda6daded312a458bcd914266d s = new RC_5ad46beda6daded312a458bcd914266d();
  if(obj != null) {
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_5ad46beda6daded312a458bcd914266d, ssConectaProveedores.RestRecords.JSONRC_5ad46beda6daded312a458bcd914266d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5ad46beda6daded312a458bcd914266d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_5ad46beda6daded312a458bcd914266d FromStructure(RC_5ad46beda6daded312a458bcd914266d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_5ad46beda6daded312a458bcd914266d(s, config);
}

}


