using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// EnvironmentRecord
public class JSONRC_e1a5e242516e79b9390b0e4c2ab2f5cc : AbstractRESTStructure<RC_e1a5e242516e79b9390b0e4c2ab2f5cc> {
[JsonProperty("Environment")]
[JsonPropertyName("Environment")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_201dce7bb255178c132fec4d547942aeStructure AttrEnvironment;

public JSONRC_e1a5e242516e79b9390b0e4c2ab2f5cc() { }

public JSONRC_e1a5e242516e79b9390b0e4c2ab2f5cc (RC_e1a5e242516e79b9390b0e4c2ab2f5cc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEnvironment = ConvertToRestWithoutDefaults(s.ssSTEnvironment, new ST_201dce7bb255178c132fec4d547942aeStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_201dce7bb255178c132fec4d547942aeStructure.FromStructure, config);
  } else {
AttrEnvironment = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_201dce7bb255178c132fec4d547942aeStructure.FromStructure(s.ssSTEnvironment, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e1a5e242516e79b9390b0e4c2ab2f5cc, RC_e1a5e242516e79b9390b0e4c2ab2f5cc> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e1a5e242516e79b9390b0e4c2ab2f5cc s) => ToStructure(s, config);
}
public static RC_e1a5e242516e79b9390b0e4c2ab2f5cc ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e1a5e242516e79b9390b0e4c2ab2f5cc obj, IBehaviorsConfiguration config) { 
  RC_e1a5e242516e79b9390b0e4c2ab2f5cc s = new RC_e1a5e242516e79b9390b0e4c2ab2f5cc();
  if(obj != null) {
  s.ssSTEnvironment = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_201dce7bb255178c132fec4d547942aeStructure.ToStructure(obj.AttrEnvironment, config);
  }
  return s;
}

public static Func<RC_e1a5e242516e79b9390b0e4c2ab2f5cc, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e1a5e242516e79b9390b0e4c2ab2f5cc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e1a5e242516e79b9390b0e4c2ab2f5cc s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e1a5e242516e79b9390b0e4c2ab2f5cc FromStructure(RC_e1a5e242516e79b9390b0e4c2ab2f5cc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e1a5e242516e79b9390b0e4c2ab2f5cc(s, config);
}

}


