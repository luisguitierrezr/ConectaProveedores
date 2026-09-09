using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TextRecord
public class RESTRC_ca61515b5f1b81a3f63a72f69693ae36 : AbstractRESTStructure<RC_ca61515b5f1b81a3f63a72f69693ae36> {
[JsonProperty("Text")]
public string AttrText;

public RESTRC_ca61515b5f1b81a3f63a72f69693ae36() { }

public RESTRC_ca61515b5f1b81a3f63a72f69693ae36 (RC_ca61515b5f1b81a3f63a72f69693ae36 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrText = ConvertToRestWithoutDefaults(s.ssText, "");
  } else {
AttrText = s.ssText;
  }
}

public static RC_ca61515b5f1b81a3f63a72f69693ae36 ToStructure(ssConectaProveedores.RestRecords.RESTRC_ca61515b5f1b81a3f63a72f69693ae36 obj) { 
  RC_ca61515b5f1b81a3f63a72f69693ae36 s = new RC_ca61515b5f1b81a3f63a72f69693ae36();
  if(obj != null) {
  s.ssText = obj.AttrText == null ? "" : obj.AttrText;
  }
  return s;
}

public static Func<RC_ca61515b5f1b81a3f63a72f69693ae36, ssConectaProveedores.RestRecords.RESTRC_ca61515b5f1b81a3f63a72f69693ae36> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ca61515b5f1b81a3f63a72f69693ae36 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ca61515b5f1b81a3f63a72f69693ae36 FromStructure(RC_ca61515b5f1b81a3f63a72f69693ae36 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ca61515b5f1b81a3f63a72f69693ae36(s, config);
}

}


