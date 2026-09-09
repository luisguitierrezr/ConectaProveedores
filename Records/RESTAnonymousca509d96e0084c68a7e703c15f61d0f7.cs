using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IsBulkShowRecord
public class RESTRC_b2bab424cbee127fcb27bb237f9cab05 : AbstractRESTStructure<RC_b2bab424cbee127fcb27bb237f9cab05> {
[JsonProperty("IsBulk")]
public bool? AttrIsBulk;

[JsonProperty("Show")]
public bool? AttrShow;

public RESTRC_b2bab424cbee127fcb27bb237f9cab05() { }

public RESTRC_b2bab424cbee127fcb27bb237f9cab05 (RC_b2bab424cbee127fcb27bb237f9cab05 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsBulk = ConvertToRestWithoutDefaults(s.ssIsBulk, false);
AttrShow = ConvertToRestWithoutDefaults(s.ssShow, false);
  } else {
AttrIsBulk = (bool?) s.ssIsBulk;
AttrShow = (bool?) s.ssShow;
  }
}

public static RC_b2bab424cbee127fcb27bb237f9cab05 ToStructure(ssConectaProveedores.RestRecords.RESTRC_b2bab424cbee127fcb27bb237f9cab05 obj) { 
  RC_b2bab424cbee127fcb27bb237f9cab05 s = new RC_b2bab424cbee127fcb27bb237f9cab05();
  if(obj != null) {
  s.ssIsBulk = obj.AttrIsBulk == null ? false : obj.AttrIsBulk.Value;
  s.ssShow = obj.AttrShow == null ? false : obj.AttrShow.Value;
  }
  return s;
}

public static Func<RC_b2bab424cbee127fcb27bb237f9cab05, ssConectaProveedores.RestRecords.RESTRC_b2bab424cbee127fcb27bb237f9cab05> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b2bab424cbee127fcb27bb237f9cab05 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b2bab424cbee127fcb27bb237f9cab05 FromStructure(RC_b2bab424cbee127fcb27bb237f9cab05 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b2bab424cbee127fcb27bb237f9cab05(s, config);
}

}


