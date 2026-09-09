using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EnvironmentRecord
public class RESTRC_e1a5e242516e79b9390b0e4c2ab2f5cc : AbstractRESTStructure<RC_e1a5e242516e79b9390b0e4c2ab2f5cc> {
[JsonProperty("Environment")]
public ssConectaProveedores.RestRecords.RESTST_201dce7bb255178c132fec4d547942aeStructure AttrEnvironment;

public RESTRC_e1a5e242516e79b9390b0e4c2ab2f5cc() { }

public RESTRC_e1a5e242516e79b9390b0e4c2ab2f5cc (RC_e1a5e242516e79b9390b0e4c2ab2f5cc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEnvironment = ConvertToRestWithoutDefaults(s.ssSTEnvironment, new ST_201dce7bb255178c132fec4d547942aeStructure(), ssConectaProveedores.RestRecords.RESTST_201dce7bb255178c132fec4d547942aeStructure.FromStructure, config);
  } else {
AttrEnvironment = ssConectaProveedores.RestRecords.RESTST_201dce7bb255178c132fec4d547942aeStructure.FromStructure(s.ssSTEnvironment, config);
  }
}

public static RC_e1a5e242516e79b9390b0e4c2ab2f5cc ToStructure(ssConectaProveedores.RestRecords.RESTRC_e1a5e242516e79b9390b0e4c2ab2f5cc obj) { 
  RC_e1a5e242516e79b9390b0e4c2ab2f5cc s = new RC_e1a5e242516e79b9390b0e4c2ab2f5cc();
  if(obj != null) {
  s.ssSTEnvironment = ssConectaProveedores.RestRecords.RESTST_201dce7bb255178c132fec4d547942aeStructure.ToStructure(obj.AttrEnvironment);
  }
  return s;
}

public static Func<RC_e1a5e242516e79b9390b0e4c2ab2f5cc, ssConectaProveedores.RestRecords.RESTRC_e1a5e242516e79b9390b0e4c2ab2f5cc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e1a5e242516e79b9390b0e4c2ab2f5cc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e1a5e242516e79b9390b0e4c2ab2f5cc FromStructure(RC_e1a5e242516e79b9390b0e4c2ab2f5cc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e1a5e242516e79b9390b0e4c2ab2f5cc(s, config);
}

}


