using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserRole
public class RESTST_9adff333942ff7120fc18c8e55f201fdStructure : AbstractRESTStructure<ST_9adff333942ff7120fc18c8e55f201fdStructure> {
[JsonProperty("ApplicationRoleId")]
public long? AttrApplicationRoleId;

[JsonProperty("RoleName")]
public string AttrRoleName;

public RESTST_9adff333942ff7120fc18c8e55f201fdStructure() { }

public RESTST_9adff333942ff7120fc18c8e55f201fdStructure (ST_9adff333942ff7120fc18c8e55f201fdStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApplicationRoleId = ConvertToRestWithoutDefaults(s.ssApplicationRoleId, 0L);
AttrRoleName = ConvertToRestWithoutDefaults(s.ssRoleName, "");
  } else {
AttrApplicationRoleId = (long?) s.ssApplicationRoleId;
AttrRoleName = s.ssRoleName;
  }
}

public static ST_9adff333942ff7120fc18c8e55f201fdStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_9adff333942ff7120fc18c8e55f201fdStructure obj) { 
  ST_9adff333942ff7120fc18c8e55f201fdStructure s = new ST_9adff333942ff7120fc18c8e55f201fdStructure();
  if(obj != null) {
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssRoleName = obj.AttrRoleName == null ? "" : obj.AttrRoleName;
  }
  return s;
}

public static Func<ST_9adff333942ff7120fc18c8e55f201fdStructure, ssConectaProveedores.RestRecords.RESTST_9adff333942ff7120fc18c8e55f201fdStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9adff333942ff7120fc18c8e55f201fdStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_9adff333942ff7120fc18c8e55f201fdStructure FromStructure(ST_9adff333942ff7120fc18c8e55f201fdStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_9adff333942ff7120fc18c8e55f201fdStructure(s, config);
}

}


