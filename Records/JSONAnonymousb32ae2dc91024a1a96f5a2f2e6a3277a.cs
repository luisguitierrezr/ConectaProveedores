using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ImportStatusRecord
public class JSONRC_73cba58e096fd5aef16244a229132919 : AbstractRESTStructure<RC_73cba58e096fd5aef16244a229132919> {
[JsonProperty("ImportStatus")]
[JsonPropertyName("ImportStatus")]
public ssConectaProveedores.RestRecords.JSONEN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord AttrImportStatus;

public JSONRC_73cba58e096fd5aef16244a229132919() { }

public JSONRC_73cba58e096fd5aef16244a229132919 (RC_73cba58e096fd5aef16244a229132919 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrImportStatus = ConvertToRestWithoutDefaults(s.ssENImportStatus, new EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord.FromStructure, config);
  } else {
AttrImportStatus = ssConectaProveedores.RestRecords.JSONEN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord.FromStructure(s.ssENImportStatus, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_73cba58e096fd5aef16244a229132919, RC_73cba58e096fd5aef16244a229132919> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_73cba58e096fd5aef16244a229132919 s) => ToStructure(s, config);
}
public static RC_73cba58e096fd5aef16244a229132919 ToStructure(ssConectaProveedores.RestRecords.JSONRC_73cba58e096fd5aef16244a229132919 obj, IBehaviorsConfiguration config) { 
  RC_73cba58e096fd5aef16244a229132919 s = new RC_73cba58e096fd5aef16244a229132919();
  if(obj != null) {
  s.ssENImportStatus = ssConectaProveedores.RestRecords.JSONEN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord.ToStructure(obj.AttrImportStatus, config);
  }
  return s;
}

public static Func<RC_73cba58e096fd5aef16244a229132919, ssConectaProveedores.RestRecords.JSONRC_73cba58e096fd5aef16244a229132919> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_73cba58e096fd5aef16244a229132919 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_73cba58e096fd5aef16244a229132919 FromStructure(RC_73cba58e096fd5aef16244a229132919 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_73cba58e096fd5aef16244a229132919(s, config);
}

}


