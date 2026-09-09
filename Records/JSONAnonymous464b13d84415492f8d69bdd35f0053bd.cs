using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderAccountingRecord
public class JSONRC_2dc2cf38bcc16a8b338dc5ea9a5c6446 : AbstractRESTStructure<RC_2dc2cf38bcc16a8b338dc5ea9a5c6446> {
[JsonProperty("OrderAccounting")]
[JsonPropertyName("OrderAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord AttrOrderAccounting;

public JSONRC_2dc2cf38bcc16a8b338dc5ea9a5c6446() { }

public JSONRC_2dc2cf38bcc16a8b338dc5ea9a5c6446 (RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderAccounting = ConvertToRestWithoutDefaults(s.ssENOrderAccounting, new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.FromStructure, config);
  } else {
AttrOrderAccounting = ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.FromStructure(s.ssENOrderAccounting, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_2dc2cf38bcc16a8b338dc5ea9a5c6446, RC_2dc2cf38bcc16a8b338dc5ea9a5c6446> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_2dc2cf38bcc16a8b338dc5ea9a5c6446 s) => ToStructure(s, config);
}
public static RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 ToStructure(ssConectaProveedores.RestRecords.JSONRC_2dc2cf38bcc16a8b338dc5ea9a5c6446 obj, IBehaviorsConfiguration config) { 
  RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 s = new RC_2dc2cf38bcc16a8b338dc5ea9a5c6446();
  if(obj != null) {
  s.ssENOrderAccounting = ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.ToStructure(obj.AttrOrderAccounting, config);
  }
  return s;
}

public static Func<RC_2dc2cf38bcc16a8b338dc5ea9a5c6446, ssConectaProveedores.RestRecords.JSONRC_2dc2cf38bcc16a8b338dc5ea9a5c6446> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_2dc2cf38bcc16a8b338dc5ea9a5c6446 FromStructure(RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_2dc2cf38bcc16a8b338dc5ea9a5c6446(s, config);
}

}


