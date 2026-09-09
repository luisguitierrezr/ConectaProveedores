using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CompanyRecord
public class RESTRC_99a1fa6df481ec5b1908e770c81b73b1 : AbstractRESTStructure<RC_99a1fa6df481ec5b1908e770c81b73b1> {
[JsonProperty("Company")]
public ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

public RESTRC_99a1fa6df481ec5b1908e770c81b73b1() { }

public RESTRC_99a1fa6df481ec5b1908e770c81b73b1 (RC_99a1fa6df481ec5b1908e770c81b73b1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
  } else {
AttrCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
  }
}

public static RC_99a1fa6df481ec5b1908e770c81b73b1 ToStructure(ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1 obj) { 
  RC_99a1fa6df481ec5b1908e770c81b73b1 s = new RC_99a1fa6df481ec5b1908e770c81b73b1();
  if(obj != null) {
  s.ssENCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany);
  }
  return s;
}

public static Func<RC_99a1fa6df481ec5b1908e770c81b73b1, ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_99a1fa6df481ec5b1908e770c81b73b1 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1 FromStructure(RC_99a1fa6df481ec5b1908e770c81b73b1 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_99a1fa6df481ec5b1908e770c81b73b1(s, config);
}

}


