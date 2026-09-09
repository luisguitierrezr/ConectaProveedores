using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentTypeRecord
public class RESTRC_10f704d4de8999e255a09f6b1b9b5668 : AbstractRESTStructure<RC_10f704d4de8999e255a09f6b1b9b5668> {
[JsonProperty("DocumentType")]
public ssConectaProveedores.RestRecords.RESTEN_a70d553ce1458b3952d039852f258a76EntityRecord AttrDocumentType;

public RESTRC_10f704d4de8999e255a09f6b1b9b5668() { }

public RESTRC_10f704d4de8999e255a09f6b1b9b5668 (RC_10f704d4de8999e255a09f6b1b9b5668 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocumentType = ConvertToRestWithoutDefaults(s.ssENDocumentType, new EN_a70d553ce1458b3952d039852f258a76EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a70d553ce1458b3952d039852f258a76EntityRecord.FromStructure, config);
  } else {
AttrDocumentType = ssConectaProveedores.RestRecords.RESTEN_a70d553ce1458b3952d039852f258a76EntityRecord.FromStructure(s.ssENDocumentType, config);
  }
}

public static RC_10f704d4de8999e255a09f6b1b9b5668 ToStructure(ssConectaProveedores.RestRecords.RESTRC_10f704d4de8999e255a09f6b1b9b5668 obj) { 
  RC_10f704d4de8999e255a09f6b1b9b5668 s = new RC_10f704d4de8999e255a09f6b1b9b5668();
  if(obj != null) {
  s.ssENDocumentType = ssConectaProveedores.RestRecords.RESTEN_a70d553ce1458b3952d039852f258a76EntityRecord.ToStructure(obj.AttrDocumentType);
  }
  return s;
}

public static Func<RC_10f704d4de8999e255a09f6b1b9b5668, ssConectaProveedores.RestRecords.RESTRC_10f704d4de8999e255a09f6b1b9b5668> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_10f704d4de8999e255a09f6b1b9b5668 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_10f704d4de8999e255a09f6b1b9b5668 FromStructure(RC_10f704d4de8999e255a09f6b1b9b5668 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_10f704d4de8999e255a09f6b1b9b5668(s, config);
}

}


