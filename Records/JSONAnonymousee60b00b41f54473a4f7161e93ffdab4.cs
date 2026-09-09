using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NewNotification2Record
public class JSONRC_aa55fa7d9c7abf8c590a425e904bc1f7 : AbstractRESTStructure<RC_aa55fa7d9c7abf8c590a425e904bc1f7> {
[JsonProperty("NewNotification2")]
[JsonPropertyName("NewNotification2")]
public ssConectaProveedores.RestRecords.JSONST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure AttrNewNotification2;

public JSONRC_aa55fa7d9c7abf8c590a425e904bc1f7() { }

public JSONRC_aa55fa7d9c7abf8c590a425e904bc1f7 (RC_aa55fa7d9c7abf8c590a425e904bc1f7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNewNotification2 = ConvertToRestWithoutDefaults(s.ssSTNewNotification2, new ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure(), ssConectaProveedores.RestRecords.JSONST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure.FromStructure, config);
  } else {
AttrNewNotification2 = ssConectaProveedores.RestRecords.JSONST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure.FromStructure(s.ssSTNewNotification2, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_aa55fa7d9c7abf8c590a425e904bc1f7, RC_aa55fa7d9c7abf8c590a425e904bc1f7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_aa55fa7d9c7abf8c590a425e904bc1f7 s) => ToStructure(s, config);
}
public static RC_aa55fa7d9c7abf8c590a425e904bc1f7 ToStructure(ssConectaProveedores.RestRecords.JSONRC_aa55fa7d9c7abf8c590a425e904bc1f7 obj, IBehaviorsConfiguration config) { 
  RC_aa55fa7d9c7abf8c590a425e904bc1f7 s = new RC_aa55fa7d9c7abf8c590a425e904bc1f7();
  if(obj != null) {
  s.ssSTNewNotification2 = ssConectaProveedores.RestRecords.JSONST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure.ToStructure(obj.AttrNewNotification2, config);
  }
  return s;
}

public static Func<RC_aa55fa7d9c7abf8c590a425e904bc1f7, ssConectaProveedores.RestRecords.JSONRC_aa55fa7d9c7abf8c590a425e904bc1f7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_aa55fa7d9c7abf8c590a425e904bc1f7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_aa55fa7d9c7abf8c590a425e904bc1f7 FromStructure(RC_aa55fa7d9c7abf8c590a425e904bc1f7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_aa55fa7d9c7abf8c590a425e904bc1f7(s, config);
}

}


