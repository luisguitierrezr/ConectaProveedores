using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TextRecord
public class JSONRC_ca61515b5f1b81a3f63a72f69693ae36 : AbstractRESTStructure<RC_ca61515b5f1b81a3f63a72f69693ae36> {
[JsonProperty("Text")]
[JsonPropertyName("Text")]
public string AttrText;

public JSONRC_ca61515b5f1b81a3f63a72f69693ae36() { }

public JSONRC_ca61515b5f1b81a3f63a72f69693ae36 (RC_ca61515b5f1b81a3f63a72f69693ae36 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrText = ConvertToRestWithoutDefaults(s.ssText, "");
  } else {
AttrText = s.ssText;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ca61515b5f1b81a3f63a72f69693ae36, RC_ca61515b5f1b81a3f63a72f69693ae36> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ca61515b5f1b81a3f63a72f69693ae36 s) => ToStructure(s, config);
}
public static RC_ca61515b5f1b81a3f63a72f69693ae36 ToStructure(ssConectaProveedores.RestRecords.JSONRC_ca61515b5f1b81a3f63a72f69693ae36 obj, IBehaviorsConfiguration config) { 
  RC_ca61515b5f1b81a3f63a72f69693ae36 s = new RC_ca61515b5f1b81a3f63a72f69693ae36();
  if(obj != null) {
  s.ssText = obj.AttrText == null ? "" : obj.AttrText;
  }
  return s;
}

public static Func<RC_ca61515b5f1b81a3f63a72f69693ae36, ssConectaProveedores.RestRecords.JSONRC_ca61515b5f1b81a3f63a72f69693ae36> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ca61515b5f1b81a3f63a72f69693ae36 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ca61515b5f1b81a3f63a72f69693ae36 FromStructure(RC_ca61515b5f1b81a3f63a72f69693ae36 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ca61515b5f1b81a3f63a72f69693ae36(s, config);
}

}


