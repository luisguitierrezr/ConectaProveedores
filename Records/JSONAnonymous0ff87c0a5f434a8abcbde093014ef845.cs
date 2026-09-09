using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NotificationOptionalConfigsRecord
public class JSONRC_e5ad8f04c38047441643c6868992c277 : AbstractRESTStructure<RC_e5ad8f04c38047441643c6868992c277> {
[JsonProperty("NotificationOptionalConfigs")]
[JsonPropertyName("NotificationOptionalConfigs")]
public ssConectaProveedores.RestRecords.JSONST_09173c1b0f41f719b9efd6430c2e737dStructure AttrNotificationOptionalConfigs;

public JSONRC_e5ad8f04c38047441643c6868992c277() { }

public JSONRC_e5ad8f04c38047441643c6868992c277 (RC_e5ad8f04c38047441643c6868992c277 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNotificationOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTNotificationOptionalConfigs, new ST_09173c1b0f41f719b9efd6430c2e737dStructure(), ssConectaProveedores.RestRecords.JSONST_09173c1b0f41f719b9efd6430c2e737dStructure.FromStructure, config);
  } else {
AttrNotificationOptionalConfigs = ssConectaProveedores.RestRecords.JSONST_09173c1b0f41f719b9efd6430c2e737dStructure.FromStructure(s.ssSTNotificationOptionalConfigs, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e5ad8f04c38047441643c6868992c277, RC_e5ad8f04c38047441643c6868992c277> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e5ad8f04c38047441643c6868992c277 s) => ToStructure(s, config);
}
public static RC_e5ad8f04c38047441643c6868992c277 ToStructure(ssConectaProveedores.RestRecords.JSONRC_e5ad8f04c38047441643c6868992c277 obj, IBehaviorsConfiguration config) { 
  RC_e5ad8f04c38047441643c6868992c277 s = new RC_e5ad8f04c38047441643c6868992c277();
  if(obj != null) {
  s.ssSTNotificationOptionalConfigs = ssConectaProveedores.RestRecords.JSONST_09173c1b0f41f719b9efd6430c2e737dStructure.ToStructure(obj.AttrNotificationOptionalConfigs, config);
  }
  return s;
}

public static Func<RC_e5ad8f04c38047441643c6868992c277, ssConectaProveedores.RestRecords.JSONRC_e5ad8f04c38047441643c6868992c277> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e5ad8f04c38047441643c6868992c277 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e5ad8f04c38047441643c6868992c277 FromStructure(RC_e5ad8f04c38047441643c6868992c277 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e5ad8f04c38047441643c6868992c277(s, config);
}

}


