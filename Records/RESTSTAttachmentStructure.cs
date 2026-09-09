using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Attachment
public class RESTSTAttachmentStructure : AbstractRESTStructure<STAttachmentStructure> {
[JsonProperty("FileName")]
public string AttrFileName;

[JsonProperty("FileContent")]
public byte[] AttrFileContent;

[JsonProperty("MimeType")]
public string AttrMimeType;

public RESTSTAttachmentStructure() { }

public RESTSTAttachmentStructure (STAttachmentStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFileName = ConvertToRestWithoutDefaults(s.ssFileName, "");
AttrFileContent = ConvertToRestWithoutDefaults(s.ssFileContent);
AttrMimeType = ConvertToRestWithoutDefaults(s.ssMimeType, "");
  } else {
AttrFileName = s.ssFileName;
AttrFileContent = s.ssFileContent;
AttrMimeType = s.ssMimeType;
  }
}

public static STAttachmentStructure ToStructure(ssConectaProveedores.RestRecords.RESTSTAttachmentStructure obj) { 
  STAttachmentStructure s = new STAttachmentStructure();
  if(obj != null) {
  s.ssFileName = obj.AttrFileName == null ? "" : obj.AttrFileName;
  s.ssFileContent = obj.AttrFileContent == null ? new byte[] {} : obj.AttrFileContent;
  s.ssMimeType = obj.AttrMimeType == null ? "" : obj.AttrMimeType;
  }
  return s;
}

public static Func<STAttachmentStructure, ssConectaProveedores.RestRecords.RESTSTAttachmentStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STAttachmentStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTSTAttachmentStructure FromStructure(STAttachmentStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTSTAttachmentStructure(s, config);
}

}


