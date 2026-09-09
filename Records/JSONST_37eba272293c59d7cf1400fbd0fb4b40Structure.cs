using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ErroImport
public class JSONST_37eba272293c59d7cf1400fbd0fb4b40Structure : AbstractRESTStructure<ST_37eba272293c59d7cf1400fbd0fb4b40Structure> {
[JsonProperty("Document")]
[JsonPropertyName("Document")]
public string AttrDocument;

[JsonProperty("Error")]
[JsonPropertyName("Error")]
public string AttrError;

public JSONST_37eba272293c59d7cf1400fbd0fb4b40Structure() { }

public JSONST_37eba272293c59d7cf1400fbd0fb4b40Structure (ST_37eba272293c59d7cf1400fbd0fb4b40Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocument = ConvertToRestWithoutDefaults(s.ssDocument, "");
AttrError = ConvertToRestWithoutDefaults(s.ssError, "");
  } else {
AttrDocument = s.ssDocument;
AttrError = s.ssError;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_37eba272293c59d7cf1400fbd0fb4b40Structure, ST_37eba272293c59d7cf1400fbd0fb4b40Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_37eba272293c59d7cf1400fbd0fb4b40Structure s) => ToStructure(s, config);
}
public static ST_37eba272293c59d7cf1400fbd0fb4b40Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_37eba272293c59d7cf1400fbd0fb4b40Structure obj, IBehaviorsConfiguration config) { 
  ST_37eba272293c59d7cf1400fbd0fb4b40Structure s = new ST_37eba272293c59d7cf1400fbd0fb4b40Structure();
  if(obj != null) {
  s.ssDocument = obj.AttrDocument == null ? "" : obj.AttrDocument;
  s.ssError = obj.AttrError == null ? "" : obj.AttrError;
  }
  return s;
}

public static Func<ST_37eba272293c59d7cf1400fbd0fb4b40Structure, ssConectaProveedores.RestRecords.JSONST_37eba272293c59d7cf1400fbd0fb4b40Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_37eba272293c59d7cf1400fbd0fb4b40Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_37eba272293c59d7cf1400fbd0fb4b40Structure FromStructure(ST_37eba272293c59d7cf1400fbd0fb4b40Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_37eba272293c59d7cf1400fbd0fb4b40Structure(s, config);
}

}


