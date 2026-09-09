using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentRecord
public class JSONRC_9b26d66c2c2462dead9020a39a074a2b : AbstractRESTStructure<RC_9b26d66c2c2462dead9020a39a074a2b> {
[JsonProperty("Document")]
[JsonPropertyName("Document")]
public string AttrDocument;

public JSONRC_9b26d66c2c2462dead9020a39a074a2b() { }

public JSONRC_9b26d66c2c2462dead9020a39a074a2b (RC_9b26d66c2c2462dead9020a39a074a2b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocument = ConvertToRestWithoutDefaults(s.ssDocument, "");
  } else {
AttrDocument = s.ssDocument;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_9b26d66c2c2462dead9020a39a074a2b, RC_9b26d66c2c2462dead9020a39a074a2b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_9b26d66c2c2462dead9020a39a074a2b s) => ToStructure(s, config);
}
public static RC_9b26d66c2c2462dead9020a39a074a2b ToStructure(ssConectaProveedores.RestRecords.JSONRC_9b26d66c2c2462dead9020a39a074a2b obj, IBehaviorsConfiguration config) { 
  RC_9b26d66c2c2462dead9020a39a074a2b s = new RC_9b26d66c2c2462dead9020a39a074a2b();
  if(obj != null) {
  s.ssDocument = obj.AttrDocument == null ? "" : obj.AttrDocument;
  }
  return s;
}

public static Func<RC_9b26d66c2c2462dead9020a39a074a2b, ssConectaProveedores.RestRecords.JSONRC_9b26d66c2c2462dead9020a39a074a2b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9b26d66c2c2462dead9020a39a074a2b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_9b26d66c2c2462dead9020a39a074a2b FromStructure(RC_9b26d66c2c2462dead9020a39a074a2b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_9b26d66c2c2462dead9020a39a074a2b(s, config);
}

}


