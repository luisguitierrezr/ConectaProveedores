using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// DocumentTypeRecord
public class JSONRC_10f704d4de8999e255a09f6b1b9b5668 : AbstractRESTStructure<RC_10f704d4de8999e255a09f6b1b9b5668> {
[JsonProperty("DocumentType")]
[JsonPropertyName("DocumentType")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord AttrDocumentType;

public JSONRC_10f704d4de8999e255a09f6b1b9b5668() { }

public JSONRC_10f704d4de8999e255a09f6b1b9b5668 (RC_10f704d4de8999e255a09f6b1b9b5668 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocumentType = ConvertToRestWithoutDefaults(s.ssENDocumentType, new EN_a70d553ce1458b3952d039852f258a76EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord.FromStructure, config);
  } else {
AttrDocumentType = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord.FromStructure(s.ssENDocumentType, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_10f704d4de8999e255a09f6b1b9b5668, RC_10f704d4de8999e255a09f6b1b9b5668> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_10f704d4de8999e255a09f6b1b9b5668 s) => ToStructure(s, config);
}
public static RC_10f704d4de8999e255a09f6b1b9b5668 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_10f704d4de8999e255a09f6b1b9b5668 obj, IBehaviorsConfiguration config) { 
  RC_10f704d4de8999e255a09f6b1b9b5668 s = new RC_10f704d4de8999e255a09f6b1b9b5668();
  if(obj != null) {
  s.ssENDocumentType = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord.ToStructure(obj.AttrDocumentType, config);
  }
  return s;
}

public static Func<RC_10f704d4de8999e255a09f6b1b9b5668, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_10f704d4de8999e255a09f6b1b9b5668> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_10f704d4de8999e255a09f6b1b9b5668 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_10f704d4de8999e255a09f6b1b9b5668 FromStructure(RC_10f704d4de8999e255a09f6b1b9b5668 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_10f704d4de8999e255a09f6b1b9b5668(s, config);
}

}


