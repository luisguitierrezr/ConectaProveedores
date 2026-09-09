using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ErroImport
public class RESTST_37eba272293c59d7cf1400fbd0fb4b40Structure : AbstractRESTStructure<ST_37eba272293c59d7cf1400fbd0fb4b40Structure> {
[JsonProperty("Document")]
public string AttrDocument;

[JsonProperty("Error")]
public string AttrError;

public RESTST_37eba272293c59d7cf1400fbd0fb4b40Structure() { }

public RESTST_37eba272293c59d7cf1400fbd0fb4b40Structure (ST_37eba272293c59d7cf1400fbd0fb4b40Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocument = ConvertToRestWithoutDefaults(s.ssDocument, "");
AttrError = ConvertToRestWithoutDefaults(s.ssError, "");
  } else {
AttrDocument = s.ssDocument;
AttrError = s.ssError;
  }
}

public static ST_37eba272293c59d7cf1400fbd0fb4b40Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_37eba272293c59d7cf1400fbd0fb4b40Structure obj) { 
  ST_37eba272293c59d7cf1400fbd0fb4b40Structure s = new ST_37eba272293c59d7cf1400fbd0fb4b40Structure();
  if(obj != null) {
  s.ssDocument = obj.AttrDocument == null ? "" : obj.AttrDocument;
  s.ssError = obj.AttrError == null ? "" : obj.AttrError;
  }
  return s;
}

public static Func<ST_37eba272293c59d7cf1400fbd0fb4b40Structure, ssConectaProveedores.RestRecords.RESTST_37eba272293c59d7cf1400fbd0fb4b40Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_37eba272293c59d7cf1400fbd0fb4b40Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_37eba272293c59d7cf1400fbd0fb4b40Structure FromStructure(ST_37eba272293c59d7cf1400fbd0fb4b40Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_37eba272293c59d7cf1400fbd0fb4b40Structure(s, config);
}

}


