using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DeletedStorage
public class RESTEN_cddda4c1238a2c23ce999ed0bb374320EntityRecord : AbstractRESTStructure<EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("InternalConceptId")]
public int? AttrInternalConceptId;

[JsonProperty("Concept")]
public string AttrConcept;

[JsonProperty("Filename")]
public string AttrFilename;

[JsonProperty("Vendor")]
public string AttrVendor;

[JsonProperty("Doc_Type")]
public string AttrDoc_Type;

[JsonProperty("Object_type")]
public string AttrObject_type;

[JsonProperty("Archive_ID")]
public string AttrArchive_ID;

[JsonProperty("Arc_Doc_ID")]
public string AttrArc_Doc_ID;

public RESTEN_cddda4c1238a2c23ce999ed0bb374320EntityRecord() { }

public RESTEN_cddda4c1238a2c23ce999ed0bb374320EntityRecord (EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInternalConceptId = (int?) s.ssInternalConceptId;
AttrConcept = ConvertToRestWithoutDefaults(s.ssConcept, "");
AttrFilename = ConvertToRestWithoutDefaults(s.ssFilename, "");
AttrVendor = s.ssVendor;
AttrDoc_Type = ConvertToRestWithoutDefaults(s.ssDoc_Type, "");
AttrObject_type = ConvertToRestWithoutDefaults(s.ssObject_type, "");
AttrArchive_ID = ConvertToRestWithoutDefaults(s.ssArchive_ID, "");
AttrArc_Doc_ID = ConvertToRestWithoutDefaults(s.ssArc_Doc_ID, "");
  } else {
AttrId = (long?) s.ssId;
AttrInternalConceptId = (int?) s.ssInternalConceptId;
AttrConcept = s.ssConcept;
AttrFilename = s.ssFilename;
AttrVendor = s.ssVendor;
AttrDoc_Type = s.ssDoc_Type;
AttrObject_type = s.ssObject_type;
AttrArchive_ID = s.ssArchive_ID;
AttrArc_Doc_ID = s.ssArc_Doc_ID;
  }
}

public static EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_cddda4c1238a2c23ce999ed0bb374320EntityRecord obj) { 
  EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord s = new EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInternalConceptId = obj.AttrInternalConceptId == null ? 0 : obj.AttrInternalConceptId.Value;
  s.ssConcept = obj.AttrConcept == null ? "" : obj.AttrConcept;
  s.ssFilename = obj.AttrFilename == null ? "" : obj.AttrFilename;
  s.ssVendor = obj.AttrVendor == null ? "" : obj.AttrVendor;
  s.ssDoc_Type = obj.AttrDoc_Type == null ? "" : obj.AttrDoc_Type;
  s.ssObject_type = obj.AttrObject_type == null ? "" : obj.AttrObject_type;
  s.ssArchive_ID = obj.AttrArchive_ID == null ? "" : obj.AttrArchive_ID;
  s.ssArc_Doc_ID = obj.AttrArc_Doc_ID == null ? "" : obj.AttrArc_Doc_ID;
  }
  return s;
}

public static Func<EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord, ssConectaProveedores.RestRecords.RESTEN_cddda4c1238a2c23ce999ed0bb374320EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_cddda4c1238a2c23ce999ed0bb374320EntityRecord FromStructure(EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_cddda4c1238a2c23ce999ed0bb374320EntityRecord(s, config);
}

}


