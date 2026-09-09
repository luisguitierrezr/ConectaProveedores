using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntraRoleIdRecord
public class RESTRC_ff0b06695390fb8e1933a62e3ed27cb9 : AbstractRESTStructure<RC_ff0b06695390fb8e1933a62e3ed27cb9> {
[JsonProperty("EntraRoleId")]
public long? AttrEntraRoleId;

public RESTRC_ff0b06695390fb8e1933a62e3ed27cb9() { }

public RESTRC_ff0b06695390fb8e1933a62e3ed27cb9 (RC_ff0b06695390fb8e1933a62e3ed27cb9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEntraRoleId = ConvertToRestWithoutDefaults(s.ssEntraRoleId, 0L);
  } else {
AttrEntraRoleId = (long?) s.ssEntraRoleId;
  }
}

public static RC_ff0b06695390fb8e1933a62e3ed27cb9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_ff0b06695390fb8e1933a62e3ed27cb9 obj) { 
  RC_ff0b06695390fb8e1933a62e3ed27cb9 s = new RC_ff0b06695390fb8e1933a62e3ed27cb9();
  if(obj != null) {
  s.ssEntraRoleId = obj.AttrEntraRoleId == null ? 0L : obj.AttrEntraRoleId.Value;
  }
  return s;
}

public static Func<RC_ff0b06695390fb8e1933a62e3ed27cb9, ssConectaProveedores.RestRecords.RESTRC_ff0b06695390fb8e1933a62e3ed27cb9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ff0b06695390fb8e1933a62e3ed27cb9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ff0b06695390fb8e1933a62e3ed27cb9 FromStructure(RC_ff0b06695390fb8e1933a62e3ed27cb9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ff0b06695390fb8e1933a62e3ed27cb9(s, config);
}

}


