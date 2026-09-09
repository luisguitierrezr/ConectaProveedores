using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CompanySupplierSupplierDetailRegionRecord
public class JSONRC_631f64667ced05b3101507560ed0f622 : AbstractRESTStructure<RC_631f64667ced05b3101507560ed0f622> {
[JsonProperty("Company")]
[JsonPropertyName("Company")]
public ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("SupplierDetail")]
[JsonPropertyName("SupplierDetail")]
public ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord AttrSupplierDetail;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_631f64667ced05b3101507560ed0f622() { }

public JSONRC_631f64667ced05b3101507560ed0f622 (RC_631f64667ced05b3101507560ed0f622 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrSupplierDetail = ConvertToRestWithoutDefaults(s.ssENSupplierDetail, new EN_57ee0c02163ab55038103469b2569162EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrSupplierDetail = ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord.FromStructure(s.ssENSupplierDetail, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_631f64667ced05b3101507560ed0f622, RC_631f64667ced05b3101507560ed0f622> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_631f64667ced05b3101507560ed0f622 s) => ToStructure(s, config);
}
public static RC_631f64667ced05b3101507560ed0f622 ToStructure(ssConectaProveedores.RestRecords.JSONRC_631f64667ced05b3101507560ed0f622 obj, IBehaviorsConfiguration config) { 
  RC_631f64667ced05b3101507560ed0f622 s = new RC_631f64667ced05b3101507560ed0f622();
  if(obj != null) {
  s.ssENCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  s.ssENSupplierDetail = ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord.ToStructure(obj.AttrSupplierDetail, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_631f64667ced05b3101507560ed0f622, ssConectaProveedores.RestRecords.JSONRC_631f64667ced05b3101507560ed0f622> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_631f64667ced05b3101507560ed0f622 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_631f64667ced05b3101507560ed0f622 FromStructure(RC_631f64667ced05b3101507560ed0f622 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_631f64667ced05b3101507560ed0f622(s, config);
}

}


