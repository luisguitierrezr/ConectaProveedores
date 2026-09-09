using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderAccountingRecord
public class RESTRC_2dc2cf38bcc16a8b338dc5ea9a5c6446 : AbstractRESTStructure<RC_2dc2cf38bcc16a8b338dc5ea9a5c6446> {
[JsonProperty("OrderAccounting")]
public ssConectaProveedores.RestRecords.RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord AttrOrderAccounting;

public RESTRC_2dc2cf38bcc16a8b338dc5ea9a5c6446() { }

public RESTRC_2dc2cf38bcc16a8b338dc5ea9a5c6446 (RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderAccounting = ConvertToRestWithoutDefaults(s.ssENOrderAccounting, new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.FromStructure, config);
  } else {
AttrOrderAccounting = ssConectaProveedores.RestRecords.RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.FromStructure(s.ssENOrderAccounting, config);
  }
}

public static RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 ToStructure(ssConectaProveedores.RestRecords.RESTRC_2dc2cf38bcc16a8b338dc5ea9a5c6446 obj) { 
  RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 s = new RC_2dc2cf38bcc16a8b338dc5ea9a5c6446();
  if(obj != null) {
  s.ssENOrderAccounting = ssConectaProveedores.RestRecords.RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.ToStructure(obj.AttrOrderAccounting);
  }
  return s;
}

public static Func<RC_2dc2cf38bcc16a8b338dc5ea9a5c6446, ssConectaProveedores.RestRecords.RESTRC_2dc2cf38bcc16a8b338dc5ea9a5c6446> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2dc2cf38bcc16a8b338dc5ea9a5c6446 FromStructure(RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2dc2cf38bcc16a8b338dc5ea9a5c6446(s, config);
}

}


