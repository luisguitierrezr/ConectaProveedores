using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Size
public class RESTEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord : AbstractRESTStructure<EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord> {
[JsonProperty("Size")]
public string AttrSize;

public RESTEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord() { }

public RESTEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord (EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSize = s.ssSize;
  } else {
AttrSize = s.ssSize;
  }
}

public static EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord obj) { 
  EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord s = new EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord();
  if(obj != null) {
  s.ssSize = obj.AttrSize == null ? "" : obj.AttrSize;
  }
  return s;
}

public static Func<EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord, ssConectaProveedores.RestRecords.RESTEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord FromStructure(EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord(s, config);
}

}


