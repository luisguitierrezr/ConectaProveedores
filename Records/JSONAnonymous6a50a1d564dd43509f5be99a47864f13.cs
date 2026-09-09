using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserRoleRecord
public class JSONRC_7bfa75f5202ddb9627a7dd8185c0c12b : AbstractRESTStructure<RC_7bfa75f5202ddb9627a7dd8185c0c12b> {
[JsonProperty("UserRole")]
[JsonPropertyName("UserRole")]
public ssConectaProveedores.RestRecords.JSONST_9adff333942ff7120fc18c8e55f201fdStructure AttrUserRole;

public JSONRC_7bfa75f5202ddb9627a7dd8185c0c12b() { }

public JSONRC_7bfa75f5202ddb9627a7dd8185c0c12b (RC_7bfa75f5202ddb9627a7dd8185c0c12b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserRole = ConvertToRestWithoutDefaults(s.ssSTUserRole, new ST_9adff333942ff7120fc18c8e55f201fdStructure(), ssConectaProveedores.RestRecords.JSONST_9adff333942ff7120fc18c8e55f201fdStructure.FromStructure, config);
  } else {
AttrUserRole = ssConectaProveedores.RestRecords.JSONST_9adff333942ff7120fc18c8e55f201fdStructure.FromStructure(s.ssSTUserRole, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7bfa75f5202ddb9627a7dd8185c0c12b, RC_7bfa75f5202ddb9627a7dd8185c0c12b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7bfa75f5202ddb9627a7dd8185c0c12b s) => ToStructure(s, config);
}
public static RC_7bfa75f5202ddb9627a7dd8185c0c12b ToStructure(ssConectaProveedores.RestRecords.JSONRC_7bfa75f5202ddb9627a7dd8185c0c12b obj, IBehaviorsConfiguration config) { 
  RC_7bfa75f5202ddb9627a7dd8185c0c12b s = new RC_7bfa75f5202ddb9627a7dd8185c0c12b();
  if(obj != null) {
  s.ssSTUserRole = ssConectaProveedores.RestRecords.JSONST_9adff333942ff7120fc18c8e55f201fdStructure.ToStructure(obj.AttrUserRole, config);
  }
  return s;
}

public static Func<RC_7bfa75f5202ddb9627a7dd8185c0c12b, ssConectaProveedores.RestRecords.JSONRC_7bfa75f5202ddb9627a7dd8185c0c12b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7bfa75f5202ddb9627a7dd8185c0c12b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7bfa75f5202ddb9627a7dd8185c0c12b FromStructure(RC_7bfa75f5202ddb9627a7dd8185c0c12b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7bfa75f5202ddb9627a7dd8185c0c12b(s, config);
}

}


