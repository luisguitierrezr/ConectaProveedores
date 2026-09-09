using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NameRecord
public class RESTRC_140ae7635b5c550e5f93324b123e0b4f : AbstractRESTStructure<RC_140ae7635b5c550e5f93324b123e0b4f> {
[JsonProperty("Name")]
public string AttrName;

public RESTRC_140ae7635b5c550e5f93324b123e0b4f() { }

public RESTRC_140ae7635b5c550e5f93324b123e0b4f (RC_140ae7635b5c550e5f93324b123e0b4f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
  } else {
AttrName = s.ssName;
  }
}

public static RC_140ae7635b5c550e5f93324b123e0b4f ToStructure(ssConectaProveedores.RestRecords.RESTRC_140ae7635b5c550e5f93324b123e0b4f obj) { 
  RC_140ae7635b5c550e5f93324b123e0b4f s = new RC_140ae7635b5c550e5f93324b123e0b4f();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<RC_140ae7635b5c550e5f93324b123e0b4f, ssConectaProveedores.RestRecords.RESTRC_140ae7635b5c550e5f93324b123e0b4f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_140ae7635b5c550e5f93324b123e0b4f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_140ae7635b5c550e5f93324b123e0b4f FromStructure(RC_140ae7635b5c550e5f93324b123e0b4f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_140ae7635b5c550e5f93324b123e0b4f(s, config);
}

}


