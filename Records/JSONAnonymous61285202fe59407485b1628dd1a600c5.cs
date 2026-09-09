using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AttachmentRecord
public class JSONRCAttachmentRecord : AbstractRESTStructure<RCAttachmentRecord> {
[JsonProperty("Attachment")]
[JsonPropertyName("Attachment")]
public ssConectaProveedores.RestRecords.JSONSTAttachmentStructure AttrAttachment;

public JSONRCAttachmentRecord() { }

public JSONRCAttachmentRecord (RCAttachmentRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAttachment = ConvertToRestWithoutDefaults(s.ssSTAttachment, new STAttachmentStructure(), ssConectaProveedores.RestRecords.JSONSTAttachmentStructure.FromStructure, config);
  } else {
AttrAttachment = ssConectaProveedores.RestRecords.JSONSTAttachmentStructure.FromStructure(s.ssSTAttachment, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRCAttachmentRecord, RCAttachmentRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRCAttachmentRecord s) => ToStructure(s, config);
}
public static RCAttachmentRecord ToStructure(ssConectaProveedores.RestRecords.JSONRCAttachmentRecord obj, IBehaviorsConfiguration config) { 
  RCAttachmentRecord s = new RCAttachmentRecord();
  if(obj != null) {
  s.ssSTAttachment = ssConectaProveedores.RestRecords.JSONSTAttachmentStructure.ToStructure(obj.AttrAttachment, config);
  }
  return s;
}

public static Func<RCAttachmentRecord, ssConectaProveedores.RestRecords.JSONRCAttachmentRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAttachmentRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRCAttachmentRecord FromStructure(RCAttachmentRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRCAttachmentRecord(s, config);
}

}


