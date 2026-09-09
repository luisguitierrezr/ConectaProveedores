using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileStructRecord
public class RESTRC_9c083bb252b911414014156336301f46 : AbstractRESTStructure<RC_9c083bb252b911414014156336301f46> {
[JsonProperty("OrderRequestFileStruct")]
public ssConectaProveedores.RestRecords.RESTST_d9010d115c38fb059bccbc457fe11b18Structure AttrOrderRequestFileStruct;

public RESTRC_9c083bb252b911414014156336301f46() { }

public RESTRC_9c083bb252b911414014156336301f46 (RC_9c083bb252b911414014156336301f46 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRequestFileStruct = ConvertToRestWithoutDefaults(s.ssSTOrderRequestFileStruct, new ST_d9010d115c38fb059bccbc457fe11b18Structure(), ssConectaProveedores.RestRecords.RESTST_d9010d115c38fb059bccbc457fe11b18Structure.FromStructure, config);
  } else {
AttrOrderRequestFileStruct = ssConectaProveedores.RestRecords.RESTST_d9010d115c38fb059bccbc457fe11b18Structure.FromStructure(s.ssSTOrderRequestFileStruct, config);
  }
}

public static RC_9c083bb252b911414014156336301f46 ToStructure(ssConectaProveedores.RestRecords.RESTRC_9c083bb252b911414014156336301f46 obj) { 
  RC_9c083bb252b911414014156336301f46 s = new RC_9c083bb252b911414014156336301f46();
  if(obj != null) {
  s.ssSTOrderRequestFileStruct = ssConectaProveedores.RestRecords.RESTST_d9010d115c38fb059bccbc457fe11b18Structure.ToStructure(obj.AttrOrderRequestFileStruct);
  }
  return s;
}

public static Func<RC_9c083bb252b911414014156336301f46, ssConectaProveedores.RestRecords.RESTRC_9c083bb252b911414014156336301f46> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9c083bb252b911414014156336301f46 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_9c083bb252b911414014156336301f46 FromStructure(RC_9c083bb252b911414014156336301f46 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_9c083bb252b911414014156336301f46(s, config);
}

}


