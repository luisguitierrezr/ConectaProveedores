using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CompanySupplierSupplierDetailRegionRecord
public class RESTRC_631f64667ced05b3101507560ed0f622 : AbstractRESTStructure<RC_631f64667ced05b3101507560ed0f622> {
[JsonProperty("Company")]
public ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("SupplierDetail")]
public ssConectaProveedores.RestRecords.RESTEN_57ee0c02163ab55038103469b2569162EntityRecord AttrSupplierDetail;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_631f64667ced05b3101507560ed0f622() { }

public RESTRC_631f64667ced05b3101507560ed0f622 (RC_631f64667ced05b3101507560ed0f622 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrSupplierDetail = ConvertToRestWithoutDefaults(s.ssENSupplierDetail, new EN_57ee0c02163ab55038103469b2569162EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_57ee0c02163ab55038103469b2569162EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrSupplierDetail = ssConectaProveedores.RestRecords.RESTEN_57ee0c02163ab55038103469b2569162EntityRecord.FromStructure(s.ssENSupplierDetail, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_631f64667ced05b3101507560ed0f622 ToStructure(ssConectaProveedores.RestRecords.RESTRC_631f64667ced05b3101507560ed0f622 obj) { 
  RC_631f64667ced05b3101507560ed0f622 s = new RC_631f64667ced05b3101507560ed0f622();
  if(obj != null) {
  s.ssENCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany);
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  s.ssENSupplierDetail = ssConectaProveedores.RestRecords.RESTEN_57ee0c02163ab55038103469b2569162EntityRecord.ToStructure(obj.AttrSupplierDetail);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_631f64667ced05b3101507560ed0f622, ssConectaProveedores.RestRecords.RESTRC_631f64667ced05b3101507560ed0f622> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_631f64667ced05b3101507560ed0f622 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_631f64667ced05b3101507560ed0f622 FromStructure(RC_631f64667ced05b3101507560ed0f622 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_631f64667ced05b3101507560ed0f622(s, config);
}

}


