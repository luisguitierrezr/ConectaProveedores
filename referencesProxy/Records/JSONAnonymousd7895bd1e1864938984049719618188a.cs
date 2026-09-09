using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// AuditPublicStrucRecord
public class JSONRC_ec6369e0ab5a663741bcc7fd811dc6b4 : AbstractRESTStructure<RC_ec6369e0ab5a663741bcc7fd811dc6b4> {
[JsonProperty("AuditPublicStruc")]
[JsonPropertyName("AuditPublicStruc")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure AttrAuditPublicStruc;

public JSONRC_ec6369e0ab5a663741bcc7fd811dc6b4() { }

public JSONRC_ec6369e0ab5a663741bcc7fd811dc6b4 (RC_ec6369e0ab5a663741bcc7fd811dc6b4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAuditPublicStruc = ConvertToRestWithoutDefaults(s.ssSTAuditPublicStruc, new ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure.FromStructure, config);
  } else {
AttrAuditPublicStruc = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure.FromStructure(s.ssSTAuditPublicStruc, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ec6369e0ab5a663741bcc7fd811dc6b4, RC_ec6369e0ab5a663741bcc7fd811dc6b4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ec6369e0ab5a663741bcc7fd811dc6b4 s) => ToStructure(s, config);
}
public static RC_ec6369e0ab5a663741bcc7fd811dc6b4 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ec6369e0ab5a663741bcc7fd811dc6b4 obj, IBehaviorsConfiguration config) { 
  RC_ec6369e0ab5a663741bcc7fd811dc6b4 s = new RC_ec6369e0ab5a663741bcc7fd811dc6b4();
  if(obj != null) {
  s.ssSTAuditPublicStruc = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure.ToStructure(obj.AttrAuditPublicStruc, config);
  }
  return s;
}

public static Func<RC_ec6369e0ab5a663741bcc7fd811dc6b4, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ec6369e0ab5a663741bcc7fd811dc6b4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ec6369e0ab5a663741bcc7fd811dc6b4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ec6369e0ab5a663741bcc7fd811dc6b4 FromStructure(RC_ec6369e0ab5a663741bcc7fd811dc6b4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ec6369e0ab5a663741bcc7fd811dc6b4(s, config);
}

}


