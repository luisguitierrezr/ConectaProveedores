using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IsBulkShowRecord
public class JSONRC_b2bab424cbee127fcb27bb237f9cab05 : AbstractRESTStructure<RC_b2bab424cbee127fcb27bb237f9cab05> {
[JsonProperty("IsBulk")]
[JsonPropertyName("IsBulk")]
public bool? AttrIsBulk;

[JsonProperty("Show")]
[JsonPropertyName("Show")]
public bool? AttrShow;

public JSONRC_b2bab424cbee127fcb27bb237f9cab05() { }

public JSONRC_b2bab424cbee127fcb27bb237f9cab05 (RC_b2bab424cbee127fcb27bb237f9cab05 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsBulk = ConvertToRestWithoutDefaults(s.ssIsBulk, false);
AttrShow = ConvertToRestWithoutDefaults(s.ssShow, false);
  } else {
AttrIsBulk = (bool?) s.ssIsBulk;
AttrShow = (bool?) s.ssShow;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b2bab424cbee127fcb27bb237f9cab05, RC_b2bab424cbee127fcb27bb237f9cab05> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b2bab424cbee127fcb27bb237f9cab05 s) => ToStructure(s, config);
}
public static RC_b2bab424cbee127fcb27bb237f9cab05 ToStructure(ssConectaProveedores.RestRecords.JSONRC_b2bab424cbee127fcb27bb237f9cab05 obj, IBehaviorsConfiguration config) { 
  RC_b2bab424cbee127fcb27bb237f9cab05 s = new RC_b2bab424cbee127fcb27bb237f9cab05();
  if(obj != null) {
  s.ssIsBulk = obj.AttrIsBulk == null ? false : obj.AttrIsBulk.Value;
  s.ssShow = obj.AttrShow == null ? false : obj.AttrShow.Value;
  }
  return s;
}

public static Func<RC_b2bab424cbee127fcb27bb237f9cab05, ssConectaProveedores.RestRecords.JSONRC_b2bab424cbee127fcb27bb237f9cab05> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b2bab424cbee127fcb27bb237f9cab05 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b2bab424cbee127fcb27bb237f9cab05 FromStructure(RC_b2bab424cbee127fcb27bb237f9cab05 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b2bab424cbee127fcb27bb237f9cab05(s, config);
}

}


