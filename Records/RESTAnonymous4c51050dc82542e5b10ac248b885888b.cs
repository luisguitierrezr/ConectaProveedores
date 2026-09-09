using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CompanySupplierDetailRecord
public class RESTRC_5df7bb5aa64fe06d5d087faa4a2fd561 : AbstractRESTStructure<RC_5df7bb5aa64fe06d5d087faa4a2fd561> {
[JsonProperty("Company")]
public ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

[JsonProperty("SupplierDetail")]
public ssConectaProveedores.RestRecords.RESTEN_57ee0c02163ab55038103469b2569162EntityRecord AttrSupplierDetail;

public RESTRC_5df7bb5aa64fe06d5d087faa4a2fd561() { }

public RESTRC_5df7bb5aa64fe06d5d087faa4a2fd561 (RC_5df7bb5aa64fe06d5d087faa4a2fd561 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrSupplierDetail = ConvertToRestWithoutDefaults(s.ssENSupplierDetail, new EN_57ee0c02163ab55038103469b2569162EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_57ee0c02163ab55038103469b2569162EntityRecord.FromStructure, config);
  } else {
AttrCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
AttrSupplierDetail = ssConectaProveedores.RestRecords.RESTEN_57ee0c02163ab55038103469b2569162EntityRecord.FromStructure(s.ssENSupplierDetail, config);
  }
}

public static RC_5df7bb5aa64fe06d5d087faa4a2fd561 ToStructure(ssConectaProveedores.RestRecords.RESTRC_5df7bb5aa64fe06d5d087faa4a2fd561 obj) { 
  RC_5df7bb5aa64fe06d5d087faa4a2fd561 s = new RC_5df7bb5aa64fe06d5d087faa4a2fd561();
  if(obj != null) {
  s.ssENCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany);
  s.ssENSupplierDetail = ssConectaProveedores.RestRecords.RESTEN_57ee0c02163ab55038103469b2569162EntityRecord.ToStructure(obj.AttrSupplierDetail);
  }
  return s;
}

public static Func<RC_5df7bb5aa64fe06d5d087faa4a2fd561, ssConectaProveedores.RestRecords.RESTRC_5df7bb5aa64fe06d5d087faa4a2fd561> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5df7bb5aa64fe06d5d087faa4a2fd561 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5df7bb5aa64fe06d5d087faa4a2fd561 FromStructure(RC_5df7bb5aa64fe06d5d087faa4a2fd561 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5df7bb5aa64fe06d5d087faa4a2fd561(s, config);
}

}


