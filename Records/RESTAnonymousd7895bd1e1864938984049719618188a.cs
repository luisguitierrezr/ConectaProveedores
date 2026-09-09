using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AuditPublicStrucRecord
public class RESTRC_ec6369e0ab5a663741bcc7fd811dc6b4 : AbstractRESTStructure<RC_ec6369e0ab5a663741bcc7fd811dc6b4> {
[JsonProperty("AuditPublicStruc")]
public ssConectaProveedores.RestRecords.RESTST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure AttrAuditPublicStruc;

public RESTRC_ec6369e0ab5a663741bcc7fd811dc6b4() { }

public RESTRC_ec6369e0ab5a663741bcc7fd811dc6b4 (RC_ec6369e0ab5a663741bcc7fd811dc6b4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAuditPublicStruc = ConvertToRestWithoutDefaults(s.ssSTAuditPublicStruc, new ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure(), ssConectaProveedores.RestRecords.RESTST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure.FromStructure, config);
  } else {
AttrAuditPublicStruc = ssConectaProveedores.RestRecords.RESTST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure.FromStructure(s.ssSTAuditPublicStruc, config);
  }
}

public static RC_ec6369e0ab5a663741bcc7fd811dc6b4 ToStructure(ssConectaProveedores.RestRecords.RESTRC_ec6369e0ab5a663741bcc7fd811dc6b4 obj) { 
  RC_ec6369e0ab5a663741bcc7fd811dc6b4 s = new RC_ec6369e0ab5a663741bcc7fd811dc6b4();
  if(obj != null) {
  s.ssSTAuditPublicStruc = ssConectaProveedores.RestRecords.RESTST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure.ToStructure(obj.AttrAuditPublicStruc);
  }
  return s;
}

public static Func<RC_ec6369e0ab5a663741bcc7fd811dc6b4, ssConectaProveedores.RestRecords.RESTRC_ec6369e0ab5a663741bcc7fd811dc6b4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ec6369e0ab5a663741bcc7fd811dc6b4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ec6369e0ab5a663741bcc7fd811dc6b4 FromStructure(RC_ec6369e0ab5a663741bcc7fd811dc6b4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ec6369e0ab5a663741bcc7fd811dc6b4(s, config);
}

}


