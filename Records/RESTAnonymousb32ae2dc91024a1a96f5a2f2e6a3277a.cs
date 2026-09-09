using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ImportStatusRecord
public class RESTRC_73cba58e096fd5aef16244a229132919 : AbstractRESTStructure<RC_73cba58e096fd5aef16244a229132919> {
[JsonProperty("ImportStatus")]
public ssConectaProveedores.RestRecords.RESTEN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord AttrImportStatus;

public RESTRC_73cba58e096fd5aef16244a229132919() { }

public RESTRC_73cba58e096fd5aef16244a229132919 (RC_73cba58e096fd5aef16244a229132919 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrImportStatus = ConvertToRestWithoutDefaults(s.ssENImportStatus, new EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord.FromStructure, config);
  } else {
AttrImportStatus = ssConectaProveedores.RestRecords.RESTEN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord.FromStructure(s.ssENImportStatus, config);
  }
}

public static RC_73cba58e096fd5aef16244a229132919 ToStructure(ssConectaProveedores.RestRecords.RESTRC_73cba58e096fd5aef16244a229132919 obj) { 
  RC_73cba58e096fd5aef16244a229132919 s = new RC_73cba58e096fd5aef16244a229132919();
  if(obj != null) {
  s.ssENImportStatus = ssConectaProveedores.RestRecords.RESTEN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord.ToStructure(obj.AttrImportStatus);
  }
  return s;
}

public static Func<RC_73cba58e096fd5aef16244a229132919, ssConectaProveedores.RestRecords.RESTRC_73cba58e096fd5aef16244a229132919> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_73cba58e096fd5aef16244a229132919 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_73cba58e096fd5aef16244a229132919 FromStructure(RC_73cba58e096fd5aef16244a229132919 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_73cba58e096fd5aef16244a229132919(s, config);
}

}


