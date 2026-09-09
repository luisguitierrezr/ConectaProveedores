using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserRoleRecord
public class RESTRC_7bfa75f5202ddb9627a7dd8185c0c12b : AbstractRESTStructure<RC_7bfa75f5202ddb9627a7dd8185c0c12b> {
[JsonProperty("UserRole")]
public ssConectaProveedores.RestRecords.RESTST_9adff333942ff7120fc18c8e55f201fdStructure AttrUserRole;

public RESTRC_7bfa75f5202ddb9627a7dd8185c0c12b() { }

public RESTRC_7bfa75f5202ddb9627a7dd8185c0c12b (RC_7bfa75f5202ddb9627a7dd8185c0c12b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserRole = ConvertToRestWithoutDefaults(s.ssSTUserRole, new ST_9adff333942ff7120fc18c8e55f201fdStructure(), ssConectaProveedores.RestRecords.RESTST_9adff333942ff7120fc18c8e55f201fdStructure.FromStructure, config);
  } else {
AttrUserRole = ssConectaProveedores.RestRecords.RESTST_9adff333942ff7120fc18c8e55f201fdStructure.FromStructure(s.ssSTUserRole, config);
  }
}

public static RC_7bfa75f5202ddb9627a7dd8185c0c12b ToStructure(ssConectaProveedores.RestRecords.RESTRC_7bfa75f5202ddb9627a7dd8185c0c12b obj) { 
  RC_7bfa75f5202ddb9627a7dd8185c0c12b s = new RC_7bfa75f5202ddb9627a7dd8185c0c12b();
  if(obj != null) {
  s.ssSTUserRole = ssConectaProveedores.RestRecords.RESTST_9adff333942ff7120fc18c8e55f201fdStructure.ToStructure(obj.AttrUserRole);
  }
  return s;
}

public static Func<RC_7bfa75f5202ddb9627a7dd8185c0c12b, ssConectaProveedores.RestRecords.RESTRC_7bfa75f5202ddb9627a7dd8185c0c12b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7bfa75f5202ddb9627a7dd8185c0c12b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7bfa75f5202ddb9627a7dd8185c0c12b FromStructure(RC_7bfa75f5202ddb9627a7dd8185c0c12b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7bfa75f5202ddb9627a7dd8185c0c12b(s, config);
}

}


