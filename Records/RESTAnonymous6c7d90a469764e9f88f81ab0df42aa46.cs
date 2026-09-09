using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TelcelDirectionRecord
public class RESTRC_f7c59318074340c0e230babd5ea62fb5 : AbstractRESTStructure<RC_f7c59318074340c0e230babd5ea62fb5> {
[JsonProperty("TelcelDirection")]
public ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord AttrTelcelDirection;

public RESTRC_f7c59318074340c0e230babd5ea62fb5() { }

public RESTRC_f7c59318074340c0e230babd5ea62fb5 (RC_f7c59318074340c0e230babd5ea62fb5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTelcelDirection = ConvertToRestWithoutDefaults(s.ssENTelcelDirection, new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure, config);
  } else {
AttrTelcelDirection = ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure(s.ssENTelcelDirection, config);
  }
}

public static RC_f7c59318074340c0e230babd5ea62fb5 ToStructure(ssConectaProveedores.RestRecords.RESTRC_f7c59318074340c0e230babd5ea62fb5 obj) { 
  RC_f7c59318074340c0e230babd5ea62fb5 s = new RC_f7c59318074340c0e230babd5ea62fb5();
  if(obj != null) {
  s.ssENTelcelDirection = ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.ToStructure(obj.AttrTelcelDirection);
  }
  return s;
}

public static Func<RC_f7c59318074340c0e230babd5ea62fb5, ssConectaProveedores.RestRecords.RESTRC_f7c59318074340c0e230babd5ea62fb5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f7c59318074340c0e230babd5ea62fb5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f7c59318074340c0e230babd5ea62fb5 FromStructure(RC_f7c59318074340c0e230babd5ea62fb5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f7c59318074340c0e230babd5ea62fb5(s, config);
}

}


