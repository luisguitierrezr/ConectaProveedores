using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Attachment
public class JSONSTAttachmentStructure : AbstractRESTStructure<STAttachmentStructure> {
[JsonProperty("FileName")]
[JsonPropertyName("FileName")]
public string AttrFileName;

[JsonProperty("FileContent")]
[JsonPropertyName("FileContent")]
public byte[] AttrFileContent;

[JsonProperty("MimeType")]
[JsonPropertyName("MimeType")]
public string AttrMimeType;

public JSONSTAttachmentStructure() { }

public JSONSTAttachmentStructure (STAttachmentStructure s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONSTAttachmentStructure, STAttachmentStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONSTAttachmentStructure s) => ToStructure(s, config);
}
public static STAttachmentStructure ToStructure(ssConectaProveedores.RestRecords.JSONSTAttachmentStructure obj, IBehaviorsConfiguration config) { 
  STAttachmentStructure s = new STAttachmentStructure();
  if(obj != null) {
  s.ssFileName = obj.AttrFileName == null ? "" : obj.AttrFileName;
  s.ssFileContent = obj.AttrFileContent == null ? new byte[] {} : obj.AttrFileContent;
  s.ssMimeType = obj.AttrMimeType == null ? "" : obj.AttrMimeType;
  }
  return s;
}

public static Func<STAttachmentStructure, ssConectaProveedores.RestRecords.JSONSTAttachmentStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STAttachmentStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONSTAttachmentStructure FromStructure(STAttachmentStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONSTAttachmentStructure(s, config);
}

}


