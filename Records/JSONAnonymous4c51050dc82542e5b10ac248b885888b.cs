using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CompanySupplierDetailRecord
public class JSONRC_5df7bb5aa64fe06d5d087faa4a2fd561 : AbstractRESTStructure<RC_5df7bb5aa64fe06d5d087faa4a2fd561> {
[JsonProperty("Company")]
[JsonPropertyName("Company")]
public ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

[JsonProperty("SupplierDetail")]
[JsonPropertyName("SupplierDetail")]
public ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord AttrSupplierDetail;

public JSONRC_5df7bb5aa64fe06d5d087faa4a2fd561() { }

public JSONRC_5df7bb5aa64fe06d5d087faa4a2fd561 (RC_5df7bb5aa64fe06d5d087faa4a2fd561 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrSupplierDetail = ConvertToRestWithoutDefaults(s.ssENSupplierDetail, new EN_57ee0c02163ab55038103469b2569162EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord.FromStructure, config);
  } else {
AttrCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
AttrSupplierDetail = ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord.FromStructure(s.ssENSupplierDetail, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_5df7bb5aa64fe06d5d087faa4a2fd561, RC_5df7bb5aa64fe06d5d087faa4a2fd561> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_5df7bb5aa64fe06d5d087faa4a2fd561 s) => ToStructure(s, config);
}
public static RC_5df7bb5aa64fe06d5d087faa4a2fd561 ToStructure(ssConectaProveedores.RestRecords.JSONRC_5df7bb5aa64fe06d5d087faa4a2fd561 obj, IBehaviorsConfiguration config) { 
  RC_5df7bb5aa64fe06d5d087faa4a2fd561 s = new RC_5df7bb5aa64fe06d5d087faa4a2fd561();
  if(obj != null) {
  s.ssENCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany, config);
  s.ssENSupplierDetail = ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord.ToStructure(obj.AttrSupplierDetail, config);
  }
  return s;
}

public static Func<RC_5df7bb5aa64fe06d5d087faa4a2fd561, ssConectaProveedores.RestRecords.JSONRC_5df7bb5aa64fe06d5d087faa4a2fd561> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5df7bb5aa64fe06d5d087faa4a2fd561 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_5df7bb5aa64fe06d5d087faa4a2fd561 FromStructure(RC_5df7bb5aa64fe06d5d087faa4a2fd561 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_5df7bb5aa64fe06d5d087faa4a2fd561(s, config);
}

}


