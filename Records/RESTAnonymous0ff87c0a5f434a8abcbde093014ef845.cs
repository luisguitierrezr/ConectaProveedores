using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NotificationOptionalConfigsRecord
public class RESTRC_e5ad8f04c38047441643c6868992c277 : AbstractRESTStructure<RC_e5ad8f04c38047441643c6868992c277> {
[JsonProperty("NotificationOptionalConfigs")]
public ssConectaProveedores.RestRecords.RESTST_09173c1b0f41f719b9efd6430c2e737dStructure AttrNotificationOptionalConfigs;

public RESTRC_e5ad8f04c38047441643c6868992c277() { }

public RESTRC_e5ad8f04c38047441643c6868992c277 (RC_e5ad8f04c38047441643c6868992c277 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNotificationOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTNotificationOptionalConfigs, new ST_09173c1b0f41f719b9efd6430c2e737dStructure(), ssConectaProveedores.RestRecords.RESTST_09173c1b0f41f719b9efd6430c2e737dStructure.FromStructure, config);
  } else {
AttrNotificationOptionalConfigs = ssConectaProveedores.RestRecords.RESTST_09173c1b0f41f719b9efd6430c2e737dStructure.FromStructure(s.ssSTNotificationOptionalConfigs, config);
  }
}

public static RC_e5ad8f04c38047441643c6868992c277 ToStructure(ssConectaProveedores.RestRecords.RESTRC_e5ad8f04c38047441643c6868992c277 obj) { 
  RC_e5ad8f04c38047441643c6868992c277 s = new RC_e5ad8f04c38047441643c6868992c277();
  if(obj != null) {
  s.ssSTNotificationOptionalConfigs = ssConectaProveedores.RestRecords.RESTST_09173c1b0f41f719b9efd6430c2e737dStructure.ToStructure(obj.AttrNotificationOptionalConfigs);
  }
  return s;
}

public static Func<RC_e5ad8f04c38047441643c6868992c277, ssConectaProveedores.RestRecords.RESTRC_e5ad8f04c38047441643c6868992c277> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e5ad8f04c38047441643c6868992c277 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e5ad8f04c38047441643c6868992c277 FromStructure(RC_e5ad8f04c38047441643c6868992c277 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e5ad8f04c38047441643c6868992c277(s, config);
}

}


