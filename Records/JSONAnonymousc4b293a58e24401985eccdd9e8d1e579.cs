using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApplicationRole2Record
public class JSONRC_9682e08607652557f92f63efe40bdcce : AbstractRESTStructure<RC_9682e08607652557f92f63efe40bdcce> {
[JsonProperty("ApplicationRole2")]
[JsonPropertyName("ApplicationRole2")]
public ssConectaProveedores.RestRecords.JSONST_5728db9d26b9364eef512c59f8517473Structure AttrApplicationRole2;

public JSONRC_9682e08607652557f92f63efe40bdcce() { }

public JSONRC_9682e08607652557f92f63efe40bdcce (RC_9682e08607652557f92f63efe40bdcce s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApplicationRole2 = ConvertToRestWithoutDefaults(s.ssSTApplicationRole2, new ST_5728db9d26b9364eef512c59f8517473Structure(), ssConectaProveedores.RestRecords.JSONST_5728db9d26b9364eef512c59f8517473Structure.FromStructure, config);
  } else {
AttrApplicationRole2 = ssConectaProveedores.RestRecords.JSONST_5728db9d26b9364eef512c59f8517473Structure.FromStructure(s.ssSTApplicationRole2, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_9682e08607652557f92f63efe40bdcce, RC_9682e08607652557f92f63efe40bdcce> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_9682e08607652557f92f63efe40bdcce s) => ToStructure(s, config);
}
public static RC_9682e08607652557f92f63efe40bdcce ToStructure(ssConectaProveedores.RestRecords.JSONRC_9682e08607652557f92f63efe40bdcce obj, IBehaviorsConfiguration config) { 
  RC_9682e08607652557f92f63efe40bdcce s = new RC_9682e08607652557f92f63efe40bdcce();
  if(obj != null) {
  s.ssSTApplicationRole2 = ssConectaProveedores.RestRecords.JSONST_5728db9d26b9364eef512c59f8517473Structure.ToStructure(obj.AttrApplicationRole2, config);
  }
  return s;
}

public static Func<RC_9682e08607652557f92f63efe40bdcce, ssConectaProveedores.RestRecords.JSONRC_9682e08607652557f92f63efe40bdcce> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9682e08607652557f92f63efe40bdcce s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_9682e08607652557f92f63efe40bdcce FromStructure(RC_9682e08607652557f92f63efe40bdcce s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_9682e08607652557f92f63efe40bdcce(s, config);
}

}


