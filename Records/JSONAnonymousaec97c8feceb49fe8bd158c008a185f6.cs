using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ManagementRecord
public class JSONRC_97877e692c313605c09a0be8396b97b4 : AbstractRESTStructure<RC_97877e692c313605c09a0be8396b97b4> {
[JsonProperty("Management")]
[JsonPropertyName("Management")]
public ssConectaProveedores.RestRecords.JSONEN_57ed198e55e574aae8caa812c90093e4EntityRecord AttrManagement;

public JSONRC_97877e692c313605c09a0be8396b97b4() { }

public JSONRC_97877e692c313605c09a0be8396b97b4 (RC_97877e692c313605c09a0be8396b97b4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrManagement = ConvertToRestWithoutDefaults(s.ssENManagement, new EN_57ed198e55e574aae8caa812c90093e4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_57ed198e55e574aae8caa812c90093e4EntityRecord.FromStructure, config);
  } else {
AttrManagement = ssConectaProveedores.RestRecords.JSONEN_57ed198e55e574aae8caa812c90093e4EntityRecord.FromStructure(s.ssENManagement, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_97877e692c313605c09a0be8396b97b4, RC_97877e692c313605c09a0be8396b97b4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_97877e692c313605c09a0be8396b97b4 s) => ToStructure(s, config);
}
public static RC_97877e692c313605c09a0be8396b97b4 ToStructure(ssConectaProveedores.RestRecords.JSONRC_97877e692c313605c09a0be8396b97b4 obj, IBehaviorsConfiguration config) { 
  RC_97877e692c313605c09a0be8396b97b4 s = new RC_97877e692c313605c09a0be8396b97b4();
  if(obj != null) {
  s.ssENManagement = ssConectaProveedores.RestRecords.JSONEN_57ed198e55e574aae8caa812c90093e4EntityRecord.ToStructure(obj.AttrManagement, config);
  }
  return s;
}

public static Func<RC_97877e692c313605c09a0be8396b97b4, ssConectaProveedores.RestRecords.JSONRC_97877e692c313605c09a0be8396b97b4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_97877e692c313605c09a0be8396b97b4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_97877e692c313605c09a0be8396b97b4 FromStructure(RC_97877e692c313605c09a0be8396b97b4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_97877e692c313605c09a0be8396b97b4(s, config);
}

}


