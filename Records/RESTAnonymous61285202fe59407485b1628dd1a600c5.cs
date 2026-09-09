using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AttachmentRecord
public class RESTRCAttachmentRecord : AbstractRESTStructure<RCAttachmentRecord> {
[JsonProperty("Attachment")]
public ssConectaProveedores.RestRecords.RESTSTAttachmentStructure AttrAttachment;

public RESTRCAttachmentRecord() { }

public RESTRCAttachmentRecord (RCAttachmentRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAttachment = ConvertToRestWithoutDefaults(s.ssSTAttachment, new STAttachmentStructure(), ssConectaProveedores.RestRecords.RESTSTAttachmentStructure.FromStructure, config);
  } else {
AttrAttachment = ssConectaProveedores.RestRecords.RESTSTAttachmentStructure.FromStructure(s.ssSTAttachment, config);
  }
}

public static RCAttachmentRecord ToStructure(ssConectaProveedores.RestRecords.RESTRCAttachmentRecord obj) { 
  RCAttachmentRecord s = new RCAttachmentRecord();
  if(obj != null) {
  s.ssSTAttachment = ssConectaProveedores.RestRecords.RESTSTAttachmentStructure.ToStructure(obj.AttrAttachment);
  }
  return s;
}

public static Func<RCAttachmentRecord, ssConectaProveedores.RestRecords.RESTRCAttachmentRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAttachmentRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRCAttachmentRecord FromStructure(RCAttachmentRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRCAttachmentRecord(s, config);
}

}


