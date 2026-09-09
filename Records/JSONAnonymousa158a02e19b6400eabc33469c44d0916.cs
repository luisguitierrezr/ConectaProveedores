using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FinishUpdateEmailResultRecord
public class JSONRC_679ae82d2c7d05b47c7411f8ce9aeb62 : AbstractRESTStructure<RC_679ae82d2c7d05b47c7411f8ce9aeb62> {
[JsonProperty("FinishUpdateEmailResult")]
[JsonPropertyName("FinishUpdateEmailResult")]
public ssConectaProveedores.RestRecords.JSONST_992b6b077ef933bd10f0df6cf0ce4be3Structure AttrFinishUpdateEmailResult;

public JSONRC_679ae82d2c7d05b47c7411f8ce9aeb62() { }

public JSONRC_679ae82d2c7d05b47c7411f8ce9aeb62 (RC_679ae82d2c7d05b47c7411f8ce9aeb62 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFinishUpdateEmailResult = ConvertToRestWithoutDefaults(s.ssSTFinishUpdateEmailResult, new ST_992b6b077ef933bd10f0df6cf0ce4be3Structure(), ssConectaProveedores.RestRecords.JSONST_992b6b077ef933bd10f0df6cf0ce4be3Structure.FromStructure, config);
  } else {
AttrFinishUpdateEmailResult = ssConectaProveedores.RestRecords.JSONST_992b6b077ef933bd10f0df6cf0ce4be3Structure.FromStructure(s.ssSTFinishUpdateEmailResult, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_679ae82d2c7d05b47c7411f8ce9aeb62, RC_679ae82d2c7d05b47c7411f8ce9aeb62> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_679ae82d2c7d05b47c7411f8ce9aeb62 s) => ToStructure(s, config);
}
public static RC_679ae82d2c7d05b47c7411f8ce9aeb62 ToStructure(ssConectaProveedores.RestRecords.JSONRC_679ae82d2c7d05b47c7411f8ce9aeb62 obj, IBehaviorsConfiguration config) { 
  RC_679ae82d2c7d05b47c7411f8ce9aeb62 s = new RC_679ae82d2c7d05b47c7411f8ce9aeb62();
  if(obj != null) {
  s.ssSTFinishUpdateEmailResult = ssConectaProveedores.RestRecords.JSONST_992b6b077ef933bd10f0df6cf0ce4be3Structure.ToStructure(obj.AttrFinishUpdateEmailResult, config);
  }
  return s;
}

public static Func<RC_679ae82d2c7d05b47c7411f8ce9aeb62, ssConectaProveedores.RestRecords.JSONRC_679ae82d2c7d05b47c7411f8ce9aeb62> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_679ae82d2c7d05b47c7411f8ce9aeb62 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_679ae82d2c7d05b47c7411f8ce9aeb62 FromStructure(RC_679ae82d2c7d05b47c7411f8ce9aeb62 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_679ae82d2c7d05b47c7411f8ce9aeb62(s, config);
}

}


